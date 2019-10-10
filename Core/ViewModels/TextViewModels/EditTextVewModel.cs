using System.ComponentModel.DataAnnotations;
using Knigosha.Core.Models.Enums;
using Microsoft.AspNetCore.Http;

namespace Knigosha.Core.ViewModels.TextViewModels
{
    public class EditTextVewModel
    {
        public int  Id { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите заголовок новости/имя автора викторины")]
        [MaxLength(90)]
        [Display(Name = "*Заголовок новости/имя автора викторины")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите текст")]
        [Display(Name = "1 параграф новости/город автора викторины")]
        [MinLength(70, ErrorMessage = "Минимальная длина: 70 знаков")]
        public string Paragraph1 { get; set; }

        [Display(Name = "2 параграф новости/профессия автора викторины")]
        public string Paragraph2 { get; set; }

        [Display(Name = "3 параграф новости")]
        public string Paragraph3 { get; set; }
        [Display(Name = "4 параграф новости")]
        public string Paragraph4 { get; set; }
        [Display(Name = "5 параграф новости")]
        public string Paragraph5 { get; set; }
        [Display(Name = "6 параграф новости")]
        public string Paragraph6 { get; set; }
        [Display(Name = "7 параграф новости")]
        public string Paragraph7 { get; set; }
        [Display(Name = "8 параграф новости")]
        public string Paragraph8 { get; set; }
        [Display(Name = "9 параграф новости")]
        public string Paragraph9 { get; set; }
        [Display(Name = "10 параграф новости")]
        public string Paragraph10 { get; set; }

        [MaxLength(50, ErrorMessage = "Максимальное кол-во знаков: 50")]
        [Display(Name = "*View name (только для новости)")]
        public string ViewName { get; set; }

        [Display(Name = "Фото (квадратное для автора)")]
        public IFormFile Photo { get; set; }

        [Display(Name = "Тип")]
        public TextTypes? TextType { get; set; }
    }
}