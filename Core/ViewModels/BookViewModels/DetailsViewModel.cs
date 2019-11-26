using System.Collections.Generic;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;

namespace Knigosha.Core.ViewModels.BookViewModels
{
    public class DetailsViewModel
    {
        public Book Book { get; set; }
        public Answer Answer { get; set; }
        public int BookId { get; set; }
        public List<Book> Recommended { get; set; }
        public BookNote BookNote { get; set; }
        public UserTypes UserType { get; set; }
        public int? MyRating { get; set; }
        public int? CountOfStudentsAnswers { get; set; }
        public int? PercentageOfStudentsRightResponses { get; set; }
        public string OpinionQuestion { get; set; }
        public List<int> BooksIds { get; set; }
        public string Action { get; set; }
        public string Text { get; set; }
        public int AnswerId { get; set; }
    }
}