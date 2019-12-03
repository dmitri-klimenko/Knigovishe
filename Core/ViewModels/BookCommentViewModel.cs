using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels
{
    public class BookCommentViewModel
    {
        public ApplicationUser User { get; set; }
        public BookRating BookRating { get; set; }
        public BookComment BookComment { get; set; }
    }
}
