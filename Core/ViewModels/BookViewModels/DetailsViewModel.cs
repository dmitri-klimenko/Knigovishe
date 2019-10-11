using System.Collections.Generic;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.BookViewModels
{
    public class DetailsViewModel
    {
        public Book Book { get; set; }
        public List<Book> Recommended { get; set; }
    }
}