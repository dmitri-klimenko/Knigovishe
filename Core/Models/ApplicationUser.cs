using System;
using Knigosha.Core.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Knigosha.Core.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }

        public UserTypes UserType { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Greeting { get; set; }

        public bool? ShowAchievements { get; set; }

        public string FullName => Name + " " + Surname;

        public override string UserName { get; set; }

        public string Password { get; set; }

        public override string Email { get; set; }

        public override string PhoneNumber { get; set; }

        public string Photo { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string School { get; set; } 

        public string Parallel { get; set; }

        public Student Student { get; set; }

        public Grades Grade { get; set; }

        public int NumberOfCreatedBooks => CreatedBooks.Count; 

        public int PointsForCreatedBooks => CreatedBooks.Sum(cb => cb.Points);

        public AgeGroups AgeGroup
        {
            get
            {
                AgeGroups ageGroup;
                if (Grade == Grades.One)
                    ageGroup = AgeGroups.SixPlus;
                else if (Grade == Grades.Two || Grade == Grades.Three || Grade == Grades.Four)
                    ageGroup = AgeGroups.EightPlus;
                else if (Grade == Grades.Five || Grade == Grades.Six || Grade == Grades.Seven)
                    ageGroup = AgeGroups.ElevenPlus;
                else ageGroup = AgeGroups.FourteenPlus;
                return ageGroup;
            }
        }

        public int PercentageOfRightResponses
        {
            get
            {
                var percentageSum = Answers.Sum(answer => PercentageOfRightResponses);
                return NumberOfAnswers != 0 ? percentageSum / NumberOfAnswers : 0;
            }
        }

        public int PointsForAnswers => Answers.Sum(answer => answer.Points);

        public int Points =>  PointsForAnswers + PointsForCreatedBooks;

        public int NumberOfAnswers => Answers.Count;

        public Levels Level
        {
            get
            {
                var levelName = Levels.Null;
                if (Points <= 45)  levelName = Levels.Null;
                else if (Points > 45 || Points <= 90) levelName = Levels.One;
                else if (Points > 90  || Points <= 135) levelName = Levels.Two;
                else if (Points > 135  || Points <= 180) levelName = Levels.Three;
                else if (Points > 180  || Points <= 225) levelName = Levels.Four;
                else if (Points > 225  || Points <= 270) levelName = Levels.Five;
                else if (Points > 270 || Points <= 315) levelName = Levels.Six;
                else if (Points > 315) levelName = Levels.Seven; 
                return levelName;
            }

        }

        public bool SubscribedToNewsletter { get; set; }

        public string DateAdded { get; set; }

        public string DateEdited { get; set; }

        public string LastLogin { get; set; }

        public int LoginTimes { get; set; }

        public ICollection<UserSubscription> UserSubscriptions { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public ICollection<CreatedBook> CreatedBooks { get; set; }

        public ICollection<BookNote> BookNotes { get; set; }

        public ICollection<BookRating> BookRatings { get; set; }

        public IList<MarkedBook> MarkedBooks { get; set; }

        public IList<Message> Messages { get; set; }

        public int TotalAnswers { get; set; }
        public int TotalPercentage { get; set; }
        public int TotalPoints { get; set; }

        public ApplicationUser()
        {
            UserSubscriptions = new Collection<UserSubscription>();
            Messages = new List<Message>();
            Answers = new Collection<Answer>();
            CreatedBooks = new Collection<CreatedBook>();
            BookNotes = new Collection<BookNote>();
            BookRatings = new Collection<BookRating>();
            MarkedBooks = new Collection<MarkedBook>();
            DateAdded = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}