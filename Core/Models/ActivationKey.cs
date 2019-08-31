using System;
using System.Text;

namespace Knigosha.Core.Models
{
    public class ActivationKey
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public UserSubscription UserSubscription { get; set; }
        public int UserSubscriptionId { get; set; }
        private static string GenerateCode()
        {
            {
                var builder = new StringBuilder();
                var random = new Random();
                for (var i = 0; i < 7; i++)
                {
                    var ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builder.Append(ch);
                }
                return builder.ToString().ToUpper();
            }
        }

        public ActivationKey()
        {
            Code = GenerateCode();
        }
    }
}