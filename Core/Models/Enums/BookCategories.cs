using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum BookCategories
    {
        [Display(Name = "Художественная литература")]
        Fiction = 1,
        [Display(Name = "Научно-познавательная литература")]
        Nonfiction = 2
    }
}