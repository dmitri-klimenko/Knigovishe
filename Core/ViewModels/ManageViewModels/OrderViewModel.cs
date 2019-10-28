using System.Collections.Generic;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels.OrderViewModel
{
    public class OrderViewModel
    {
        public Subscription Suggested { get; set; }
        public List<Subscription> Subscriptions { get; set; }
    }
}