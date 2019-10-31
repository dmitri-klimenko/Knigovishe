using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Knigosha.ViewComponents
{
    public class ManageNavViewComponent : ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ManageNavViewComponent(UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(UserClaimsPrincipal);
            switch (user.UserType)
            {
                case UserTypes.Student:
                {
                    var student = await _context.Students
                        .Include(s => s.MarkedBooks)
                        .Include(s => s.StudentClasses)
                        .Include(s => s.StudentFamilies)
                        .SingleAsync(s => s.Id == user.Id);
                    var hasActiveClass = student.StudentClasses.Any(sc => sc.IsActive);
                    var hasActiveFamily = student.StudentFamilies.Any(sc => sc.IsActive);
                    var componentVm = new ManageNavViewModel()
                    {
                        User = user,
                        HasActiveClass = hasActiveClass,
                        HasActiveFamily = hasActiveFamily
                    };
                    return View(componentVm);
                }
                case UserTypes.Parent:
                {
                    var parent = await _context.Families
                        .Include(s => s.MarkedBooks)
                        .SingleAsync(s => s.Id == user.Id);

                    var componentVm2 = new ManageNavViewModel()
                    {
                        User = parent,
                    };
                    return View(componentVm2);
                }
                case UserTypes.Teacher:
                {
                    var teacher = await _context.Classes
                        .Include(s => s.MarkedBooks)
                        .SingleAsync(s => s.Id == user.Id);

                    var componentVm3 = new ManageNavViewModel()
                    {
                        User = teacher,
                    };
                    return View(componentVm3);
                }
            }
            return View();
        }
    }

    public class ManageNavViewModel
    {
        public ApplicationUser User { get; set; }
        public bool HasActiveClass { get; set; }
        public bool HasActiveFamily { get; set; }
    }
}
