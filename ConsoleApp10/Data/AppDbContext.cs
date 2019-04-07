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
        // These also hold the shadow classes, I'm not sure, should these also be added?
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<Audio> Audios { get; set; }
        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<GroupSignUpLink> GroupSignUpLink { get; set; }
        public DbSet<Students> Students { get; set; }
        public  DbSet<Teacher> Teacher { get; set; }
        public DbSet<TextBlock> TextBlock { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<AssistantTeacher> AssistantTeacher { get; set; }
        public DbSet<ContentArea> ContentArea { get; set; }
        public DbSet<ContentFolder> ContentFolder { get; set; }
        public DbSet<CourseAssignment> CourseAssignment { get; set; }
        public DbSet<CourseContent> CourseContents { get; set; }
        public DbSet<CourseGroup> CourseGroup { get; set; }
        public DbSet<CourseEnrolledStudents> CourseEnrolledStudents { get; set; }
        public DbSet<CourseTeacher> CourseTeacher { get; set; }
        public DbSet<GroupAssignment> GroupAssignment { get; set; }

        
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

            // Many Courses have many Assignments
            modelBuilder.Entity<CourseAssignment>()
                .HasKey(bc => new {bc.Course_id, bc.Assignment_id});
            modelBuilder.Entity<CourseAssignment>()
                .HasOne(b => b.Course)
                .WithMany(ba => ba.CourseAssignments)
                .HasForeignKey(bf => bf.Course_id);
            modelBuilder.Entity<CourseAssignment>()
                .HasOne(ba => ba.Assignment)
                .WithMany(bc => bc.CourseAssignments)
                .HasForeignKey(b => b.Assignment_id);

            //Many Courses have many groups
            modelBuilder.Entity<CourseGroup>()
                .HasKey(bc => new {bc.Course_id, bc.Group_id});
            modelBuilder.Entity<CourseGroup>()
                .HasOne(b => b.Course)
                .WithMany(ba => ba.CourseGroups)
                .HasForeignKey(bc => bc.Course_id);
            modelBuilder.Entity<CourseGroup>()
                .HasOne(b => b.Group)
                .WithMany(bl => bl.CourseGroups)
                .HasForeignKey(bf => bf.Group_id);
           
             //one teacher many assignment 
             modelBuilder.Entity<Assignment>()
                .HasOne(p => p.Teacher)
                .WithMany(b => b.Assignments);
             //one AssistentTeacher many Assignment
             modelBuilder.Entity<Assignment>()
                .HasOne(p => p.AssistentTeacher)
                .WithMany(b => b.Assignments_);

             // Multiple Content areas to one content
             modelBuilder.Entity<ContentArea>()
                 .HasOne(c => c.Content)
                 .WithMany(ca => ca.ContentAreas);

             // Multiple Content folders to one content
             modelBuilder.Entity<ContentFolder>()
                 .HasOne(c => c.Content)
                 .WithMany(cf => cf.ContentFolders);

             // Multiple Content areas to one Content folder
             modelBuilder.Entity<ContentArea>()
                 .HasOne(cf => cf.Folder)
                 .WithMany(ca => ca.ContentAreas);

             // Multiple sub elements to one Content area
             modelBuilder.Entity<ContentArea>()
                 .HasMany(v => v.Videos)
                 .WithOne(ca => ca.ContentArea_Id);
             modelBuilder.Entity<ContentArea>()
                 .HasMany(gsul => gsul.GroupSignUpLinks)
                 .WithOne(ca => ca.ContentArea_Id);
             modelBuilder.Entity<ContentArea>()
                 .HasMany(tb => tb.TextBlocks)
                 .WithOne(ca => ca.ContentArea_Id);
             modelBuilder.Entity<ContentArea>()
                 .HasMany(a => a.Audios)
                 .WithOne(ca => ca.ContentArea_Id);
        }


    }
}
