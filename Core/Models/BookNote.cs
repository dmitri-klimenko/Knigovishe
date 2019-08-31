using System;
using System.Globalization;

namespace Knigosha.Core.Models
{
    public class BookNote
    {

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public string Text { get; set; }
        public string DateTime { get; set; }

        protected BookNote() { }

        public BookNote(ApplicationUser user, Book book)
        {
            User = user ?? throw new ArgumentNullException(nameof(User));
            Book = book ?? throw new ArgumentNullException(nameof(Book));
            DateTime = System.DateTime.Now.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
        }

    }
}