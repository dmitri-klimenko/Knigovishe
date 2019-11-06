using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Core.ViewModels.ManageViewModels;
using Knigosha.Core.ViewModels.OrderViewModel;
using Knigosha.Persistence;
using Knigosha.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Knigosha.Persistence.Migrations;
using Microsoft.AspNetCore.Hosting;

namespace Knigosha.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class ManageController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;
        private readonly UrlEncoder _urlEncoder;
        private readonly ApplicationDbContext _context;


        private const string AuthenticatorUriFormat = "otpauth://totp/{0}:{1}?secret={2}&issuer={0}&digits=6";
        private const string RecoveryCodesKey = nameof(RecoveryCodesKey);

        public ManageController(
          UserManager<ApplicationUser> userManager,
          SignInManager<ApplicationUser> signInManager,
          IEmailSender emailSender,
          ILogger<ManageController> logger,
          UrlEncoder urlEncoder,
          ApplicationDbContext context, 
          IHostingEnvironment environment
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
            _urlEncoder = urlEncoder;
            _context = context;
            _hostingEnvironment = environment;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            var user = await _userManager.GetUserAsync(User);

            var paidSubscriptions = user.UserSubscriptions.Where(us =>
                us.Subscription.SubscriptionType == SubscriptionTypes.Class ||
                us.Subscription.SubscriptionType == SubscriptionTypes.Family ||
                us.Subscription.SubscriptionType == SubscriptionTypes.Student);

            var vm = new DashboardViewModel()
            {
                User = user,
                HasPaidSubscriptions = paidSubscriptions.Any()
            };
            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> Answers(string type)
        {
            var user = await _userManager.GetUserAsync(User);
            ViewData["SchoolYear"] = DateTime.Parse(DateTime.Today.ToString(CultureInfo.CurrentCulture)).Year 
                                     + "/" + DateTime.Parse(DateTime.Today.AddYears(1).ToString(CultureInfo.CurrentCulture)).Year;

            if (type == "reset")
            {
                // sth
                return View("Reset");
            }

            if (type == "family")
            {
                var meStudent = await _context.Students.SingleOrDefaultAsync(s => s.Id == user.Id);
                var myActiveFamily = _context.StudentFamilies
                    .Single(sf => sf.StudentId == meStudent.Id && sf.IsActive).Family;
                if (myActiveFamily == null) return View("AnswersGroup");
                {
                    var ids = _context.StudentFamilies
                        .Where(sf => sf.FamilyId == myActiveFamily.Id)
                        .Select(sf => sf.StudentId)
                        .ToList();
                    var answers = _context.Answers
                        .Include(a => a.Book)
                        .ThenInclude(b => b.Answers)
                        .Where(a => ids.Contains(a.UserId))
                        .ToList();
                    ViewBag.Ids = ids;
                    return View("AnswersGroup", answers);
                }
            }

            if (type == "class")
            {
                var meStudent = await _context.Students.SingleOrDefaultAsync(s => s.Id == user.Id);
                var myActiveClass = _context.StudentClasses
                    .Single(sf => sf.StudentId == meStudent.Id && sf.IsActive).Class;
                if (myActiveClass == null) return View("AnswersGroup");
                {
                    var ids = _context.StudentClasses
                        .Where(sf => sf.ClassId == myActiveClass.Id)
                        .Select(sf => sf.StudentId)
                        .ToList();
                    var answers = _context.Answers
                        .Include(a => a.Book)
                        .ThenInclude(b => b.Answers)
                        .Where(a => ids.Contains(a.UserId))
                        .ToList();
                    ViewBag.Ids = ids;
                    return View("AnswersGroup", answers);
                }
            }

            if (type == "group") // "VMESTE"
            {
                var answers = await _context.Answers
                    .Include(a => a.Book)
                    .ThenInclude(b => b.Answers)
                    .Where(a => a.UserId == user.Id)
                    .ToListAsync();

                return View(answers);
            }

            switch (user.UserType)
            {
                case UserTypes.Student:
                    var answers = await _context.Answers
                        .Include(a => a.Book)
                        .ThenInclude(b => b.Answers)
                        .Where(a => a.UserId == user.Id)
                        .ToListAsync();

                    return View(answers);

                case UserTypes.Teacher:
                    var myStudents = _context.StudentClasses
                        .Where(sc => sc.ClassId == user.Id).Select(sc => sc.StudentId).ToList();
                    if (myStudents.Count == 0) return View("AnswersGroup");
                
                    var answers2 = _context.Answers
                        .Include(a => a.Book)
                        .ThenInclude(b => b.Answers)
                        .Where(a => myStudents.Contains(a.UserId))
                        .ToList();
                    ViewBag.Ids = myStudents;
                    return View("AnswersGroup", answers2);

                case UserTypes.Parent:
                    var myChildren = _context.StudentFamilies
                        .Where(sc => sc.FamilyId == user.Id).Select(sc => sc.StudentId).ToList();
                    if (myChildren.Count == 0) return View("AnswersGroup");
                
                    var answers3 = _context.Answers
                        .Include(a => a.Book)
                        .ThenInclude(b => b.Answers)
                        .Where(a => myChildren.Contains(a.UserId))
                        .ToList();
                    ViewBag.Ids = myChildren;
                    return View("AnswersGroup", answers3);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> MarkedBooks()
        {
            var user = await _userManager.GetUserAsync(User);
            var markedBooks = await _context.MarkedBooks
                .Include(mb => mb.Book)
                .Where(a => a.UserId == user.Id)
                .ToListAsync();
            return View(markedBooks);
        }

        [HttpGet]
        public IActionResult CreateQuiz()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Points()
        {
            var user = await _userManager.GetUserAsync(User);
            var createdByUserBooks = _context.Books
                .Where(b => String
                    .Equals(b.QuestionsAuthor, (user.Name + " " + user.Surname), StringComparison.CurrentCultureIgnoreCase))
                .ToList();
            ViewData["CreatedBooks"] = createdByUserBooks.Count;
            ViewData["PointsForCreatedBooks"] = user.PointsForCreatedBooks;
            return View(createdByUserBooks);
        }


        [HttpGet]
        public async Task<IActionResult> Messages(string type, string subject, string to, int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (id != 0)
            {
                var message = await _context.Messages
                    .Include(m => m.Sender)
                    .Include(m => m.Recipient)
                    .SingleAsync(m => m.Id == id);
                message.IsRead = true;
                _context.Messages.Update(message);
                await _context.SaveChangesAsync();
                return View("MessageDetails", message);
            }

            if (type == "sent")
            {
                bool hasGroup = false;
                switch (user.UserType)
                {
                    case UserTypes.Student:
                        hasGroup = _context.StudentClasses.Any(sc => sc.StudentId == user.Id) ||
                                   _context.StudentFamilies.Any(sc => sc.StudentId == user.Id);
                        break;
                    case UserTypes.Parent:
                        hasGroup = _context.StudentFamilies.Any(sc => sc.FamilyId == user.Id);
                        break;
                    case UserTypes.Teacher:
                        hasGroup = _context.StudentClasses.Any(sc => sc.ClassId == user.Id);
                        break;
                }
                var messagesVm = new MessagesViewModel()
                {
                    Messages = _context.Messages
                     .Include(m => m.Recipient)
                     .Include(m => m.Sender)
                     .Where(m => m.SenderId == user.Id)
                     .ToList(),
                    HasGroup = hasGroup
                };
                return View("MessagesSent", messagesVm);

            }

            if (type == "send" && to == null)
            {
                switch (user.UserType)
                {
                    case UserTypes.Student:
                        var messageVm = new MessageViewModel()
                        {
                            Message = new Message()
                            {
                                SenderId = user.Id
                            },
                            Recipients = new List<SelectListItem>()
                        };

                        if (_context.StudentClasses.Any(sc => sc.StudentId == user.Id))
                        {
                            var group1 = _context.StudentClasses.Where(sc => sc.StudentId == user.Id).Select(sc => sc.Class)
                                .ToList();
                            messageVm.Recipients = group1.Select(c => new SelectListItem()
                            { Value = c.Id, Text = c.FullName + " [" + c.UserName + "] " }).ToList();
                        }

                        if (_context.StudentFamilies.Any(sc => sc.StudentId == user.Id))
                        {
                            var group2 = _context.StudentFamilies.Where(sf => sf.StudentId == user.Id).Select(sf => sf.Family)
                                .ToList();
                            var selectList2 = group2.Select(f => new SelectListItem()
                            { Value = f.Id, Text = f.FullName + " [" + f.UserName + "] " }).ToList();

                            if (messageVm.Recipients.Count != 0) messageVm.Recipients.AddRange(selectList2);
                            else messageVm.Recipients = selectList2;
                        }
                        return View("MessageCreate", messageVm);

                    case UserTypes.Teacher:

                        var messageVm2 = new MessageViewModel()
                        {
                            Message = new Message()
                            {
                                SenderId = user.Id
                            },
                            Recipients = new List<SelectListItem>()
                        };

                        if (_context.StudentClasses.Any(sc => sc.ClassId == user.Id))
                        {
                            var group1 = _context.StudentClasses.Where(sc => sc.ClassId == user.Id).Select(sc => sc.Student)
                                .ToList();
                            messageVm2.Recipients = group1.Select(s => new SelectListItem()
                            { Value = s.Id, Text = s.FullName + " [" + s.UserName + "] " }).ToList();
                        }
                        return View("MessageCreate", messageVm2);

                    case UserTypes.Parent:

                        var messageVm3 = new MessageViewModel()
                        {
                            Message = new Message()
                            {
                                SenderId = user.Id
                            },
                            Recipients = new List<SelectListItem>()
                        };

                        if (_context.StudentFamilies.Any(sc => sc.FamilyId == user.Id))
                        {
                            var group1 = _context.StudentFamilies.Where(sc => sc.FamilyId == user.Id).Select(sc => sc.Student)
                                .ToList();
                            messageVm3.Recipients = group1.Select(s => new SelectListItem()
                            { Value = s.Id, Text = s.FullName + " [" + s.UserName + "] " }).ToList();
                        }
                        return View("MessageCreate", messageVm3);
                }

            }

            if (type == "send" && to != null)
            {
                var messageVm = new MessageViewModel()
                {
                    Message = new Message()
                    {
                        SenderId = user.Id,
                        Topic = subject
                    },
                    Recipients = new List<SelectListItem>()
                };

                var recipientStudent = _context.Students.SingleOrDefault(s => s.Id == to);
                if (recipientStudent != null)
                {
                    var item = new SelectListItem()
                    {
                        Value = recipientStudent.Id,
                        Text = recipientStudent.FullName + " [" + recipientStudent.UserName + " ]"
                    };
                    messageVm.Recipients.Add(item);
                    return View("MessageCreate", messageVm);
                }

                var recipientClass = _context.Classes.SingleOrDefault(c => c.Id == to);
                if (recipientClass != null)
                {
                    var item = new SelectListItem()
                    {
                        Value = recipientClass.Id,
                        Text = recipientClass.FullName + " [" + recipientClass.UserName + " ]"
                    };
                    messageVm.Recipients.Add(item);
                    return View("MessageCreate", messageVm);
                }

                var recipientFamily = _context.Families.SingleOrDefault(f => f.Id == to);
                if (recipientFamily != null)
                {
                    var item2 = new SelectListItem()
                    {
                        Value = recipientFamily.Id,
                        Text = recipientFamily.FullName + " [" + recipientFamily.UserName + " ]"
                    };
                    messageVm.Recipients.Add(item2);
                    return View("MessageCreate", messageVm);
                }

                return View("MessageCreate", messageVm);
            }

            bool hasGroup2 = false;
            switch (user.UserType)
            {
                case UserTypes.Student:
                    hasGroup2 = _context.StudentClasses.Any(sc => sc.StudentId == user.Id) ||
                               _context.StudentFamilies.Any(sc => sc.StudentId == user.Id);
                    break;
                case UserTypes.Parent:
                    hasGroup2 = _context.StudentFamilies.Any(sc => sc.FamilyId == user.Id);
                    break;
                case UserTypes.Teacher:
                    hasGroup2 = _context.StudentClasses.Any(sc => sc.ClassId == user.Id);
                    break;
            }
            var messagesVm2 = new MessagesViewModel()
            {
                Messages = _context.Messages
                    .Include(m => m.Sender)
                    .Include(m => m.Recipient)
                    .Where(m => m.RecipientId == user.Id)
                    .ToList(),
                HasGroup = hasGroup2
            };
            return View("MessagesReceived", messagesVm2);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Messages(MessageViewModel model)
        {
            var message = new Message()
            {
                RecipientId = model.Message.RecipientId,
                SenderId = model.Message.SenderId,
                Body = model.Message.Body,
                Topic = model.Message.Topic
            };
            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Messages));
        }

        [HttpGet]
        public async Task<IActionResult> Groups(string type, string id)
        {
            var groupsVm = new GroupsViewModel();

            var user = await _userManager.GetUserAsync(User);

            if (user.UserType == UserTypes.Student)
            {
                if (type == "request")
                {
                    var request = new Request()
                    {
                        ClassId = id,
                        StudentId = user.Id
                    };
                    _context.Requests.Add(request);
                    var result = await _context.SaveChangesAsync();
                }
                if (type == "leave")
                {
                    var studentClass = await _context.StudentClasses
                        .SingleOrDefaultAsync(sc => sc.ClassId == id && sc.StudentId == user.Id);
                    if (studentClass == null)
                    {
                        var studentFamily = await _context.StudentFamilies
                                            .SingleAsync(sf => sf.FamilyId == id && sf.StudentId == user.Id);
                        _context.StudentFamilies.Remove(studentFamily);
                    }
                    else
                    {
                        _context.StudentClasses.Remove(studentClass);
                    }
                    await _context.SaveChangesAsync();
                }

                if (type == "visible-class")
                {
                    var myStudentClasses = _context.StudentClasses.Where(sc => sc.StudentId == user.Id)?.ToList();
                    foreach (var studentClass in myStudentClasses)
                    {
                        studentClass.IsActive = studentClass.ClassId == id;
                    }
                    var myStudentFamilies = _context.StudentFamilies.Where(sf => sf.StudentId == user.Id)?.ToList();
                    foreach (var studentFamily in myStudentFamilies)
                    {
                        studentFamily.IsActive = false;
                    }
                    _context.StudentClasses.UpdateRange(myStudentClasses);
                    _context.StudentFamilies.UpdateRange(myStudentFamilies);
                    await _context.SaveChangesAsync();
                }
                if (type == "visible-family")
                {
                    var myStudentFamilies = _context.StudentFamilies.Where(sc => sc.StudentId == user.Id)?.ToList();
                    foreach (var studentFamily in myStudentFamilies)
                    {
                        studentFamily.IsActive = studentFamily.FamilyId == id;
                    }
                    var myStudentClasses = _context.StudentClasses.Where(sc => sc.StudentId == user.Id)?.ToList();
                    foreach (var studentClass in myStudentClasses)
                    {
                        studentClass.IsActive = false;
                    }
                    _context.StudentClasses.UpdateRange(myStudentClasses);
                    _context.StudentFamilies.UpdateRange(myStudentFamilies);
                    await _context.SaveChangesAsync();
                }

                //check if I have any groups and requests to render
                var myCurrentStudentClasses = _context.StudentClasses
                    .Include(sc => sc.Class)
                    .Where(sc => sc.StudentId == user.Id)
                    .ToList();
                var myCurrentStudentFamilies = _context.StudentFamilies
                    .Include(sc => sc.Family)
                    .Where(sc => sc.StudentId == user.Id)
                    .ToList();
                var myRequests = _context.Requests
                    .Include(r => r.Class)
                    .Where(r => r.StudentId == user.Id)
                    .ToList();
                if (myRequests.Any()) groupsVm.MyRequests = myRequests;
                if (myCurrentStudentClasses.Any()) groupsVm.MyCurrentStudentClasses = myCurrentStudentClasses;
                if (myCurrentStudentFamilies.Any()) groupsVm.MyCurrentStudentFamilies = myCurrentStudentFamilies;
                return View(groupsVm);
            }
            if (user.UserType == UserTypes.Teacher)
            {
                if (type == "accept")
                {
                    // add Student to Class
                    var thisStudent = await _context.Students.SingleAsync(s => s.Id == id);
                    var hasActiveGroup = _context.StudentClasses.Any(sc => sc.StudentId == id && sc.IsActive) ||
                        _context.StudentFamilies.Any(sf => sf.StudentId == id && sf.IsActive);
                    var myClass = await _context.Classes.SingleAsync(c => c.Id == user.Id);
                    var newStudentClass = new StudentClass()
                    {
                        StudentId = thisStudent.Id,
                        ClassId = myClass.Id,
                        IsActive = !hasActiveGroup
                    };
                    myClass.StudentClasses.Add(newStudentClass);
                    // remove first key from list
                    var userSubscription = _context.UserSubscriptions.Include(us => us.ActivationKeys)
                        .SingleOrDefault(us => us.UserId == user.Id && us.Status == StatusTypes.Activated);
                    var key = userSubscription?.ActivationKeys.Find(ak =>
                        ak.ActivationKeyType != ActivationKeyTypes.Class);
                    if (key != null) _context.ActivationKeys.Remove(key);
                    // remove request
                    var requestToDelete = await _context.Requests
                        .SingleAsync(r => r.StudentId == id && r.ClassId == user.Id);
                    _context.Requests.Remove(requestToDelete);
                    await _context.SaveChangesAsync();
                }
                if (type == "deny")
                {
                    // remove request
                    var requestToDelete = await _context.Requests
                        .SingleAsync(r => r.StudentId == id && r.ClassId == user.Id);
                    _context.Requests.Remove(requestToDelete);
                    await _context.SaveChangesAsync();
                }
                var myTeacherRequests = _context.Requests
                    .Include(r => r.Student)
                    .Where(r => r.ClassId == user.Id)
                    .ToList();
                if (myTeacherRequests.Any()) groupsVm.MyRequests = myTeacherRequests;
                return View(groupsVm);
            }
            return View(groupsVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Groups(GroupsViewModel groupsVm)
        {
            var user = await _userManager.GetUserAsync(User);

            if (!string.IsNullOrEmpty(groupsVm.Search) && _context.Classes.Any())
            {
                var allGroups = _context.Classes
                    .Where(c => c.NameOfGroup != null && c.NameOfGroup.Contains(groupsVm.Search, StringComparison.OrdinalIgnoreCase) ||
                                c.FullName.Contains(groupsVm.Search, StringComparison.OrdinalIgnoreCase) ||
                                c.School != null && c.School.Contains(groupsVm.Search, StringComparison.OrdinalIgnoreCase)).ToList();
                var currentClasses = _context.StudentClasses
                        .Where(sc => sc.StudentId == user.Id)
                        .Select(sc => sc.Class)
                        .ToList();
                var requestedClasses = _context.Requests
                    .Where(r => r.StudentId == user.Id)
                    .Select(r => r.Class)
                    .ToList();

                var queriedCurrentClasses = currentClasses
                    .Where(c => c.NameOfGroup != null && c.NameOfGroup.Contains(groupsVm.Search, StringComparison.OrdinalIgnoreCase) ||
                                c.FullName.Contains(groupsVm.Search, StringComparison.OrdinalIgnoreCase) ||
                                c.School != null && c.School.Contains(groupsVm.Search, StringComparison.OrdinalIgnoreCase)).ToList();
                var queriedRequestedClasses = requestedClasses
                    .Where(c => c.NameOfGroup != null && c.NameOfGroup.Contains(groupsVm.Search, StringComparison.OrdinalIgnoreCase) ||
                                c.FullName.Contains(groupsVm.Search, StringComparison.OrdinalIgnoreCase) ||
                                c.School != null && c.School.Contains(groupsVm.Search, StringComparison.OrdinalIgnoreCase)).ToList();

                ViewBag.CurrentClassesIds = queriedCurrentClasses.Select(g => g.Id).ToList();
                ViewBag.RequestedClassesIds = queriedRequestedClasses.Select(g => g.Id).ToList();

                allGroups.AddRange(queriedCurrentClasses);
                allGroups.AddRange(queriedRequestedClasses);

                groupsVm.AllGroups = allGroups.Distinct().ToList();
            }
            // avoiding AllGroups being null 
            groupsVm.AllGroups = groupsVm.AllGroups ?? new List<Class>();
            if (groupsVm.AllGroups.Count == 0)
            {
                var myCurrentStudentClasses = _context.StudentClasses
                    .Include(sc => sc.Class)
                    .Where(sc => sc.StudentId == user.Id)
                    .ToList();
                if (myCurrentStudentClasses.Any()) groupsVm.MyCurrentStudentClasses = myCurrentStudentClasses;

                var myCurrentStudentFamilies = _context.StudentFamilies
                    .Include(sc => sc.Family)
                    .Where(sc => sc.StudentId == user.Id)
                    .ToList();
                if (myCurrentStudentFamilies.Any()) groupsVm.MyCurrentStudentFamilies = myCurrentStudentFamilies;
            }
            return View(groupsVm);
        }

        [HttpGet]
        public async Task<IActionResult> Order(int? id, int? myself, int? old, int? license_id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (id.HasValue && license_id.HasValue)
            {
                var subscription = await _context.Subscriptions.SingleAsync(s => s.Id == id);
                ViewData["UserSubscriptionId"] = license_id;
                return View("PostOrder", subscription);
            }
            if (id.HasValue && !old.HasValue)
            {
                var subscription = await _context.Subscriptions.SingleAsync(s => s.Id == id);
                var newUserSubscriptionVm = new UserSubscriptionViewModel()
                {
                    Countries = _context.Countries.Select(c => new SelectListItem()
                    { Value = c.Title, Text = c.Title }).ToList(),
                    MainCitiesRussia = _context.Cities.Select(c => new SelectListItem()
                    { Value = c.Title, Text = c.Title }).ToList(),
                    TelephoneOfInstitution = user.PhoneNumber,
                    Country = user.Country,
                    MainCityRussia = user.City,
                    CityInput = user.City,
                    SubscriptionId = subscription.Id,
                    Subscription = subscription,
                    Email = user.Email,
                    Myself = myself == 1

                };
                return View(newUserSubscriptionVm);
            }
            if (id.HasValue && old.HasValue)
            {
                var subscription = await _context.Subscriptions.SingleAsync(s => s.Id == id);
                var userSubscription = await _context.UserSubscriptions.Include(us => us.User)
                    .SingleAsync(us => us.Id == old);
                var editUserSubscriptionVm = new UserSubscriptionViewModel()
                {
                    Id = userSubscription.Id,
                    Countries = _context.Countries.Select(c => new SelectListItem()
                    { Value = c.Title, Text = c.Title }).ToList(),
                    MainCitiesRussia = _context.Cities.Select(c => new SelectListItem()
                    { Value = c.Title, Text = c.Title }).ToList(),
                    TelephoneOfInstitution = userSubscription.TelephoneOfInstitution,
                    Country = userSubscription.Country,
                    MainCityRussia = userSubscription.City,
                    CityInput = userSubscription.City,
                    SubscriptionId = subscription.Id,
                    Myself = userSubscription.Myself,
                    Subscription = subscription,
                    Email = userSubscription.User.Email,
                    Uid = userSubscription.Uid,
                    AddressOfInstitution = userSubscription.AddressOfInstitution,
                    Person = userSubscription.Person,
                    Invoice = userSubscription.Invoice,
                    PayMethod = userSubscription.PaymentType == PaymentType.BankTransfer ? 1 : 2
                };
                return View(editUserSubscriptionVm);
            }

            Subscription suggested = null;
            switch (user.UserType)
            {
                case UserTypes.Student:
                    suggested = await _context.Subscriptions.SingleAsync(s =>
                        s.SubscriptionType == SubscriptionTypes.Student);
                    break;
                case UserTypes.Parent:
                    suggested = await _context.Subscriptions.SingleAsync(s =>
                        s.SubscriptionType == SubscriptionTypes.Family);
                    break;
                case UserTypes.Teacher:
                    suggested = await _context.Subscriptions.SingleAsync(s =>
                        s.SubscriptionType == SubscriptionTypes.Class);
                    break;
            }
            var vM = new OrderViewModel()
            {
                Suggested = suggested,
                Subscriptions = await _context.Subscriptions
                    .Where(s => s.SubscriptionType != SubscriptionTypes.FreeStudent &&
                                s.SubscriptionType != SubscriptionTypes.FreeFamily &&
                                s.SubscriptionType != SubscriptionTypes.FreeClass)
                    .ToListAsync()
            };
            return View("PreOrder", vM);
        }

        [HttpPost]
        public async Task<IActionResult> Order(UserSubscriptionViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            var subscription = await _context.Subscriptions.SingleAsync(s => s.Id == model.SubscriptionId);
            model.Subscription = subscription;
            if (ModelState.IsValid)
            {
                if (model.Id != 0)
                {
                    var userSubscription = await _context.UserSubscriptions.SingleAsync(us => us.Id == model.Id);
                    userSubscription.Email = model.Email;
                    userSubscription.Invoice = model.Invoice;
                    userSubscription.Myself = model.Myself;
                    userSubscription.PaymentType =
                        model.PayMethod == 1 ? PaymentType.BankTransfer : PaymentType.CreditCard;
                    if (model.Invoice)
                    {
                        userSubscription.AddressOfInstitution = model.AddressOfInstitution;
                        userSubscription.Institution = model.Institution;
                        userSubscription.Person = model.Person;
                        userSubscription.TelephoneOfInstitution = model.TelephoneOfInstitution;
                        userSubscription.Uid = model.Uid;
                        userSubscription.Country = model.Country;
                        userSubscription.City = !string.IsNullOrWhiteSpace(model.CityInput)
                            ? model.CityInput
                            : model.MainCityRussia;
                    }

                    _context.UserSubscriptions.Update(userSubscription);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Licenses");
                }
                else
                {
                    var newUserSubscription = new UserSubscription(user, subscription)
                    {
                        Status = StatusTypes.Waiting,
                        OrderedOn = DateTime.Today.ToString("dd.MM.yyyy"),
                        Email = model.Email,
                        PaymentType = model.PayMethod == 1 ? PaymentType.BankTransfer : PaymentType.CreditCard,
                        Invoice = model.Invoice,
                        Myself = model.Myself
                    };
                    if (model.Invoice)
                    {
                        newUserSubscription.AddressOfInstitution = model.AddressOfInstitution;
                        newUserSubscription.Institution = model.Institution;
                        newUserSubscription.Person = model.Person;
                        newUserSubscription.TelephoneOfInstitution = model.TelephoneOfInstitution;
                        newUserSubscription.Uid = model.Uid;
                        newUserSubscription.Country = model.Country;
                        newUserSubscription.City = !string.IsNullOrWhiteSpace(model.CityInput) ? model.CityInput : model.MainCityRussia;
                    }
                    new UserSubscriptionController(_context).CreateActivationKeys(newUserSubscription);
                    user.UserSubscriptions.Add(newUserSubscription);
                    _context.UserSubscriptions.Add(newUserSubscription);
                    await _context.SaveChangesAsync();
                    //for credit card
                    //if (newUserSubscription.PaymentType == PaymentType.CreditCard) return Redirect(""); 
                    return RedirectToAction("Order", new { license_id = newUserSubscription.Id, id = model.SubscriptionId });
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Licenses()
        {
            var user = await _userManager.GetUserAsync(User);
            var paidUserSubscriptions = _context.UserSubscriptions
                .Include(us => us.Subscription)
                .Include(us => us.ActivationKeys)
                .Where(us => us.UserId == user.Id &&
                             (us.Subscription.SubscriptionType == SubscriptionTypes.Class ||
                              us.Subscription.SubscriptionType == SubscriptionTypes.Family ||
                              us.Subscription.SubscriptionType == SubscriptionTypes.Student)).ToList();
            return View(paidUserSubscriptions);
        }

        [HttpGet]
        public async Task<IActionResult> License()
        {
            var user = await _userManager.GetUserAsync(User);
            var myUserSubscription = _context.UserSubscriptions
                .Include(us => us.ActivationKeys)
                .Include(us => us.Subscription)
                .Last(us => us.UserId == user.Id && us.Status == StatusTypes.Activated);
            var licenseVm = new LicenseViewModel()
            {
                MyUserSubscription = myUserSubscription,
                User = user,
                StatusMessage = StatusMessage
            };
            return View(licenseVm);
        }

        [HttpPost]
        public async Task<IActionResult> License(LicenseViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            model.User = user;
            var currentUserSubscription = _context.UserSubscriptions
                .Include(us => us.ActivationKeys)
                .Include(us => us.Subscription)
                .Last(us => us.UserId == user.Id && us.Status == StatusTypes.Activated);

            var aKey = await _context.ActivationKeys
                .Include(ak => ak.UserSubscription)
                .SingleOrDefaultAsync(ak => ak.Code == model.Code);

            if (aKey == null)
            {
                ModelState.AddModelError("Code", "Неверный код абонемента!");
            }
            else
            {
                var usId = aKey.UserSubscriptionId;
                var foundUserSubscription = _context.UserSubscriptions
                    .Include(us => us.Subscription)
                    .Include(us => us.ActivationKeys)
                    .Include(us => us.User)
                    .Single(us => us.Id == usId);

                if (foundUserSubscription.UserId == user.Id) // my subscriptions
                {
                    if (foundUserSubscription.User.UserType == user.UserType)  // of same type
                    {
                        if (foundUserSubscription.Status == StatusTypes.Activated) //already activated 
                            ModelState.AddModelError("Code", "Абонемент уже активирован другим пользователем!");

                        else if ((currentUserSubscription.Subscription.SubscriptionType == SubscriptionTypes.Student ||
                                  currentUserSubscription.Subscription.SubscriptionType == SubscriptionTypes.Family ||
                                  currentUserSubscription.Subscription.SubscriptionType == SubscriptionTypes.Class) &&
                                 currentUserSubscription.Status == StatusTypes.Activated)
                        {    // already has paid active userSubscription
                            ModelState.AddModelError("Code", "У Вас уже есть текущий абонемент!");
                        }
                        else //activate
                        {
                            foundUserSubscription.Status = StatusTypes.Activated;
                            foundUserSubscription.ActivatedOn = DateTime.Now.ToString("dd.MM.yyyy");
                            _context.UserSubscriptions.Update(foundUserSubscription);
                            await _context.SaveChangesAsync();
                            model.MyUserSubscription = foundUserSubscription;
                            model.StatusMessage = "Абонемент успешно активирован!";
                            return View(model);
                        }
                    }
                    else // was bought by me for somebody else
                    {
                        ModelState.AddModelError("Code", "Тип Вашего профиля не совпадает с типом абонемента!");
                    }
                }

                else // not my subscriptions
                {
                    if (foundUserSubscription.User.UserType == user.UserType)  // of same type
                    {
                        if (foundUserSubscription.Status == StatusTypes.Activated)
                            ModelState.AddModelError("Code", "Абонемент уже активирован!"); //  given subscription already activated
                        else //activate given subscription
                        {
                            foundUserSubscription.UserId = user.Id;
                            foundUserSubscription.Status = StatusTypes.Activated;
                            foundUserSubscription.ActivatedOn = DateTime.Now.ToString("dd.MM.yyyy");
                            _context.UserSubscriptions.Update(foundUserSubscription);
                            await _context.SaveChangesAsync();
                            model.MyUserSubscription = foundUserSubscription;
                            model.StatusMessage = "Абонемент успешно активирован!";
                            return View(model);
                        }
                    }  // join family-group
                    else if (user.UserType == UserTypes.Student && foundUserSubscription.User.UserType == UserTypes.Parent && aKey.ActivationKeyType == ActivationKeyTypes.Student)
                    {
                        if (_context.StudentFamilies.Any(sf => sf.StudentId == user.Id && sf.FamilyId == foundUserSubscription.UserId)) // already joined
                        {
                            ModelState.AddModelError("Code", "Вы уже присоединены к этой группе!");
                        }
                        else  // join
                        {
                            var hasActiveGroup = _context.StudentClasses.Any(sc => sc.StudentId == user.Id && sc.IsActive) ||
                                                 _context.StudentFamilies.Any(sf => sf.StudentId == user.Id && sf.IsActive);
                            var newStudentFamily = new StudentFamily
                            {
                                StudentId = user.Id,
                                FamilyId = foundUserSubscription.UserId,
                                IsActive = !hasActiveGroup
                            };
                            _context.ActivationKeys.Remove(aKey);
                            _context.Families.Single(f => f.Id == foundUserSubscription.UserId).StudentFamilies.Add(newStudentFamily);
                            //_context.StudentFamilies.Add(newStudentFamily); ??
                            await _context.SaveChangesAsync();
                            model.MyUserSubscription = currentUserSubscription;
                            model.StatusMessage = "Профиль успешно присоединён к группе СЕМЬЯ!";
                            return View(model);
                        }
                    }
                    else 
                    {
                        ModelState.AddModelError("Code", "Тип Вашего профиля не совпадает с типом абонемента!");
                    }
                }
            }
            model.MyUserSubscription = currentUserSubscription;
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Details()
        {
            var user = await _userManager.GetUserAsync(User);

            switch (user.UserType)
            {
                case UserTypes.Student:
                    var student = await _context.Students.SingleAsync(s => s.Id == user.Id);

                    var detailsVm = new DetailsViewModel
                    {
                        Countries =
                            _context.Countries.Select(c => new SelectListItem() { Value = c.Title, Text = c.Title }).ToList(),
                        MainCitiesRussia = _context.Cities.Select(c => new SelectListItem()
                        {
                            Value = c.Title,
                            Text = c.Title
                        }).ToList(),

                        UserType = UserTypes.Student,
                        Country = student.Country,
                        Name = student.Name,
                        Surname = student.Surname,
                        UserName = student.UserName,
                        Email = student.Email,
                        RequiredEmail = student.Email,
                        ParentEmail = student.ParentEmail,
                        PhoneNumber = student.PhoneNumber,
                        CityInput = student.City,
                        MainCityRussia = student.City,
                        SchoolInput = student.School,
                        SchoolSelect = student.School,
                        Parallel = student.Parallel,
                        Password = student.Password,
                        FullName = student.FullName,
                        SubscribedToNewsletter = student.SubscribedToNewsletter,
                        StatusMessage = StatusMessage
                    };
                    return View(detailsVm);
                
                case UserTypes.Teacher:
                    var teacher = await _context.Classes.SingleAsync(s => s.Id == user.Id);

                    var detailsVm2 = new DetailsViewModel
                    {
                        Countries =
                            _context.Countries.Select(c => new SelectListItem() { Value = c.Title, Text = c.Title }).ToList(),
                        MainCitiesRussia = _context.Cities.Select(c => new SelectListItem()
                        {
                            Value = c.Title,
                            Text = c.Title
                        }).ToList(),

                        Greetings = new List<SelectListItem>
                        {
                            new SelectListItem(teacher.Greeting, teacher.Greeting),
                            new SelectListItem("Здравствуйте, госпожа " + teacher.Surname, "Здравствуйте, госпожа " + teacher.Surname),
                            new SelectListItem("Здравствуйте, господин " + teacher.Surname, "Здравствуйте, господин " + teacher.Surname),
                        },

                        UserType = UserTypes.Teacher,
                        Country = teacher.Country,
                        Name = teacher.Name,
                        Surname = teacher.Surname,
                        UserName = teacher.UserName,
                        Email = teacher.Email,
                        RequiredEmail = teacher.Email,
                        PhoneNumber = teacher.PhoneNumber,
                        CityInput = teacher.City,
                        MainCityRussia = teacher.City,
                        SchoolInput = teacher.School,
                        SchoolSelect = teacher.School,
                        Parallel = teacher.Parallel,
                        Password = teacher.Password,
                        FullName = teacher.FullName,
                        SubscribedToNewsletter = teacher.SubscribedToNewsletter,
                        StatusMessage = StatusMessage
                    };
                    return View(detailsVm2);

                case UserTypes.Parent:

                    var parent = await _context.Families.SingleAsync(s => s.Id == user.Id);

                    var detailsVm3 = new DetailsViewModel
                    {
                        Countries =
                            _context.Countries.Select(c => new SelectListItem() { Value = c.Title, Text = c.Title }).ToList(),
                        MainCitiesRussia = _context.Cities.Select(c => new SelectListItem()
                        {
                            Value = c.Title,
                            Text = c.Title
                        }).ToList(),

                        UserType = UserTypes.Parent,
                        Country = parent.Country,
                        Name = parent.Name,
                        Surname = parent.Surname,
                        UserName = parent.UserName,
                        Email = parent.Email,
                        RequiredEmail = parent.Email,
                        PhoneNumber = parent.PhoneNumber,
                        CityInput = parent.City,
                        MainCityRussia = parent.City,
                        SchoolInput = parent.School,
                        SchoolSelect = parent.School,
                        Parallel = parent.Parallel,
                        Password = parent.Password,
                        FullName = parent.FullName,
                        SubscribedToNewsletter = parent.SubscribedToNewsletter,
                        StatusMessage = StatusMessage
                    };
                    return View(detailsVm3);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(DetailsViewModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            switch (model.Action)
            {
                case "save":
                    if (!ModelState.IsValid) return View(model);
                    if (model.Photo != null)
                    {
                        var uniqueFileName = GetUniqueFileName(model.Photo.FileName);
                        var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                        var filePath = Path.Combine(uploads, uniqueFileName);
                        model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                        user.Photo = uniqueFileName;
                    }

                    if (user.UserName != model.UserName) user.UserName = model.UserName;
                    if(user.Name != model.Name) user.Name = model.Name;
                    if(user.Surname != model.Surname) user.Surname = model.Surname;
                    if (user.City != model.CityInput && user.City != model.MainCityRussia)
                        user.City = !string.IsNullOrEmpty(model.CityInput) ? model.CityInput : model.MainCityRussia;
                    if(user.Country != model.Country) user.Country = model.Country;
                    if(user.Grade != model.Grade) user.Grade = model.Grade;
                    if(user.Parallel != model.Parallel) user.Parallel = model.Parallel;
                    if (user.UserType == UserTypes.Student || user.UserType == UserTypes.Parent)
                        user.Greeting = model.GreetingRadio == 0 ? "Привет, " + model.UserName : "Привет, " + model.FullName;
                    else user.Greeting = model.GreetingString;
                    user.DateEdited = DateTime.Now.ToString("dd.MM.yyyy");

                    await _userManager.UpdateAsync(user);

                    string modelEmail;
                    if (user.UserType == UserTypes.Student)
                        modelEmail = model.Email ?? model.ParentEmail;
                    else modelEmail = model.RequiredEmail;

                    var email = user.Email;
                    if (modelEmail != email)
                    {
                        var setEmailResult = await _userManager.SetEmailAsync(user, model.Email);
                        if (!setEmailResult.Succeeded)
                        {
                            throw new ApplicationException(
                                $"Unexpected error occurred setting email for user with ID '{user.Id}'.");
                        }
                    }

                    var phoneNumber = user.PhoneNumber;
                    if (model.PhoneNumber != phoneNumber)
                    {
                        var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, model.PhoneNumber);
                        if (!setPhoneResult.Succeeded)
                        {
                            throw new ApplicationException(
                                $"Unexpected error occurred setting phone number for user with ID '{user.Id}'.");
                        }
                    }

                    var password = user.Password;
                    if (model.Password != password)
                    {
                        var changePasswordResult = await _userManager.ChangePasswordAsync(user, user.Password, model.Password);
                        if (!changePasswordResult.Succeeded)
                        {
                            AddErrors(changePasswordResult);
                            return View(model);
                        }
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        _logger.LogInformation("User changed their password successfully.");
                    }

                    StatusMessage = "Данные профиля обновлены!";
                    return RedirectToAction(nameof(Details));

                case "subscribe":
                    user.SubscribedToNewsletter = true;
                    await _userManager.UpdateAsync(user);
                    StatusMessage = "Данные профиля обновлены!";
                    return RedirectToAction(nameof(Details));

                case "unsubscribe":
                    user.SubscribedToNewsletter = false;
                    await _userManager.UpdateAsync(user);
                    StatusMessage = "Данные профиля обновлены!";
                    return RedirectToAction(nameof(Details));
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Students(int remove, string id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (id != null)
            {
                var student = _context.Students.Single(s => s.Id == id);
                var countOfAnswers = _context.Answers.Count(a => a.UserId == id);
                ViewBag.CountOfAnswers = countOfAnswers;
                return View("StudentDetails", student);
            }

            var children = _context.StudentFamilies
                .Where(sf => sf.FamilyId == user.Id)
                .Select(sf => sf.Student)
                .Include(s => s.UserSubscriptions)
                .ThenInclude(us => us.Subscription).ToList();

            var userSubscription =  _context.UserSubscriptions
                .Include(us => us.ActivationKeys)
                .Include(us => us.Subscription)
                .Last(us => us.UserId == user.Id && us.Status == StatusTypes.Activated);

            var studentsVm = new StudentsViewModel
            {
                Keys = userSubscription.ActivationKeys.Where(ak => ak.ActivationKeyType == ActivationKeyTypes.Student).ToList(),
                Children = children,
                SchoolYear = userSubscription.SchoolYear,
                User = user
            };

            if (remove == 0) return View(studentsVm);
            var thisStudentFamily = _context.StudentFamilies.Single(uf => uf.Id == remove);
            _context.StudentFamilies.Remove(thisStudentFamily);
            await _context.SaveChangesAsync();
            return View(studentsVm);
        }

        public async Task<IActionResult> Help()
        {
            var user = await _userManager.GetUserAsync(User);
            var helpVm = new HelpViewModel
            {
                User = user
            };

            return View(helpVm);
        }

      

















            #region Helpers

            private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_"
                   + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private string FormatKey(string unformattedKey)
        {
            var result = new StringBuilder();
            int currentPosition = 0;
            while (currentPosition + 4 < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition, 4)).Append(" ");
                currentPosition += 4;
            }
            if (currentPosition < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition));
            }

            return result.ToString().ToLowerInvariant();
        }

        private string GenerateQrCodeUri(string email, string unformattedKey)
        {
            return string.Format(
                AuthenticatorUriFormat,
                _urlEncoder.Encode("WebApplication1"),
                _urlEncoder.Encode(email),
                unformattedKey);
        }

        private async Task LoadSharedKeyAndQrCodeUriAsync(ApplicationUser user, EnableAuthenticatorViewModel model)
        {
            var unformattedKey = await _userManager.GetAuthenticatorKeyAsync(user);
            if (string.IsNullOrEmpty(unformattedKey))
            {
                await _userManager.ResetAuthenticatorKeyAsync(user);
                unformattedKey = await _userManager.GetAuthenticatorKeyAsync(user);
            }

            model.SharedKey = FormatKey(unformattedKey);
            model.AuthenticatorUri = GenerateQrCodeUri(user.Email, unformattedKey);
        }

        #endregion
    }
}
