using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum SubscriptionNames
    {
        [Display(Name = "БЕСПЛАТНОЕ ДЕМО")]
        Free = 1,
        [Display(Name = "ИНДИВИДУАЛЬНЫЙ")]
        Student = 2,
        [Display(Name = "СЕМЕЙНЫЙ")]
        Family = 3,
        [Display(Name = "КЛАССНЫЙ")]
        Class = 4
    }
}