using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Persistence.Migrations;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;

namespace Knigosha.Core.Models
{
    public class Text
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите namespace")]
        [MaxLength(50)]
        public string Namespace { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите key")]
        [MaxLength(50)]
        public string Key { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите текст")]
        [Display(Name = "Текст")]
        public string Content { get; set; }

        [Display(Name = "Добавлен")]
        public string DateAdded { get; set; }

        [Display(Name = "Редактирован")]
        public string DateEdited { get; set; }
        public Text()
        {
            DateAdded = DateTime.Now.ToString("d");
        }
    }
  
}
