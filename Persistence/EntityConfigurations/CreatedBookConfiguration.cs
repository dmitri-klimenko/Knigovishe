using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    
    public class CreatedBookConfiguration : IEntityTypeConfiguration<CreatedBook>
    {
        public void Configure(EntityTypeBuilder<CreatedBook> builder)
        {
            builder.ToTable("CreatedBooks");
            builder.HasKey(cb => cb.Id);

        }
    }
}
