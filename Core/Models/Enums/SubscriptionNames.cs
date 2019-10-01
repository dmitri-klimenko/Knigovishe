using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum SubscriptionNames
    {
        [Display(Name = "Бесплатное демо")]
        Free = 1,
        [Display(Name = "Индивидуальный")]
        Student = 2,
        [Display(Name = "Семейный")]
        Family = 3,
        [Display(Name = "Классный")]
        Class = 4
    }
}