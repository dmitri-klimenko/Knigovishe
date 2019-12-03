using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore.Internal;
using Remotion.Linq.Clauses;

namespace Knigosha.Core.Models
{
    public class Student : ApplicationUser
    {
        public IList<StudentClass> StudentClasses { get; set; }
        public IList<StudentFamily> StudentFamilies { get; set; }
 

        public Student()
        {
            StudentClasses = new List<StudentClass>();
            StudentFamilies = new List<StudentFamily>();
        }

        public string ParentEmail { get; set; }

    }
}