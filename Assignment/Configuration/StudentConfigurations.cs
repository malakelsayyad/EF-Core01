using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configuration
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.HasKey(S => S.Id);

            S.Property(S => S.DeptId).IsRequired();

            S.Property(S => S.FName)
             .IsRequired(true)
             .HasColumnType("varchar")
             .HasMaxLength(50)
             .HasColumnName("FirstName");

            S.Property(S => S.LName)
            .IsRequired(true)
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .HasColumnName("LastName");

            S.Property(S => S.Address).IsRequired().HasMaxLength(50);

            S.Property(E => E.Age).IsRequired(false);

           

        }
    }
}
