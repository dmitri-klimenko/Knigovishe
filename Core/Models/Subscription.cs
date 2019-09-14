using Knigosha.Core.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models
{
    public class Subscription
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите название абонемента")]
        [Display(Name = "Название:")]
        public SubscriptionNames? Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите тип абонемента")]
        [Display(Name="Тип абонемента:")]
        public SubscriptionTypes? SubscriptionType { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите цену")]
        [Display(Name = "Цена:")]
        public string CurrentPrice { get; set; }

        [Display(Name = "Старая цена:")]
        public string OldPrice { get; set; }

        [Display(Name = "Скидка:")] 
        public string Discount { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите количество вопросников")]
        [Display(Name = "Количество вопросников:")]
        public string MaxQuizzes { get; set; }

        [Display(Name = "Ученических профилей:")]
        public string NumberOfStudentProfiles { get; set; }

        [Display(Name = "Родительских профилей:")]
        public char? NumberOfParentProfiles { get; set; }

        [Display(Name = "Учительских профилей:")]
        public char? NumberOfTeacherProfiles { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите до какого месяца абонемент действителен")]
        [Display(Name = "Действителен до:")]
        public string ValidUntil { get; set; }

        [Display(Name = "Данные банка для перевода:")]
        public string BankData { get; set; }

        [Display(Name = "Текст 1:")]
        public string Text1 { get; set; }

        [Display(Name = "Текст 2:")]
        public string Text2 { get; set; }

        [Display(Name = "Текст 3:")]
        public string Text3 { get; set; }
    }
}
