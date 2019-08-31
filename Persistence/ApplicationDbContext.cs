using Knigosha.Core.Models;
using Knigosha.Persistence.EntityConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Knigosha.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookNote> BookNotes { get; set; }
        public DbSet<BookRating> BookRatings { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<ActivationKey> ActivationKeys { get; set; }
        public DbSet<MarkedBook> MarkedBooks { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<SentMessage> SentMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new AnswerConfiguration());
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new BookNoteConfiguration());
            builder.ApplyConfiguration(new BookRatingConfiguration());
            builder.ApplyConfiguration(new ClassConfiguration());
            builder.ApplyConfiguration(new FamilyConfiguration());
            builder.ApplyConfiguration(new ActivationKeyConfiguration());
            builder.ApplyConfiguration(new MarkedBookConfiguration());
            builder.ApplyConfiguration(new QuestionConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new UserSubscriptionConfiguration());
            builder.ApplyConfiguration(new SubscriptionConfiguration());
            builder.ApplyConfiguration(new SentMessageConfiguration());
            builder.ApplyConfiguration(new ReceivedMessageConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
