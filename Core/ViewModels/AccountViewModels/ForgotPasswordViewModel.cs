using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.ViewModels.AccountViewModels
{
    public class ForgotPasswordViewModel

    {
        [Required]
        [EmailAddress(ErrorMessage = "Адрес должен быть действительным.")]
        public string Email { get; set; }
    }
}
