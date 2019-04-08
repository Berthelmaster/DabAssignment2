using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class AddedCourseTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_CourseTeacher_AU_id",
                table: "CourseTeacher",
                column: "AU_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTeacher");
        }
    }
}
