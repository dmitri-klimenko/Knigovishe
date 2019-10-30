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

            if (user.UserType == UserTypes.Student)
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
