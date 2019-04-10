﻿// <auto-generated />
using System;
using ConsoleApp10;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp10.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190409124503_secondAddMigration")]
    partial class secondAddMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp10.Assignment", b =>
                {
                    b.Property<int>("Assignment_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AU_ID");

                    b.Property<int>("AU_Id_Assistant");

                    b.Property<int>("Grades");

                    b.Property<DateTime>("HandInDate");

                    b.HasKey("Assignment_Id");

                    b.HasIndex("AU_ID");

                    b.HasIndex("AU_Id_Assistant");

                    b.ToTable("Assignment");
                });

            modelBuilder.Entity("ConsoleApp10.AssistantTeacher", b =>
                {
                    b.Property<int>("AU_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Name");

                    b.HasKey("AU_ID");

                    b.ToTable("AssistantTeacher");
                });

            modelBuilder.Entity("ConsoleApp10.Audio", b =>
                {
                    b.Property<int>("Audio_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Area_Id");

                    b.HasKey("Audio_id");

                    b.HasIndex("Area_Id");

                    b.ToTable("Audios");
                });

            modelBuilder.Entity("ConsoleApp10.Calendar", b =>
                {
                    b.Property<int>("Calendar_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CourseLecture");

                    b.Property<DateTime>("Deadlines");

                    b.Property<DateTime>("Handin");

                    b.HasKey("Calendar_id");

                    b.ToTable("Calendar");
                });

            modelBuilder.Entity("ConsoleApp10.Content", b =>
                {
                    b.Property<int>("Content_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Content_Id");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("ConsoleApp10.ContentArea", b =>
                {
                    b.Property<int>("Area_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Content_Id");

                    b.HasKey("Area_Id");

                    b.HasIndex("Content_Id");

                    b.ToTable("ContentArea");
                });

            modelBuilder.Entity("ConsoleApp10.Course", b =>
                {
                    b.Property<int>("Course_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calendar_id");

                    b.Property<string>("Name");

                    b.Property<bool>("Status");

                    b.HasKey("Course_id");

                    b.HasIndex("Calendar_id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ConsoleApp10.CourseAssignment", b =>
                {
                    b.Property<int>("Course_id");

                    b.Property<int>("Assignment_id");

                    b.HasKey("Course_id", "Assignment_id");

                    b.HasIndex("Assignment_id");

                    b.ToTable("CourseAssignment");
                });

            modelBuilder.Entity("ConsoleApp10.CourseContent", b =>
                {
                    b.Property<int>("Course_id");

                    b.Property<int>("Content_id");

                    b.HasKey("Course_id", "Content_id");

                    b.HasIndex("Content_id");

                    b.ToTable("CourseContents");
                });

            modelBuilder.Entity("ConsoleApp10.CourseEnrolledStudents", b =>
                {
                    b.Property<int>("AU_id");

                    b.Property<int>("Course_id");

                    b.Property<DateTime>("EnrolledDate");

                    b.Property<int>("Grade");

                    b.Property<DateTime>("GraduationDate");

                    b.HasKey("AU_id", "Course_id");

                    b.HasIndex("Course_id");

                    b.ToTable("CourseEnrolledStudents");
                });

            modelBuilder.Entity("ConsoleApp10.CourseGroup", b =>
                {
                    b.Property<int>("Course_id");

                    b.Property<int>("Group_id");

                    b.HasKey("Course_id", "Group_id");

                    b.HasIndex("Group_id");

                    b.ToTable("CourseGroup");
                });

            modelBuilder.Entity("ConsoleApp10.CourseTeacher", b =>
                {
                    b.Property<int>("Course_id");

                    b.Property<int>("AU_id");

                    b.HasKey("Course_id", "AU_id");

                    b.HasIndex("AU_id");

                    b.ToTable("CourseTeacher");
                });

            modelBuilder.Entity("ConsoleApp10.Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GroupSize");

                    b.HasKey("GroupID");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("ConsoleApp10.GroupAssignment", b =>
                {
                    b.Property<int>("Assignment_ID");

                    b.Property<int>("GroupID");

                    b.HasKey("Assignment_ID", "GroupID");

                    b.HasIndex("GroupID");

                    b.ToTable("GroupAssignment");
                });

            modelBuilder.Entity("ConsoleApp10.GroupSignUpLink", b =>
                {
                    b.Property<int>("GSUL_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Area_Id");

                    b.HasKey("GSUL_id");

                    b.HasIndex("Area_Id");

                    b.ToTable("GroupSignUpLink");
                });

            modelBuilder.Entity("ConsoleApp10.Students", b =>
                {
                    b.Property<int>("AU_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday");

                    b.Property<int>("Group_id");

                    b.Property<string>("Name");

                    b.HasKey("AU_ID");

                    b.HasIndex("Group_id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ConsoleApp10.Teacher", b =>
                {
                    b.Property<int>("AU_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Name");

                    b.HasKey("AU_ID");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("ConsoleApp10.TextBlock", b =>
                {
                    b.Property<int>("TextBlock_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Area_Id");

                    b.HasKey("TextBlock_id");

                    b.HasIndex("Area_Id");

                    b.ToTable("TextBlock");
                });

            modelBuilder.Entity("ConsoleApp10.Video", b =>
                {
                    b.Property<int>("Video_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Area_Id");

                    b.HasKey("Video_id");

                    b.HasIndex("Area_Id");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("ConsoleApp10.Assignment", b =>
                {
                    b.HasOne("ConsoleApp10.Teacher", "Teacher")
                        .WithMany("Assignments")
                        .HasForeignKey("AU_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleApp10.AssistantTeacher", "AssistentTeacher")
                        .WithMany("Assignments_")
                        .HasForeignKey("AU_Id_Assistant")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.Audio", b =>
                {
                    b.HasOne("ConsoleApp10.ContentArea", "ContentArea_Id")
                        .WithMany("Audios")
                        .HasForeignKey("Area_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.ContentArea", b =>
                {
                    b.HasOne("ConsoleApp10.Content", "Content")
                        .WithMany("ContentAreas")
                        .HasForeignKey("Content_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.Course", b =>
                {
                    b.HasOne("ConsoleApp10.Calendar", "Calendar")
                        .WithMany("Courses")
                        .HasForeignKey("Calendar_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.CourseAssignment", b =>
                {
                    b.HasOne("ConsoleApp10.Assignment", "Assignment")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("Assignment_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleApp10.Course", "Course")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("Course_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.CourseContent", b =>
                {
                    b.HasOne("ConsoleApp10.Content", "Content")
                        .WithMany("CourseContents")
                        .HasForeignKey("Content_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleApp10.Course", "Course")
                        .WithMany("CourseContents")
                        .HasForeignKey("Course_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.CourseEnrolledStudents", b =>
                {
                    b.HasOne("ConsoleApp10.Students", "_Students")
                        .WithMany("CourseEnrolledStudents")
                        .HasForeignKey("AU_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleApp10.Course", "_Course")
                        .WithMany("CourseEnrolledStudents")
                        .HasForeignKey("Course_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.CourseGroup", b =>
                {
                    b.HasOne("ConsoleApp10.Course", "Course")
                        .WithMany("CourseGroups")
                        .HasForeignKey("Course_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleApp10.Group", "Group")
                        .WithMany("CourseGroups")
                        .HasForeignKey("Group_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.CourseTeacher", b =>
                {
                    b.HasOne("ConsoleApp10.Teacher", "Teacher")
                        .WithMany("CourseTeachers")
                        .HasForeignKey("AU_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleApp10.Course", "Course")
                        .WithMany("CourseTeachers")
                        .HasForeignKey("Course_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.GroupAssignment", b =>
                {
                    b.HasOne("ConsoleApp10.Assignment", "Assignment")
                        .WithMany("GroupAssignment")
                        .HasForeignKey("Assignment_ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleApp10.Group", "Group")
                        .WithMany("GroupAssignment")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.GroupSignUpLink", b =>
                {
                    b.HasOne("ConsoleApp10.ContentArea", "ContentArea_Id")
                        .WithMany("GroupSignUpLinks")
                        .HasForeignKey("Area_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.Students", b =>
                {
                    b.HasOne("ConsoleApp10.Group", "Group")
                        .WithMany("_Students")
                        .HasForeignKey("Group_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.TextBlock", b =>
                {
                    b.HasOne("ConsoleApp10.ContentArea", "ContentArea_Id")
                        .WithMany("TextBlocks")
                        .HasForeignKey("Area_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp10.Video", b =>
                {
                    b.HasOne("ConsoleApp10.ContentArea", "ContentArea_Id")
                        .WithMany("Videos")
                        .HasForeignKey("Area_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
