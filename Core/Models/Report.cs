using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigosha.Core.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Question { get; set; }
        public Book Book { get; set; }
        public DateTime DateTime { get; set; }

        public Report()
        {
            DateTime = DateTime.Now;
        }
    }
}
