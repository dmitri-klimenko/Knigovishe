using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace Knigosha.Core.Models
{
    public class Request
    {
        public int Id { get; set; }
        public Class Class { get; set; }
        public string ClassId { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }
    }
}
