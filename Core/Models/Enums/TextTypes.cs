using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Knigosha.Core.Models.Enums
{
    public enum TextTypes
    {
        [Display(Name = "Новость")]
        Post = 1,
        [Display(Name="Автор")]
        Author = 2
    }

}
