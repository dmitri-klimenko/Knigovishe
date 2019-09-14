using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum SubscriptionNames
    {
        [Display(Name = "БЕСПЛАТНОЕ ДЕМО")]
        Free,
        [Display(Name = "ИНДИВИДУАЛЬНЫЙ")]
        Student,
        [Display(Name = "СЕМЕЙНЫЙ")]
        Family,
        [Display(Name = "КЛАССНЫЙ")]
        Class

    }
}