using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Knigosha.Core.Models.Enums
{
    public enum StatusTypes
    {

        [Display(Name = "Ожидание платежа")] Waiting,
        [Display(Name = "Абонемент оплачен")] Paid,
        [Display(Name ="Абонемент активирован")] Activated
  
    }

    //public static class temp
    //{

    //    public static string DisplayName(this Enum value)
    //    {
    //        Type enumType = value.GetType();
    //        var enumValue = Enum.GetName(enumType, value);
    //        MemberInfo member = enumType.GetMember(enumValue)[0];

    //        var attrs = member.GetCustomAttributes(typeof(DisplayAttribute), false);
    //        var outString = ((DisplayAttribute) attrs[0]).Name;

    //        if (((DisplayAttribute) attrs[0]).ResourceType != null)
    //        {
    //            outString = ((DisplayAttribute) attrs[0]).GetName();
    //        }

    //        return outString;
    //    }
    //}
}