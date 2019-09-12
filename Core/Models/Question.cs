using System.ComponentModel.DataAnnotations;
using Knigosha.Core.Models.Enums;

namespace Knigosha.Core.Models
{
    public class Question
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите текст вопроса")]
        [Display(Name = "Текст вопроса:")]
        public string Text { get; set; }
      

        [Required(ErrorMessage = "Пожалуйста, введите правильный ответ")]
        [Display(Name = "Правильный ответ:")]
        public string RightAnswer { get; set; }


        [Required(ErrorMessage = "Пожалуйста, введите первый неправильный ответ")]
        [Display(Name = "Первый неправильный ответ:")]
        public string WrongAnswer1 { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите второй неправильный ответ")]
        [Display(Name = "Второй неправильный ответ::")]
        public string WrongAnswer2 { get; set; }


        [Required(ErrorMessage = "Пожалуйста, выберите тип вопроса")]
        [Display(Name = "Тип вопроса:")]
        public QuestionTypes? QuestionType { get; set; }

        public byte?  QuestionNumber { get; set; }
    }
}

