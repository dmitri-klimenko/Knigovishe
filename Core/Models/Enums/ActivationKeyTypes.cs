using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum ActivationKeyTypes
    {
        [Display(Name = "Ученик")]
        Student = 1,
        [Display(Name = "Родитель")]
        Family = 2,
        [Display(Name = "Учитель")]
        Class = 3
    }
}