using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace Knigosha.Core.Models
{
    public class Class : ApplicationUser
    {
        public string NameOfGroup { get; set; }

        public IList<StudentClass> StudentClasses { get; set; }

        public Class()
        {
            StudentClasses = new List<StudentClass>();
            NameOfGroup = "";
        }
    }
}