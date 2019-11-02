using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Knigosha.Persistence;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;

namespace Knigosha.Core.Models
{
    public class Family : ApplicationUser
    {
        //calculated properties
        public int TotalPoints => StudentFamilies.Sum(s => s.Student.Points);

        public int TotalNumberOfAnswers => StudentFamilies.Sum(s => s.Student.Answers.Count);

        public int TotalPercentageOfRightResponses
        {
            get
            {
                var totalPercentage = StudentFamilies.Sum(s => s.Student.PercentageOfRightResponses);
                return NumberOfStudentsInFamily != 0? totalPercentage / NumberOfStudentsInFamily : 0; 
            }
        }

        public int PositionInAgeGroupAccordingToTotalPoints
        {
            get
            {
                var family = this;
                var familiesInOrder = AllFamiliesGroup.Families.OrderBy(f => f.TotalPoints);
                var number = familiesInOrder.IndexOf(family) + 1;
                return number > 0 ? number : 0;
            }
        }

        public int PositionInAgeGroupAccordingToTotalNumberOfAnswers
        {
            get
            {
                var family = this;
                var familiesInOrder = AllFamiliesGroup.Families.OrderBy(f => f.TotalNumberOfAnswers);
                var number = familiesInOrder.IndexOf(family) + 1;
                return number > 0 ? number : 0;
            }
        }

        public int PositionInAgeGroupAccordingToTotalNumberOfRightResponses
        {
            get
            {
                var family = this;
                var familiesInOrder = AllFamiliesGroup.Families.OrderBy(f => f.TotalPercentageOfRightResponses);
                var number = familiesInOrder.IndexOf(family) + 1;
                return number > 0 ? number : 0;
            }
        }

        public int NumberOfFamiliesInAgeGroup => AllFamiliesGroup.NumberOfFamiliesInGroup;

        public string TopPercentageInAgeGroupAccordingToTotalPoints
        {
            get
            {
                string label = null;
                var item = this;
                var onePercent = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.01); 
                var twoPercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.02); 
                var threePercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.03); 
                var fourPercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.04); 
                var fivePercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.05);
                var itemsInOrder = AllFamiliesGroup.Families.OrderBy(f => f.TotalPoints);
                var number = itemsInOrder.IndexOf(item)+1;
                if(number <= onePercent) label = "TOП 1%";
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
                var onePercent = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.01);
                var twoPercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.02);
                var threePercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.03);
                var fourPercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.04);
                var fivePercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.05);
                var itemsInOrder = AllFamiliesGroup.Families.OrderBy(f => f.TotalNumberOfAnswers);
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
                var onePercent = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.01);
                var twoPercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.02);
                var threePercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.03);
                var fourPercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.04);
                var fivePercents = Math.Ceiling(NumberOfFamiliesInAgeGroup * 0.05);
                var itemsInOrder = AllFamiliesGroup.Families.OrderBy(f => f.TotalPercentageOfRightResponses);
                var number = itemsInOrder.IndexOf(item) + 1;
                if (number <= onePercent) label = "TOП 1%";
                else if (number > onePercent || number <= twoPercents) label = "TOП 2%";
                else if (number > twoPercents || number <= threePercents) label = "TOП 3%";
                else if (number > threePercents || number <= fourPercents) label = "TOП 4%";
                else if (number > fourPercents || number <= fivePercents) label = "TOП 5%";
                return label;
            }
        }

        public int NumberOfStudentsInFamily => StudentFamilies.Count;

        public IList<StudentFamily> StudentFamilies { get; set; }

        public AllFamiliesGroup AllFamiliesGroup { get; set; }
        
        public Family()   
        {
            StudentFamilies = new List<StudentFamily>();
        }
    }
}