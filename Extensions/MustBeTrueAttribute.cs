using System.ComponentModel.DataAnnotations;

namespace Knigosha.Extensions
{
    public class MustBeTrueAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value is bool b && b;
        }
    }
}
