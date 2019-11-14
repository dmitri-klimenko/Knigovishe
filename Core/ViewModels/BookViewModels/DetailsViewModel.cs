using System.Collections.Generic;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;

namespace Knigosha.Core.ViewModels.BookViewModels
{
    public class DetailsViewModel
    {
        public Book Book { get; set; }
        public int BookId { get; set; }
        public List<Book> Recommended { get; set; }
        public BookNote BookNote { get; set; }
        public UserTypes UserType { get; set; }
        public int? MyRating { get; set; }
        public int? CountOfStudentsAnswers { get; set; }
        public int? PercentageOfStudentsRightResponses { get; set; }
    }
}