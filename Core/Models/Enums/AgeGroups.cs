using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum AgeGroups
    {
        [Display(Name = "6+")]
        SixPlus,
        [Display(Name = "8+")]
        EightPlus,
        [Display(Name = "11+")]
        ElevenPlus,
        [Display(Name = "14+")]
        FourteenPlus

    }
}