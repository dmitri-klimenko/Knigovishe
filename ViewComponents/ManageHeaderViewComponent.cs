using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Security.Claims;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Knigosha.ViewComponents
{
    public class ManageHeaderViewComponent : ViewComponent
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public ManageHeaderViewComponent(UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(UserClaimsPrincipal);

            Class activeClass = null;
            Family activeFamily = null;

            if (user.UserType == UserTypes.Student)
            {
                user = await _context.Students.Include(s => s.Answers).SingleAsync(s => s.Id == user.Id);
                activeClass = _context.StudentClasses.SingleOrDefault(sc => sc.IsActive && sc.StudentId == user.Id)?.Class;
                activeFamily = _context.StudentFamilies.SingleOrDefault(sf => sf.IsActive && sf.StudentId == user.Id)?.Family;
            }

            var componentVm = new ComponentViewModel()
            {
                User = user,
                ActiveClass = activeClass,
                ActiveFamily = activeFamily
            };

            return View(componentVm);
        }
    }

    public class ComponentViewModel
    {
        public ApplicationUser User { get; set; }
        public Class ActiveClass { get; set; }
        public Family ActiveFamily { get; set; }
    }
}
