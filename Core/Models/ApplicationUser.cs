using Knigosha.Core.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Knigosha.Core.Models
{
    public class ApplicationUser : IdentityUser
    {
        private Grades _grade;

        public string Name { get; set; }

        public string Surname { get; set; }

        public override string UserName { get; set; }

        public string Password { get; set; }

        //public string RepeatPassword { get; set; }

        public override string Email { get; set; }

        public override string PhoneNumber { get; set; }

        public string Photo { get; set; }

        public string City { get; set; }
        //public IList<SelectListItem> Cities { get; set; }

        public string Country { get; set; }
        //public IList<SelectListItem> Countries { get; set; }

        public Grades Grade
        {
            get => _grade;
            set => _grade = value;
        }

        public AgeGroups AgeGroup
        {
            get
            {
                AgeGroups ageGroup;
                if (_grade == Grades.One)
                    ageGroup = AgeGroups.SixPlus;
                else if (_grade == Grades.Two || _grade == Grades.Three || _grade == Grades.Four)
                    ageGroup = AgeGroups.EightPlus;
                else if (_grade == Grades.Five || _grade == Grades.Six || _grade == Grades.Seven)
                    ageGroup = AgeGroups.ElevenPlus;
                else ageGroup = AgeGroups.FourteenPlus;
                return ageGroup;
            }
        }


        public int NumberOfCreatedBooks { get; set; }

        public int NumberPointsForCreatedBooks { get; set; }

        public Student Student { get; set; }

        public Class Class { get; set; }

        public Family Family { get; set; }


        public ICollection<Subscription> Subscriptions { get; set; }

        public ICollection<SentMessage> SentMessages { get; set; }

        public ICollection<ReceivedMessage> ReceivedMessages { get; set; }

        public ICollection<Answer> Answers { get; set; }

        public ICollection<BookNote> BookNotes { get; set; }

        public ICollection<BookRating> BookRatings { get; set; }

        public ICollection<MarkedBook> MarkedBooks { get; set; }


        public ApplicationUser()
        {
            Subscriptions = new Collection<Subscription>();
            SentMessages = new Collection<SentMessage>();
            ReceivedMessages = new Collection<ReceivedMessage>();
            Answers = new Collection<Answer>();
            BookNotes = new Collection<BookNote>();
            BookRatings = new Collection<BookRating>();
            MarkedBooks = new Collection<MarkedBook>();
        }
    }
}