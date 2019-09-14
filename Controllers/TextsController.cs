using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Knigosha.Core.Models;
using Knigosha.Persistence;

namespace Knigosha.Controllers
{
    public class TextsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TextsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Texts.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var text = await _context.Texts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (text == null) return NotFound();
            return View(text);
        }

        public IActionResult Create()
        {
            var text = new Text();
            return View(text);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Namespace,Key,Content")] Text text)
        {
            if (ModelState.IsValid)
            {
                _context.Add(text);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(text);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var text = await _context.Texts.FindAsync(id);
            if (text == null) return NotFound();
            return View(text);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Namespace,Key,Content")] Text text)
        {
            if (id != text.Id) return NotFound();
            if (ModelState.IsValid)
            {
                text.DateEdited = DateTime.Now.ToString("d");
                try
                {
                    _context.Update(text);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TextExists(text.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(text);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
                var text = await _context.Texts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (text == null) return NotFound();
            return View(text);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var text = await _context.Texts.FindAsync(id);
            _context.Texts.Remove(text);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TextExists(int id)
        {
            return _context.Texts.Any(e => e.Id == id);
        }
    }
}
