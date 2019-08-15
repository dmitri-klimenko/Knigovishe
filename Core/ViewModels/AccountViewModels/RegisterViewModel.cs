using Knigosha.Core.Models.Enums;
using Knigosha.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.ViewModels.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "*Я")]
        public UserTypes UserType { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваше имя")]
        [Display(Name = "*Имя:")]

        [StringLength(50, ErrorMessage = "Ваше имя должно содержать минимум {1} и максимум {0} знаков.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Вашу фамилию")]
        [Display(Name = "*Фамилия:")]
        [StringLength(50, ErrorMessage = "Ваша фамилия должна содержать минимум {1} и максимум {0} знаков.", MinimumLength = 2)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваше имя пользователя")]
        [Display(Name = "*Имя пользователя:")]
        [StringLength(50, ErrorMessage = "Ваше имя пользователя должно содержать минимум {1} и максимум {0} знаков.", MinimumLength = 2)]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Пожалуйста, введите действующий адрес электронной почты.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите адрес Вашей электронной почты")]
        [EmailAddress(ErrorMessage = "Пожалуйста, введите действующий адрес электронной почты.")]
        public string RequiredEmail { get; set; }

        [EmailAddress(ErrorMessage = "Пожалуйста, введите действующий адрес электронной почты.")]
        [Display(Name = "Адрес электронной почты родителя:")]
        public string ParentEmail { get; set; }

        [Display(Name = "Номер телефона:")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Страна:")]
        public string Country { get; set; }

        [Display(Name = "Регион:")]
        public string Region { get; set; }

        [Display(Name = "Город:")]
        public string City { get; set; }

        [Display(Name = "Город:")]
        public string CityInRegion { get; set; }

        [Display(Name = "Школа:")]
        public string School { get; set; }

        [Display(Name = "Школа:")]
        public string SchoolInRussiaRegionCity { get; set; }

        [Display(Name = "Класс:")]
        public Grades Grade { get; set; }

        [Display(Name = "Параллель (буква):")]
        public string Parallel { get; set; }

        [Display(Name = "Код абонемента:")]
        public string ActivationCode { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваш пароль")]
        [StringLength(50, ErrorMessage = " {0} Пароль должен содержать минимум {2} и максимум {1} знаков.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "*Пароль:")]
        public string Password { get; set; }

        [Display(Name = "Я хочу получать электронную рассылку")]
        public bool IsSubscribedToNewsletter { get; set; }

        [MustBeTrue(ErrorMessage = "Отметьте, пожалуйста, что Вы соглашаетесь с Условиями использования!")]
        public bool TermsOfUse { get; set; }
    }
}
