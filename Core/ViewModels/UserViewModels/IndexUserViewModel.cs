using System.Collections.Generic;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;

namespace Knigosha.Core.ViewModels.UserViewModels
{
    public class IndexUserViewModel
    {
        public string Id { get; set; }

        public UserTypes UserType { get; set; }

        public List<string>  RoleNames { get; set; }

        public string Email { get; set; }

        public string DateAdded { get; set; }

        public string DateEdited { get; set; }

        public string LastLogin { get; set; }

    }
}
