using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class engrenmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseGroup_Groups_Group_id",
                table: "CourseGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupAssignment_Groups_GroupID",
                table: "GroupAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_Group_id",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Group");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseGroup_Group_Group_id",
                table: "CourseGroup",
                column: "Group_id",
                principalTable: "Group",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupAssignment_Group_GroupID",
                table: "GroupAssignment",
                column: "GroupID",
                principalTable: "Group",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Group_Group_id",
                table: "Students",
                column: "Group_id",
                principalTable: "Group",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseGroup_Group_Group_id",
                table: "CourseGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupAssignment_Group_GroupID",
                table: "GroupAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Group_Group_id",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Groups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseGroup_Groups_Group_id",
                table: "CourseGroup",
                column: "Group_id",
                principalTable: "Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupAssignment_Groups_GroupID",
                table: "GroupAssignment",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_Group_id",
                table: "Students",
                column: "Group_id",
                principalTable: "Groups",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
