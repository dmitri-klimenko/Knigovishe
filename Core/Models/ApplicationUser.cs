using Knigosha.Core.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Knigosha.Core.Models
{
    public class ApplicationUser : IdentityUser
    {
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

        public string Parallel { get; set; }

        public Student Student { get; set; }
        public Family Family { get; set; }
        public Class Class { get; set; }


        public Grades Grade { get; set; }

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


        public int? NumberOfCreatedBooks { get; set; }

        public int? NumberPointsForCreatedBooks { get; set; }

        public bool? SubscribedToNewsletter { get; set; }

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

        }

        public void OrderSubscription(Subscription subscription)
        {
            UserSubscriptions.Add(new UserSubscription(this, subscription));
        }

        public void SentMessage(SentMessage message, ApplicationUser receiver)
        {
            SentMessages.Add(new SentMessage(this, receiver));
        }

        public void MarkBook(Book book, ApplicationUser user)
        {
            MarkedBooks.Add(new MarkedBook(this, book));
        }

        public void CreateBookNote(Book book, ApplicationUser user)
        {
            BookNotes.Add(new BookNote(this, book));
        }

        public void RateBook(Book book, ApplicationUser user)
        {
            BookRatings.Add(new BookRating(this, book));
        }

        public void AnswerBook(Book book, ApplicationUser user)
        {
            Answers.Add(new Answer(this, book));
        }


    }

}