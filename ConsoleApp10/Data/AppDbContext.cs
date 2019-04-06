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


        //Dbsets for when we have to use the Data in any way. Also this will be used for seeding data into our Database
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Audio> Audios { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupSignUpLink> GroupSignUpLinks { get; set; }
        public DbSet<Students> Studentss { get; set; }
        public  DbSet<Teacher> Teachers { get; set; }
        public DbSet<TextBlock> TextBlocks { get; set; }
        public DbSet<Video> Videos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Many students have one Group
            modelBuilder.Entity<Students>()
                .HasOne(ba => ba.Group)
                .WithMany(b => b._Students)
                .HasForeignKey(bc => bc.Group_id)
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
                
            // Many Courses have one Calendar
            modelBuilder.Entity<Course>()
                .HasOne(ba => ba.Calendar)
                .WithMany(b => b.Courses)
                .HasForeignKey(bc => bc.Calendar_id)
                .IsRequired();

            // Many Courses have Many Content (Wow that doesn't sound very good)
            modelBuilder.Entity<CourseContent>()
                .HasKey(bc => new {bc.Course_id, bc.Content_id});
            modelBuilder.Entity<CourseContent>()
                .HasOne(bc => bc.Course)
                .WithMany(b => b.CourseContents)
                .HasForeignKey(ba => ba.Course_id);
            modelBuilder.Entity<CourseContent>()
                .HasOne(ba => ba.Content)
                .WithMany(b => b.CourseContents)
                .HasForeignKey(b => b.Content_id);
           

              

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
