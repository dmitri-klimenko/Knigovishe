namespace Knigosha.Core.Models
{
    public class Student : ApplicationUser
    {
        public override string Id { get; set; }

        public Class ClassStudentBelongsTo { get; set; }
        public string ClassStudentBelongsToId { get; set; }

        public Family FamilyStudentBelongsTo { get; set; }
        public string FamilyStudentBelongsToId { get; set; }


        public string School { get; set; }

        public string ParentEmail { get; set; }

        public string GreetingName { get; set; }

        public string Level { get; set; }

        public int Points { get; set; }

        public int NumberOfAnswers { get; set; }

        public int PercentageOfRightResponses { get; set; }


        public int PositionInFamilyAccordingToPoints { get; set; }

        public int PositionInClassAccordingToPoints { get; set; }


        public int PositionInFamilyAccordingToNumberOfAnswers { get; set; }

        public int PositionInClassAccordingToNumberOfAnswers { get; set; }


        public int PositionInFamilyAccordingToPercentageOfRightResponses { get; set; }

        public int PositionInClassAccordingToPercentageOfRightResponses { get; set; }


    }
}