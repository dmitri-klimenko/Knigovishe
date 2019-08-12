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
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Вашу фамилию")]
        [Display(Name = "*Фамилия:")]
        [MaxLength(50)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваше имя пользователя")]
        [Display(Name = "*Имя пользователя:")]
        [MaxLength(50)]
        public string UserName { get; set; }

        [EmailAddress]
        [Display(Name = "Адрес электронной почты:")]
        public string Email { get; set; }

        //Only for Student
        [EmailAddress]
        [Display(Name = "Адрес электронной почты родителя:")]
        public string ParentEmail { get; set; }

        [Display(Name = "Номер телефона:")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Страна:")]
        public string Country { get; set; }

        [Display(Name = "Город:")]
        public string City { get; set; }

        // Hide for parent
        [Display(Name = "Школа:")]
        public string School { get; set; }

        // Hide for parent
        [Display(Name = "Класс:")]
        public Grades Grade { get; set; }

        // Hide for parent
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
