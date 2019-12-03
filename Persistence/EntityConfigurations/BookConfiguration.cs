using System.Text;
using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title).IsRequired().HasMaxLength(255);
            builder.Property(b => b.BookAuthor).HasMaxLength(255);
            builder.Property(b => b.Publisher).IsRequired().HasMaxLength(255);
            builder.Property(b => b.YearPublished).IsRequired().HasMaxLength(4);
            builder.Property(b => b.BookCategory).IsRequired();
            builder.Property(b => b.CoverPhoto).IsRequired();
            builder.Property(b => b.Grade).IsRequired();
            builder.Property(b => b.Isbn1).IsRequired();
            builder.Property(b => b.Description).IsRequired();
            builder.Property(b => b.Tags).IsRequired();
            builder.Property(b => b.QuestionsAuthor).IsRequired();

            builder.HasMany(b => b.Questions)
                .WithOne(q => q.Book)
                .HasForeignKey(q => q.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(b => b.Answers)
                .WithOne(q => q.Book)
                .HasForeignKey(q => q.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(b => b.BookRatings)
                .WithOne(q => q.Book)
                .HasForeignKey(q => q.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(b => b.BookComments)
                .WithOne(q => q.Book)
                .HasForeignKey(q => q.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasMany(b => b.BookOpinions)
            //    .WithOne(q => q.Book)
            //    .HasForeignKey(q => q.BookId)
            //    .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
