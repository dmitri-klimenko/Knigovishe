using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Knigosha.Core.Models
{
    public class AllClassesGroup
    {
        public int Id { get; set; }
        public ICollection<Class> Classes { get; set; }

        public int NumberOfClassesInGroup => Classes.Count;

        public AllClassesGroup()
        {
            Classes = new Collection<Class>();
        }
    }
}
