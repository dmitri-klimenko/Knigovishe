
using System;
using System.Globalization;

namespace Knigosha.Core.Models
{
    public class MarkedBook
    {

        public Book Book { get; set; }
        public int BookId { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public string DateTime { get; set; }

        protected MarkedBook() { }

        public MarkedBook(ApplicationUser user, Book book)
        {
            User = user ?? throw new ArgumentNullException(nameof(User));
            Book = book ?? throw new ArgumentNullException(nameof(Book));
            DateTime = System.DateTime.Now.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
        }

    }
}