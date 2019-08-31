using Knigosha.Core.Models.Enums;
using System;
using System.Globalization;

namespace Knigosha.Core.Models
{
    public class Answer
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public Book Book { get; set; }

        public int BookId { get; set; }

        public int NumberOfWriteResponses { get; set; }

        public int NumberOfWrongResponses { get; set; }

        public int NumberOfSkippedQuestions { get; set; }

        public string DateTime { get; set; }

        public string ReasonForRestart { get; set; }

        public AnswerTypes AnswerType { get; set; }

        public QuizTypes QuizType { get; set; }

        public int PercentageOfRightResponses { get; set; }

        public int PercentageOfWrongResponses { get; set; }

        public int PercentageOfSkippedQuestions { get; set; }

        protected Answer() { }

        public Answer(ApplicationUser user, Book book)
        {
            User = user ?? throw new ArgumentNullException(nameof(User));
            Book = book ?? throw new ArgumentNullException(nameof(Book));
            DateTime = System.DateTime.Now.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
        }

        // Start (){ }
        // Finish (){ }

        //Reset (){}
        //Refuse () {}
    }
}