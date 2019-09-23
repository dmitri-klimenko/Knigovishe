using System;
using System.Text;
using Knigosha.Core.Models.Enums;

namespace Knigosha.Core.Models
{
    public class ActivationKey
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public UserSubscription UserSubscription { get; set; }
        public int UserSubscriptionId { get; set; }
        public ActivationKeyTypes ActivationKeyType { get; set; }
        private static string GenerateCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                var numbers = "0123456789";
                var stringChars = new char[8];
                var random = new Random();

                for (int i = 0; i < 2; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                for (int i = 2; i < 6; i++)
                {
                    stringChars[i] = numbers[random.Next(numbers.Length)];
                }
                for (int i = 6; i < 8; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                var finalString = new String(stringChars);
                return finalString;
        }
        public ActivationKey()
        {
            Code = GenerateCode();
        }
    }
 }