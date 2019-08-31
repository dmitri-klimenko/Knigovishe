using Knigosha.Core.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models
{
    public class Subscription
    {
        [Display(Name = "Номер абонемента")]
        public int Id { get; set; }

        //"Бесплатное демо" 
        //"ИндивидуальныЙ"
        //"Семейный" 
        //"Абонемент класса"
        public SubscriptionTypes SubscriptionType { get; set; }

        [Display(Name = "Цена:")]
        public string PriceTag { get; set; }

        public int Price { get; set; }

        [Display(Name = "Количество вопросников:")]
        public int MaxQuizzes { get; set; }

        [Display(Name = "Ученических профилей:")]
        public int NumberOfStudentProfiles { get; set; }

        [Display(Name = "Родительских профилей:")]
        public int NumberOfParentProfiles { get; set; }
        [Display(Name = "Учительских профилей:")]
        public int NumberOfTeacherProfiles { get; set; }

        [Display(Name = "Действителен до:")]
        public string ValidUntil { get; set; }

        public string BankData { get; set; }

        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
    }
}
