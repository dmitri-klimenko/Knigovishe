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
            var user = await _userManager.GetUserAsync(Request.HttpContext.User);
            Student student = null;
            if (user.UserType == UserTypes.Student)
            {
                 student = await _context.Students
                    .Include(s => s.Answers)
                    .Include(s => s.StudentClasses).ThenInclude(sc => sc.Class)
                    .SingleAsync(s => s.Id == user.Id);
            }
            return View(student);
        }
    }
}
