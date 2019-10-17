using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum Levels
    {
        [Display(Name = "новичок")]
        Null = 0,
        [Display(Name = "освоившийся")]
        One = 1,
        [Display(Name = "поднаторелый")]
        Two = 2,
        [Display(Name = "умелый")]
        Three = 3,
        [Display(Name = "профи")]
        Four = 4,
        [Display(Name = "мастер")]
        Five = 5,
        [Display(Name = "герой")]
        Six = 6
      
    }
}