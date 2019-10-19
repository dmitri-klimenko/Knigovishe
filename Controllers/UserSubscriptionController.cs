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

    }
}
