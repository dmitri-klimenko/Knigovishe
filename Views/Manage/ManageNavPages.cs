using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Knigosha.Views.Manage
{
    public static class ManageNavPages
    {
        public static string ActivePageKey => "ActivePage";

        public static string Dashboard => "Dashboard";

        public static string Answers => "Answers";

        public static string Students => "Students";

        public static string Order => "Order";

        public static string MarkedBooks => "MarkedBooks";

        public static string CreateQuiz => "CreateQuiz";

        public static string Points => "Points";

        public static string Messages => "Messages";

        public static string Licenses => "Licenses";

        public static string License => "License";

        public static string Details => "Details";

        public static string Reset => "Reset";

        public static string Help => "Help";

        public static string Groups => "Groups";

        public static string AnswersGroup => "AnswersGroup";



        public static string DashboardNavClass(ViewContext viewContext) => PageNavClass(viewContext, Dashboard);

        public static string AnswersNavClass(ViewContext viewContext) => PageNavClass(viewContext, Answers);

        public static string MarkedBooksNavClass(ViewContext viewContext) => PageNavClass(viewContext, MarkedBooks);

        public static string CreateQuizNavClass(ViewContext viewContext) => PageNavClass(viewContext, CreateQuiz);

        public static string PointsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Points);

        public static string MessagesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Messages);

        public static string LicensesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Licenses);

        public static string LicenseNavClass(ViewContext viewContext) => PageNavClass(viewContext, License);

        public static string DetailsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Details);

        public static string ResetNavClass(ViewContext viewContext) => PageNavClass(viewContext, Reset);

        public static string HelpNavClass(ViewContext viewContext) => PageNavClass(viewContext, Help);

        public static string StudentsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Students);

        public static string OrderNavClass(ViewContext viewContext) => PageNavClass(viewContext, Order);

        public static string GroupsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Groups);

        public static string AnswersGroupNavClass(ViewContext viewContext) => PageNavClass(viewContext, AnswersGroup);

        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string;
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "bold" : null;
        }

        public static void AddActivePage(this ViewDataDictionary viewData, string activePage) => viewData[ActivePageKey] = activePage;
    }
}
