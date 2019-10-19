using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Knigosha.Core.Models
{
    public class BookNote
    {
        public ApplicationUser User { get; set; }

        [Key, Column(Order = 1)]
        public string UserId { get; set; }

        public Book Book { get; set; }

        [Key, Column(Order = 2)]
        public int BookId { get; set; }

        public string Text { get; set; }
        public string DateTime { get; set; }

        public BookNote()
        {
            DateTime = System.DateTime.Now.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
        }
    }
}