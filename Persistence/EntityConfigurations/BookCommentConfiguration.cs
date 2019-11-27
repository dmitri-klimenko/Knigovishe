using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class BookCommentConfiguration : IEntityTypeConfiguration<BookComment>
    {
        public void Configure(EntityTypeBuilder<BookComment> builder)
        {
            builder.ToTable("BookComments");
            builder.HasKey(bc => new { bc.BookId, bc.UserId });
            builder.Property(bc => bc.UserId).IsRequired();
            builder.Property(bc => bc.BookId).IsRequired();
        }
    }
}
