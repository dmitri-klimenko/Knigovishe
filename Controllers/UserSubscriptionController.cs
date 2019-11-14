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
                .Where(us => us.Subscription.SubscriptionType == SubscriptionTypes.Class ||
                             us.Subscription.SubscriptionType == SubscriptionTypes.Family ||
                             us.Subscription.SubscriptionType == SubscriptionTypes.Student)
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

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var userSubscription = await _context.UserSubscriptions
                .Include(us => us.Subscription)
                .Include(us => us.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userSubscription == null) return NotFound();
            return View(userSubscription);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userSubscription = await _context.UserSubscriptions.FindAsync(id);
            _context.UserSubscriptions.Remove(userSubscription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<ActionResult> CreateFree(ApplicationUser user)
        {
            var userType = user.UserType;
            UserSubscription userSubscription = null;
            switch (userType)
            {
                case UserTypes.Student:
                    var studentSubscription =
                        await _context.Subscriptions.SingleAsync(s =>
                            s.SubscriptionType == SubscriptionTypes.FreeStudent);
                    userSubscription = new UserSubscription(user, studentSubscription);
                    var studentActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Student };
                    userSubscription.ActivationKeys.Add(studentActivationKey);
                    userSubscription.Status = StatusTypes.Activated;
                    userSubscription.ActivatedOn = DateTime.Today;
                    userSubscription.Myself = true;
                    break;
                case UserTypes.Parent:
                    var familySubscription =
                        await _context.Subscriptions.SingleAsync(
                            s => s.SubscriptionType == SubscriptionTypes.FreeFamily);
                    userSubscription = new UserSubscription(user, familySubscription);
                    var familyActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Family };
                    userSubscription.ActivationKeys.Add(familyActivationKey);
                    userSubscription.Status = StatusTypes.Activated;
                    userSubscription.ActivatedOn = DateTime.Today;
                    userSubscription.Myself = true;
                    for (var i = 1; i < 5; i++)
                    {
                        var studentActivationKeyInFamily = new ActivationKey()
                        { ActivationKeyType = ActivationKeyTypes.Student };
                        userSubscription.ActivationKeys.Add(studentActivationKeyInFamily);
                    }

                    break;
                case UserTypes.Teacher:
                    var classSubscription =
                        await _context.Subscriptions.SingleAsync(s =>
                            s.SubscriptionType == SubscriptionTypes.FreeClass);
                    userSubscription = new UserSubscription(user, classSubscription);
                    var classActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Class };
                    userSubscription.ActivationKeys.Add(classActivationKey);
                    userSubscription.Status = StatusTypes.Activated;
                    userSubscription.Myself = true;
                    userSubscription.ActivatedOn = DateTime.Today;
                    for (var i = 1; i < 31; i++)
                    {
                        var studentActivationKeyInClass = new ActivationKey()
                        { ActivationKeyType = ActivationKeyTypes.Student };
                        userSubscription.ActivationKeys.Add(studentActivationKeyInClass);
                    }

                    break;
            }

            user.UserSubscriptions.Add(userSubscription ?? throw new InvalidOperationException());
            await _context.SaveChangesAsync();
            return NoContent();
        }

        public void CreateActivationKeys(UserSubscription userSubscription)
        {
            switch (userSubscription.Subscription.SubscriptionType)
            {
                case SubscriptionTypes.Student:
                    var studentActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Student };
                    userSubscription.ActivationKeys.Add(studentActivationKey);
                    _context.ActivationKeys.Add(studentActivationKey); // needed?
                    break;
                case SubscriptionTypes.Family:
                    var familyActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Family };
                    userSubscription.ActivationKeys.Add(familyActivationKey);
                    for (var i = 1; i < 5; i++)
                    {
                        var studentActivationKeyInFamily = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Student };
                        userSubscription.ActivationKeys.Add(studentActivationKeyInFamily);
                        _context.ActivationKeys.Add(studentActivationKeyInFamily); // needed?
                    }
                    break;
                case SubscriptionTypes.Class:
                    var classActivationKey = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Class };
                    userSubscription.ActivationKeys.Add(classActivationKey);
                    for (var i = 1; i < 31; i++)
                    {
                        var studentActivationKeyInClass = new ActivationKey() { ActivationKeyType = ActivationKeyTypes.Student };
                        userSubscription.ActivationKeys.Add(studentActivationKeyInClass);
                        _context.ActivationKeys.Add(studentActivationKeyInClass); // needed?
                    }
                    break;
            }
        }

        public async Task<ActionResult> DisplayActivationKey(int id)
        {
            var userSubscription = await _context.UserSubscriptions.SingleAsync(us => us.Id == id);
            userSubscription.Status = StatusTypes.Paid;
            _context.UserSubscriptions.Update(userSubscription);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", new {id});
        }
    }
}
