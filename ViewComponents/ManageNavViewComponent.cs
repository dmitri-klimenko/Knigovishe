using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;
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
                        .Include(s => s.StudentClasses)
                        .Include(s => s.StudentFamilies)
                        .SingleAsync(s => s.Id == user.Id);

                    var messagesCount = _context.Messages.Count(m => !m.IsRead && m.RecipientId == user.Id);

                    var componentVm = new ManageNavViewModel()
                    {
                        User = user,
                        HasActiveClass = student.StudentClasses.Any(sc => sc.IsActive),
                        HasActiveFamily = student.StudentFamilies.Any(sc => sc.IsActive),
                        MessagesCount = messagesCount
                    };

                    return View(componentVm);
                }
                case UserTypes.Parent:
                {
                    var messagesCount = _context.Messages.Count(m => !m.IsRead && m.RecipientId == user.Id);

                    var componentVm2 = new ManageNavViewModel()
                    {
                        User = user,
                        MessagesCount = messagesCount
                    };
                    return View(componentVm2);
                }
                case UserTypes.Teacher:
                {
                    var messagesCount = _context.Messages.Count(m => !m.IsRead && m.RecipientId == user.Id);

                    var componentVm3 = new ManageNavViewModel()
                    {
                        User = user,
                        MessagesCount = messagesCount
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
        public int MessagesCount { get; set; }  
    }
}
