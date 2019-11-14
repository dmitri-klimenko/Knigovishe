using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class PointsViewModel
    {
        public ApplicationUser User { get; set; }
        public int NumberOfBooksCreatedByMe { get; set; }
        public int PointsForBooksCreatedByMe { get; set; }
        public int NumberOfBooksCreatedByStudents { get; set; }
        public int PointsForBooksCreatedByStudents { get; set; }
        public List<Book> BooksCreatedByMe { get; set; }
        public List<Book> BooksCreatedByStudents{ get; set; }
    }
}
