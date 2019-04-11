using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 1234, 1, 0, 10, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1423, 2, 0, 12, new DateTime(2019, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssistantTeacher",
                keyColumn: "AU_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AssistantTeacher",
                keyColumn: "AU_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Audios",
                keyColumn: "Audio_id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Audios",
                keyColumn: "Audio_id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "CourseContents",
                keyColumns: new[] { "Course_id", "Content_id" },
                keyValues: new object[] { 1, 1000 });

            migrationBuilder.DeleteData(
                table: "CourseContents",
                keyColumns: new[] { "Course_id", "Content_id" },
                keyValues: new object[] { 2, 1020 });

            migrationBuilder.DeleteData(
                table: "CourseEnrolledStudents",
                keyColumns: new[] { "AU_id", "Course_id" },
                keyValues: new object[] { 98, 1 });

            migrationBuilder.DeleteData(
                table: "CourseEnrolledStudents",
                keyColumns: new[] { "AU_id", "Course_id" },
                keyValues: new object[] { 99, 2 });

            migrationBuilder.DeleteData(
                table: "CourseGroup",
                keyColumns: new[] { "Course_id", "Group_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CourseGroup",
                keyColumns: new[] { "Course_id", "Group_id" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "Course_id", "AU_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CourseTeacher",
                keyColumns: new[] { "Course_id", "AU_id" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "GroupAssignment",
                keyColumns: new[] { "Assignment_ID", "GroupID" },
                keyValues: new object[] { 1234, 1 });

            migrationBuilder.DeleteData(
                table: "GroupAssignment",
                keyColumns: new[] { "Assignment_ID", "GroupID" },
                keyValues: new object[] { 1423, 2 });

            migrationBuilder.DeleteData(
                table: "GroupSignUpLink",
                keyColumn: "GSUL_id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "GroupSignUpLink",
                keyColumn: "GSUL_id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "TextBlock",
                keyColumn: "TextBlock_id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "TextBlock",
                keyColumn: "TextBlock_id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumn: "Video_id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Video",
                keyColumn: "Video_id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Assignment_Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Assignment_Id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "ContentArea",
                keyColumn: "Area_Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "ContentArea",
                keyColumn: "Area_Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Course_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Course_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AU_ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "AU_ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Calendar",
                keyColumn: "Calendar_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Calendar",
                keyColumn: "Calendar_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Content_Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Content_Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "GroupID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "GroupID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "AU_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teacher",
                keyColumn: "AU_ID",
                keyValue: 2);
        }
    }
}
