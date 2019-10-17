using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum AgeGroups
    {
        [Display(Name = "6+")]
        SixPlus = 1,
        [Display(Name = "8+")]
        EightPlus = 2,
        [Display(Name = "11+")]
        ElevenPlus = 3,
        [Display(Name = "14+")]
        FourteenPlus = 4

    }
}