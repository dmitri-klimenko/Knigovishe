using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class SubscriptionTypeConfiguration : IEntityTypeConfiguration<SubscriptionType>
    {
        public void Configure(EntityTypeBuilder<SubscriptionType> builder)
        {
            builder.ToTable("SubscriptionTypes");
            builder.HasKey(st => st.Id);

            builder.Property(st => st.Name).IsRequired();
            builder.Property(st => st.PriceTag).IsRequired().HasMaxLength(255);
            builder.Property(st => st.MaxQuizzes).IsRequired();
            builder.Property(st => st.ValidUntil).IsRequired().HasMaxLength(255);
            builder.Property(st => st.Text1).HasMaxLength(255);
            builder.Property(st => st.Text2).HasMaxLength(255);
            builder.Property(st => st.Text3).HasMaxLength(255);
        }
    }
}
