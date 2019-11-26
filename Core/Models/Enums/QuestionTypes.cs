using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum QuestionTypes
    {
        [Display(Name = "Вопрос о содержании или на понимание")]
        ContentComprehension = 1,

        [Display(Name = "Вопрос о мнении")]
        Opinion = 2
    }
}