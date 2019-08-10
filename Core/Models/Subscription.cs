using Knigosha.Core.Models.Enums;
using System;
using System.Collections.Generic;

namespace Knigosha.Core.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public SubscriptionType SubscriptionType { get; set; }

        public string ActivationCode { get; set; }

        public DateTime SubscribeDateTime { get; set; }

        public PaymentType PaymentType { get; set; }

        public string Note { get; set; }

        public StatusTypes Status { get; set; }

        public string BankData { get; set; }

        public string SchoolYear { get; set; }

        public ICollection<AssociationKey> AssociationKeys { get; set; }

        protected Subscription() { }

        private Subscription(ApplicationUser user, SubscriptionType subscriptionType)
        {
            User = user ?? throw new ArgumentNullException(nameof(User));
            SubscriptionType = subscriptionType ?? throw new ArgumentNullException(nameof(SubscriptionType));
            SubscribeDateTime = DateTime.Now;
        }

    }
}