using System.ComponentModel;

namespace Knigosha.Core.Models.Enums
{
    public enum StatusTypes
    {
        [DisplayName("Ожидание платежа")]
        Waiting,
        [DisplayName("Абонемент оплачен")]
        Paid,
        [DisplayName("Абонемент активирован")]
        Activated,
        [DisplayName("Абонемент истёк")]
        Expired
    }
}