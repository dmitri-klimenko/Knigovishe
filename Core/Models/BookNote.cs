using System;

namespace Knigosha.Core.Models
{
    public class BookNote

    {
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public string Text { get; set; }

        protected BookNote() { }

        private BookNote(ApplicationUser user, Book book)
        {
            User = user ?? throw new ArgumentNullException(nameof(User));
            Book = book ?? throw new ArgumentNullException(nameof(Book));
        }

    }
}