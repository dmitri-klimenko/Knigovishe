using Knigosha.Core.Models.Enums;

namespace Knigosha.Core.Models
{
    public class SubscriptionType
    {
        public int Id { get; set; }

        public Subscription Subscription { get; set; }

        public int SubscriptionId { get; set; }

        public SubscriptionTypeNames Name { get; set; }

        public string PriceTag { get; set; }

        public int Price { get; set; }

        public string ValidUntil { get; set; }

        public int MaxQuizzes { get; set; }

        public int NumberOfStudentProfiles { get; set; }

        public int NumberOfParentProfiles { get; set; }

        public int NumberOfTeacherProfiles { get; set; }

        public string Text1 { get; set; }

        public string Text2 { get; set; }

        public string Text3 { get; set; }
    }
}
