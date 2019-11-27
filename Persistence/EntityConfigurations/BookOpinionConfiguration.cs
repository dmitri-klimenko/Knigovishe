using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class BookOpinionConfiguration : IEntityTypeConfiguration<BookOpinion>
    {
        public void Configure(EntityTypeBuilder<BookOpinion> builder)
        {
            builder.ToTable("BookOpinions");
            builder.HasKey(br => new { br.BookId, br.UserId });

            builder.Property(br => br.UserId).IsRequired();
            builder.Property(br => br.BookId).IsRequired();
        }
    }
}
