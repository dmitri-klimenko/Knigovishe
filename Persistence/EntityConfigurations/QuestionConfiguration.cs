using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>

    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions");
            builder.HasKey(q => q.Id);

            builder.Property(q => q.BookId).IsRequired();
            builder.Property(q => q.RightAnswer).HasMaxLength(255);
            builder.Property(q => q.QuestionType).IsRequired();
            builder.Property(q => q.WrongAnswer1).HasMaxLength(255);
            builder.Property(q => q.WrongAnswer2).HasMaxLength(255);
            builder.Property(q => q.Text).IsRequired().HasMaxLength(255);
        }
    }
}
