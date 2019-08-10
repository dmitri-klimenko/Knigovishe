using Knigosha.Core.Models.Enums;

namespace Knigosha.Core.Models
{
    public class Question
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public string Text { get; set; }

        public string RightAnswer { get; set; }
        public string WrongAnswer1 { get; set; }
        public string WrongAnswer2 { get; set; }
        public QuestionTypes QuestionType { get; set; }
    }
}