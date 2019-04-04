using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssistantTeacher",
                columns: table => new
                {
                    AU_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssistantTeacher", x => x.AU_ID);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Course_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Course_id);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupSize = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupID);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    AU_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.AU_ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    AU_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Group_idGroupID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.AU_ID);
                    table.ForeignKey(
                        name: "FK_Students_Group_Group_idGroupID",
                        column: x => x.Group_idGroupID,
                        principalTable: "Group",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Assignment_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HandInDate = table.Column<DateTime>(nullable: false),
                    Grades = table.Column<int>(nullable: false),
                    TeacherAU_ID = table.Column<int>(nullable: true),
                    AssistentTeacherAU_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Assignment_Id);
                    table.ForeignKey(
                        name: "FK_Assignments_AssistantTeacher_AssistentTeacherAU_ID",
                        column: x => x.AssistentTeacherAU_ID,
                        principalTable: "AssistantTeacher",
                        principalColumn: "AU_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignments_Teacher_TeacherAU_ID",
                        column: x => x.TeacherAU_ID,
                        principalTable: "Teacher",
                        principalColumn: "AU_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseEnrolledStudents",
                columns: table => new
                {
                    Course_id = table.Column<int>(nullable: false),
                    AU_id = table.Column<int>(nullable: false),
                    EnrolledDate = table.Column<DateTime>(nullable: false),
                    GraduationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseEnrolledStudents", x => new { x.AU_id, x.Course_id });
                    table.ForeignKey(
                        name: "FK_CourseEnrolledStudents_Students_AU_id",
                        column: x => x.AU_id,
                        principalTable: "Students",
                        principalColumn: "AU_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseEnrolledStudents_Course_Course_id",
                        column: x => x.Course_id,
                        principalTable: "Course",
                        principalColumn: "Course_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_AssistentTeacherAU_ID",
                table: "Assignments",
                column: "AssistentTeacherAU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_TeacherAU_ID",
                table: "Assignments",
                column: "TeacherAU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseEnrolledStudents_Course_id",
                table: "CourseEnrolledStudents",
                column: "Course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Group_idGroupID",
                table: "Students",
                column: "Group_idGroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "CourseEnrolledStudents");

            migrationBuilder.DropTable(
                name: "AssistantTeacher");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Group");
        }
    }
}
