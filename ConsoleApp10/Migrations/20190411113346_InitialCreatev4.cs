using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class InitialCreatev4 : Migration
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
                    Name = table.Column<string>(nullable: true),
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
                    GraduationDate = table.Column<DateTime>(nullable: false),
                    Grade = table.Column<int>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "AssistantTeacher",
                columns: new[] { "AU_ID", "Birthday", "Name" },
                values: new object[,]
                {
                    { 3, new DateTime(1993, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mikkel Mortensen" },
                    { 4, new DateTime(1994, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thomas Thomsen" }
                });

            migrationBuilder.InsertData(
                table: "Calendar",
                columns: new[] { "Calendar_id", "CourseLecture", "Deadlines", "Handin" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2019, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Content",
                column: "Content_Id",
                values: new object[]
                {
                    1000,
                    1020
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "GroupID", "GroupSize" },
                values: new object[,]
                {
                    { 1, 3L },
                    { 2, 4L }
                });

            migrationBuilder.InsertData(
                table: "Teacher",
                columns: new[] { "AU_ID", "Birthday", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Henrik Hansen" },
                    { 2, new DateTime(1981, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poul Petersen" }
                });

            migrationBuilder.InsertData(
                table: "Assignment",
                columns: new[] { "Assignment_Id", "AU_ID", "AU_Id_Assistant", "Grades", "HandInDate" },
                values: new object[,]
                {
                    { 1234, 1, 3, 10, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1423, 2, 4, 12, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ContentArea",
                columns: new[] { "Area_Id", "Content_Id" },
                values: new object[,]
                {
                    { 1200, 1000 },
                    { 1900, 1020 }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Course_id", "Calendar_id", "Name", "Status" },
                values: new object[,]
                {
                    { 2, 1, "I4DAB", true },
                    { 1, 2, "I4GUI", true }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "AU_ID", "Birthday", "Group_id", "Name" },
                values: new object[,]
                {
                    { 98, new DateTime(1995, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hans Hansen" },
                    { 99, new DateTime(1996, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Frank Jepsersen" }
                });

            migrationBuilder.InsertData(
                table: "Audios",
                columns: new[] { "Audio_id", "Area_Id" },
                values: new object[,]
                {
                    { 402, 1200 },
                    { 401, 1900 }
                });

            migrationBuilder.InsertData(
                table: "CourseContents",
                columns: new[] { "Course_id", "Content_id" },
                values: new object[,]
                {
                    { 2, 1020 },
                    { 1, 1000 }
                });

            migrationBuilder.InsertData(
                table: "CourseEnrolledStudents",
                columns: new[] { "AU_id", "Course_id", "EnrolledDate", "Grade", "GraduationDate" },
                values: new object[,]
                {
                    { 99, 2, new DateTime(2017, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, 1, new DateTime(2017, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CourseGroup",
                columns: new[] { "Course_id", "Group_id" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "CourseTeacher",
                columns: new[] { "Course_id", "AU_id" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "GroupAssignment",
                columns: new[] { "Assignment_ID", "GroupID" },
                values: new object[,]
                {
                    { 1423, 2 },
                    { 1234, 1 }
                });

            migrationBuilder.InsertData(
                table: "GroupSignUpLink",
                columns: new[] { "GSUL_id", "Area_Id" },
                values: new object[,]
                {
                    { 301, 1900 },
                    { 302, 1200 }
                });

            migrationBuilder.InsertData(
                table: "TextBlock",
                columns: new[] { "TextBlock_id", "Area_Id" },
                values: new object[,]
                {
                    { 201, 1900 },
                    { 202, 1200 }
                });

            migrationBuilder.InsertData(
                table: "Video",
                columns: new[] { "Video_id", "Area_Id" },
                values: new object[,]
                {
                    { 102, 1900 },
                    { 101, 1200 }
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
