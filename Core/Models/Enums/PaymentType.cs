using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Knigosha.Core.Models.Enums
{
    public enum PaymentType
    {
        [Display(Name="Банковский перевод")]
        BankTransfer,
        [Display(Name = "Кредитная карточка")]
        CreditCard
    }
}