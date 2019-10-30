using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigosha.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Knigosha.Persistence.EntityConfigurations
{

    public class StudentFamilyConfiguration : IEntityTypeConfiguration<StudentFamily>
    {
        public void Configure(EntityTypeBuilder<StudentFamily> builder)
        {
            builder.ToTable("StudentFamily");
            builder.HasKey(sf => sf.Id);
            builder
                .HasOne(sf => sf.Student)
                .WithMany(s => s.StudentFamilies)
                .HasForeignKey(sf => sf.StudentId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(sc => sc.Family)
                .WithMany(f => f.StudentFamilies)
                .HasForeignKey(sf => sf.FamilyId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
