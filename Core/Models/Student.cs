using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore.Internal;
using Remotion.Linq.Clauses;

namespace Knigosha.Core.Models
{
    public class Student : ApplicationUser
    {
        public Class ClassStudentBelongsTo { get; set; }
        public string ClassStudentBelongsToId { get; set; }

        public Family FamilyStudentBelongsTo { get; set; }
        public string FamilyStudentBelongsToId { get; set; }

        public string ParentEmail { get; set; }

        public string GreetingName { get; set; }

        //calculated properties
        public int PositionInFamilyAccordingToPoints
        {
            get
            {
                var student = this;
                var studentsInOrder = Family.Students.OrderBy(s => s.Points);
                var number = studentsInOrder.IndexOf(student) + 1;
                return number > 0 ? number : 0;
            }
        }

        public int PositionInClassAccordingToPoints
        {
            get
            {
                var student = this;
                var studentsInOrder = Class.Students.OrderBy(s => s.Points);
                var number = studentsInOrder.IndexOf(student) + 1;
                return number > 0 ? number : 0;
            }
        }

        public int PositionInFamilyAccordingToNumberOfAnswers
        {
            get
            {
                var student = this;
                var studentsInOrder = Family.Students.OrderBy(s => s.NumberOfAnswers);
                var number = studentsInOrder.IndexOf(student) + 1;
                return number > 0 ? number : 0;
            }
        }

        public int PositionInClassAccordingToNumberOfAnswers
        {
            get
            {
                var student = this;
                var studentsInOrder = Class.Students.OrderBy(s => s.NumberOfAnswers);
                var number = studentsInOrder.IndexOf(student) + 1;
                return number > 0 ? number : 0;
            }
        }

        public int PositionInFamilyAccordingToPercentageOfRightResponses
        {
            get
            {
                var student = this;
                var studentsInOrder = Family.Students.OrderBy(s => s.PercentageOfRightResponses);
                var number = studentsInOrder.IndexOf(student) + 1;
                return number > 0 ? number : 0;
            }
        }

        public int PositionInClassAccordingToPercentageOfRightResponses
        {
            get
            {
                var student = this;
                var studentsInOrder = Class.Students.OrderBy(s => s.NumberOfAnswers);
                var number = studentsInOrder.IndexOf(student) + 1;
                return number > 0 ? number : 0;
            }
        }
    }
}