using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class SentMessageConfiguration : IEntityTypeConfiguration<SentMessage>
    {
        public void Configure(EntityTypeBuilder<SentMessage> builder)
        {
            builder.ToTable("SentMessages");
            builder.HasKey(sm => new { sm.ReceiverId, sm.SenderId });

            builder.HasOne(sm => sm.Sender).WithMany(s => s.SentMessages);

        }
    }
}
