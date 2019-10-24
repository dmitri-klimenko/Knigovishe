using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.ViewModels.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Пожалуйста, введите адрес почты/имя пользователя")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваш пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
