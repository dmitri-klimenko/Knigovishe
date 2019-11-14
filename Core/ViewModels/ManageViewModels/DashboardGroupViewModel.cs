using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class DashboardGroupViewModel
    {
        public ApplicationUser User { get; set; }

        public bool HasAccess { get; set; }

        public List<Book> JustReadBooks { get; set; }

        public List<Student> Students { get; set; }

        public int CountOfChildren { get; set; }
        public int CountOfAnswers { get; set; }

        public int TotalPercentageOfRightResponses { get; set; }
        public int PointsForAnswersByStudents { get; set; }
        public int PointsForBooksCreatedByStudents { get; set; }
        public int PointsForCreatedBooks { get; set; }
        public int TotalPoints { get; set; }

        public int? PositionInTableAccordingToPoints { get; set; }
        public int? PositionInTableAccordingToAnswers { get; set; }
        public int? PositionInTableAccordingToRightResponses { get; set; }

        public string TopInTableAccordingToPoints { get; set; }
        public string TopInTableAccordingToAnswers { get; set; }
        public string TopInTableAccordingToRightResponses { get; set; }

        public string MyCountry { get; set; }

        public int NumberOfGroupsInTable { get; set; }

        public int Average { get; set; }


        public List<SelectListItem> Locations { get; set; }
        public string Location { get; set; }
        public List<SelectListItem> Periods { get; set; }
        public string Period { get; set; }
        public List<SelectListItem> ChartLocations { get; set; }
        public string ChartLocation { get; set; }
    }
}
