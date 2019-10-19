using System.Collections.Generic;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.BookViewModels
{
    public class DetailsViewModel
    {
        public Book Book { get; set; }
        public int BookId { get; set; }

        public List<Book> Recommended { get; set; }
        public BookNote BookNote { get; set; }

    }
}