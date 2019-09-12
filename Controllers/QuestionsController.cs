using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Knigosha.Core.Models;
using Knigosha.Persistence;
using Knigosha.Persistence.Migrations;

namespace Knigosha.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuestionsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            var questions = _context.Questions.Where(q => q.BookId == id);
            var title = _context.Books.Single(b => b.Id == id).Title;
            ViewData["BookId"] = id;
            ViewData["BookTitle"] = title;
            return View(questions);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            
            var question = await _context.Questions
                .Include(q => q.Book)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question == null) return NotFound();
            return View(question);
        }


        public async Task<IActionResult> Create(int id)
        {
            var numberOfQuestions = await _context.Questions.CountAsync(q => q.BookId == id);
            ViewData["NumberOfQuestion"] = numberOfQuestions + 1;
           var  questionNumber = numberOfQuestions + 1;

            var question = new Question()
            {
                BookId = id,
                QuestionNumber = (byte)questionNumber
            };
            return View(question);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,Text,RightAnswer,WrongAnswer1,WrongAnswer2,QuestionType")] Question question)
        {
            if (ModelState.IsValid)
            {
                //var book = await _context.Books.SingleAsync(b => b.Id == question.BookId);
                //book.Questions.Add(question);
                _context.Add(question);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", "Questions", new {id = question.BookId});
            }
            return View(question);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var question = await _context.Questions.FindAsync(id);
            if (question == null) return NotFound();
            ViewData["BookId"] = new SelectList(_context.Books, "Id", "BookAuthor", question.BookId);
            return View(question);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BookId,Text,RightAnswer,WrongAnswer1,WrongAnswer2,QuestionType")] Question question)
        {
            if (id != question.Id) return NotFound();
            
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(question);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionExists(question.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Questions", new { id = question.BookId });
            }
     
            return View(question);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var question = await _context.Questions
                .Include(q => q.Book)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (question == null) return NotFound();
            return View(question);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Questions", new {id = question.BookId});
        }

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.Id == id);
        }
    }
}
