using Knigosha.Core.Models;
using Knigosha.Core.ViewModels.ManageViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Knigosha.Core.Models.Enums;
using Knigosha.Core.ViewModels.OrderViewModel;
using Knigosha.Persistence;
using Knigosha.Utilities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Knigosha.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class ManageController : Controller
    {
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
          ApplicationDbContext context
          )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
            _urlEncoder = urlEncoder;
            _context = context;
        }

        [TempData]
        public string StatusMessage { get; set; }

        //[HttpGet]
        //public async Task<IActionResult> Index()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var model = new IndexViewModel
        //    {
        //        Username = user.UserName,
        //        Email = user.Email,
        //        PhoneNumber = user.PhoneNumber,
        //        IsEmailConfirmed = user.EmailConfirmed,
        //        StatusMessage = StatusMessage,
        //        Photo = user.Photo
        //    };

        //    return View(model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Index(IndexViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var email = user.Email;
        //    if (model.Email != email)
        //    {
        //        var setEmailResult = await _userManager.SetEmailAsync(user, model.Email);
        //        if (!setEmailResult.Succeeded)
        //        {
        //            throw new ApplicationException($"Unexpected error occurred setting email for user with ID '{user.Id}'.");
        //        }
        //    }

        //    var phoneNumber = user.PhoneNumber;
        //    if (model.PhoneNumber != phoneNumber)
        //    {
        //        var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, model.PhoneNumber);
        //        if (!setPhoneResult.Succeeded)
        //        {
        //            throw new ApplicationException($"Unexpected error occurred setting phone number for user with ID '{user.Id}'.");
        //        }
        //    }

        //    StatusMessage = "Your profile has been updated";
        //    return RedirectToAction(nameof(Index));
        //}

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
            
            if (type == "family")
            {
                ViewBag.HasQueryString = true;
                var meStudent = await _context.Students.SingleOrDefaultAsync(s => s.Id == user.Id);
                var myActiveStudentFamily = await _context.StudentFamilies.SingleOrDefaultAsync(sf => sf.StudentId == meStudent.Id && sf.IsActive);
                var myFamily = myActiveStudentFamily.Family;
                List<Answer> answers = null;
                if (myFamily != null)
                {
                    var ids = _context.StudentFamilies
                        .Where(sf => sf.FamilyId == myFamily.Id)
                        .Select(sf => sf.StudentId)
                        .ToList();
                    answers = _context.Answers
                        .Include(a => a.Book)
                        .ThenInclude(b => b.Answers)
                        .Where(a => ids.Contains(a.UserId))
                        .ToList();
                    ViewBag.Ids = ids;
                    return View(answers);
                }
                return View(answers);
            }

            var answers2 = await _context.Answers
                .Include(a => a.Book)
                .ThenInclude(b => b.Answers)
                .Where(a => a.UserId == user.Id)
                .ToListAsync();
            ViewBag.HasQueryString = false;
            ViewData["SchoolYear"] = DateTime.Parse(DateTime.Today.ToString(CultureInfo.CurrentCulture)).Year + "/"
                                     + DateTime.Parse(DateTime.Today.AddYears(1).ToString(CultureInfo.CurrentCulture)).Year;
            return View(answers2);
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
        public  async Task<IActionResult> Messages(MessageViewModel model)
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
                    if(studentClass == null)
                    {
                        var studentFamily = await _context.StudentFamilies
                                            .SingleAsync(sc => sc.FamilyId == id && sc.StudentId == user.Id);
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
                    var myStudentFamilies = _context.StudentFamilies.Where(sf => sf.FamilyId == id)?.ToList();
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
                        if (studentFamily.FamilyId == id) studentFamily.IsActive = true;
                        studentFamily.IsActive = false;
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
            if(user.UserType == UserTypes.Teacher)
            {
                if (type == "accept")
                {
                    // add Student to Class
                    var thisStudent = await _context.Students.SingleAsync(s => s.Id == id);
                    var hasActiveStudentClass = _context.StudentClasses.Any(sc => sc.StudentId == id && sc.IsActive) ||
                        _context.StudentFamilies.Any(sf => sf.StudentId == id && sf.IsActive);
                    var myClass = await _context.Classes.SingleAsync(c => c.Id == user.Id);
                    var newStudentClass = new StudentClass()
                    {
                        Student = thisStudent,
                        StudentId = thisStudent.Id,
                        Class = myClass,
                        ClassId = myClass.Id,
                        IsActive = !hasActiveStudentClass
                    };
                    myClass.StudentClasses.Add(newStudentClass);
                    // remove first key from list
                    var userSubscription = _context.UserSubscriptions
                        .SingleOrDefault(us => us.UserId == user.Id && us.Status == StatusTypes.Activated);
                    userSubscription?.ActivationKeys.RemoveAt(0);
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

            if (!string.IsNullOrEmpty(groupsVm.Search) && _context.Classes.Any()) {

                var allGroups = _context.Classes
                    .Where(c => c.NameOfGroup != null && c.NameOfGroup.Contains(groupsVm.Search) || 
                                c.FullName.Contains(groupsVm.Search) || 
                                c.School != null && c.School.Contains(groupsVm.Search)).ToList();
                var currentClasses = _context.StudentClasses
                        .Where(sc => sc.StudentId == user.Id)
                        .Select(sc => sc.Class)
                        .ToList();
                var requestedClasses = _context.Requests
                    .Where(r => r.StudentId == user.Id)
                    .Select(r => r.Class)
                    .ToList();

                var queriedCurrentClasses = currentClasses
                    .Where(c => c.NameOfGroup != null && c.NameOfGroup.Contains(groupsVm.Search) ||
                                c.FullName.Contains(groupsVm.Search) ||
                                c.School != null && c.School.Contains(groupsVm.Search)).ToList();
                var queriedRequestedClasses = requestedClasses
                    .Where(c => c.NameOfGroup != null && c.NameOfGroup.Contains(groupsVm.Search) ||
                                c.FullName.Contains(groupsVm.Search) ||
                                c.School != null && c.School.Contains(groupsVm.Search)).ToList();

                ViewBag.CurrentClassesIds = queriedCurrentClasses.Select(g => g.Id).ToList();
                ViewBag.RequestedClassesIds = queriedRequestedClasses.Select(g => g.Id).ToList();

                allGroups.AddRange(queriedCurrentClasses);
                allGroups.AddRange(queriedRequestedClasses);

                groupsVm.AllGroups = allGroups.Distinct().ToList();
            }
            // avoiding AllGroups being null to display message in view
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
        public async Task<IActionResult> Order( int? id, int? myself, int? old, int? license_id)
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
                    Email = user.Email
                };
                return View(newUserSubscriptionVm); 
            }
            if (id.HasValue && old.HasValue)
            {
                var subscription = await _context.Subscriptions.SingleAsync(s => s.Id == id);
               var userSubscription =  await _context.UserSubscriptions.Include(us => us.User)
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
                    Subscription = subscription,
                    Email = userSubscription.User.Email,
                    Uid = userSubscription.Uid,
                    AddressOfInstitution = userSubscription.AddressOfInstitution,
                    Person = userSubscription.Person,
                    Invoice = userSubscription.Invoice,
                    PayMethod = userSubscription.PaymentType == PaymentType.BankTransfer? 1 : 2
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
            if (ModelState.IsValid)
            {
                if (model.Id != 0) 
                {
                    var userSubscription = await _context.UserSubscriptions.SingleAsync(us => us.Id == model.Id);
                    userSubscription.Email = model.Email;
                    userSubscription.Invoice = model.Invoice;
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
                        Email = model.Email,
                        PaymentType = model.PayMethod == 1 ? PaymentType.BankTransfer : PaymentType.CreditCard,
                        Invoice = model.Invoice
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
                    CreateActivationKeys(newUserSubscription);

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

        public void CreateActivationKeys(UserSubscription userSubscription)
        {
            switch (userSubscription.Subscription.SubscriptionType)
            {
                case SubscriptionTypes.Student:
                    var studentActivationKey = new ActivationKey();
                    userSubscription.ActivationKeys.Add(studentActivationKey);
                    _context.ActivationKeys.Add(studentActivationKey); // needed?
                    break;
                case SubscriptionTypes.Family:
                    var familyActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Family };
                    userSubscription.ActivationKeys.Add(familyActivationKey);
                    for (var i = 1; i <= 5; i++)
                    {
                        var studentActivationKeyInFamily = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Student };
                        userSubscription.ActivationKeys.Add(studentActivationKeyInFamily);
                        _context.ActivationKeys.Add(studentActivationKeyInFamily); // needed?
                    }
                    break;
                case SubscriptionTypes.Class:
                    var classActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Class };
                    userSubscription.ActivationKeys.Add(classActivationKey);
                    for (var i = 1; i <= 31; i++)
                    {
                        var studentActivationKeyInClass = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Student };
                        userSubscription.ActivationKeys.Add(studentActivationKeyInClass);
                        _context.ActivationKeys.Add(studentActivationKeyInClass); // needed?
                    }
                    break;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Licenses()
        {
            var user = await _userManager.GetUserAsync(User);
            var allUserSubscriptions = _context.UserSubscriptions
                .Include(us => us.Subscription)
                .Include(us => us.ActivationKeys)
                .Where(us => us.UserId == user.Id).ToList();
            var paid = allUserSubscriptions.Where(us =>
                us.Subscription.SubscriptionType != SubscriptionTypes.FreeClass ||
                us.Subscription.SubscriptionType != SubscriptionTypes.FreeFamily ||
                us.Subscription.SubscriptionType != SubscriptionTypes.FreeClass).ToList();
            Enum userType = null;
            switch (user.UserType)
            {
                case UserTypes.Student:
                    userType = ActivationKeyTypes.Student;
                    break;
                case UserTypes.Parent:
                    userType = ActivationKeyTypes.Family;
                    break;
                case UserTypes.Teacher:
                    userType = ActivationKeyTypes.Class;
                    break;
            }
            ViewBag.UserType = userType;
            return View(paid);
        }

        //[HttpGet]
        //public async Task<IActionResult> License()
        //{

        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> SendVerificationEmail(IndexViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(nameof(Dashboard), model);
        //    }

        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        //    var callbackUrl = Url.EmailConfirmationLink((user.Id).ToString(), code, Request.Scheme);
        //    var email = user.Email;
        //    await _emailSender.SendEmailConfirmationAsync(email, callbackUrl);

        //    StatusMessage = "Verification email sent. Please check your email.";
        //    return RedirectToAction(nameof(Index));
        //}

        //[HttpGet]
        //public async Task<IActionResult> ChangePassword()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var hasPassword = await _userManager.HasPasswordAsync(user);
        //    if (!hasPassword)
        //    {
        //        return RedirectToAction(nameof(SetPassword));
        //    }

        //    var model = new ChangePasswordViewModel { StatusMessage = StatusMessage };
        //    return View(model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
        //    if (!changePasswordResult.Succeeded)
        //    {
        //        AddErrors(changePasswordResult);
        //        return View(model);
        //    }

        //    await _signInManager.SignInAsync(user, isPersistent: false);
        //    _logger.LogInformation("User changed their password successfully.");
        //    StatusMessage = "Your password has been changed.";

        //    return RedirectToAction(nameof(ChangePassword));
        //}


        //[HttpGet]
        //public async Task<IActionResult> SetPassword()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var hasPassword = await _userManager.HasPasswordAsync(user);

        //    if (hasPassword)
        //    {
        //        return RedirectToAction(nameof(ChangePassword));
        //    }

        //    var model = new SetPasswordViewModel { StatusMessage = StatusMessage };
        //    return View(model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> SetPassword(SetPasswordViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var addPasswordResult = await _userManager.AddPasswordAsync(user, model.NewPassword);
        //    if (!addPasswordResult.Succeeded)
        //    {
        //        AddErrors(addPasswordResult);
        //        return View(model);
        //    }

        //    await _signInManager.SignInAsync(user, isPersistent: false);
        //    StatusMessage = "Your password has been set.";

        //    return RedirectToAction(nameof(SetPassword));
        //}

        //[HttpGet]
        //public async Task<IActionResult> ExternalLogins()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var model = new ExternalLoginsViewModel { CurrentLogins = await _userManager.GetLoginsAsync(user) };
        //    model.OtherLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync())
        //        .Where(auth => model.CurrentLogins.All(ul => auth.Name != ul.LoginProvider))
        //        .ToList();
        //    model.ShowRemoveButton = await _userManager.HasPasswordAsync(user) || model.CurrentLogins.Count > 1;
        //    model.StatusMessage = StatusMessage;

        //    return View(model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> LinkLogin(string provider)
        //{
        //    // Clear the existing external cookie to ensure a clean login process
        //    await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

        //    // Request a redirect to the external login provider to link a login for the current user
        //    var redirectUrl = Url.Action(nameof(LinkLoginCallback));
        //    var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl, _userManager.GetUserId(User));
        //    return new ChallengeResult(provider, properties);
        //}

        //[HttpGet]
        //public async Task<IActionResult> LinkLoginCallback()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var info = await _signInManager.GetExternalLoginInfoAsync((user.Id).ToString());
        //    if (info == null)
        //    {
        //        throw new ApplicationException($"Unexpected error occurred loading external login info for user with ID '{user.Id}'.");
        //    }

        //    var result = await _userManager.AddLoginAsync(user, info);
        //    if (!result.Succeeded)
        //    {
        //        throw new ApplicationException($"Unexpected error occurred adding external login for user with ID '{user.Id}'.");
        //    }

        //    // Clear the existing external cookie to ensure a clean login process
        //    await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

        //    StatusMessage = "The external login was added.";
        //    return RedirectToAction(nameof(ExternalLogins));
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> RemoveLogin(RemoveLoginViewModel model)
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var result = await _userManager.RemoveLoginAsync(user, model.LoginProvider, model.ProviderKey);
        //    if (!result.Succeeded)
        //    {
        //        throw new ApplicationException($"Unexpected error occurred removing external login for user with ID '{user.Id}'.");
        //    }

        //    await _signInManager.SignInAsync(user, isPersistent: false);
        //    StatusMessage = "The external login was removed.";
        //    return RedirectToAction(nameof(ExternalLogins));
        //}

        //[HttpGet]
        //public async Task<IActionResult> TwoFactorAuthentication()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var model = new TwoFactorAuthenticationViewModel
        //    {
        //        HasAuthenticator = await _userManager.GetAuthenticatorKeyAsync(user) != null,
        //        Is2faEnabled = user.TwoFactorEnabled,
        //        RecoveryCodesLeft = await _userManager.CountRecoveryCodesAsync(user),
        //    };

        //    return View(model);
        //}

        //[HttpGet]
        //public async Task<IActionResult> Disable2faWarning()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    if (!user.TwoFactorEnabled)
        //    {
        //        throw new ApplicationException($"Unexpected error occured disabling 2FA for user with ID '{user.Id}'.");
        //    }

        ////    return View(nameof(Disable2fa));
        ////}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Disable2fa()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var disable2faResult = await _userManager.SetTwoFactorEnabledAsync(user, false);
        //    if (!disable2faResult.Succeeded)
        //    {
        //        throw new ApplicationException($"Unexpected error occured disabling 2FA for user with ID '{user.Id}'.");
        //    }

        //    _logger.LogInformation("User with ID {UserId} has disabled 2fa.", user.Id);
        //    return RedirectToAction(nameof(TwoFactorAuthentication));
        //}

        //[HttpGet]
        //public async Task<IActionResult> EnableAuthenticator()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var model = new EnableAuthenticatorViewModel();
        //    await LoadSharedKeyAndQrCodeUriAsync(user, model);

        //    return View(model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> EnableAuthenticator(EnableAuthenticatorViewModel model)
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    if (!ModelState.IsValid)
        //    {
        //        await LoadSharedKeyAndQrCodeUriAsync(user, model);
        //        return View(model);
        //    }

        //    // Strip spaces and hypens
        //    var verificationCode = model.Code.Replace(" ", string.Empty).Replace("-", string.Empty);

        //    var is2faTokenValid = await _userManager.VerifyTwoFactorTokenAsync(
        //        user, _userManager.Options.Tokens.AuthenticatorTokenProvider, verificationCode);

        //    if (!is2faTokenValid)
        //    {
        //        ModelState.AddModelError("Code", "Verification code is invalid.");
        //        await LoadSharedKeyAndQrCodeUriAsync(user, model);
        //        return View(model);
        //    }

        //    await _userManager.SetTwoFactorEnabledAsync(user, true);
        //    _logger.LogInformation("User with ID {UserId} has enabled 2FA with an authenticator app.", user.Id);
        //    var recoveryCodes = await _userManager.GenerateNewTwoFactorRecoveryCodesAsync(user, 10);
        //    TempData[RecoveryCodesKey] = recoveryCodes.ToArray();

        //    return RedirectToAction(nameof(ShowRecoveryCodes));
        //}

        //[HttpGet]
        //public IActionResult ShowRecoveryCodes()
        //{
        //    var recoveryCodes = (string[])TempData[RecoveryCodesKey];
        //    if (recoveryCodes == null)
        //    {
        //        return RedirectToAction(nameof(TwoFactorAuthentication));
        //    }

        //    var model = new ShowRecoveryCodesViewModel { RecoveryCodes = recoveryCodes };
        //    return View(model);
        //}

        //[HttpGet]
        //public IActionResult ResetAuthenticatorWarning()
        //{
        //    return View(nameof(ResetAuthenticator));
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ResetAuthenticator()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    await _userManager.SetTwoFactorEnabledAsync(user, false);
        //    await _userManager.ResetAuthenticatorKeyAsync(user);
        //    _logger.LogInformation("User with id '{UserId}' has reset their authentication app key.", user.Id);

        //    return RedirectToAction(nameof(EnableAuthenticator));
        //}

        //[HttpGet]
        //public async Task<IActionResult> GenerateRecoveryCodesWarning()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    if (!user.TwoFactorEnabled)
        //    {
        //        throw new ApplicationException($"Cannot generate recovery codes for user with ID '{user.Id}' because they do not have 2FA enabled.");
        //    }

        //    return View(nameof(GenerateRecoveryCodes));
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> GenerateRecoveryCodes()
        //{
        //    var user = await _userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    if (!user.TwoFactorEnabled)
        //    {
        //        throw new ApplicationException($"Cannot generate recovery codes for user with ID '{user.Id}' as they do not have 2FA enabled.");
        //    }

        //    var recoveryCodes = await _userManager.GenerateNewTwoFactorRecoveryCodesAsync(user, 10);
        //    _logger.LogInformation("User with ID {UserId} has generated new 2FA recovery codes.", user.Id);

        //    var model = new ShowRecoveryCodesViewModel { RecoveryCodes = recoveryCodes.ToArray() };

        //    return View(nameof(ShowRecoveryCodes), model);
        //}

        #region Helpers

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
