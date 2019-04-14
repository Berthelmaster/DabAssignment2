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
            builder.UseSqlServer(@"Server=Localhost;Database=DabAssignmentV4;Integrated Security=True");
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
                .HasForeignKey(bc => bc.Group_id);

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
               .WithMany(b => b.Assignments)
               .HasForeignKey(b2 => b2.AU_ID);

            //one AssistentTeacher many Assignment
            modelBuilder.Entity<Assignment>()
               .HasOne(p => p.AssistentTeacher)
               .WithMany(b => b.Assignments_)
               .HasForeignKey(b1 => b1.AU_Id_Assistant);

             // Multiple Content areas to one content
             modelBuilder.Entity<ContentArea>()
                 .HasOne(c => c.Content)
                 .WithMany(ca => ca.ContentAreas);
                 

             // Subelements of content are foreignkeys
             modelBuilder.Entity<GroupSignUpLink>()
                 .HasOne(ca => ca.ContentArea_Id)
                 .WithMany(gsul => gsul.GroupSignUpLinks)
                 .HasForeignKey(ca => ca.Area_Id);

             modelBuilder.Entity<Audio>()
                 .HasOne(ca => ca.ContentArea_Id)
                 .WithMany(a => a.Audios)
                 .HasForeignKey(ca => ca.Area_Id);

             modelBuilder.Entity<TextBlock>()
                 .HasOne(ca => ca.ContentArea_Id)
                 .WithMany(tb => tb.TextBlocks)
                 .HasForeignKey(ca => ca.Area_Id);

             modelBuilder.Entity<Video>()
                 .HasOne(ca => ca.ContentArea_Id)
                 .WithMany(v=> v.Videos)
                 .HasForeignKey(ca => ca.Area_Id);
             
            // many to many GroupAssignment, many groups many assignments
            modelBuilder.Entity<GroupAssignment>()
                .HasKey(ga => new { ga.Assignment_ID, ga.GroupID });
            modelBuilder.Entity<GroupAssignment>()
                .HasOne(p => p.Group)
                .WithMany(p => p.GroupAssignment)
                .HasForeignKey(ga => ga.GroupID);
            modelBuilder.Entity<GroupAssignment>()
                .HasOne(a => a.Assignment)
                .WithMany(a => a.GroupAssignment)
                .HasForeignKey(ga => ga.Assignment_ID);

            //Many Courses have many teachers
            modelBuilder.Entity<CourseTeacher>()
                 .HasKey(ct => new { ct.Course_id, ct.AU_id});
             modelBuilder.Entity<CourseTeacher>()
                 .HasOne(c => c.Course)
                 .WithMany( ct=> ct.CourseTeachers)
                 .HasForeignKey(bc => bc.Course_id);
             modelBuilder.Entity<CourseTeacher>()
                 .HasOne(t => t.Teacher)
                 .WithMany(ct => ct.CourseTeachers)
                 .HasForeignKey(ct => ct.AU_id);

            //Seeding Data in Database 
            //Teachers
            modelBuilder.Entity<Teacher>().HasData(new Teacher { AU_ID = 0001, Name = "Henrik Hansen", Birthday = new DateTime(1980, 4, 21) });
            modelBuilder.Entity<Teacher>().HasData(new Teacher { AU_ID = 0002, Name = "Poul Petersen", Birthday = new DateTime(1981, 5, 22) });

            //Assistent teacher
            modelBuilder.Entity<AssistantTeacher>().HasData(new AssistantTeacher { AU_ID = 0003, Name = "Mikkel Mortensen", Birthday = new DateTime(1993, 9, 15) });
            modelBuilder.Entity<AssistantTeacher>().HasData(new AssistantTeacher { AU_ID = 0004, Name = "Thomas Thomsen", Birthday = new DateTime(1994, 10, 16) });

            //Group
            modelBuilder.Entity<Group>().HasData(new Group { GroupID = 001, GroupSize = 3 });
            modelBuilder.Entity<Group>().HasData(new Group { GroupID = 002, GroupSize = 4 });

            //Calendar
            modelBuilder.Entity<Calendar>().HasData(new Calendar { Calendar_id = 001, CourseLecture = new DateTime(2019, 4, 8), Handin = new DateTime(2019, 4, 12), Deadlines = new DateTime(2019, 4, 15) });
            modelBuilder.Entity<Calendar>().HasData(new Calendar { Calendar_id = 002, CourseLecture = new DateTime(2019, 5, 9), Handin = new DateTime(2019, 5, 20), Deadlines = new DateTime(2019, 5, 20) });

            //Course
            modelBuilder.Entity<Course>().HasData(new Course { Course_id = 001, Name = "I4GUI", Status = true, Calendar_id = 002 });
            modelBuilder.Entity<Course>().HasData(new Course { Course_id = 002, Name = "I4DAB", Status = true, Calendar_id = 001 });

            //Course Teachers
            modelBuilder.Entity<CourseTeacher>().HasData(new CourseTeacher { AU_id = 0001, Course_id = 001 });
            modelBuilder.Entity<CourseTeacher>().HasData(new CourseTeacher { AU_id = 0002, Course_id = 002 });

            //Course Group
            modelBuilder.Entity<CourseGroup>().HasData(new CourseGroup { Group_id = 001, Course_id = 001 });
            modelBuilder.Entity<CourseGroup>().HasData(new CourseGroup { Group_id = 002, Course_id = 002 });

            //Students
            modelBuilder.Entity<Students>().HasData(new Students { AU_ID = 0098, Name = "Hans Hansen", Birthday = new DateTime(1995, 6, 10), Group_id = 001});
            modelBuilder.Entity<Students>().HasData(new Students { AU_ID = 0099, Name = "Frank Jepsersen", Birthday = new DateTime(1996, 3, 17), Group_id = 002 });

            //CoursesEnrolledStudents
            modelBuilder.Entity<CourseEnrolledStudents>().HasData(new CourseEnrolledStudents { Course_id = 001, AU_id = 0098, EnrolledDate = new DateTime(2017, 9, 1), GraduationDate = new DateTime(2021, 2, 1) });
            modelBuilder.Entity<CourseEnrolledStudents>().HasData(new CourseEnrolledStudents { Course_id = 002, AU_id = 0099, EnrolledDate = new DateTime(2017, 9, 1), GraduationDate = new DateTime(2021, 2, 1) });

            //Assignment
            modelBuilder.Entity<Assignment>().HasData(new Assignment { Assignment_Id = 1234, HandInDate = new DateTime(2019, 4, 12), Grades = 10, AU_ID = 0001, AU_Id_Assistant = 0003 });
            modelBuilder.Entity<Assignment>().HasData(new Assignment { Assignment_Id = 1423, HandInDate = new DateTime(2019, 4, 12), Grades = 12, AU_ID = 0002, AU_Id_Assistant = 0004 });

            //GroupAssignment
            modelBuilder.Entity<GroupAssignment>().HasData(new GroupAssignment { GroupID = 001, Assignment_ID = 1234});
            modelBuilder.Entity<GroupAssignment>().HasData(new GroupAssignment { GroupID = 002, Assignment_ID = 1423 });

            //Content
            modelBuilder.Entity<Content>().HasData(new Content { Content_Id = 1000});
            modelBuilder.Entity<Content>().HasData(new Content { Content_Id = 1020});

            //CourseContent
            modelBuilder.Entity<CourseContent>().HasData(new CourseContent { Course_id = 001, Content_id = 1000 });
            modelBuilder.Entity<CourseContent>().HasData(new CourseContent { Course_id = 002, Content_id = 1020 });

            //CourseAssignemnts
            modelBuilder.Entity<CourseAssignment>().HasData(new CourseAssignment {Course_id = 001, Assignment_id = 1234});

            //ContentArea
            modelBuilder.Entity<ContentArea>().HasData(new ContentArea { Area_Id = 1200, Content_Id = 1000 });
            modelBuilder.Entity<ContentArea>().HasData(new ContentArea { Area_Id = 1900, Content_Id = 1020 });

            //Video
            modelBuilder.Entity<Video>().HasData(new Video { Video_id = 101, Area_Id = 1200 });
            modelBuilder.Entity<Video>().HasData(new Video { Video_id = 102, Area_Id = 1900 });

            //TextBlock 
            modelBuilder.Entity<TextBlock>().HasData(new TextBlock { TextBlock_id = 201, Area_Id = 1900 });
            modelBuilder.Entity<TextBlock>().HasData(new TextBlock { TextBlock_id = 202, Area_Id = 1200 });

            //GroupSignUpLinks
            modelBuilder.Entity<GroupSignUpLink>().HasData(new GroupSignUpLink { GSUL_id = 301, Area_Id = 1900 });
            modelBuilder.Entity<GroupSignUpLink>().HasData(new GroupSignUpLink { GSUL_id = 302, Area_Id = 1200 });

            //Audio
            modelBuilder.Entity<Audio>().HasData(new Audio { Audio_id = 401, Area_Id = 1900 });
            modelBuilder.Entity<Audio>().HasData(new Audio { Audio_id = 402, Area_Id = 1200 });

        }

    }
}
