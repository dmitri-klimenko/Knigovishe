using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigosha.Core.Models
{
    public class StudentFamily
    {
        public int Id { get; set; }

        public string StudentId { get; set; }
        public Student Student { get; set; }


        public string FamilyId { get; set; }
        public Family Family { get; set; }

        public bool IsActive { get; set; }
    }

}
