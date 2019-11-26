using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class UserSubscriptionViewModel
    {
        public int Id  { get; set; }

        public int SubscriptionId   { get; set; }

        public Subscription Subscription { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите способ платежа")]
        public int PayMethod { get; set; }

        public bool Myself { get; set; }

        public bool Invoice { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите адрес почты")]
        [EmailAddress(ErrorMessage = "Адрес должен быть действительным")]
        public string Email { get; set; }

        [Display(Name = "Страна:")]
        public string Country { get; set; }
        public List<SelectListItem> Countries { set; get; }

        [Display(Name = "Город:")]
        public string CityInput { get; set; }

        [Display(Name = "Город:")]
        public string MainCityRussia { get; set; }
        public List<SelectListItem> MainCitiesRussia { set; get; }

        [Display(Name = "Учреждение:")]
        public string  Institution { get; set; }

        [Display(Name = "Адрес учреждения:")]
        public string AddressOfInstitution { get; set; }

        [Display(Name = "ИНН:")]
        public string Uid { get; set; }

        [Display(Name = "Заказчик:")]
        public string Person { get; set; }

        [Display(Name = "Телефон учреждения:")]
        public string TelephoneOfInstitution { get; set; }

    }
}
