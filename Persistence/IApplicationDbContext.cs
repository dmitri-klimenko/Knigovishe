using Knigosha.Core.Models;
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
        DbSet<ActivationKey> ActivationKeys { get; set; }
        DbSet<MarkedBook> MarkedBooks { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<UserSubscription> UserSubscriptions { get; set; }
        DbSet<Subscription> Subscriptions { get; set; }
        DbSet<ApplicationUser> Users { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<School> Schools { get; set; }
        DbSet<Text> Texts { get; set; }

    }
}