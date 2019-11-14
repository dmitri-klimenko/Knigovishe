using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class StudentsViewModel
    {
        public List<Student> Children { get; set; }
        public List<ActivationKey> Keys { get; set; }
        public string SchoolYear { get; set; }
        public ApplicationUser User { get; set; }
        public string StatusMessage { get; set; }
    }
}
