using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class DashboardViewModel
    {
        public ApplicationUser User { get; set; }
        public bool HasPaidSubscriptions { get; set; }
    }
}
