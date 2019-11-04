using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Knigosha.Core.Models
{
    public class Message
    {
        public int Id { get; set; }
        public ApplicationUser Sender { get; set; }
        public string SenderId { get; set; }
        public string DateTime { get; set; }
        public string Topic { get; set; }
        public string Body { get; set; }
        public ApplicationUser Recipient { get; set; }
        public string RecipientId { get; set; }
        public bool IsRead { get; set; }

        public Message()
        {
            DateTime = System.DateTime.Now.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
        }
    }
}

