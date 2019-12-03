using Knigosha.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Knigosha.Core.Models
{
    public class UserSubscription
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public Subscription Subscription { get; set; }

        public int SubscriptionId { get; set; }

        public bool Myself { get; set; }

        public bool Invoice  { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Institution { get; set; }

        public string AddressOfInstitution { get; set; }

        public string TelephoneOfInstitution { get; set; }

        public string Uid { get; set; }

        public string Person { get; set; }

        public string OrderedOn { get; set; }

        public DateTime? ActivatedOn { get; set; }

        public PaymentType? PaymentType { get; set; }

        public StatusTypes? Status { get; set; }

        //2019/2020
        public string SchoolYear
        {
            get
            {
                string thisYear = DateTime.Parse(DateTime.Today.ToString(CultureInfo.CurrentCulture)).Year.ToString();
                string nextYear = DateTime.Parse(DateTime.Today.AddYears(1).ToString(CultureInfo.CurrentCulture)).Year.ToString();

                return thisYear + '/' + nextYear;
            }
        }

        public List<ActivationKey> ActivationKeys { get; set; }

        private UserSubscription() { }

        public UserSubscription(ApplicationUser user, Subscription subscription)
        {
            ActivationKeys = new List<ActivationKey>();
            User = user ?? throw new ArgumentNullException(nameof(User));
            Subscription = subscription ?? throw new ArgumentNullException(nameof(Subscription));
        }
    }
}