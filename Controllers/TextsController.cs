using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Core.ViewModels.TextViewModels;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Hosting;

namespace Knigosha.Controllers
{
    public class TextsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public TextsController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _hostingEnvironment = environment;
        }

        public async Task<IActionResult> Index()
        {
            var news = await _context.Texts.Where(t => t.TextType == TextTypes.Post).OrderByDescending(t => t.DateAdded).ToListAsync();

            var vm = new IndexTextViewModel()
            {
                LastAddedText = news.Count > 0 ? news[0] : null,
                LastAddedTexts = news.Count > 1 ? news.Skip(1).ToList() : null
            };

            return View(vm);
        }

        public async Task<IActionResult> IndexAdmin()
        {
            return View(await _context.Texts.ToListAsync());
        }

        public async Task<IActionResult> DetailsAdmin(int? id)
        {
            if (id == null) return NotFound();
            var text = await _context.Texts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (text == null) return NotFound();
            return View(text);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var text = await _context.Texts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (text == null) return NotFound();

            var otherTexts = await _context.Texts.Where(t => t.Id != id).ToListAsync();

            var vm = new IndexTextViewModel()
            {
                LastAddedText = text,
                LastAddedTexts = otherTexts
            };
            return View(vm);
        }

        public IActionResult Create()
        {
            var textVm = new CreateTextVewModel();
            return View(textVm);
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_"
                   + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateTextVewModel createTextVm)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                 
                if (createTextVm.Photo != null)
                {
                    uniqueFileName = GetUniqueFileName(createTextVm.Photo.FileName);
                    var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    createTextVm.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                
                var newText = new Text()
                {
                    Title = createTextVm.Title,
                    Paragraph1 = createTextVm.Paragraph1,
                    Paragraph2 = createTextVm.Paragraph2,
                    Paragraph3 = createTextVm.Paragraph3,
                    Paragraph4 = createTextVm.Paragraph4,
                    Paragraph5 = createTextVm.Paragraph5,
                    Paragraph6 = createTextVm.Paragraph6,
                    Paragraph7 = createTextVm.Paragraph7,
                    Paragraph8 = createTextVm.Paragraph8,
                    Paragraph9 = createTextVm.Paragraph9,
                    Paragraph10 = createTextVm.Paragraph10,
                    Photo = uniqueFileName,
                    TextType = createTextVm.TextType,
                    DateAdded = DateTime.Now.ToString("dd.MM.yyyy")
                };
                _context.Texts.Add(newText);
                await _context.SaveChangesAsync();

                return RedirectToAction("IndexAdmin", "Texts");
            }
            return View(createTextVm);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var text = await _context.Texts.FindAsync(id);
            if (text == null) return NotFound();
            var textVm = new EditTextVewModel()
            {
                Id = text.Id,
                Title = text.Title,
                Paragraph1 = text.Paragraph1,
                Paragraph2 = text.Paragraph2,
                Paragraph3 = text.Paragraph3,
                Paragraph4 = text.Paragraph4,
                Paragraph5 = text.Paragraph5,
                Paragraph6 = text.Paragraph6,
                Paragraph7 = text.Paragraph7,
                Paragraph8 = text.Paragraph8,
                Paragraph9 = text.Paragraph9,
                Paragraph10 = text.Paragraph10,
                TextType = text.TextType
            };

            return View(textVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditTextVewModel textVm)
        {
            if (ModelState.IsValid)
            {
                var text = await _context.Texts.FindAsync(textVm.Id);

                if (textVm.Photo != null)
                {
                    var uniqueFileName = GetUniqueFileName(textVm.Photo.FileName);
                    var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    textVm.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    text.Photo = uniqueFileName;
                }
                text.Title = textVm.Title;
                text.Paragraph1 = textVm.Paragraph1;
                text.Paragraph2 = textVm.Paragraph2;
                text.Paragraph3 = textVm.Paragraph3;
                text.Paragraph4 = textVm.Paragraph4;
                text.Paragraph5 = textVm.Paragraph5;
                text.Paragraph6 = textVm.Paragraph6;
                text.Paragraph7 = textVm.Paragraph7;
                text.Paragraph8 = textVm.Paragraph8;
                text.Paragraph9 = textVm.Paragraph9;
                text.Paragraph10 = textVm.Paragraph10;
                text.TextType = textVm.TextType;
                text.DateEdited = DateTime.Now.ToString("dd.MM.yyyy");
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
                return RedirectToAction(nameof(IndexAdmin));
            }
            return View(textVm);
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
            return RedirectToAction(nameof(IndexAdmin));
        }

        private bool TextExists(int id)
        {
            return _context.Texts.Any(e => e.Id == id);
        }
    }
}
