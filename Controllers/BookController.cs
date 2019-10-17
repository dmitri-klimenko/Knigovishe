using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Core.ViewModels.BookViewModels;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Knigosha.Controllers
{
    public class BookController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
            _context = context;
        }

        public async Task<IActionResult> IndexAdmin()
        {
            return View(await _context.Books.ToListAsync());
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(string keywords, string bookPublisher, BookCategories category, AgeGroups ageGroup, string yearFrom, string yearTo, string sortField)
        {
            var books = _context.Books.Include(b => b.Answers).AsQueryable();

            var publishers = books.Select(b => b.Publisher);

            if (!string.IsNullOrEmpty(keywords))
            {
                books = books.Where(b => b.Title.Contains(keywords) ||
                                         b.BookAuthor.Contains(keywords)
                                         || b.Isbn1.Contains(keywords) ||
                                         b.Isbn2.Contains(keywords));
            }

            if (!string.IsNullOrEmpty(bookPublisher))
            {
                books = books.Where(b => b.Publisher == bookPublisher);
            }

            if (category != 0)
            {
                books = books.Where(b => b.BookCategory == category);
            }

            if (ageGroup != 0)
            {
                books = books.Where(b => b.AgeGroup == ageGroup);

            }
            if (!string.IsNullOrEmpty(yearFrom))
            {
                books = books.Where(b => int.Parse(b.YearPublished) >= int.Parse(yearFrom));
            }

            if (!string.IsNullOrEmpty(yearTo))
            {
                books = books.Where(b => int.Parse(b.YearPublished) <= int.Parse(yearTo));
            }

            switch (sortField)
            {
                case "latest":
                    books = books.OrderByDescending(b => b.DateAdded);
                    break;
                case "rating":
                    books = books.OrderByDescending(b => b.AverageRating);
                    break;
                case "views":
                    books = books.OrderByDescending(b => b.Answers.Count);
                    break;
                case "class":
                    books = books.OrderBy(b => b.Grade);
                    break;
                case "year":
                    books = books.OrderBy(b => b.YearPublished);
                    break;
                case "title":
                    books = books.OrderBy(b => b.Title);
                    break;
                case "author":
                    books = books.OrderBy(b => b.BookAuthor);
                    break;
                default:
                    books = books.OrderByDescending(b => b.DateAdded);
                    break;
            }

            var indexVm = new IndexBookViewModel()
            {
                Books = await books.ToListAsync(),
                Publishers = new SelectList(await publishers.Distinct().ToListAsync()),
            };

            return View(indexVm);

        }

        public async Task<IActionResult> DetailsAdmin(int? id)
        {
            if (id == null) return NotFound();
            var book = await _context.Books
                .Include(b=> b.Questions)
                .Include(b => b.Answers)
                .Include(b => b.BookRatings)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var book = await _context.Books
                .Include(b => b.Answers)
                .Include(b => b.BookRatings)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null) return NotFound();

            var recommended = _context.Books.Take(4).ToList();
            var vm = new DetailsViewModel() 
            {
                Book = book,
                Recommended = recommended
            };
            return View(vm);
        }

        public IActionResult Create()
        {
            var createBookVm = new CreateBookViewModel();
            return View(createBookVm);
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateBookViewModel createBookVm)
        {
            if (ModelState.IsValid)
            {
                var uniqueFileName = GetUniqueFileName(createBookVm.UploadPhoto.FileName);
                var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                var filePath = Path.Combine(uploads, uniqueFileName);
                createBookVm.UploadPhoto.CopyTo(new FileStream(filePath, FileMode.Create));

                var newBook = new Book()
                {
                    Title = createBookVm.Title,
                    AddedByAdmin = createBookVm.AddedByAdmin,
                    BookAuthor = createBookVm.BookAuthor,
                    BookCategory = createBookVm.BookCategory,
                    QuestionsAuthor = createBookVm.QuestionsAuthor,
                    PartOfSchoolProgramAtGrade = createBookVm.PartOfSchoolProgramAtGrade,
                    Publisher = createBookVm.Publisher,
                    Description = createBookVm.Description,
                    IsShortForm = createBookVm.IsShortForm,
                    Isbn1 = createBookVm.Isbn1,
                    Isbn2 = createBookVm.Isbn2,
                    Tags = createBookVm.Tags,
                    Translator = createBookVm.Translator,
                    NumberOfPages = createBookVm.NumberOfPages,
                    YearPublished = createBookVm.YearPublished,
                    Grade = createBookVm.Grade,
                    CoverPhoto = uniqueFileName
                };
                _context.Books.Add(newBook);
                await _context.SaveChangesAsync();

                return RedirectToAction("IndexAdmin", "Book");
            }
            return View(createBookVm);
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                   + "_"
                   + Guid.NewGuid().ToString().Substring(0, 4)
                   + Path.GetExtension(fileName);
        }
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var book = await _context.Books.FindAsync(id);
            if (book == null) return NotFound();
            var editBookVm = new EditBookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                AddedByAdmin = book.AddedByAdmin,
                BookAuthor = book.BookAuthor,
                BookCategory = book.BookCategory,
                QuestionsAuthor = book.QuestionsAuthor,
                PartOfSchoolProgramAtGrade = book.PartOfSchoolProgramAtGrade,
                Publisher = book.Publisher,
                Description = book.Description,
                IsShortForm = book.IsShortForm,
                Isbn1 = book.Isbn1,
                Isbn2 = book.Isbn2,
                Tags = book.Tags,
                Translator = book.Translator,
                NumberOfPages = book.NumberOfPages,
                YearPublished = book.YearPublished,
                Grade = book.Grade,
            };

            return View(editBookVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditBookViewModel editBookVm)
        {

            if (ModelState.IsValid)
            {
                var book = await _context.Books.FindAsync(editBookVm.Id);

                if (editBookVm.UploadPhoto != null)
                {
                    var uniqueFileName = GetUniqueFileName(editBookVm.UploadPhoto.FileName);
                    var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    editBookVm.UploadPhoto.CopyTo(new FileStream(filePath, FileMode.Create));
                    book.CoverPhoto = uniqueFileName;
                }
                book.Title = editBookVm.Title;
                book.AddedByAdmin = editBookVm.AddedByAdmin;
                book.BookAuthor = editBookVm.BookAuthor;
                book.BookCategory = editBookVm.BookCategory;
                book.QuestionsAuthor = editBookVm.QuestionsAuthor;
                book.PartOfSchoolProgramAtGrade = editBookVm.PartOfSchoolProgramAtGrade;
                book.Publisher = editBookVm.Publisher;
                book.Description = editBookVm.Description;
                book.IsShortForm = editBookVm.IsShortForm;
                book.Isbn1 = editBookVm.Isbn1;
                book.Isbn2 = editBookVm.Isbn2;
                book.Tags = editBookVm.Tags;
                book.Translator = editBookVm.Translator;
                book.NumberOfPages = editBookVm.NumberOfPages;
                book.YearPublished = editBookVm.YearPublished;
                book.Grade = editBookVm.Grade;
                book.DateEdited = DateTime.Now.ToString("d");
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(editBookVm.Id))
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
            return View(editBookVm);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexAdmin));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }

    }
}
