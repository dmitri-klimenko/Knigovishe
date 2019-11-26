using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    
        public class ManageNavViewModel
        {
            public ApplicationUser User { get; set; }
            public bool HasActiveClass { get; set; }
            public bool HasActiveFamily { get; set; }
            public int MessagesCount { get; set; }
            public int RequestsCount { get; set; }
            public int ResetsCount { get; set; }
            public List<MarkedBook> MarkedBooks { get; set; }
        }
    
}
