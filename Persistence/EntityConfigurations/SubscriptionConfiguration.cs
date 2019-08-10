using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("Subscriptions");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.UserId).IsRequired();

            builder.HasOne(s => s.User)
                .WithMany(u => u.Subscriptions);

            builder.HasMany(s => s.AssociationKeys)
                .WithOne(ak => ak.Subscription)
                .HasForeignKey(ak => ak.SubscriptionId);

            builder.HasOne(s => s.SubscriptionType)
                .WithOne(st => st.Subscription)
                .HasForeignKey<SubscriptionType>(st => st.SubscriptionId);
        }
    }
}
