using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Knigosha.Core.Models
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public  ApplicationUser User { get; set; }

        public  ApplicationRole Role { get; set; }
    }
}
