using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Knigosha.Core.Models
{
    public class StudentClass
    {
        [Key, Column(Order = 2)]
        public string StudentId { get; set; }
        public Student Student { get; set; }

        [Key, Column(Order = 1)]
        public string ClassId { get; set; }
        public Class Class { get; set; }

        public bool IsActive { get; set; }
    }
}
