using System;
using System.Globalization;

namespace Knigosha.Core.Models
{
    public class SentMessage
    {
        public string DateTime { get; set; }

        public ApplicationUser Sender { get; set; }
        public string SenderId { get; set; }
        public ApplicationUser Receiver { get; set; }
        public string ReceiverId { get; set; }

        public string Topic { get; set; }
        public string Body { get; set; }

        private SentMessage() { }

        public SentMessage(ApplicationUser sender, ApplicationUser receiver)
        {
            DateTime = System.DateTime.Now.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            Sender = sender ?? throw new ArgumentNullException(nameof(Sender));
            Receiver = receiver ?? throw new ArgumentNullException(nameof(Receiver));
        }
    }

}
