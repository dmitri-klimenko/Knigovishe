using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class MarkedBookConfiguration : IEntityTypeConfiguration<MarkedBook>
    {
        public void Configure(EntityTypeBuilder<MarkedBook> builder)
        {
            builder.ToTable("MarkedBooks");
            builder.HasKey(mb => new { mb.BookId, mb.UserId });

            builder.Property(mb => mb.UserId).IsRequired();
            builder.Property(mb => mb.BookId).IsRequired();
        }
    }
}

