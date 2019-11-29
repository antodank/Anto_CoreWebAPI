using Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configuration code added directly in method

            //modelBuilder.Entity<Student>()
            //    .ToTable("Student");
            //modelBuilder.Entity<Student>()
            //    .Property(s => s.Age)
            //    .IsRequired(false);
            //modelBuilder.Entity<Student>()
            //    .Property(s => s.IsRegularStudent)
            //    .HasDefaultValue(true);

            //modelBuilder.Entity<Student>()
            //.HasData(
            //    new Student
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "John Doe",
            //        Age = 30
            //    },
            //    new Student
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Jane Doe",
            //        Age = 25
            //    }
            //);

            modelBuilder.ApplyConfiguration(new StudentConfiguration());

            
        }

        public DbSet<Student> Students { get; set; }
    }
}
