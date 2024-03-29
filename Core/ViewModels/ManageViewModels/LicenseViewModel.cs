﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class LicenseViewModel
    {
        public string Code { get; set; }
        public UserSubscription MyUserSubscription { get; set; }
        public ApplicationUser User { get; set; }
        public string StatusMessage { get; set; }
    }
}
