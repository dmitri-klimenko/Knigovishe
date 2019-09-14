using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class TextConfiguration : IEntityTypeConfiguration<Text>
    {
        public void Configure(EntityTypeBuilder<Text> builder)
        {
            builder.ToTable("Texts");
            builder.HasKey(t => t.Id);

        }
    }
}
