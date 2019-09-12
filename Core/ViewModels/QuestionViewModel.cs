using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.ViewModels
{
    public class QuestionViewModel
    {
        public int BookId { get; set; }
        [Display(Name = "Текст вопроса:")]
        public string Text { get; set; }
        [Display(Name = "Правильный ответ")]
        public string RightAnswer { get; set; }
        [Display(Name = "Неправильный ответ 1")]
        public string WrongAnswer1 { get; set; }
        [Display(Name = "Неправильный ответ 2")]
        public string WrongAnswer2 { get; set; }
        
        public string QuestionType { get; set; }
    }
}