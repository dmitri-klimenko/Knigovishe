using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using UoN.ExpressiveAnnotations.NetCore.Attributes;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class DetailsViewModel
    {
        public string Action { get; set; }

        public UserTypes UserType { get; set; }

        public string FullName { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваше имя")]
        [Display(Name = "*Имя:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Вашу фамилию")]
        [Display(Name = "*Фамилия:")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваше имя пользователя")]
        [Display(Name = "*Имя пользователя:")]
        public string UserName { get; set; }

        [Display(Name = "Адрес электронной почты")]
        [RequiredIf("ParentEmail == null && UserType == 1", ErrorMessage = "Пожалуйста, введите адрес почты")]
        [EmailAddress(ErrorMessage = "Адрес должен быть действительным")]
        public string Email { get; set; }

        [RequiredIf("UserType == 2 || UserType == 3", ErrorMessage = "Пожалуйста, введите адрес почты")]
        [Display(Name = "*Адрес электронной почты")]
        [EmailAddress(ErrorMessage = "Адрес должен быть действительным")]
        public string RequiredEmail { get; set; }

        [EmailAddress(ErrorMessage = "Адрес должен быть действительным")]
        [Display(Name = "Адрес почты одного из родителей:")]
        public string ParentEmail { get; set; }

        [Display(Name = "Номер телефона:")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Страна:")]
        public string Country { get; set; }
        public List<SelectListItem> Countries { set; get; }

        [Display(Name = "Город:")]
        public string CityInput { get; set; }

        [Display(Name = "Город:")]
        public string MainCityRussia { get; set; }
        public List<SelectListItem> MainCitiesRussia { set; get; }

        [Display(Name = "Школа:")]
        public string SchoolInput { get; set; }

        [Display(Name = "Школа:")]
        public string SchoolSelect { get; set; }

        [Display(Name = "Класс:")]
        public Grades Grade { get; set; }

        [Display(Name = "Параллель (буква):")]
        public string Parallel { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваш пароль")]
        [StringLength(50, ErrorMessage = "Пароль должен содержать минимум {2} знаков.",
            MinimumLength = 6)]
        [DataType(DataType.Password, ErrorMessage = "Пароль должен содержать минимум 6 знаков.")]
        [Display(Name = "*Изменить пароль:")]
        public string Password { get; set; }

        [Display(Name = "Называть меня:")]
        public int GreetingRadio  { get; set; }

        public List<SelectListItem> Greetings { get; set; }

        public string GreetingString { get; set; }

        [Display(Name = "Хотите, чтобы Ваши комментарии и достижения отображались в рейтинге игроков?")]
        public int ShowAchievements { get; set; }

        [Display(Name = "Аватар:")]
        public IFormFile Photo { get; set; }

        public string NameOfGroup { get; set; }

    }
}
