using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class MessageViewModel
    {
        public List<SelectListItem> Recipients { get; set;  }
        public Message Message { get; set; }
    }
}
