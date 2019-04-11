using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class ændret_Assistent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Teacher_AU_ID",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_AssistantTeacher_AU_Id_Assistant",
                table: "Assignment");

            migrationBuilder.AlterColumn<int>(
                name: "AU_Id_Assistant",
                table: "Assignment",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AU_ID",
                table: "Assignment",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Teacher_AU_ID",
                table: "Assignment",
                column: "AU_ID",
                principalTable: "Teacher",
                principalColumn: "AU_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_AssistantTeacher_AU_Id_Assistant",
                table: "Assignment",
                column: "AU_Id_Assistant",
                principalTable: "AssistantTeacher",
                principalColumn: "AU_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Teacher_AU_ID",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_AssistantTeacher_AU_Id_Assistant",
                table: "Assignment");

            migrationBuilder.AlterColumn<int>(
                name: "AU_Id_Assistant",
                table: "Assignment",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AU_ID",
                table: "Assignment",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Teacher_AU_ID",
                table: "Assignment",
                column: "AU_ID",
                principalTable: "Teacher",
                principalColumn: "AU_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_AssistantTeacher_AU_Id_Assistant",
                table: "Assignment",
                column: "AU_Id_Assistant",
                principalTable: "AssistantTeacher",
                principalColumn: "AU_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
