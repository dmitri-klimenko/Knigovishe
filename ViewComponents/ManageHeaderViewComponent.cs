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

            switch (user.UserType)
            {
                case UserTypes.Student:
                {
                    var student = await _context.Students
                        .Include(s => s.Answers)
                        .Include(s => s.StudentClasses)
                        .ThenInclude(sc => sc.Class)
                        .Include(s => s.StudentFamilies)
                        .ThenInclude(sf => sf.Family)
                        .SingleAsync(s => s.Id == user.Id);

                    var activeClass = student.StudentClasses.SingleOrDefault(sc => sc.IsActive)?.Class;
                    var activeFamily = student.StudentFamilies.SingleOrDefault(sf => sf.IsActive)?.Family;

                    var componentVm = new ManageHeaderViewModel()
                    {
                        User = student,
                        ActiveClass = activeClass,
                        ActiveFamily = activeFamily
                    };
                    return View(componentVm);
                }
                case UserTypes.Teacher:
                {
                    var teacher = await _context.Classes
                        .SingleAsync(c => c.Id == user.Id);
                    var componentVm2 = new ManageHeaderViewModel()
                    {
                        User = teacher
                    };
                    return View(componentVm2);
                }
                case UserTypes.Parent:
                    var parent = await _context.Families
                        .SingleAsync(c => c.Id == user.Id);
                    var componentVm3 = new ManageHeaderViewModel()
                    {
                        User = parent
                    };
                    return View(componentVm3);
            }

            return View();
        }
    }

    public class ManageHeaderViewModel
    {
        public ApplicationUser User { get; set; }
        public Class ActiveClass { get; set; }
        public Family ActiveFamily { get; set; }
    }
}
