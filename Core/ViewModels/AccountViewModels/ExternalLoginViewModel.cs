using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.ViewModels.AccountViewModels
{
    public class ExternalLoginViewModel

    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
