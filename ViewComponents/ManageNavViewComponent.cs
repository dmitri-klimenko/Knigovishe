using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Core.ViewModels.ManageViewModels;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;

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
                        .Include(s => s.MarkedBooks)
                        .ThenInclude(mb => mb.Book)
                        .SingleAsync(s => s.Id == user.Id);

                    var messagesCount = _context.Messages.Count(m => !m.IsRead && m.RecipientId == user.Id);

                    var componentVm = new ManageNavViewModel()
                    {
                        User = student,
                        HasActiveClass = student.StudentClasses.Any(sc => sc.IsActive),
                        HasActiveFamily = student.StudentFamilies.Any(sc => sc.IsActive),
                        MessagesCount = messagesCount,
                        MarkedBooks = user.MarkedBooks.ToList()
                    };

                    return View(componentVm);
                }
                case UserTypes.Parent:
                {
                    var parent = await _context.Families
                        .Include(f => f.MarkedBooks)
                        .ThenInclude(mb => mb.Book)
                        .Include(f => f.StudentFamilies)
                        .ThenInclude(sf => sf.Student)
                        .SingleAsync(f => f.Id == user.Id);

                    var messagesCount = _context.Messages.Count(m => !m.IsRead && m.RecipientId == user.Id);

                    var componentVm2 = new ManageNavViewModel()
                    {
                        User = parent,
                        MessagesCount = messagesCount,
                        MarkedBooks = user.MarkedBooks.ToList(),
                    };

                    if (parent.StudentFamilies.Count != 0)
                    {
                        var studentIds = parent.StudentFamilies.Select(sf => sf.StudentId).ToList();

                        var answersWithReasonForRestart =
                            _context.Answers
                                .Count(a => studentIds.Contains(a.UserId) && !string.IsNullOrEmpty(a.ReasonForRestart));

                        componentVm2.AnswersCount = answersWithReasonForRestart;
                    }

                    return View(componentVm2);
                }

                case UserTypes.Teacher:
                {
                    var teacher = await _context.Classes
                        .Include(f => f.StudentClasses)
                        .ThenInclude(sf => sf.Student)
                        .Include(c => c.MarkedBooks)
                        .ThenInclude(mb => mb.Book)
                        .SingleAsync(c => c.Id == user.Id);

                        var messagesCount = _context.Messages.Count(m => !m.IsRead && m.RecipientId == user.Id);
                        var requestsCount = _context.Requests.Count(r => r.ClassId == user.Id);

                        var componentVm3 = new ManageNavViewModel()
                        {
                            User = teacher,
                            MessagesCount = messagesCount,
                            MarkedBooks = teacher.MarkedBooks.ToList(),
                            RequestsCount = requestsCount
                        };

                        if (teacher.StudentClasses.Count != 0)
                        {
                            var studentIds = teacher.StudentClasses.Select(sf => sf.StudentId).ToList();

                            var answersWithReasonForRestart =
                                _context.Answers
                                    .Count(a => studentIds.Contains(a.UserId) && !string.IsNullOrEmpty(a.ReasonForRestart));

                            componentVm3.AnswersCount = answersWithReasonForRestart;
                        }


                        return View(componentVm3);
                }
            }
            return View();
        }
    }
}
