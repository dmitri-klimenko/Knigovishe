using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels
{
    public class BookOpinionViewModel
    {
        public BookOpinion BookOpinion { get; set; }
        public ApplicationUser User { get; set; }
        public BookRating BookRating { get; set; }

    }
}
