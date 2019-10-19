using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class BookNoteConfiguration : IEntityTypeConfiguration<BookNote>
    {
        public void Configure(EntityTypeBuilder<BookNote> builder)
        {
            builder.ToTable("BookNotes");
            builder.HasKey(bn => new { bn.UserId, bn.BookId });

            builder.Property(bn => bn.Text).HasMaxLength(255);
            builder.Property(bn => bn.BookId).IsRequired();
            builder.Property(bn => bn.UserId).IsRequired();
        }
    }
}
