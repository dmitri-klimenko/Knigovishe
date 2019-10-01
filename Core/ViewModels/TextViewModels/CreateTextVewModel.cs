﻿using System.ComponentModel.DataAnnotations;
using Knigosha.Core.Models.Enums;
using Microsoft.AspNetCore.Http;

namespace Knigosha.Core.ViewModels.TextViewModels
{
    public class CreateTextVewModel
    {
        [Required(ErrorMessage = "Пожалуйста, введите название")]
        [MaxLength(50)]
        [Display(Name = "*Название")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите описание")]
        [Display(Name = "*Описание")]
        public string Description { get; set; }

        [Display(Name = "Фото:")]
        public IFormFile Photo { get; set; }

        [Display(Name = "Тип")]
        public TextTypes? TextType { get; set; }

    }
}