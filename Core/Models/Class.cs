using System.Collections.Generic;

namespace Knigosha.Core.Models
{
    public class Class : ApplicationUser
    {

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        //public IList<SelectListItem> Schools { get; set; }
        public string School { get; set; }

        public int TotalPoints { get; set; }

        public int TotalNumberOfAnswers { get; set; }

        public int TotalPercentageOfRightResponses { get; set; }


        public int PositionInAgeGroupAccordingToTotalPoints { get; set; }

        public int PositionInAgeGroupAccordingToTotalNumberOfAnswers { get; set; }

        public int PositionInAgeGroupAccordingToTotalNumberOfRightResponses { get; set; }


        public int NumberOfClassesInAgeGroup { get; set; }


        public int TopPercentageInAgeGroupAccordingToTotalPoints { get; set; }

        public int TopPercentageInAgeGroupAccordingToTotalNumberOfAnswers { get; set; }

        public int TopPercentageInAgeGroupAccordingToTotalNumberOfRightResponses { get; set; }


        public int NumberOfStudentsInClass { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}