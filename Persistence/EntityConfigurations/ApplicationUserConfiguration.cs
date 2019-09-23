using System.ComponentModel.DataAnnotations;
using System.Text;
using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Surname).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.Grade).IsRequired();
            builder.Property(a => a.Password).IsRequired().HasMaxLength(50);
            builder.Property(a => a.UserName).IsRequired().HasMaxLength(50);

            builder.HasMany(a => a.MarkedBooks)
                .WithOne(mb => mb.User)
                .HasForeignKey(mb => mb.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.SentMessages)
                .WithOne(m => m.Sender)
                .HasForeignKey(sm => sm.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(a => a.ReceivedMessages)
                .WithOne(m => m.Receiver)
                .HasForeignKey(sm => sm.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(a => a.Answers)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(a => a.BookNotes)
                .WithOne(bn => bn.User)
                .HasForeignKey(bn => bn.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.BookRatings)
                .WithOne(br => br.User)
                .HasForeignKey(br => br.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.UserSubscriptions)
                .WithOne(s => s.User)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
