using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Timers;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Core.ViewModels.ManageViewModels;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Knigosha.Controllers
{
    public class AnswerController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private int _bookId;


        public AnswerController(
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<ActionResult> Quiz(string act, int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var book = await _context.Books
                .Include(b => b.Questions)
                .SingleAsync(b => b.Id == id);
            var rating = _context.BookRatings.SingleOrDefault(br => br.UserId == user.Id && br.BookId == id)?.Rating;
            _bookId = book.Id;

            var quizVm = new QuizViewModel
            {
                Book = book,
                HasAccess = HasAccess(user),
                MyRating = rating,
            };

            if (act == "start")
            {
                var questions = _context.Questions.Where(q =>
                    q.BookId == book.Id && q.QuestionType == QuestionTypes.ContentComprehension).ToList();

                quizVm.Questions = questions;

                if (_context.Answers.Count(a => a.BookId == book.Id && a.UserId == user.Id) == 0)
                {
                    var newAnswer = new Answer(user, book)
                    {
                        UserId = user.Id,
                        BookId = book.Id,
                        QuizType = user.UserType == UserTypes.Student ? QuizTypes.Individual : QuizTypes.Group,
                        Started = DateTime.Now
                    };
                    _context.Answers.Add(newAnswer);
                    await _context.SaveChangesAsync();
                    quizVm.Points = 0;
                    quizVm.CurrentQuestion = 0;
                    quizVm.CurrentSecond = 1800;
                }
                else
                {
                    var answer = await _context.Answers.SingleAsync(a => a.BookId == book.Id && a.UserId == user.Id);
                    var now = DateTime.Now;
                    var timeSPan = now - answer.Started;
                    var seconds = (int)timeSPan.TotalSeconds;
                    quizVm.Points = answer.Points;
                    quizVm.CurrentQuestion = answer.CurrentQuestion;
                    quizVm.CurrentSecond = 1800 - seconds;
                }

                return View("QuizAction", quizVm);
            }
            return View(quizVm);
        }

        public bool HasAccess(ApplicationUser user)
        {
            var activeSubscriptions = _context.UserSubscriptions.Include(us => us.Subscription)
                .Where(us => us.UserId == user.Id && us.ActivatedOn != null).ToList();

            var freeSubscription = activeSubscriptions
                .Find(us => us.Subscription.SubscriptionType == SubscriptionTypes.FreeClass ||
                            us.Subscription.SubscriptionType == SubscriptionTypes.FreeFamily ||
                            us.Subscription.SubscriptionType == SubscriptionTypes.FreeStudent);

            var duration = DateTime.Today.Subtract((DateTime)freeSubscription.ActivatedOn);
            TimeSpan maxDuration = TimeSpan.FromDays(14);

            var count = _context.Answers.Count(a => a.UserId == user.Id);

            var hasValidFreeSubscription = TimeSpan.Compare(duration, maxDuration) < 0 && count < 3;

            var paidSubscription = activeSubscriptions
                .Find(us => us.Subscription.SubscriptionType == SubscriptionTypes.Class ||
                            us.Subscription.SubscriptionType == SubscriptionTypes.Family ||
                            us.Subscription.SubscriptionType == SubscriptionTypes.Student);

            var hasValidPaidSubscription = paidSubscription != null && DateTime.Compare((DateTime)paidSubscription.ActivatedOn,
                                               DateTime.Parse(paidSubscription.Subscription.ValidUntil)) < 0;

            return (hasValidFreeSubscription || hasValidPaidSubscription);
        }
    }
}