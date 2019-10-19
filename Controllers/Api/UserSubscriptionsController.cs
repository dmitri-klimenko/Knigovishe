using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Knigosha.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSubscriptionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserSubscriptionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [HttpPost]
        public async Task<ActionResult> CreateFree (ApplicationUser user)
        {
            var userType = user.UserType;
            UserSubscription userSubscription = null;
            switch (userType)
            {
                case UserTypes.Student:
                    var studentSubscription =
                        await _context.Subscriptions.SingleAsync(s => s.SubscriptionType == SubscriptionTypes.FreeStudent);
                    userSubscription = new UserSubscription(user, studentSubscription);
                    var studentActivationKey = new ActivationKey() {ActivationKeyType = ActivationKeyTypes.Student};
                    userSubscription.ActivationKeys.Add(studentActivationKey);
                    userSubscription.ActivatedOn = DateTime.Today.ToString("d");
                    break;
                case UserTypes.Parent:
                    var familySubscription =
                        await _context.Subscriptions.SingleAsync(s => s.SubscriptionType == SubscriptionTypes.FreeFamily);
                    userSubscription = new UserSubscription(user, familySubscription);
                    var familyActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Family };
                    userSubscription.ActivationKeys.Add(familyActivationKey);
                    userSubscription.ActivatedOn = DateTime.Today.ToString("d");
                    for (var i = 1; i < 5; i++)
                    {
                        var studentActivationKeyInFamily = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Student };
                        userSubscription.ActivationKeys.Add(studentActivationKeyInFamily);
                    }
                    break;
                case UserTypes.Teacher:
                    var classSubscription =
                        await _context.Subscriptions.SingleAsync(s => s.SubscriptionType == SubscriptionTypes.FreeClass);
                    userSubscription = new UserSubscription(user, classSubscription);
                    var classActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Class };
                    userSubscription.ActivationKeys.Add(classActivationKey);
                    userSubscription.ActivatedOn = DateTime.Today.ToString("d");
                    for (var i = 1; i < 31; i++)
                    {
                        var studentActivationKeyInClass = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Student };
                        userSubscription.ActivationKeys.Add(studentActivationKeyInClass);
                    }
                    break;
            }

            user.UserSubscriptions.Add(userSubscription ?? throw new InvalidOperationException());
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Create (string id, int subscriptionId)
        {
            var user = await _context.Users.FindAsync(id);
            var subscription = await _context.Subscriptions.FindAsync(subscriptionId);
            var userSubscription = new UserSubscription(user, subscription)
                { Status = StatusTypes.Waiting };
            user.UserSubscriptions.Add(userSubscription);
            _context.UserSubscriptions.Add(userSubscription);
            await _context.SaveChangesAsync();
            return NoContent();
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
        public async Task<ActionResult<UserSubscription>> ActivateUserSubscription(int? userSubscriptionId, string entryCode)
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
                userSubscription.ActivatedOn = DateTime.Today.ToString("d");

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
