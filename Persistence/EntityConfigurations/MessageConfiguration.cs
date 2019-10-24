using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Messages");
            builder.Property(m => m.Topic).HasMaxLength(50);
            builder.Property(m => m.Body).IsRequired().HasMaxLength(255);
            builder.HasOne(m => m.Sender).WithMany(s => s.Messages);
        }
    }
}
