using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Knigosha.Core.ViewModels;
using Knigosha.Core.ViewModels.BookViewModels;
using Knigosha.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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

        public int CurrentPage { get; set; } = 1;

        public int Count { get; set; }

        public int PageSize { get; set; } = 24;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public bool EnablePrevious => CurrentPage > 1;

        public bool EnableNext => CurrentPage < TotalPages;


        public async Task<IActionResult> IndexAdmin()
        {
            return View(await _context.Books.ToListAsync());
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(string keywords, string bookPublisher, BookCategories category, AgeGroups ageGroup, string yearFrom, string yearTo, string sortField, int page = 1)
        {
            var user = await _userManager.GetUserAsync(User);

            var books = _context.Books
                .Include(b => b.Answers)
                .Include(b => b.BookRatings)
                .AsQueryable();

            CurrentPage = page == 0 ? 1 : page;

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

            Count = books.Count();

            if (CurrentPage > TotalPages)
                CurrentPage = TotalPages;

            var indexVm = new IndexBookViewModel()
            {
                Books = await books.Skip((CurrentPage - 1) * PageSize)
                    .Take(PageSize)
                    .ToListAsync(),

                Publishers = new SelectList(await publishers.Distinct().ToListAsync()),

                CurrentPage = CurrentPage,
                Count = Count,
                PageSize = PageSize,
                TotalPages = TotalPages,
                EnablePrevious = EnablePrevious,
                EnableNext = EnableNext
            };

            if (User.Identity.IsAuthenticated)
            {
                var booksIds = _context.MarkedBooks
                    .Where(mb => mb.UserId == user.Id)
                    .Select(mb => mb.BookId).ToList();

                indexVm.BooksIds = booksIds;
            }
            return View(indexVm);
        }





        public async Task<IActionResult> DetailsAdmin(int? id)
        {
            var book = await _context.Books
                .Include(b => b.Questions)
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

                }
                else { book = answer.Book; }

                var bookCommentsFromOthers =
                    _context.BookComments
                        .Include(bc => bc.User)
                        .ThenInclude(u => u.BookRatings)
                        .Where(bc => bc.UserId != user.Id && bc.Approved)
                        .Select(bc => new BookCommentViewModel
                        {
                            BookComment = bc,
                            User = bc.User,
                            BookRating = bc.User.BookRatings.SingleOrDefault(br => br.BookId == bc.BookId)
                        }).ToList();


                var bookOpinionsFromOthers =
                    _context.BookOpinions
                        .Include(bo => bo.User)
                        .ThenInclude(u => u.BookRatings)
                        .Where(bo => bo.UserId != user.Id && bo.Approved)
                        .Select(bo => new BookOpinionViewModel
                        {
                            BookOpinion = bo,
                            User = bo.User,
                            BookRating = bo.User.BookRatings.SingleOrDefault(br => br.BookId == bo.BookId)
                        }).ToList();


                var bookNoteText =
                     _context.BookNotes.SingleOrDefault(bn => bn.UserId == user.Id && bn.BookId == book.Id)?.Text;

                var bookComment = await _context.BookComments.SingleOrDefaultAsync(bc =>
                    bc.UserId == user.Id && bc.BookId == book.Id);

                var bookOpinion =
                   await  _context.BookOpinions.SingleOrDefaultAsync(bc =>
                        bc.UserId == user.Id && bc.BookId == book.Id);

                var rating = _context.BookRatings.SingleOrDefault(br => br.UserId == user.Id && br.BookId == id)?.Rating;

                var recommended = _context.Books.Take(4).ToList(); // change it later

                var opinionQuestionText = _context.Questions
                    .SingleOrDefault(q => q.QuestionType == QuestionTypes.Opinion && q.BookId == book.Id)?.Text;

                var booksIds = _context.MarkedBooks
                    .Where(mb => mb.UserId == user.Id)
                    .Select(mb => mb.BookId).ToList();

                var vm1 = new DetailsViewModel
                {
                    Answer = answer,
                    Book = book,
                    BookId = book.Id,
                    Recommended = recommended,
                    MyRating = rating,
                    UserType = user.UserType,
                    OpinionQuestion = opinionQuestionText,
                    BooksIds = booksIds,
                    BookComment = bookComment,
                    BookOpinion = bookOpinion,

                    BookNoteText = bookNoteText,
                    BookOpinionText = bookOpinion?.AnswerText,
                    BookCommentText = bookComment?.Text,

                    BookCommentsFromOthers = bookCommentsFromOthers,
                    BookOpinionsFromOthers = bookOpinionsFromOthers,
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
            var user = await _userManager.GetUserAsync(User);

            switch (detailsViewModel.Action)
            {
                case "reset":
                    {
                        var answer = await _context.Answers
                            .Include(a => a.Book)
                            .FirstOrDefaultAsync(a => a.BookId == detailsViewModel.BookId && a.UserId == user.Id);

                        answer.ReasonForRestart = detailsViewModel.ReasonForRestart;  // presence of ReasonForRestart indicates request for restart
                        _context.Answers.Update(answer);
                        await _context.SaveChangesAsync();

                        return RedirectToAction("Details", new { id = detailsViewModel.BookId });
                    }
                case "saveOpinion":
                    {
                        var bookComment = await _context.BookComments
                            .SingleOrDefaultAsync(bn => bn.UserId == user.Id &&
                                                        bn.BookId == detailsViewModel.BookId);
                        if (bookComment == null)
                        {
                            var newBookComment = new BookComment
                            {
                                BookId = detailsViewModel.BookId,
                                UserId = user.Id,
                                Text = detailsViewModel.BookCommentText,
                                Share = detailsViewModel.Share
                            };
                            _context.BookComments.Add(newBookComment);
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            bookComment.Share = detailsViewModel.Share;
                            bookComment.Text = detailsViewModel.BookCommentText;
                            await _context.SaveChangesAsync();
                        }

                        return RedirectToAction("Details", new { id = detailsViewModel.BookId });
                    }
                case "answerText":
                    {
                        var bookOpinion = await _context.BookOpinions
                            .SingleOrDefaultAsync(bn => bn.UserId == user.Id &&
                                                        bn.BookId == detailsViewModel.BookId);
                        if (bookOpinion == null)
                        {
                            var newBookOpinion = new BookOpinion
                            {
                                BookId = detailsViewModel.BookId,
                                UserId = user.Id,
                                AnswerText = detailsViewModel.BookOpinionText,
                                Share = detailsViewModel.Share
                            };
                            _context.BookOpinions.Add(newBookOpinion);
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            bookOpinion.Share = detailsViewModel.Share;
                            bookOpinion.AnswerText = detailsViewModel.BookOpinionText;
                            await _context.SaveChangesAsync();
                        }

                        return RedirectToAction("Details", new { id = detailsViewModel.BookId });

                    }
                case "makeNote":
                    {
                        var bookNote = await _context.BookNotes
                            .SingleOrDefaultAsync(bn => bn.UserId == user.Id &&
                                                        bn.BookId == detailsViewModel.BookId);

                        if (bookNote == null)
                        {
                            var newBookNote = new BookNote()
                            {
                                UserId = user.Id,
                                BookId = detailsViewModel.BookId,
                                Text = detailsViewModel.BookNoteText
                            };
                            user.BookNotes.Add(newBookNote);
                            await _userManager.UpdateAsync(user);
                        }
                        else
                        {
                            bookNote.Text = detailsViewModel.BookNoteText;
                            await _context.SaveChangesAsync();
                        }

                        return RedirectToAction("Details", new { id = detailsViewModel.BookId });

                    }
            }

            return NoContent();
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
