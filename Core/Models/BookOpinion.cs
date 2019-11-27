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
        public ApplicationUser User { get; set; }
        [Key, Column(Order = 2)]
        public string UserId { get; set; }
        public Book Book { get; set; }
        [Key, Column(Order = 1)]
        public int BookId { get; set; }
        public string AnswerText { get; set; }
        public bool Share { get; set; }
    }
}
