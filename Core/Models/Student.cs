using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore.Internal;
using Remotion.Linq.Clauses;

namespace Knigosha.Core.Models
{
    public class Student : ApplicationUser
    {
        public IList<StudentClass> StudentClasses { get; set; }
        public Family Family { get; set; }
        public string FamilyId { get; set; }

        public Student()
        {
            StudentClasses = new List<StudentClass>();
        }

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
                var activeClass = StudentClasses.Single(sc => sc.IsActive).Class;
                var studentsInOrder = activeClass.StudentClasses.OrderBy(cs => cs.Student.Points);
                var number = studentsInOrder.IndexOf(StudentClasses.Single(sc => sc.StudentId == Id)) + 1;
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
                var activeClass = StudentClasses.Single(sc => sc.IsActive).Class;
                var studentsInOrder = activeClass.StudentClasses.OrderBy(cs => cs.Student.NumberOfAnswers);
                var number = studentsInOrder.IndexOf(StudentClasses.Single(sc => sc.StudentId == Id)) + 1;
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
                var activeClass = StudentClasses.Single(sc => sc.IsActive).Class;
                var studentsInOrder = activeClass.StudentClasses.OrderBy(cs => cs.Student.PercentageOfRightResponses);
                var number = studentsInOrder.IndexOf(StudentClasses.Single(sc => sc.StudentId == Id)) + 1;
                return number > 0 ? number : 0;
            }
        }
    }
}