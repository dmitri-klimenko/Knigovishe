using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name).IsRequired().HasMaxLength(255);
            builder.Property(a => a.Surname).IsRequired().HasMaxLength(255);
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.Grade).IsRequired();
            builder.Property(a => a.Password).IsRequired().HasMaxLength(50);
            builder.Property(a => a.UserName).IsRequired().HasMaxLength(50);

            builder.HasOne(a => a.Student)
                .WithOne(s => s.User)
                .HasForeignKey<Student>(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Family)
                .WithOne(s => s.User)
                .HasForeignKey<Family>(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Class)
                .WithOne(s => s.User)
                .HasForeignKey<Class>(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasMany(a => a.MarkedBooks)
                .WithOne(mb => mb.User)
                .HasForeignKey(mb => mb.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(a => a.SentMessages)
                .WithOne(sm => sm.Sender)
                .HasForeignKey(sm => sm.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(a => a.ReceivedMessages)
                .WithOne(rm => rm.Receiver)
                .HasForeignKey(rm => rm.ReceiverId)
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

            builder.HasMany(a => a.Subscriptions)
                .WithOne(s => s.User)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
