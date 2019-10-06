using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models.Enums;
using Knigosha.Persistence.Migrations;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;

namespace Knigosha.Core.Models
{
    public class Text
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите название")]
        [MaxLength(90)]
        [Display(Name = "Название")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите описание")]
        [Display(Name = "Описание/Город")]
        public string Description { get; set; }

        [Display(Name = "Описание/Профессия")]
        public string Description2 { get; set; }

        [Display(Name = "Добавлен")] public string DateAdded { get; set; }

        public string Photo { get; set; }

        [Display(Name = "Тип")]
        public TextTypes? TextType { get; set; }

        [Display(Name = "Редактирован")] public string DateEdited { get; set; }

        public Text()
        {
            DateAdded = DateTime.Now.ToString("d");
        }
    }

}
