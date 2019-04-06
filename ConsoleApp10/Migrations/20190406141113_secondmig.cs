using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class secondmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Group_Group_idGroupID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Group_idGroupID",
                table: "Students",
                newName: "Group_id");

            migrationBuilder.RenameIndex(
                name: "IX_Students_Group_idGroupID",
                table: "Students",
                newName: "IX_Students_Group_id");

            migrationBuilder.AddColumn<int>(
                name: "Calendar_id",
                table: "Course",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Calendar",
                columns: table => new
                {
                    AU_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendar", x => x.AU_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Calendar_id",
                table: "Course",
                column: "Calendar_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Calendar_Calendar_id",
                table: "Course",
                column: "Calendar_id",
                principalTable: "Calendar",
                principalColumn: "AU_id",
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
                name: "FK_Course_Calendar_Calendar_id",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Group_Group_id",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Calendar");

            migrationBuilder.DropIndex(
                name: "IX_Course_Calendar_id",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Calendar_id",
                table: "Course");

            migrationBuilder.RenameColumn(
                name: "Group_id",
                table: "Students",
                newName: "Group_idGroupID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_Group_id",
                table: "Students",
                newName: "IX_Students_Group_idGroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Group_Group_idGroupID",
                table: "Students",
                column: "Group_idGroupID",
                principalTable: "Group",
                principalColumn: "GroupID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
