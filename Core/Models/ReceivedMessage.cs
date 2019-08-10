using System;

namespace Knigosha.Core.Models
{
    public class ReceivedMessage
    {
        public DateTime DateTime { get; set; }

        public ApplicationUser Sender { get; set; }
        public string SenderId { get; set; }
        public ApplicationUser Receiver { get; set; }
        public string ReceiverId { get; set; }

        public string Topic { get; set; }
        public string Body { get; set; }

        protected ReceivedMessage() { }

        private ReceivedMessage(ApplicationUser sender, ApplicationUser receiver)
        {
            Sender = sender ?? throw new ArgumentNullException(nameof(Sender));
            Receiver = receiver ?? throw new ArgumentNullException(nameof(Receiver));
        }

    }

}