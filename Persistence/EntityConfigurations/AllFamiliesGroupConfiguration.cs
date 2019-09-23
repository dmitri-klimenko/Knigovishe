using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class AllFamiliesGroupConfiguration : IEntityTypeConfiguration<AllFamiliesGroup>
    {
        public void Configure(EntityTypeBuilder<AllFamiliesGroup> builder)
        {
            builder.ToTable("AllFamiliesGroup");
            builder.HasKey(k => k.Id);
            builder.HasMany(ac => ac.Families)
                .WithOne(c => c.AllFamiliesGroup);
        }
    }
}
