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
    [Migration("20190406141113_secondmig")]
    partial class secondmig
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

                    b.Property<int?>("AssistentTeacherAU_ID");

                    b.Property<int>("Grades");

                    b.Property<DateTime>("HandInDate");

                    b.Property<int?>("TeacherAU_ID");

                    b.HasKey("Assignment_Id");

                    b.HasIndex("AssistentTeacherAU_ID");

                    b.HasIndex("TeacherAU_ID");

                    b.ToTable("Assignments");
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

            modelBuilder.Entity("ConsoleApp10.Calendar", b =>
                {
                    b.Property<int>("AU_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Name");

                    b.HasKey("AU_id");

                    b.ToTable("Calendar");
                });

            modelBuilder.Entity("ConsoleApp10.Course", b =>
                {
                    b.Property<int>("Course_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calendar_id");

                    b.Property<bool>("Status");

                    b.HasKey("Course_id");

                    b.HasIndex("Calendar_id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ConsoleApp10.CourseEnrolledStudents", b =>
                {
                    b.Property<int>("AU_id");

                    b.Property<int>("Course_id");

                    b.Property<DateTime>("EnrolledDate");

                    b.Property<DateTime>("GraduationDate");

                    b.HasKey("AU_id", "Course_id");

                    b.HasIndex("Course_id");

                    b.ToTable("CourseEnrolledStudents");
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

            modelBuilder.Entity("ConsoleApp10.Assignment", b =>
                {
                    b.HasOne("ConsoleApp10.AssistantTeacher", "AssistentTeacher")
                        .WithMany("Assignments_")
                        .HasForeignKey("AssistentTeacherAU_ID");

                    b.HasOne("ConsoleApp10.Teacher", "Teacher")
                        .WithMany("Assignments")
                        .HasForeignKey("TeacherAU_ID");
                });

            modelBuilder.Entity("ConsoleApp10.Course", b =>
                {
                    b.HasOne("ConsoleApp10.Calendar", "Calendar")
                        .WithMany("Courses")
                        .HasForeignKey("Calendar_id")
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

            modelBuilder.Entity("ConsoleApp10.Students", b =>
                {
                    b.HasOne("ConsoleApp10.Group", "Group")
                        .WithMany("_Students")
                        .HasForeignKey("Group_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
