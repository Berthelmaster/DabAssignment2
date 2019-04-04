using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp10
{
    class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=Localhost;Database=DabAssignment;Integrated Security=True");

        }

        public DbSet<Assignment> Assignments { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Many students have one Group
            modelBuilder.Entity<Students>()
                .HasOne(ba => ba.Group_id)
                .WithMany(b => b._Students)
                .IsRequired();

            // Many students have Many Courses through CourseEnrolledmentStudent
            modelBuilder.Entity<CourseEnrolledStudents>()
                .HasKey(bw => new {bw.AU_id, bw.Course_id});
            modelBuilder.Entity<CourseEnrolledStudents>()
                .HasOne(ba => ba._Students)
                .WithMany(b => b.CourseEnrolledStudents)
                .HasForeignKey(bc => bc.AU_id);

                modelBuilder.Entity<CourseEnrolledStudents>()
                    .HasOne(bc => bc._Course)
                    .WithMany(b => b.CourseEnrolledStudents)
                    .HasForeignKey(bc => bc.Course_id);
                



             //one teacher many assignment 
             modelBuilder.Entity<Assignment>()
                .HasOne(p => p.Teacher)
                .WithMany(b => b.Assignments);
             //one AssistentTeacher many Assignment
             modelBuilder.Entity<Assignment>()
                .HasOne(p => p.AssistentTeacher)
                .WithMany(b => b.Assignments_);

        }


    }
}
