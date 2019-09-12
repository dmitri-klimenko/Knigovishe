using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum QuestionTypes
    {
        [Display(Name = "Вопрос о содержании")]
        Content,

        [Display(Name = "Вопрос на понимание")]
        Comprehension,

        [Display(Name = "Вопрос о мнении")]
        Opinion
    }
}