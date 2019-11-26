using System;
using System.Collections.Generic;
using Knigosha.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Knigosha.Core.ViewModels.ManageViewModels
{
    public class QuizViewModel
    {
        public Book Book { get; set; }
        public bool HasAccess { get; set; }
        public int? MyRating { get; set; }
        public List<Question> Questions { get; set; }
        public byte CurrentQuestion{ get; set; }
        public float Points { get; set; }
        public int CurrentSecond { get; set; }
    }
}