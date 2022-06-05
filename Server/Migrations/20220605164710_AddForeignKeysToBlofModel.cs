using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    public partial class AddForeignKeysToBlofModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_categories_CategoryId",
                table: "blogs");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "blogs",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_blogs_CategoryId",
                table: "blogs",
                newName: "IX_blogs_Categories");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_categories_Categories",
                table: "blogs",
                column: "Categories",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_categories_Categories",
                table: "blogs");

            migrationBuilder.RenameColumn(
                name: "Categories",
                table: "blogs",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_blogs_Categories",
                table: "blogs",
                newName: "IX_blogs_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_categories_CategoryId",
                table: "blogs",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
