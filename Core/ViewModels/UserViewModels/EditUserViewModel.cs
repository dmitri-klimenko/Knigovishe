using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Storage;

namespace Knigosha.Core.ViewModels.UserViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Очков за созданную анкету")]
        public byte PointsForCreatedBook { get; set; }
    }
}