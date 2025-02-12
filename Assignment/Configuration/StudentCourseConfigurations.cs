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
    internal class StudentCourseConfigurations : IEntityTypeConfiguration<StudCourse>
    {
        public void Configure(EntityTypeBuilder<StudCourse> SC)
        {
            SC.HasKey(SC => SC.CrsId);

            SC.Property(SC => SC.StudId)
             .IsRequired()
             .HasColumnType("int");

            SC.Property(SC => SC.Grade)
              .HasColumnType("nvarchar");
        }
    }
}
