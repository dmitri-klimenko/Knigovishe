﻿using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Knigosha.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Answer> Answers { get; set; }
        DbSet<Book> Books { get; set; }
        DbSet<BookNote> BookNotes { get; set; }
        DbSet<BookRating> BookRatings { get; set; }
        DbSet<Class> Classes { get; set; }
        DbSet<Family> Families { get; set; }
        DbSet<AssociationKey> AssociationKeys { get; set; }
        DbSet<MarkedBook> MarkedBooks { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<ReceivedMessage> ReceivedMessages { get; set; }
        DbSet<SentMessage> SentMessages { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Subscription> Subscriptions { get; set; }
        DbSet<SubscriptionType> SubscriptionTypes { get; set; }
        DbSet<ApplicationUser> Users { get; set; }

    }
}