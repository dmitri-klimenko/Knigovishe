using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace Knigosha.Core.Models
{
    public class Class : ApplicationUser
    {
        public string NameOfGroup { get; set; }

        // calculated properties
        public int TotalPoints => StudentClasses.Sum(sc => sc.Student.Points);

        public int TotalNumberOfAnswers => StudentClasses.Sum(sc => sc.Student.Answers.Count);

        public int TotalPercentageOfRightResponses
        {
            get
            {
                var totalPercentage = StudentClasses.Sum(sc => sc.Student.PercentageOfRightResponses);
                return NumberOfStudentsInClass != 0 ? totalPercentage / NumberOfStudentsInClass : 0;
            }
        }

        public int PositionInAgeGroupAccordingToTotalPoints
        {
            
            get
            {
                var schoolClass = this;
                var classesInOrder = AllClassesGroup.Classes.OrderBy(f => f.TotalPoints);
                var number = classesInOrder.IndexOf(schoolClass) + 1;
                return number > 0 ? number : 0;
            }
        }

        public int PositionInAgeGroupAccordingToTotalNumberOfAnswers
        {
            get
            {
                var schoolClass = this;
                var classesInOrder = AllClassesGroup.Classes.OrderBy(f => f.TotalNumberOfAnswers);
                var number = classesInOrder.IndexOf(schoolClass) + 1;
                return number > 0 ? number : 0;
            }
        }

        public int PositionInAgeGroupAccordingToTotalPercentageOfRightResponses
        {
            get
            {
                var schoolClass = this;
                var classesInOrder = AllClassesGroup.Classes.OrderBy(f => f.TotalPercentageOfRightResponses);
                var number = classesInOrder.IndexOf(schoolClass) + 1;
                return number > 0 ? number : 0;
            }
        }

        public int NumberOfClassesInAgeGroup => AllClassesGroup.NumberOfClassesInGroup;

        public string TopPercentageInAgeGroupAccordingToTotalPoints
        {
            get
            {
                string label = null;
                var item = this;
                var onePercent = Math.Ceiling(NumberOfClassesInAgeGroup * 0.01);
                var twoPercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.02);
                var threePercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.03);
                var fourPercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.04);
                var fivePercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.05);
                var itemsInOrder = AllClassesGroup.Classes.OrderBy(f => f.TotalPoints);
                var number = itemsInOrder.IndexOf(item) + 1;
                if (number <= onePercent) label = "TOП 1%";
                else if (number > onePercent || number <= twoPercents) label = "TOП 2%";
                else if (number > twoPercents || number <= threePercents) label = "TOП 3%";
                else if (number > threePercents || number <= fourPercents) label = "TOП 4%";
                else if (number > fourPercents || number <= fivePercents) label = "TOП 5%";
                return label;
            }
        }

        public string TopPercentageInAgeGroupAccordingToTotalNumberOfAnswers
        {
            get
            {
                string label = null;
                var item = this;
                var onePercent = Math.Ceiling(NumberOfClassesInAgeGroup * 0.01);
                var twoPercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.02);
                var threePercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.03);
                var fourPercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.04);
                var fivePercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.05);
                var itemsInOrder = AllClassesGroup.Classes.OrderBy(f => f.TotalNumberOfAnswers);
                var number = itemsInOrder.IndexOf(item) + 1;
                if (number <= onePercent) label = "TOП 1%";
                else if (number > onePercent || number <= twoPercents) label = "TOП 2%";
                else if (number > twoPercents || number <= threePercents) label = "TOП 3%";
                else if (number > threePercents || number <= fourPercents) label = "TOП 4%";
                else if (number > fourPercents || number <= fivePercents) label = "TOП 5%";
                return label;
            }
        }

        public string TopPercentageInAgeGroupAccordingToTotalPercentageOfRightResponses
        {
            get
            {
                string label = null;
                var item = this;
                var onePercent = Math.Ceiling(NumberOfClassesInAgeGroup * 0.01);
                var twoPercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.02);
                var threePercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.03);
                var fourPercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.04);
                var fivePercents = Math.Ceiling(NumberOfClassesInAgeGroup * 0.05);
                var itemsInOrder = AllClassesGroup.Classes.OrderBy(f => f.TotalPercentageOfRightResponses);
                var number = itemsInOrder.IndexOf(item) + 1;
                if (number <= onePercent) label = "TOП 1%";
                else if (number > onePercent || number <= twoPercents) label = "TOП 2%";
                else if (number > twoPercents || number <= threePercents) label = "TOП 3%";
                else if (number > threePercents || number <= fourPercents) label = "TOП 4%";
                else if (number > fourPercents || number <= fivePercents) label = "TOП 5%";
                return label;
            }
        }

        public int NumberOfStudentsInClass => StudentClasses.Count;

        public IList<StudentClass> StudentClasses { get; set; }

        public AllClassesGroup AllClassesGroup { get; set; }
        
        public Class()
        {
            StudentClasses = new List<StudentClass>();
            NameOfGroup = "";
        }

    }
}