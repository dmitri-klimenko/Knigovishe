using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class AnswerGroupViewModel
    {
        public Answer Answer { get; set; }
        public int TimesSolved { get; set; }
    }
}
