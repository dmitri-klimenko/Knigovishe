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
                return Math.Round(averageRating, 1);
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

        public int PointsForWrongAnswer
        {
            get
            {
                var points = 0;
                if (IsShortForm || Grade == Grades.One) points = 1;
                else if (Grade != null) points = (int) Grade - 1;
                return points;
            }
        }

        public int NumberOfQuestionsForResponses => ContentQuestions + ComprehensionQuestions;

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

        public int ContentQuestions
        {
            get
            {
                var number = 0;
                if (IsShortForm || BookCategory == BookCategories.Nonfiction) number = 5;
                else
                {
                    switch (Grade)
                    {
                        case Grades.One :
                            number = 10;
                            break;
                        case Grades.Two:
                            number = 14;
                            break;
                        case Grades.Three:
                            number = 12;
                            break;
                        case Grades.Four:
                            number = 10;
                            break;
                        case Grades.Five:
                            number = 13;
                            break;
                        case Grades.Six:
                            number = 11;
                            break;
                        case Grades.Seven:
                            number = 9;
                            break;
                        case Grades.Eight:
                            number = 12;
                            break;
                        case Grades.Nine:
                            number = 11;
                            break;
                        case Grades.Ten:
                            number = 10;
                            break;
                        case Grades.Eleven:
                            number = 10;
                            break;
                    }
                }
                return number;
            }
        }

        public int ContentQuestionsCreated
        {
            get
            {
                return Questions.Count(question => question.QuestionType == QuestionTypes.Content);
            }
        }

        public int ComprehensionQuestions
        {
            get
            {
                var number = 0;
                if (IsShortForm || BookCategory == BookCategories.Nonfiction) number = 0;
                else
                {
                    switch (Grade)
                    {
                        case Grades.One:
                            number = 0;
                            break;
                        case Grades.Two:
                            number = 1;
                            break;
                        case Grades.Three:
                            number = 3;
                            break;
                        case Grades.Four:
                            number = 5;
                            break;
                        case Grades.Five:
                            number = 2;
                            break;
                        case Grades.Six:
                            number = 4;
                            break;
                        case Grades.Seven:
                            number = 6;
                            break;
                        case Grades.Eight:
                            number = 3;
                            break;
                        case Grades.Nine:
                            number = 4;
                            break;
                        case Grades.Ten:
                            number = 5;
                            break;
                        case Grades.Eleven:
                            number = 5;
                            break;
                    }
                }
                return number;
            }
        }

        public int ComprehensionQuestionsCreated
        {
            get
            {
                return Questions.Count(question => question.QuestionType == QuestionTypes.Comprehension);
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

        public Book()
        {
            Answers = new Collection<Answer>();
            BookRatings = new Collection<BookRating>();
            Questions = new Collection<Question>();
            DateAdded = DateTime.Now.ToString("d");
        }
    }


}