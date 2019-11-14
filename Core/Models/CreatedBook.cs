using System;

namespace Knigosha.Core.Models
{
    public class CreatedBook
    {
        public int Id { get; set; }
        public int Points { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsArchive { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        public CreatedBook()
        {
            DateTime = DateTime.Today;
        }
    }
}