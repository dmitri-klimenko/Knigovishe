using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class BookRatingConfiguration : IEntityTypeConfiguration<BookRating>
    {
        public void Configure(EntityTypeBuilder<BookRating> builder)
        {
            builder.ToTable("BookRatings");
            builder.HasKey(br => new { br.BookId, br.UserId });

            builder.Property(br => br.UserId).IsRequired();
            builder.Property(br => br.BookId).IsRequired();
        }
    }
}
