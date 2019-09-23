using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Knigosha.Core.Models
{
    public class ApplicationRole : IdentityRole<string>
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }

        public ApplicationRole() : base()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }
    }
}