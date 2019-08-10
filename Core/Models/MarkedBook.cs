
using System;

namespace Knigosha.Core.Models
{
    public class MarkedBook
    {

        public Book Book { get; set; }
        public int BookId { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        protected MarkedBook() { }

        private MarkedBook(ApplicationUser user, Book book)
        {
            User = user ?? throw new ArgumentNullException(nameof(User));
            Book = book ?? throw new ArgumentNullException(nameof(Book));
        }

    }
}