using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Knigosha.Core.Models
{
    public class BookOpinion
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public string AnswerText { get; set; }
        public bool Share { get; set; }
        public bool Approved { get; set; }
    }
}
