using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class AssistentTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Assignment_Id",
                keyValue: 1234,
                column: "AU_Id_Assistant",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Assignment_Id",
                keyValue: 1423,
                column: "AU_Id_Assistant",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Assignment_Id",
                keyValue: 1234,
                column: "AU_Id_Assistant",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Assignment_Id",
                keyValue: 1423,
                column: "AU_Id_Assistant",
                value: 0);
        }
    }
}
