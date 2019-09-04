using System.Collections.Generic;

namespace Knigosha.Persistence
{
    public class City
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<School> Schools { get; set; }
    }
}