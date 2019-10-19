using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Classes");

            builder.HasMany(c => c.Students)
                .WithOne(s => s.ClassStudentBelongsTo)
                .HasForeignKey(s => s.ClassStudentBelongsToId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(c => c.NameOfGroup).HasMaxLength(50);
        }
    }
}
