using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Persistence;

namespace Knigosha.Controllers
{
    public class UserSubscriptionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserSubscriptionController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var userSubscriptions = await _context.UserSubscriptions
                .Include(us => us.Subscription)
                .Include(u => u.User)
                .ToListAsync();
              
            return View(userSubscriptions);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var userSubscription = await _context.UserSubscriptions
                .Include(us => us.Subscription)
                .Include(us => us.User)
                .Include(us => us.ActivationKeys)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userSubscription == null) return NotFound();
            return View(userSubscription);
        }


        [HttpPost]
        public async Task<ActionResult> SendActivationKey(int userSubscriptionId)
        {
            var userSubscription = _context.UserSubscriptions.Single(s => s.Id == userSubscriptionId);
            userSubscription.Status = StatusTypes.Paid;

            var subscriptionType = userSubscription.Subscription.SubscriptionType;
            switch (subscriptionType)
            {
                case SubscriptionTypes.Student:
                    var studentActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Student };
                    userSubscription.ActivationKeys.Add(studentActivationKey);
                    _context.ActivationKeys.Add(studentActivationKey); 
                    break;
                case SubscriptionTypes.Family:
                    var familyActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Family };
                    userSubscription.ActivationKeys.Add(familyActivationKey);
                    _context.ActivationKeys.Add(familyActivationKey);
                    break;
                case SubscriptionTypes.Class:
                    var classActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Class };
                    userSubscription.ActivationKeys.Add(classActivationKey);
                    _context.ActivationKeys.Add(classActivationKey);
                    break;

            }
            _context.Update(userSubscription);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<UserSubscription>> ActivateUserSubscription(int userSubscriptionId, string entryCode)
        {
            var userSubscription = _context.UserSubscriptions
                .Include(us => us.ActivationKeys)
                .Single(s => s.Id == userSubscriptionId);

            var valid = false;

            foreach (var activationKey in userSubscription.ActivationKeys)
            {
                if (activationKey.Code == entryCode) valid = true;
            }
            if (valid)
            {
                userSubscription.Status = StatusTypes.Activated;

                var subscriptionType = userSubscription.Subscription.SubscriptionType;
                switch (subscriptionType)
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
                await _context.SaveChangesAsync();
                return NoContent();
            }

            return BadRequest("Неверный код");

        }
    }
}
