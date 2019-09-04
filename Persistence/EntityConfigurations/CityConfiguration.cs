using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities");
            builder.HasKey(s => s.Id);

            builder.HasMany(c => c.Schools)
                .WithOne(s => s.City)
                .HasForeignKey(s => s.CityId);
        }
    }
}