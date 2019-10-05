using System.ComponentModel.DataAnnotations;
using Knigosha.Core.Models.Enums;
using Microsoft.AspNetCore.Http;

namespace Knigosha.Core.ViewModels.TextViewModels
{
    public class CreateTextVewModel
    {
        [Required(ErrorMessage = "Пожалуйста, введите название")]
        [MaxLength(90)]
        [Display(Name = "*Название")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите описание/город")]
        [Display(Name = "*Описание/город")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите описание/профессию")]
        [Display(Name = "*Описание/профессия")]
        public string Description2 { get; set; }

        [Display(Name = "Фото:")]
        public IFormFile Photo { get; set; }

        [Display(Name = "Тип")]
        public TextTypes? TextType { get; set; }

    }
}