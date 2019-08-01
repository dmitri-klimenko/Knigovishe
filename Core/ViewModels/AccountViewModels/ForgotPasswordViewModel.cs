using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.ViewModels.AccountViewModels
{
    public class ForgotPasswordViewModel

    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
