using Knigosha.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Knigosha.Core.Models
{

    public class UserSubscription
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public Subscription Subscription { get; set; }

        public int SubscriptionId { get; set; }

        public string OrderedOn { get; set; }

        public PaymentType PaymentType { get; set; }

        public string Note { get; set; }

        public StatusTypes Status { get; set; }

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

        public bool IsPaid { get; set; }

        public List<ActivationKey> ActivationKeys { get; set; }

        private UserSubscription() { }

        public UserSubscription(ApplicationUser user, Subscription subscription)
        {
            ActivationKeys = new List<ActivationKey>();
            User = user ?? throw new ArgumentNullException(nameof(User));
            Subscription = subscription ?? throw new ArgumentNullException(nameof(Subscription));

            var subscriptionType = subscription.SubscriptionType;

            switch (subscriptionType)
            {
                case SubscriptionTypes.FreeStudent:
                    var studentActivationKey = new ActivationKey();
                    ActivationKeys.Add(studentActivationKey);
                    break;
                case SubscriptionTypes.FreeFamily:
                    for (var i = 1; i <= 5; i++)
                    {
                        var familyActivationKey = new ActivationKey();
                        ActivationKeys.Add(familyActivationKey);
                    }
                    break;
                case SubscriptionTypes.FreeClass:
                    for (var i = 1; i <= 31; i++)
                    {
                        var classActivationKey = new ActivationKey();
                        ActivationKeys.Add(classActivationKey);
                    }
                    break;
                default:
                    Status = StatusTypes.Waiting;
                    OrderedOn = DateTime.Now.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
                    break;
            }

        }

        public void CreateActivationKeys(UserSubscription userSubscription)
        {
            var paidSubscription = userSubscription;
            var userSubscriptionType = userSubscription.Subscription.SubscriptionType;
            switch (userSubscriptionType)
            {
                case SubscriptionTypes.Student:
                    paidSubscription.Status = StatusTypes.Paid;
                    var studentActivationKey = new ActivationKey();
                    paidSubscription.ActivationKeys.Add(studentActivationKey);
                    break;
                case SubscriptionTypes.Family:
                    paidSubscription.Status = StatusTypes.Paid;
                    for (var i = 1; i <= 5; i++)
                    {
                        var familyActivationKey = new ActivationKey();
                        paidSubscription.ActivationKeys.Add(familyActivationKey);
                    }
                    break;
                case SubscriptionTypes.Class:
                    paidSubscription.Status = StatusTypes.Paid;
                    for (var i = 1; i <= 31; i++)
                    {
                        var classActivationKey = new ActivationKey();
                        paidSubscription.ActivationKeys.Add(classActivationKey);
                    }
                    break;
            }

        }

    }
}