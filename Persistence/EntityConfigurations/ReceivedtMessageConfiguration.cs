using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class ReceivedMessageConfiguration : IEntityTypeConfiguration<ReceivedMessage>
    {
        public void Configure(EntityTypeBuilder<ReceivedMessage> builder)
        {
            builder.ToTable("ReceivedMessages");
            builder.HasOne(rm => rm.Receiver).WithMany(s => s.ReceivedMessages);
            builder.HasKey(m => new { m.ReceiverId, m.SenderId });
        }
    }
}
