using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class ActivationKeyConfiguration : IEntityTypeConfiguration<ActivationKey>
    {
        public void Configure(EntityTypeBuilder<ActivationKey> builder)
        {
            builder.ToTable("ActivationKeys");
            builder.HasKey(k => k.Id);
        }
    }
}
