using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum Levels
    {
        [Display(Name = "новичок")]
        Null = 0,
        [Display(Name = "безстрашный")]
        One = 1,
        [Display(Name = "путешественик")]
        Two = 2,
        [Display(Name = "открыватель")]
        Three = 3,
        [Display(Name = "изобретатель")]
        Four = 4,
        [Display(Name = "шаман")]
        Five = 5,
        [Display(Name = "сенсей")]
        Six = 6,
        [Display(Name= "творец")]
        Seven = 7
    }
}