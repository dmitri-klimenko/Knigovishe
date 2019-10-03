using Knigosha.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using Knigosha.Core.Models.Enums;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Knigosha.Controllers
{
    public class HomeController : Controller

    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var latestBooks = _context.Books.OrderByDescending(b => b.DateAdded).Take(5).ToList();
            var popularBooks = _context.Books
                .Include(b=>b.BookRatings)
                .Include(b => b.Answers)
                .OrderByDescending(b => b.AverageRating).Take(4).ToList();
            var recentNews = _context.Texts.Where(n => n.TextType == TextTypes.Post).OrderByDescending(t => t.DateAdded).Take(3).ToList();
            var subscriptions = _context.Subscriptions
                .Where(s => s.SubscriptionType != SubscriptionTypes.FreeClass 
                            && s.SubscriptionType != SubscriptionTypes.FreeFamily).OrderBy(s => s.Name)
                .ToList();

            var vm = new HomeViewModel
            {
                LatestAddedBooks = latestBooks,
                MostPopularBooks = popularBooks,
                RecentNews = recentNews,
                Subscriptions = subscriptions
            };
            return View(vm);
        }

        public IActionResult Help()
        {
            return View();
        }

        public IActionResult Team()
        {
            var team = _context.Texts.Where(t => t.TextType == TextTypes.Author).ToList();
            return View(team);
        }

        public IActionResult Partners()
        {
            return View();
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TermsOfUse()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Policy()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult HowItWorks()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult CreateClass()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult UseClass()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult CreateFamily()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult UseFamily()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Activate()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Faq()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult CreateQuiz()
        {
            throw new System.NotImplementedException();
        }
    }
}
