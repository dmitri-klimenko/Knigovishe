using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {

        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.ToTable("Schools");
            builder.HasKey(s => s.Id);

            builder.HasOne(s => s.City).WithMany(c => c.Schools);
        }


    }
}