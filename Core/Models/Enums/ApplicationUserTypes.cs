using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum ApplicationUserTypes
    {
        Student,
        [Display(Name = "Parent")]
        Family,
        [Display(Name = "Teacher")]
        Class
    }
}