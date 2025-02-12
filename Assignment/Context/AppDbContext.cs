using Assignment.Configuration;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Context
{
    internal class AppDbContext: DbContext
    {
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Instructor[FLuent APIs]
            modelBuilder.Entity<Instructor>().HasKey(I => I.Id);

            modelBuilder.Entity<Instructor>().Property(I => I.DeptId).IsRequired();

            modelBuilder.Entity<Instructor>().Property(I => I.Name)
                                             .HasMaxLength(20)
                                             .IsRequired();

            modelBuilder.Entity<Instructor>().Property(I => I.Bonus)
                                             .HasColumnType("float");

            modelBuilder.Entity<Instructor>().Property(I => I.Salary)
                                             .HasColumnType("float");

            modelBuilder.Entity<Instructor>().Property(I => I.Address)
                                             .HasMaxLength(50)
                                             .HasColumnName("EmpAddress");

            modelBuilder.Entity<Instructor>().Property(I => I.HourRate)
                                             .HasColumnType("float");
            #endregion

            #region Student [By Config]
            //Student
            modelBuilder.ApplyConfiguration(new StudentConfigurations());
            #endregion

            #region CourseInstructor [By Config]
            modelBuilder.ApplyConfiguration(new CourseInstructorConfigurations());
            #endregion

            #region StudCourse [By Config]
            modelBuilder.ApplyConfiguration(new StudentCourseConfigurations());
            #endregion

            base.OnModelCreating(modelBuilder);
        }
        public AppDbContext():base()
        {
            
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=Assignment; Trusted_Connection=True; TrustServerCertificate=True;");
        }

        public DbSet<Course> Courses { get; set; } //By Convention
        public DbSet<Department> Departments { get; set; } //Data Annotation
        public DbSet<Instructor> Instructors { get; set; } //FLuent APIs
        public DbSet<Student> Students { get; set; } // By Config
        public DbSet<Topic> Topics { get; set; } //By Convention
        public DbSet<CourseInstructor> CourseInstructor { get; set; } // By Config
        public DbSet<StudCourse> StudCourse { get; set; } // By Config

    }
}
