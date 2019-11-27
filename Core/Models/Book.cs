using Knigosha.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Knigosha.Core.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string BookAuthor { get; set; }

        public string Publisher { get; set; }

        public string YearPublished { get; set; }

        public BookCategories BookCategory { get; set; }

        public string Isbn1 { get; set; }

        public string Isbn2 { get; set; }

        public int NumberOfPages { get; set; }

        public double AverageRating {

            get
            {
                var numberOfBookRatings = BookRatings.Count;
                var sumOfBookRatings = BookRatings.Sum(bookRating => bookRating.Rating);
                var averageRating = (numberOfBookRatings != 0) ? ((double)sumOfBookRatings / numberOfBookRatings) : 0;
                var retVal = Math.Round(averageRating, 1);
                return retVal;
            }
        }

        public string CoverPhoto { get; set; }

        public int PointsForRightAnswer
        {
            get
            {
                var points = 0;
                if (IsShortForm) points = 1;
                else if (Grade != null) points = (int)Grade;
                return points;
            }
        }

        public float PointsForWrongAnswer => (float)PointsForRightAnswer / 2;

        [Display(Name = "Возрастная группа:")]
        public AgeGroups AgeGroup
        {
            get
            {
                AgeGroups ageGroup;
                if (IsShortForm)
                    ageGroup = AgeGroups.SixPlus;
                else
                {
                    if (Grade == Grades.One)
                        ageGroup = AgeGroups.SixPlus;
                    else if (Grade == Grades.Two || Grade == Grades.Three || Grade == Grades.Four)
                        ageGroup = AgeGroups.EightPlus;
                    else if (Grade == Grades.Five || Grade == Grades.Six || Grade == Grades.Seven)
                        ageGroup = AgeGroups.ElevenPlus;
                    else ageGroup = AgeGroups.FourteenPlus;
                }
                return ageGroup;
            }
        }

        public Grades? Grade { get; set; }

        public string Translator { get; set; }

        public int NumberOfQuestionsForResponses
        {
            get
            {
                int number;
                if (IsShortForm || BookCategory == BookCategories.Nonfiction) number = 5;
                else if (Grade == Grades.One) number = 10;
                else number = 15;
                return number;
            }
        }


        public int NumberOfQuestionsCreated
        {
            get
            {
                return Questions.Count(question => question.QuestionType == QuestionTypes.ContentComprehension);
            }
        }
      

        public int OpinionQuestions => BookCategory == BookCategories.Nonfiction ? 0 : 1;

        public int OpinionQuestionsCreated {
            get
            {
                return Questions.Count(question => question.QuestionType == QuestionTypes.Opinion);
            }
        }

        public bool IsShortForm { get; set; }

        public string Tags { get; set; }

        [Display(Name = "Добавлена:")]
        public string DateAdded { get; set; }

        [Display(Name = "Редактирована:")]

        public string DateEdited { get; set; }

        public string Description { get; set; }

        public  string QuestionsAuthor { get; set; }

        public string AddedByAdmin { get; set; }

        public Grades? PartOfSchoolProgramAtGrade { get; set; }

        public int TimesCompleted => Answers.Count;

        public ICollection<Question> Questions { get; set; }
        public ICollection<BookRating> BookRatings { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<BookComment> BookComments { get; set; }
        public ICollection<BookOpinion> BookOpinions { get; set; }

        public Book()
        {
            Answers = new Collection<Answer>();
            BookRatings = new Collection<BookRating>();
            Questions = new Collection<Question>();
            BookComments = new Collection<BookComment>();
            BookOpinions = new Collection<BookOpinion>();
            DateAdded = DateTime.Now.ToString("d");
        }
    }


}