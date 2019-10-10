using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class ChangesInTextModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "Texts");

            migrationBuilder.RenameColumn(
                name: "Namespace",
                table: "Texts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Texts",
                newName: "Paragraph1");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Texts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TextType",
                table: "Texts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "TextType",
                table: "Texts");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Texts",
                newName: "Namespace");

            migrationBuilder.RenameColumn(
                name: "Paragraph1",
                table: "Texts",
                newName: "Content");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Texts",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
