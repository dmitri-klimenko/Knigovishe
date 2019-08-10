using Knigosha.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models
{
    public class Book
    {
        private Grades _grade;
        private bool _isShortForm;
        private BookCategories _bookCategory;

        public int Id { get; set; }

        public string Title { get; set; }

        public string BookAuthor { get; set; }

        public string Publisher { get; set; }

        [RegularExpression(@"\d{4}")]
        public string YearPublished { get; set; }

        public string Translator { get; set; }

        public BookCategories BookCategory
        {
            get => _bookCategory;
            set => _bookCategory = value;
        }

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
                if (_isShortForm)
                    ageGroup = AgeGroups.SixPlus;
                else
                {
                    if (_grade == Grades.One)
                        ageGroup = AgeGroups.SixPlus;
                    else if (_grade == Grades.Two || _grade == Grades.Three || _grade == Grades.Four)
                        ageGroup = AgeGroups.EightPlus;
                    else if (_grade == Grades.Five || _grade == Grades.Six || _grade == Grades.Seven)
                        ageGroup = AgeGroups.ElevenPlus;
                    else ageGroup = AgeGroups.FourteenPlus;
                }
                return ageGroup;

            }
        }


        public Grades Grade
        {
            get => _grade;
            set => _grade = value;
        }

        public bool HasOpinionQuestion => _bookCategory == BookCategories.Fiction;

        public int NumberOfContentQuestions { get; set; }

        public int NumberOfComprehensionQuestions { get; set; }

        public bool IsShortForm
        {
            get => _isShortForm;
            set => _isShortForm = value;
        }

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