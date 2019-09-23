using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class AllClassesGroupConfiguration : IEntityTypeConfiguration<AllClassesGroup>
    {
        public void Configure(EntityTypeBuilder<AllClassesGroup> builder)
        {
            builder.ToTable("AllCLassesGroup");
            builder.HasKey(k => k.Id);
            builder.HasMany(ac => ac.Classes)
                .WithOne(c => c.AllClassesGroup);

        }
    }
}
