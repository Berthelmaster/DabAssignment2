using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp10.Migrations
{
    public partial class FullyDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentArea_Content_Content_Id",
                table: "ContentArea");

            migrationBuilder.DropForeignKey(
                name: "FK_ContentArea_ContentFolder_Folder_Id",
                table: "ContentArea");

            migrationBuilder.DropIndex(
                name: "IX_ContentArea_Content_Id",
                table: "ContentArea");

            migrationBuilder.RenameColumn(
                name: "Folder_Id",
                table: "ContentArea",
                newName: "Folder_id");

            migrationBuilder.RenameIndex(
                name: "IX_ContentArea_Folder_Id",
                table: "ContentArea",
                newName: "IX_ContentArea_Folder_id");

            migrationBuilder.AlterColumn<int>(
                name: "Folder_id",
                table: "ContentArea",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Folder_Id",
                table: "ContentArea",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ContentArea_Folder_Id",
                table: "ContentArea",
                column: "Folder_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentArea_Content_Folder_Id",
                table: "ContentArea",
                column: "Folder_Id",
                principalTable: "Content",
                principalColumn: "Content_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentArea_ContentFolder_Folder_id",
                table: "ContentArea",
                column: "Folder_id",
                principalTable: "ContentFolder",
                principalColumn: "Folder_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentArea_Content_Folder_Id",
                table: "ContentArea");

            migrationBuilder.DropForeignKey(
                name: "FK_ContentArea_ContentFolder_Folder_id",
                table: "ContentArea");

            migrationBuilder.DropIndex(
                name: "IX_ContentArea_Folder_Id",
                table: "ContentArea");

            migrationBuilder.DropColumn(
                name: "Folder_Id",
                table: "ContentArea");

            migrationBuilder.RenameColumn(
                name: "Folder_id",
                table: "ContentArea",
                newName: "Folder_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ContentArea_Folder_id",
                table: "ContentArea",
                newName: "IX_ContentArea_Folder_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Folder_Id",
                table: "ContentArea",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentArea_Content_Id",
                table: "ContentArea",
                column: "Content_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentArea_Content_Content_Id",
                table: "ContentArea",
                column: "Content_Id",
                principalTable: "Content",
                principalColumn: "Content_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContentArea_ContentFolder_Folder_Id",
                table: "ContentArea",
                column: "Folder_Id",
                principalTable: "ContentFolder",
                principalColumn: "Folder_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
