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
    internal class CourseInstructorConfigurations : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> CI)
        {
            CI.HasKey(CI => CI.CrsId);

            CI.Property(CI => CI.InsId)
             .IsRequired()
             .HasColumnType("int");

            CI.Property(CI => CI.Evaluate)
              .HasColumnType("nvarchar");

        }
    }
}
