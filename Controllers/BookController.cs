using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Core.ViewModels.BookViewModels;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.ResultOperators.Internal;

namespace Knigosha.Controllers
{
    public class BookController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public BookController(ApplicationDbContext context, 
            IHostingEnvironment environment, 
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
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
            var user = await _userManager.GetUserAsync(User);

            var booksIds = _context.MarkedBooks
                .Where(mb => mb.UserId == user.Id)
                .Select(mb => mb.BookId).ToList();

            var books = _context.Books
                .Include(b => b.Answers)
                .Include(b => b.BookRatings)
                .AsQueryable();


            var publishers = books.Select(b => b.Publisher);

            if (!string.IsNullOrEmpty(keywords))
            {
                books = books.Where(b => b.Title.ToUpper().Contains(keywords.ToUpper()) ||
                                         b.BookAuthor.ToUpper().Contains(keywords.ToUpper()) ||
                                         b.Isbn1.ToUpper().Contains(keywords.ToUpper()) ||
                                         b.Publisher.ToUpper().Contains(keywords.ToUpper()) ||
                                         b.Isbn2.ToUpper().Contains(keywords.ToUpper()));
            }

            if (!string.IsNullOrEmpty(bookPublisher))
                books = books.Where(b => b.Publisher == bookPublisher);
            
            if (category != 0) books = books.Where(b => b.BookCategory == category);

            if (ageGroup != 0) books = books.Where(b => b.AgeGroup == ageGroup);

            if (!string.IsNullOrEmpty(yearFrom) && int.TryParse(yearFrom, out int n))
                books = books.Where(b => int.Parse(b.YearPublished) >= n);
            
            if (!string.IsNullOrEmpty(yearTo) && int.TryParse(yearTo, out int m))
                books = books.Where(b => int.Parse(b.YearPublished) <= m);
            
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
                Books = await books?.ToListAsync(),
                Publishers = new SelectList(await publishers.Distinct().ToListAsync()),
                BooksIds = booksIds
            };

            return View(indexVm);
        }

        public async Task<IActionResult> DetailsAdmin(int? id)
        {
            var book = await _context.Books
                .Include(b=> b.Questions)
                .Include(b => b.Answers)
                .Include(b => b.BookRatings)
                .FirstOrDefaultAsync(m => m.Id == id);
            return View(book);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(User);

                var answer = await _context.Answers
                    .Include(a => a.Book)
                    .FirstOrDefaultAsync(a => a.BookId == id && a.UserId == user.Id);

                Book book;
 
                if (answer == null)
                {
                    book = _context.Books
                        .Include(b => b.Answers)
                        .Include(b => b.Questions)
                        .Include(b => b.BookRatings)
                        .Single(b => b.Id == id);

                } else {book = answer.Book;}

                var bookNote =
                    await _context.BookNotes.SingleOrDefaultAsync(bn => bn.UserId == user.Id && bn.BookId == book.Id) ??
                    new BookNote()
                    {
                        Book = book,
                        BookId = book.Id,
                        User = user,
                        UserId = user.Id
                    };

                var rating = _context.BookRatings.SingleOrDefault(br => br.UserId == user.Id && br.BookId == id)?.Rating;

                var recommended = _context.Books.Take(4).ToList(); // change it later

                var opinionQuestion = await _context.Questions
                    .SingleOrDefaultAsync(q => q.QuestionType == QuestionTypes.Opinion && q.BookId == book.Id);

                var booksIds = _context.MarkedBooks
                    .Where(mb => mb.UserId == user.Id)
                    .Select(mb => mb.BookId).ToList();

                var vm1 = new DetailsViewModel
                {
                    Answer = answer,
                    Book = book,
                    BookId = book.Id,
                    Recommended = recommended,
                    BookNote = bookNote,
                    MyRating = rating,
                    UserType = user.UserType,
                    OpinionQuestion = opinionQuestion?.Text,
                    BooksIds = booksIds
                };

                if (user.UserType == UserTypes.Parent)
                {
                    var studentIds = _context.StudentFamilies
                        .Where(uf => uf.FamilyId == user.Id)
                        .Select(uf => uf.StudentId)?.ToList();
                    var answers = _context.Answers.Where(
                        a => a.BookId == book.Id && studentIds.Contains(a.UserId))?.ToList();
                    var count = answers?.Count;
                    if (count == 0)
                    {
                        vm1.PercentageOfStudentsRightResponses = 0;
                        vm1.CountOfStudentsAnswers = 0;
                    }
                    else
                    {
                        vm1.PercentageOfStudentsRightResponses = answers.Sum(a => a.PercentageOfRightResponses) / count;
                        vm1.CountOfStudentsAnswers = count;
                    }
                }

                else if (user.UserType == UserTypes.Teacher)
                {
                    var studentIds = _context.StudentClasses
                        .Where(uf => uf.ClassId == user.Id)
                        .Select(uf => uf.StudentId)?.ToList();
                    var answers = _context.Answers.Where(
                        a => a.BookId == book.Id && studentIds.Contains(a.UserId))?.ToList();
                    var count = answers?.Count;
                    if (count == 0)
                    {
                        vm1.PercentageOfStudentsRightResponses = 0;
                        vm1.CountOfStudentsAnswers = 0;
                    }
                    else
                    {
                        vm1.PercentageOfStudentsRightResponses = answers.Sum(a => a.PercentageOfRightResponses) / count;
                        vm1.CountOfStudentsAnswers = count;
                    }

                }
                return View(vm1);
            }
            var recommended2 = _context.Books.Take(4).ToList(); // change it later

            var book2 = await _context.Books
                .Include(b => b.Answers)
                .Include(b => b.BookRatings)
                .FirstOrDefaultAsync(b => b.Id == id);

            var vm2 = new DetailsViewModel() 
            {
                Book = book2,
                Recommended = recommended2
            };
            return View(vm2);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(DetailsViewModel detailsViewModel)
        {
            if (ModelState.IsValid)
            {
                if (detailsViewModel.Action == "reset")
                {

                }

                var user = await _userManager.GetUserAsync(User);

                var book = await _context.Books
                    .Include(b => b.Answers)
                    .Include(b => b.BookRatings)
                    .FirstOrDefaultAsync(m => m.Id == detailsViewModel.BookId);

                var recommended = _context.Books.Take(4).ToList();

                var bookNote = await _context.BookNotes
                    .SingleOrDefaultAsync(bn => bn.UserId == user.Id &&
                                                bn.BookId == detailsViewModel.BookId);
                           
                if (bookNote == null)
                {
                    var newBookNote = new BookNote()
                    {
                        User = user,
                        UserId = user.Id,
                        Book = book,
                        BookId = book.Id,
                        Text = detailsViewModel.BookNote.Text
                    };
                    user.BookNotes.Add(newBookNote);
                    await _userManager.UpdateAsync(user);
                }
                else
                {
                    bookNote.Text = detailsViewModel.BookNote.Text;
                    await _context.SaveChangesAsync();
                }
                detailsViewModel.Book = book;
                detailsViewModel.Recommended = recommended;
                detailsViewModel.BookNote = bookNote;
                return View(detailsViewModel);
            }
            return View(detailsViewModel);
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
