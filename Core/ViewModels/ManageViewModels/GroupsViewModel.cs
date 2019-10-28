using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class GroupsViewModel
    {
        public string Search { get; set; }
        public List<Class> AllGroups { get; set; }
        public List<StudentClass> MyCurrentGroups { get; set; }
        public List<Request> MyRequests { get; set; }
    }
}
