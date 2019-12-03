using Knigosha.Core.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public bool  IsArchive { get; set; }

        public int NumberOfRightResponses { get; set; }

        public int NumberOfWrongResponses { get; set; }

        public int NumberOfSkippedQuestions { get; set; }

        public DateTime DateTime { get; set; }

        public string ReasonForRestart { get; set; }

        public QuizTypes QuizType { get; set; }

        public float Points { get; set; }

        public int PercentageOfRightResponses => NumberOfRightResponses * 100 / Book.NumberOfQuestionsForResponses;

        public int PercentageOfWrongResponses => NumberOfWrongResponses * 100 / Book.NumberOfQuestionsForResponses;

        public int PercentageOfSkippedQuestions => NumberOfSkippedQuestions * 100/ Book.NumberOfQuestionsForResponses;

        public byte CurrentQuestion { get; set; }

        public DateTime Started { get; set; }

        protected Answer() { }

        public Answer(ApplicationUser user, Book book)
        {
            User = user ?? throw new ArgumentNullException(nameof(User));
            Book = book ?? throw new ArgumentNullException(nameof(Book));
            DateTime = DateTime.Now;
        }

    }
}