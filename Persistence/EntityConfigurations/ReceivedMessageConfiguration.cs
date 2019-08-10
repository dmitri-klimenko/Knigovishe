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
            builder.HasKey(rm => new { rm.ReceiverId, rm.SenderId });

            builder.HasOne(rm => rm.Receiver).WithMany(r => r.ReceivedMessages);

        }
    }
}
