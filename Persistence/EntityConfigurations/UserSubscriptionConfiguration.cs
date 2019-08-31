using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class UserSubscriptionConfiguration : IEntityTypeConfiguration<UserSubscription>
    {
        public void Configure(EntityTypeBuilder<UserSubscription> builder)
        {
            builder.ToTable("UserSubscriptions");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.UserId).IsRequired();

            builder.HasOne(s => s.User)
                .WithMany(u => u.UserSubscriptions);

            builder.HasMany(s => s.ActivationKeys).WithOne(ak => ak.UserSubscription);

        }
    }
}
