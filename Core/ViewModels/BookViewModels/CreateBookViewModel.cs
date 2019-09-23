using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Knigosha.Core.Models.Enums;
using Microsoft.AspNetCore.Http;
using UoN.ExpressiveAnnotations.NetCore.Attributes;

namespace Knigosha.Core.ViewModels.BookViewModels
{
    public class CreateBookViewModel
    {
        [Required(ErrorMessage = "Пожалуйста, введите название книги.")]
        [Display(Name = "*Название:")]
        public string Title { get; set; }

        [RequiredIf("BookCategory == 1", ErrorMessage = "Пожалуйста, введите полное имя автора книги.")]
        [Display(Name = "*Автор:")]
        public string BookAuthor { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите название издательства.")]
        [Display(Name = "*Издательство:")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите год издания книги.")]
        [Display(Name = "*Год издания:")]
        [RegularExpression(@"\d{4}", ErrorMessage = "Пожалуйста, убедитесь в правильности года")]
        public string YearPublished { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите категорию.")]
        [Display(Name = "*Категория:")]
        public BookCategories BookCategory { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите ISBN код книги.")]
        [Display(Name = "*ISBN код:")]
        [RegularExpression(@"((978[\--– ])?[0-9][0-9\--– ]{10}[\--– ][0-9xX])|((978)?[0-9]{9}[0-9Xx])", 
            ErrorMessage = "Пожалуйста, убедитесь в правильности кода")]
        public string Isbn1 { get; set; }

        [Display(Name = "ISBN код (2):")]
        [RegularExpression(@"((978[\--– ])?[0-9][0-9\--– ]{10}[\--– ][0-9xX])|((978)?[0-9]{9}[0-9Xx])", 
            ErrorMessage = "Пожалуйста, убедитесь в правильности кода")]
        public string Isbn2 { get; set; }

        [Display(Name = "Страниц:")]
        public int NumberOfPages { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите файл с изображением обложки книги.")]
        [Display(Name = "*Обложка:")]
        public IFormFile UploadPhoto { get; set; }

        [Required(ErrorMessage = "Пожалуйста, выберите для какого класса подходит книга.")]
        [Display(Name = "*Класс:")]
        public Grades? Grade { get; set; }

        [Display(Name = "Автор перевода:")]
        public string Translator { get; set; }

        [Display(Name = "Краткая форма (короткая история, сказка, басня)")]
        public bool IsShortForm { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите ключевые слова.")]
        [Display(Name = "*Тэги (ключевые слова):")]
        public string Tags { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите короткое описание книги.")]
        [Display(Name = "*Описание:")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите полное имя автора вопросов.")]
        [Display(Name = "*Автор вопросов:")]
        public string QuestionsAuthor { get; set; }

        [Display(Name = "Администратор:")]
        public string AddedByAdmin { get; set; }

        [Display(Name = "Включена в программу в классе: ")]
        public Grades? PartOfSchoolProgramAtGrade { get; set; }
    }

}
