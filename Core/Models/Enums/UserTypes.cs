using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum UserTypes
    {
        [Display(Name = "Школьник")]
        Student = 1,
        [Display(Name = "Учитель")]
        Teacher = 2,
        [Display(Name = "Родитель")]
        Parent = 3
    }
}