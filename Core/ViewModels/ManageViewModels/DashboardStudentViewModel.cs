using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class DashboardStudentViewModel
    {
        public ApplicationUser User { get; set; }
        public bool HasAccess { get; set; }
        public List<Book> Recommended { get; set; }
        public int PointsTillNextLevel { get; set; }
    }
}
