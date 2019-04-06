using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class ForthMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_AssistantTeacher_AssistentTeacherAU_ID",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Teacher_TeacherAU_ID",
                table: "Assignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments");

            migrationBuilder.RenameTable(
                name: "Assignments",
                newName: "Assignment");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_TeacherAU_ID",
                table: "Assignment",
                newName: "IX_Assignment_TeacherAU_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_AssistentTeacherAU_ID",
                table: "Assignment",
                newName: "IX_Assignment_AssistentTeacherAU_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignment",
                table: "Assignment",
                column: "Assignment_Id");

            migrationBuilder.CreateTable(
                name: "Audios",
                columns: table => new
                {
                    Audio_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audios", x => x.Audio_id);
                });

            migrationBuilder.CreateTable(
                name: "GroupSignUpLink",
                columns: table => new
                {
                    GSUL_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupSignUpLink", x => x.GSUL_id);
                });

            migrationBuilder.CreateTable(
                name: "TextBlock",
                columns: table => new
                {
                    TextBlock_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextBlock", x => x.TextBlock_id);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Video_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Video_id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_AssistantTeacher_AssistentTeacherAU_ID",
                table: "Assignment",
                column: "AssistentTeacherAU_ID",
                principalTable: "AssistantTeacher",
                principalColumn: "AU_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Teacher_TeacherAU_ID",
                table: "Assignment",
                column: "TeacherAU_ID",
                principalTable: "Teacher",
                principalColumn: "AU_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_AssistantTeacher_AssistentTeacherAU_ID",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Teacher_TeacherAU_ID",
                table: "Assignment");

            migrationBuilder.DropTable(
                name: "Audios");

            migrationBuilder.DropTable(
                name: "GroupSignUpLink");

            migrationBuilder.DropTable(
                name: "TextBlock");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignment",
                table: "Assignment");

            migrationBuilder.RenameTable(
                name: "Assignment",
                newName: "Assignments");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_TeacherAU_ID",
                table: "Assignments",
                newName: "IX_Assignments_TeacherAU_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_AssistentTeacherAU_ID",
                table: "Assignments",
                newName: "IX_Assignments_AssistentTeacherAU_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments",
                column: "Assignment_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_AssistantTeacher_AssistentTeacherAU_ID",
                table: "Assignments",
                column: "AssistentTeacherAU_ID",
                principalTable: "AssistantTeacher",
                principalColumn: "AU_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Teacher_TeacherAU_ID",
                table: "Assignments",
                column: "TeacherAU_ID",
                principalTable: "Teacher",
                principalColumn: "AU_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
