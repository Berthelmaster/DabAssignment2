using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class initialmigration : Migration
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
                name: "Calendar",
                columns: table => new
                {
                    Calendar_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CourseLecture = table.Column<DateTime>(nullable: false),
                    Handin = table.Column<DateTime>(nullable: false),
                    Deadlines = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendar", x => x.Calendar_id);
                });

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    Content_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Content_Id);
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
                name: "Course",
                columns: table => new
                {
                    Course_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<bool>(nullable: false),
                    Calendar_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Course_id);
                    table.ForeignKey(
                        name: "FK_Course_Calendar_Calendar_id",
                        column: x => x.Calendar_id,
                        principalTable: "Calendar",
                        principalColumn: "Calendar_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentArea",
                columns: table => new
                {
                    Area_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentArea", x => x.Area_Id);
                    table.ForeignKey(
                        name: "FK_ContentArea_Content_Content_Id",
                        column: x => x.Content_Id,
                        principalTable: "Content",
                        principalColumn: "Content_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    AU_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Group_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.AU_ID);
                    table.ForeignKey(
                        name: "FK_Students_Group_Group_id",
                        column: x => x.Group_id,
                        principalTable: "Group",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Assignment_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HandInDate = table.Column<DateTime>(nullable: false),
                    Grades = table.Column<int>(nullable: false),
                    AU_ID = table.Column<int>(nullable: false),
                    AU_Id_Assistant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.Assignment_Id);
                    table.ForeignKey(
                        name: "FK_Assignment_Teacher_AU_ID",
                        column: x => x.AU_ID,
                        principalTable: "Teacher",
                        principalColumn: "AU_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignment_AssistantTeacher_AU_Id_Assistant",
                        column: x => x.AU_Id_Assistant,
                        principalTable: "AssistantTeacher",
                        principalColumn: "AU_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseContents",
                columns: table => new
                {
                    Course_id = table.Column<int>(nullable: false),
                    Content_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseContents", x => new { x.Course_id, x.Content_id });
                    table.ForeignKey(
                        name: "FK_CourseContents_Content_Content_id",
                        column: x => x.Content_id,
                        principalTable: "Content",
                        principalColumn: "Content_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseContents_Course_Course_id",
                        column: x => x.Course_id,
                        principalTable: "Course",
                        principalColumn: "Course_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseGroup",
                columns: table => new
                {
                    Group_id = table.Column<int>(nullable: false),
                    Course_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseGroup", x => new { x.Course_id, x.Group_id });
                    table.ForeignKey(
                        name: "FK_CourseGroup_Course_Course_id",
                        column: x => x.Course_id,
                        principalTable: "Course",
                        principalColumn: "Course_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseGroup_Group_Group_id",
                        column: x => x.Group_id,
                        principalTable: "Group",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseTeacher",
                columns: table => new
                {
                    AU_id = table.Column<int>(nullable: false),
                    Course_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTeacher", x => new { x.Course_id, x.AU_id });
                    table.ForeignKey(
                        name: "FK_CourseTeacher_Teacher_AU_id",
                        column: x => x.AU_id,
                        principalTable: "Teacher",
                        principalColumn: "AU_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTeacher_Course_Course_id",
                        column: x => x.Course_id,
                        principalTable: "Course",
                        principalColumn: "Course_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Audios",
                columns: table => new
                {
                    Audio_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Area_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audios", x => x.Audio_id);
                    table.ForeignKey(
                        name: "FK_Audios_ContentArea_Area_Id",
                        column: x => x.Area_Id,
                        principalTable: "ContentArea",
                        principalColumn: "Area_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupSignUpLink",
                columns: table => new
                {
                    GSUL_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Area_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupSignUpLink", x => x.GSUL_id);
                    table.ForeignKey(
                        name: "FK_GroupSignUpLink_ContentArea_Area_Id",
                        column: x => x.Area_Id,
                        principalTable: "ContentArea",
                        principalColumn: "Area_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TextBlock",
                columns: table => new
                {
                    TextBlock_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Area_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextBlock", x => x.TextBlock_id);
                    table.ForeignKey(
                        name: "FK_TextBlock_ContentArea_Area_Id",
                        column: x => x.Area_Id,
                        principalTable: "ContentArea",
                        principalColumn: "Area_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Video_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Area_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Video_id);
                    table.ForeignKey(
                        name: "FK_Video_ContentArea_Area_Id",
                        column: x => x.Area_Id,
                        principalTable: "ContentArea",
                        principalColumn: "Area_Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "CourseAssignment",
                columns: table => new
                {
                    Course_id = table.Column<int>(nullable: false),
                    Assignment_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseAssignment", x => new { x.Course_id, x.Assignment_id });
                    table.ForeignKey(
                        name: "FK_CourseAssignment_Assignment_Assignment_id",
                        column: x => x.Assignment_id,
                        principalTable: "Assignment",
                        principalColumn: "Assignment_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseAssignment_Course_Course_id",
                        column: x => x.Course_id,
                        principalTable: "Course",
                        principalColumn: "Course_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupAssignment",
                columns: table => new
                {
                    GroupID = table.Column<int>(nullable: false),
                    Assignment_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupAssignment", x => new { x.Assignment_ID, x.GroupID });
                    table.ForeignKey(
                        name: "FK_GroupAssignment_Assignment_Assignment_ID",
                        column: x => x.Assignment_ID,
                        principalTable: "Assignment",
                        principalColumn: "Assignment_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupAssignment_Group_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Group",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_AU_ID",
                table: "Assignment",
                column: "AU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_AU_Id_Assistant",
                table: "Assignment",
                column: "AU_Id_Assistant");

            migrationBuilder.CreateIndex(
                name: "IX_Audios_Area_Id",
                table: "Audios",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ContentArea_Content_Id",
                table: "ContentArea",
                column: "Content_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Calendar_id",
                table: "Course",
                column: "Calendar_id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssignment_Assignment_id",
                table: "CourseAssignment",
                column: "Assignment_id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseContents_Content_id",
                table: "CourseContents",
                column: "Content_id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseEnrolledStudents_Course_id",
                table: "CourseEnrolledStudents",
                column: "Course_id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGroup_Group_id",
                table: "CourseGroup",
                column: "Group_id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTeacher_AU_id",
                table: "CourseTeacher",
                column: "AU_id");

            migrationBuilder.CreateIndex(
                name: "IX_GroupAssignment_GroupID",
                table: "GroupAssignment",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupSignUpLink_Area_Id",
                table: "GroupSignUpLink",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Group_id",
                table: "Students",
                column: "Group_id");

            migrationBuilder.CreateIndex(
                name: "IX_TextBlock_Area_Id",
                table: "TextBlock",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Video_Area_Id",
                table: "Video",
                column: "Area_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audios");

            migrationBuilder.DropTable(
                name: "CourseAssignment");

            migrationBuilder.DropTable(
                name: "CourseContents");

            migrationBuilder.DropTable(
                name: "CourseEnrolledStudents");

            migrationBuilder.DropTable(
                name: "CourseGroup");

            migrationBuilder.DropTable(
                name: "CourseTeacher");

            migrationBuilder.DropTable(
                name: "GroupAssignment");

            migrationBuilder.DropTable(
                name: "GroupSignUpLink");

            migrationBuilder.DropTable(
                name: "TextBlock");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "ContentArea");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Calendar");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "AssistantTeacher");

            migrationBuilder.DropTable(
                name: "Content");
        }
    }
}
