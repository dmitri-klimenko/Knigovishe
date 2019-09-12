using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum BookCategories
    {
        [Display(Name = "Художественная литература")]
        Fiction,
        [Display(Name = "Научно-познавательная литература")]
        Nonfiction
    }
}