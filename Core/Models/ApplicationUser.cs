﻿using System;
using Knigosha.Core.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public Family Family { get; set; }

        public Class Class { get; set; }

        public Grades Grade { get; set; }

        public int NumberOfCreatedBooks { get; set; }

        public int PointsForCreatedBooks { get; set; }

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

        public string Level
        {
            get
            {
                string levelName = null;
                if (Points <= 45) levelName = "новичок";
                else if (Points > 45 || Points <= 90) levelName = "освоившийся";
                else if (Points > 90  || Points <= 135) levelName = "поднаторелый";
                else if (Points > 135  || Points <= 180) levelName = "умелый";
                else if (Points > 180  || Points <= 225) levelName = "профи";
                else if (Points > 225  || Points <= 270) levelName = "мастер";
                else if (Points > 270) levelName = "герой";
                return levelName;
            }
        }

        public int NumberOfReceivedMessages => ReceivedMessages.Count;

        public bool SubscribedToNewsletter { get; set; }

        public string DateAdded { get; set; }

        public string DateEdited { get; set; }

        public string LastLogin { get; set; }

        public ICollection<UserSubscription> UserSubscriptions { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public ICollection<BookNote> BookNotes { get; set; }

        public ICollection<BookRating> BookRatings { get; set; }

        public ICollection<MarkedBook> MarkedBooks { get; set; }

        public ICollection<SentMessage> SentMessages { get; set; }

        public ICollection<ReceivedMessage> ReceivedMessages { get; set; }


        public ApplicationUser()
        {
            UserSubscriptions = new Collection<UserSubscription>();
            Answers = new Collection<Answer>();
            BookNotes = new Collection<BookNote>();
            BookRatings = new Collection<BookRating>();
            MarkedBooks = new Collection<MarkedBook>();
            SentMessages = new Collection<SentMessage>();
            ReceivedMessages = new Collection<ReceivedMessage>();
            DateAdded = DateTime.Now.ToString("d");

        }

    }

}