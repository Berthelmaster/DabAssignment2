using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseAssignment",
                columns: new[] { "Course_id", "Assignment_id" },
                values: new object[] { 1, 1234 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseAssignment",
                keyColumns: new[] { "Course_id", "Assignment_id" },
                keyValues: new object[] { 1, 1234 });
        }
    }
}
