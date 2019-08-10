using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class AssociationKeyConfiguration : IEntityTypeConfiguration<AssociationKey>
    {
        public void Configure(EntityTypeBuilder<AssociationKey> builder)
        {
            builder.ToTable("AssociationKeys");
            builder.HasKey(k => k.Id);
        }
    }
}
