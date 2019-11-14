using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Core.ViewModels;
using Knigosha.Core.ViewModels.BookViewModels;
using Knigosha.Core.ViewModels.UserViewModels;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace Knigosha.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users
                .Include(au => au.UserRoles)
                .ThenInclude(ur => ur.Role)
                .Select(au => new IndexUserViewModel
            {
                Id = au.Id,
                UserType = au.UserType,
                Email = au.Email,
                DateAdded = au.DateAdded,
                DateEdited = au.DateEdited,
                LastLogin = au.LastLogin,
                UserName = au.UserName,
                LoginTimes = au.LoginTimes
            }).ToListAsync();

            return View(users);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null) return NotFound();
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);


            return View(user);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null) return NotFound();
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user == null) return NotFound();

            var editUserVm = new EditUserViewModel
            {
                Id = user.Id,
            };

            return View(editUserVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditUserViewModel editUserVm) { 
            if (ModelState.IsValid)
            {
                var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == editUserVm.Id);

                var newCreatedBook = new CreatedBook()
                {
                    Points = editUserVm.PointsForCreatedBook
                };

                user.DateEdited = DateTime.Now.ToString("d");
                user.CreatedBooks.Add(newCreatedBook);
                _context.CreatedBooks.Add(newCreatedBook);

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(editUserVm.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(editUserVm);
        }

        private bool UserExists(string id)
        {
            return _userManager.Users.Any(u => u.Id == id);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null) return NotFound();
            var user = await _userManager.Users
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);

            switch (user.UserType)
            {
                case UserTypes.Student:
                    var countSc = await _context.StudentClasses.CountAsync(sc => sc.StudentId == user.Id);
                    var countSf = await _context.StudentFamilies.CountAsync(sc => sc.StudentId == user.Id);
                    var messages = await _context.Messages.CountAsync(m => m.SenderId == user.Id || m.RecipientId == user.Id);

                    if (messages == 1) _context.Messages.Remove(_context.Messages.Single(m => m.SenderId == user.Id || m.RecipientId == user.Id));
                    else if (messages > 1) _context.Messages.RemoveRange(_context.Messages.Where(m => m.SenderId == user.Id || m.RecipientId == user.Id).ToList());

                    if (countSc == 1) _context.StudentClasses.Remove(_context.StudentClasses.Single(sc => sc.StudentId == user.Id));
                    else if (countSc > 1) _context.StudentClasses.RemoveRange(_context.StudentClasses.Where(sc => sc.StudentId == user.Id).ToList());

                    if (countSf == 1) _context.StudentFamilies.Remove(_context.StudentFamilies.Single(sc => sc.StudentId == user.Id));
                    else if (countSf > 1) _context.StudentFamilies.RemoveRange(_context.StudentFamilies.Where(sc => sc.StudentId == user.Id).ToList());
                    break;

                case UserTypes.Parent:
                    var countSf2 = await _context.StudentFamilies.CountAsync(sc => sc.FamilyId == user.Id);
                    var messages2 = await _context.Messages.CountAsync(m => m.SenderId == user.Id || m.RecipientId == user.Id);

                    if (messages2 == 1) _context.Messages.Remove(_context.Messages.Single(m => m.SenderId == user.Id));
                    else if (messages2 > 1) _context.Messages.RemoveRange(_context.Messages.Where(m => m.SenderId == user.Id || m.RecipientId == user.Id).ToList());

                    if (countSf2 == 1) _context.StudentFamilies.Remove(_context.StudentFamilies.Single(sf => sf.FamilyId == user.Id));
                    else if (countSf2 > 1) _context.StudentFamilies.RemoveRange(_context.StudentFamilies.Where(sf => sf.FamilyId == user.Id).ToList());
                    break;

                case UserTypes.Teacher:
                    var countSf3 = await _context.StudentClasses.CountAsync(sc => sc.ClassId == user.Id);
                    var messages3 = await _context.Messages.CountAsync(m => m.SenderId == user.Id || m.RecipientId == user.Id);

                    if (messages3 == 1) _context.Messages.Remove(_context.Messages.Single(m => m.SenderId == user.Id));
                    else if (messages3 > 1) _context.Messages.RemoveRange(_context.Messages.Where(m => m.SenderId == user.Id || m.RecipientId == user.Id).ToList());

                    if (countSf3 == 1) _context.StudentClasses.Remove(_context.StudentClasses.Single(sc => sc.ClassId == user.Id));
                    else if (countSf3 > 1) _context.StudentClasses.RemoveRange(_context.StudentClasses.Where(sc => sc.ClassId == user.Id).ToList());
                    break;
            }
            await _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(Index));
        }
    }
}
