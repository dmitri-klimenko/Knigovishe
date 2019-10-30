using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;


namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class MessagesViewModel
    {
        public List<Message> Messages { get; set; }
        public bool HasGroup { get; set; } 
    }
}
