using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.ViewModels.AccountViewModels
{
    public class ForgotPasswordViewModel

    {
        [Required]
        [EmailAddress(ErrorMessage = "Адрес должен быть действительным.")]
        [Display(Name = "Введите адрес электронной почты и мы вышлем Вам Ваше имя пользователя с инструкциями по смене пароля:")]
        public string Email { get; set; }
    }
}
