using System;
using System.Globalization;

namespace Knigosha.Core.Models
{
    public class BookRating
    {
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public int Rating { get; set; }
    }
}