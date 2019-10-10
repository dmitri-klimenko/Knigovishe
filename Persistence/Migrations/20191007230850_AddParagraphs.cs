using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class AddParagraphs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description2",
                table: "Texts",
                newName: "Paragraph9");


            migrationBuilder.AddColumn<string>(
                name: "Paragraph10",
                table: "Texts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paragraph2",
                table: "Texts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paragraph3",
                table: "Texts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paragraph4",
                table: "Texts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paragraph5",
                table: "Texts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paragraph6",
                table: "Texts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paragraph7",
                table: "Texts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paragraph8",
                table: "Texts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paragraph10",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "Paragraph2",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "Paragraph3",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "Paragraph4",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "Paragraph5",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "Paragraph6",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "Paragraph7",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "Paragraph8",
                table: "Texts");

            migrationBuilder.RenameColumn(
                name: "Paragraph9",
                table: "Texts",
                newName: "Description2");

        }
    }
}
