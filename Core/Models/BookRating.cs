using System;

namespace Knigosha.Core.Models
{
    public class BookRating
    {
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public int Rating { get; set; }

        protected BookRating() { }

        private BookRating(ApplicationUser user, Book book)
        {
            User = user ?? throw new ArgumentNullException(nameof(User));
            Book = book ?? throw new ArgumentNullException(nameof(Book));
        }
    }
}