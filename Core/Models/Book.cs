using Knigosha.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string BookAuthor { get; set; }

        public string Publisher { get; set; }

        [RegularExpression(@"\d{4}")]
        public string YearPublished { get; set; }

        public string Translator { get; set; }

        public BookCategories BookCategory { get; set; }

        [RegularExpression(@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$")]
        public string Isbn1 { get; set; }

        [RegularExpression(@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$")]
        public string Isbn2 { get; set; }

        public int NumberOfPages { get; set; }

        public float CalculatedRating { get; set; }

        public string CoverPhoto { get; set; }

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

        public Grades Grade { get; set; }

        public bool HasOpinionQuestion => BookCategory == BookCategories.Fiction;

        public int NumberOfContentQuestions { get; set; }

        public int NumberOfComprehensionQuestions { get; set; }

        public bool IsShortForm { get; set; }

        public string Tags { get; set; }

        public int DateAdded { get; set; }

        public string Description { get; set; }

        public string QuestionsAuthor { get; set; }

        public string AddedByAdmin { get; set; }

        public Grades PartOfSchoolProgramAtGrade { get; set; }

        public int TimesCompleted { get; set; }

        public ICollection<Question> Questions { get; set; }

        public ICollection<Answer> Answers { get; set; }

        private Book()
        {
            Questions = new Collection<Question>();
            Answers = new Collection<Answer>();
            DateAdded = DateTime.Now.Year;
        }
    }


}