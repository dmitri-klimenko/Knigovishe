using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum QuestionTypes
    {
        [Display(Name = "Вопрос о содержании")]
        Content =1,

        [Display(Name = "Вопрос на понимание")]
        Comprehension =2,

        [Display(Name = "Вопрос о мнении")]
        Opinion =3
    }
}