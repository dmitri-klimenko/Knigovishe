using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Knigosha.Persistence;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;

namespace Knigosha.Core.Models
{
    public class Family : ApplicationUser
    {
        public IList<StudentFamily> StudentFamilies { get; set; }

        public Family()   
        {
            StudentFamilies = new List<StudentFamily>();
        }
    }
}