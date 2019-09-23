using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Knigosha.Core.ViewModels.UserViewModels
{
    public class EditUserViewModel
    {
     
        public string Id { get; set; }

        [Display(Name = "Созданных анкет")]
        public int NumberOfCreatedBooks { get; set; }

        [Display(Name = "Очков за созданную анкету")]
        public int PointsForCreatedBooks { get; set; }
    }
}