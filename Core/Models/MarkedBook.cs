
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
    }
}