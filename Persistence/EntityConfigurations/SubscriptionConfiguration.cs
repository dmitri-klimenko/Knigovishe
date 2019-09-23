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
            builder.HasKey(st => st.Id);

            builder.Property(st => st.CurrentPrice).HasMaxLength(255).IsRequired();
            builder.Property(st => st.SubscriptionType).IsRequired();
            builder.Property(st => st.Name).HasMaxLength(255).IsRequired();
            builder.Property(st => st.OldPrice).HasMaxLength(255);
            builder.Property(st => st.Discount).HasMaxLength(4);
            builder.Property(st => st.NumberOfStudentProfiles).HasMaxLength(2);
            builder.Property(st => st.MaxQuizzes).HasMaxLength(255).IsRequired();
            builder.Property(st => st.Text1).HasMaxLength(255);
            builder.Property(st => st.Text2).HasMaxLength(255);
            builder.Property(st => st.Text3).HasMaxLength(255);
            builder.Property(st => st.ValidUntil).HasMaxLength(255).IsRequired();
            builder.Property(st => st.BankData).HasMaxLength(255);
        }
    }
}
