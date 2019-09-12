using Knigosha.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;

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

        public float CalculatedRating { get; set; }

        public string CoverPhoto { get; set; }

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

        public bool HasOpinionQuestion => BookCategory == BookCategories.Fiction;

        public int NumberOfContentQuestions { get; set; }

        public int NumberOfComprehensionQuestions { get; set; }

        public bool IsShortForm { get; set; }

        public string Tags { get; set; }

        public string DateAdded { get; set; }

        public string Description { get; set; }

        public  string QuestionsAuthor { get; set; }

        public string AddedByAdmin { get; set; }

        public Grades? PartOfSchoolProgramAtGrade { get; set; }

        public int TimesCompleted { get; set; }

        public ICollection<Question> Questions { get; set; }


        public Book()
        {
         
            Questions = new Collection<Question>();
            DateAdded = DateTime.Now.ToString("d");
        }
    }


}