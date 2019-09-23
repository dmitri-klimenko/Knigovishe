using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Knigosha.Core.Models
{
    public class AllFamiliesGroup
    {
        public int Id { get; set; }
        public ICollection<Family> Families { get; set; }

        public int NumberOfFamiliesInGroup => Families.Count;

        public AllFamiliesGroup()
        {
            Families = new Collection<Family>();
        }
    }
}
