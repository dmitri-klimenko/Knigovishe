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

            if (user.Country != null)
            {
                var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id.ToString() == user.Country);
                ViewData["Country"] = country.Title;
            }

            if (user.City != null)
            {
                var city = await _context.Cities.FirstOrDefaultAsync(c => c.Id.ToString() == user.City);
                ViewData["City"] = city.Title;
            }

            if (user.School != "Выберите город" && user.School != null)
            {
                var school = await _context.Schools.FirstOrDefaultAsync(c => c.Id.ToString() == user.School);
                ViewData["School"] = school.Title;
            }


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
               PointsForCreatedBooks = user.PointsForCreatedBooks,
               NumberOfCreatedBooks = user.NumberOfCreatedBooks
            };

            return View(editUserVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditUserViewModel editUserVm) { 
            if (ModelState.IsValid)
            {
                var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == editUserVm.Id);

                user.PointsForCreatedBooks = editUserVm.PointsForCreatedBooks;
                user.NumberOfCreatedBooks = editUserVm.NumberOfCreatedBooks;
                user.DateEdited = DateTime.Now.ToString("d");
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
            if (user.Country != null)
            {
                var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id.ToString() == user.Country);
                ViewData["Country"] = country.Title;
            }

            if (user.City != null)
            {
                var city = await _context.Cities.FirstOrDefaultAsync(c => c.Id.ToString() == user.City);
                ViewData["City"] = city.Title;
            }

            if (user.School != "Выберите город" && user.School != null)
            {
                var school = await _context.Schools.FirstOrDefaultAsync(c => c.Id.ToString() == user.School);
                ViewData["School"] = school.Title;
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
            await _userManager.DeleteAsync(user);
            return RedirectToAction(nameof(Index));
        }
    }
}
