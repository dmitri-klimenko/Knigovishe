
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Knigosha.Core.ViewModels.BookViewModels
{
    public class IndexBookViewModel
    {
        public List<Book> Books { get; set; }
        public string Keywords { get; set; }
        public SelectList Publishers { get; set; }
        public string BookPublisher { get; set; }
        public string YearFrom { get; set; }
        public string YearTo { get; set; }
        public BookCategories Category { get; set; }
        public AgeGroups AgeGroup { get; set; }
        public string SortField { get; set; }
        public List<int> BooksIds { get; set; }


        public int CurrentPage { get; set; }

        public int Count { get; set; }

        public int PageSize { get; set; }

        public int TotalPages { get; set; }

        public bool EnablePrevious { get; set; }

        public bool EnableNext { get; set; }
    }

}

