﻿// <auto-generated />
using System;
using ConsoleApp10;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp10.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("AU_ID");

                    b.Property<int?>("AU_Id_Assistant");

                    b.Property<int?>("Grades");

                    b.Property<DateTime>("HandInDate");

                    b.HasKey("Assignment_Id");

                    b.HasIndex("AU_ID");

                    b.HasIndex("AU_Id_Assistant");

                    b.ToTable("Assignment");

                    b.HasData(
                        new
                        {
                            Assignment_Id = 1234,
                            AU_ID = 1,
                            AU_Id_Assistant = 3,
                            Grades = 10,
                            HandInDate = new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Assignment_Id = 1423,
                            AU_ID = 2,
                            AU_Id_Assistant = 4,
                            Grades = 12,
                            HandInDate = new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
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

                    b.HasData(
                        new
                        {
                            AU_ID = 3,
                            Birthday = new DateTime(1993, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Mikkel Mortensen"
                        },
                        new
                        {
                            AU_ID = 4,
                            Birthday = new DateTime(1994, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Thomas Thomsen"
                        });
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

                    b.HasData(
                        new
                        {
                            Audio_id = 401,
                            Area_Id = 1900
                        },
                        new
                        {
                            Audio_id = 402,
                            Area_Id = 1200
                        });
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

                    b.HasData(
                        new
                        {
                            Calendar_id = 1,
                            CourseLecture = new DateTime(2019, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadlines = new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Handin = new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Calendar_id = 2,
                            CourseLecture = new DateTime(2019, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Deadlines = new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Handin = new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ConsoleApp10.Content", b =>
                {
                    b.Property<int>("Content_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Content_Id");

                    b.ToTable("Content");

                    b.HasData(
                        new
                        {
                            Content_Id = 1000
                        },
                        new
                        {
                            Content_Id = 1020
                        });
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

                    b.HasData(
                        new
                        {
                            Area_Id = 1200,
                            Content_Id = 1000
                        },
                        new
                        {
                            Area_Id = 1900,
                            Content_Id = 1020
                        });
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

                    b.HasData(
                        new
                        {
                            Course_id = 1,
                            Calendar_id = 2,
                            Name = "I4GUI",
                            Status = true
                        },
                        new
                        {
                            Course_id = 2,
                            Calendar_id = 1,
                            Name = "I4DAB",
                            Status = true
                        });
                });

            modelBuilder.Entity("ConsoleApp10.CourseAssignment", b =>
                {
                    b.Property<int>("Course_id");

                    b.Property<int>("Assignment_id");

                    b.HasKey("Course_id", "Assignment_id");

                    b.HasIndex("Assignment_id");

                    b.ToTable("CourseAssignment");

                    b.HasData(
                        new
                        {
                            Course_id = 1,
                            Assignment_id = 1234
                        });
                });

            modelBuilder.Entity("ConsoleApp10.CourseContent", b =>
                {
                    b.Property<int>("Course_id");

                    b.Property<int>("Content_id");

                    b.HasKey("Course_id", "Content_id");

                    b.HasIndex("Content_id");

                    b.ToTable("CourseContents");

                    b.HasData(
                        new
                        {
                            Course_id = 1,
                            Content_id = 1000
                        },
                        new
                        {
                            Course_id = 2,
                            Content_id = 1020
                        });
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

                    b.HasData(
                        new
                        {
                            AU_id = 98,
                            Course_id = 1,
                            EnrolledDate = new DateTime(2017, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grade = 0,
                            GraduationDate = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            AU_id = 99,
                            Course_id = 2,
                            EnrolledDate = new DateTime(2017, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Grade = 0,
                            GraduationDate = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ConsoleApp10.CourseGroup", b =>
                {
                    b.Property<int>("Course_id");

                    b.Property<int>("Group_id");

                    b.HasKey("Course_id", "Group_id");

                    b.HasIndex("Group_id");

                    b.ToTable("CourseGroup");

                    b.HasData(
                        new
                        {
                            Course_id = 1,
                            Group_id = 1
                        },
                        new
                        {
                            Course_id = 2,
                            Group_id = 2
                        });
                });

            modelBuilder.Entity("ConsoleApp10.CourseTeacher", b =>
                {
                    b.Property<int>("Course_id");

                    b.Property<int>("AU_id");

                    b.HasKey("Course_id", "AU_id");

                    b.HasIndex("AU_id");

                    b.ToTable("CourseTeacher");

                    b.HasData(
                        new
                        {
                            Course_id = 1,
                            AU_id = 1
                        },
                        new
                        {
                            Course_id = 2,
                            AU_id = 2
                        });
                });

            modelBuilder.Entity("ConsoleApp10.Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GroupSize");

                    b.HasKey("GroupID");

                    b.ToTable("Group");

                    b.HasData(
                        new
                        {
                            GroupID = 1,
                            GroupSize = 3L
                        },
                        new
                        {
                            GroupID = 2,
                            GroupSize = 4L
                        });
                });

            modelBuilder.Entity("ConsoleApp10.GroupAssignment", b =>
                {
                    b.Property<int>("Assignment_ID");

                    b.Property<int>("GroupID");

                    b.HasKey("Assignment_ID", "GroupID");

                    b.HasIndex("GroupID");

                    b.ToTable("GroupAssignment");

                    b.HasData(
                        new
                        {
                            Assignment_ID = 1234,
                            GroupID = 1
                        },
                        new
                        {
                            Assignment_ID = 1423,
                            GroupID = 2
                        });
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

                    b.HasData(
                        new
                        {
                            GSUL_id = 301,
                            Area_Id = 1900
                        },
                        new
                        {
                            GSUL_id = 302,
                            Area_Id = 1200
                        });
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

                    b.HasData(
                        new
                        {
                            AU_ID = 98,
                            Birthday = new DateTime(1995, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Group_id = 1,
                            Name = "Hans Hansen"
                        },
                        new
                        {
                            AU_ID = 99,
                            Birthday = new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Group_id = 2,
                            Name = "Frank Jepsersen"
                        });
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

                    b.HasData(
                        new
                        {
                            AU_ID = 1,
                            Birthday = new DateTime(1980, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Henrik Hansen"
                        },
                        new
                        {
                            AU_ID = 2,
                            Birthday = new DateTime(1981, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Poul Petersen"
                        });
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

                    b.HasData(
                        new
                        {
                            TextBlock_id = 201,
                            Area_Id = 1900
                        },
                        new
                        {
                            TextBlock_id = 202,
                            Area_Id = 1200
                        });
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

                    b.HasData(
                        new
                        {
                            Video_id = 101,
                            Area_Id = 1200
                        },
                        new
                        {
                            Video_id = 102,
                            Area_Id = 1900
                        });
                });

            modelBuilder.Entity("ConsoleApp10.Assignment", b =>
                {
                    b.HasOne("ConsoleApp10.Teacher", "Teacher")
                        .WithMany("Assignments")
                        .HasForeignKey("AU_ID");

                    b.HasOne("ConsoleApp10.AssistantTeacher", "AssistentTeacher")
                        .WithMany("Assignments_")
                        .HasForeignKey("AU_Id_Assistant");
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
