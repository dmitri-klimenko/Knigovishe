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
        public Subscription  Subscription { get; set; }

        public bool BankTransfer { get; set; }

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
