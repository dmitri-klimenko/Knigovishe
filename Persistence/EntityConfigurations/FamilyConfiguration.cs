using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class FamilyConfiguration : IEntityTypeConfiguration<Family>
    {
        public void Configure(EntityTypeBuilder<Family> builder)
        {
            builder.ToTable("Families");

            builder.HasMany(f => f.Students)
                .WithOne(s => s.FamilyStudentBelongsTo)
                .HasForeignKey(s => s.FamilyStudentBelongsToId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
