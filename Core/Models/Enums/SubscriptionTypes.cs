using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum SubscriptionTypes
    {
        [Display(Name = "Индивидуальный")]
        Student = 4,
        [Display(Name = "Семейный")]
        Family = 5,
        [Display(Name="Классный")]
        Class = 6,
        [Display(Name = "Бесплатный индивидуальный")]
        FreeStudent = 1,
        [Display(Name = "Бесплатный семейный")]
        FreeFamily = 2,
        [Display(Name = "Бесплатный классный")]
        FreeClass = 3
    }
}