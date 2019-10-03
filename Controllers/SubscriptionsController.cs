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
    public class SubscriptionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubscriptionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAdmin()
        {
            return View(await _context.Subscriptions.ToListAsync());
        }

        public async Task<IActionResult> Index()
        {
            var notFreeSubscriptions = _context.Subscriptions
                .Where(s => s.SubscriptionType != SubscriptionTypes.FreeStudent &&
                            s.SubscriptionType != SubscriptionTypes.FreeFamily &&
                            s.SubscriptionType != SubscriptionTypes.FreeClass);

            return View(await notFreeSubscriptions.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var subscription = await _context.Subscriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscription == null) return NotFound();
            return View(subscription);
        }

        public IActionResult Create()
        {
            var subscription = new Subscription();
            return View(subscription);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubscriptionType, Name, CurrentPrice,OldPrice,Discount,MaxQuizzes,NumberOfStudentProfiles,NumberOfParentProfiles,NumberOfTeacherProfiles,ValidUntil,BankData,Text1,Text2,Text3")] Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexAdmin));
            }
            return View(subscription);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound(); 

            var subscription = await _context.Subscriptions.FindAsync(id);
            if (subscription == null) return NotFound();
            return View(subscription);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name, SubscriptionType,CurrentPrice,OldPrice,Discount,MaxQuizzes,NumberOfStudentProfiles,NumberOfParentProfiles,NumberOfTeacherProfiles,ValidUntil,BankData,Text1,Text2,Text3")] Subscription subscription)
        {
            if (id != subscription.Id) return NotFound(); 

            if (ModelState.IsValid)
            {
                subscription.DateEdited = DateTime.Now.ToString("d");
                try
                {
                    _context.Update(subscription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubscriptionExists(subscription.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexAdmin));
            }
            return View(subscription);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var subscription = await _context.Subscriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subscription == null) return NotFound();
            return View(subscription);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subscription = await _context.Subscriptions.FindAsync(id);
            _context.Subscriptions.Remove(subscription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexAdmin));
        }

        private bool SubscriptionExists(int id)
        {
            return _context.Subscriptions.Any(e => e.Id == id);
        }
    }
}
