using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class AddedStuffWithContentAndDownwards : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseContent_Content_Content_id",
                table: "CourseContent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseContent_Course_Course_id",
                table: "CourseContent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseContent",
                table: "CourseContent");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Calendar");

            migrationBuilder.RenameTable(
                name: "CourseContent",
                newName: "CourseContents");

            migrationBuilder.RenameColumn(
                name: "Birthday",
                table: "Calendar",
                newName: "Handin");

            migrationBuilder.RenameColumn(
                name: "AU_id",
                table: "Calendar",
                newName: "Calendar_id");

            migrationBuilder.RenameIndex(
                name: "IX_CourseContent_Content_id",
                table: "CourseContents",
                newName: "IX_CourseContents_Content_id");

            migrationBuilder.AddColumn<int>(
                name: "Area_Id",
                table: "Video",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Area_Id",
                table: "TextBlock",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Area_Id",
                table: "GroupSignUpLink",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CourseLecture",
                table: "Calendar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Deadlines",
                table: "Calendar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Area_Id",
                table: "Audios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseContents",
                table: "CourseContents",
                columns: new[] { "Course_id", "Content_id" });

            migrationBuilder.CreateTable(
                name: "ContentFolder",
                columns: table => new
                {
                    Folder_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentFolder", x => x.Folder_id);
                    table.ForeignKey(
                        name: "FK_ContentFolder_Content_Content_id",
                        column: x => x.Content_id,
                        principalTable: "Content",
                        principalColumn: "Content_Id",
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
                name: "ContentArea",
                columns: table => new
                {
                    Area_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content_Id = table.Column<int>(nullable: false),
                    Folder_Id = table.Column<int>(nullable: false)
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
                    table.ForeignKey(
                        name: "FK_ContentArea_ContentFolder_Folder_Id",
                        column: x => x.Folder_Id,
                        principalTable: "ContentFolder",
                        principalColumn: "Folder_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Video_Area_Id",
                table: "Video",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TextBlock_Area_Id",
                table: "TextBlock",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_GroupSignUpLink_Area_Id",
                table: "GroupSignUpLink",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Audios_Area_Id",
                table: "Audios",
                column: "Area_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ContentArea_Content_Id",
                table: "ContentArea",
                column: "Content_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ContentArea_Folder_Id",
                table: "ContentArea",
                column: "Folder_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ContentFolder_Content_id",
                table: "ContentFolder",
                column: "Content_id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssignment_Assignment_id",
                table: "CourseAssignment",
                column: "Assignment_id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGroup_Group_id",
                table: "CourseGroup",
                column: "Group_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Audios_ContentArea_Area_Id",
                table: "Audios",
                column: "Area_Id",
                principalTable: "ContentArea",
                principalColumn: "Area_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseContents_Content_Content_id",
                table: "CourseContents",
                column: "Content_id",
                principalTable: "Content",
                principalColumn: "Content_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseContents_Course_Course_id",
                table: "CourseContents",
                column: "Course_id",
                principalTable: "Course",
                principalColumn: "Course_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSignUpLink_ContentArea_Area_Id",
                table: "GroupSignUpLink",
                column: "Area_Id",
                principalTable: "ContentArea",
                principalColumn: "Area_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TextBlock_ContentArea_Area_Id",
                table: "TextBlock",
                column: "Area_Id",
                principalTable: "ContentArea",
                principalColumn: "Area_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Video_ContentArea_Area_Id",
                table: "Video",
                column: "Area_Id",
                principalTable: "ContentArea",
                principalColumn: "Area_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audios_ContentArea_Area_Id",
                table: "Audios");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseContents_Content_Content_id",
                table: "CourseContents");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseContents_Course_Course_id",
                table: "CourseContents");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSignUpLink_ContentArea_Area_Id",
                table: "GroupSignUpLink");

            migrationBuilder.DropForeignKey(
                name: "FK_TextBlock_ContentArea_Area_Id",
                table: "TextBlock");

            migrationBuilder.DropForeignKey(
                name: "FK_Video_ContentArea_Area_Id",
                table: "Video");

            migrationBuilder.DropTable(
                name: "ContentArea");

            migrationBuilder.DropTable(
                name: "CourseAssignment");

            migrationBuilder.DropTable(
                name: "CourseGroup");

            migrationBuilder.DropTable(
                name: "ContentFolder");

            migrationBuilder.DropIndex(
                name: "IX_Video_Area_Id",
                table: "Video");

            migrationBuilder.DropIndex(
                name: "IX_TextBlock_Area_Id",
                table: "TextBlock");

            migrationBuilder.DropIndex(
                name: "IX_GroupSignUpLink_Area_Id",
                table: "GroupSignUpLink");

            migrationBuilder.DropIndex(
                name: "IX_Audios_Area_Id",
                table: "Audios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseContents",
                table: "CourseContents");

            migrationBuilder.DropColumn(
                name: "Area_Id",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "Area_Id",
                table: "TextBlock");

            migrationBuilder.DropColumn(
                name: "Area_Id",
                table: "GroupSignUpLink");

            migrationBuilder.DropColumn(
                name: "CourseLecture",
                table: "Calendar");

            migrationBuilder.DropColumn(
                name: "Deadlines",
                table: "Calendar");

            migrationBuilder.DropColumn(
                name: "Area_Id",
                table: "Audios");

            migrationBuilder.RenameTable(
                name: "CourseContents",
                newName: "CourseContent");

            migrationBuilder.RenameColumn(
                name: "Handin",
                table: "Calendar",
                newName: "Birthday");

            migrationBuilder.RenameColumn(
                name: "Calendar_id",
                table: "Calendar",
                newName: "AU_id");

            migrationBuilder.RenameIndex(
                name: "IX_CourseContents_Content_id",
                table: "CourseContent",
                newName: "IX_CourseContent_Content_id");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Calendar",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseContent",
                table: "CourseContent",
                columns: new[] { "Course_id", "Content_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseContent_Content_Content_id",
                table: "CourseContent",
                column: "Content_id",
                principalTable: "Content",
                principalColumn: "Content_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseContent_Course_Course_id",
                table: "CourseContent",
                column: "Course_id",
                principalTable: "Course",
                principalColumn: "Course_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
