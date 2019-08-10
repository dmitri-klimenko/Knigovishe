namespace Knigosha.Core.Models
{
    public class AssociationKey
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public Subscription Subscription { get; set; }
        public int SubscriptionId { get; set; }
    }
}