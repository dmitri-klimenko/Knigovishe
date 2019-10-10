using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class remove2Paragraph : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paragraph2",
                table: "Texts");

            migrationBuilder.RenameColumn(
                name: "Paragraph9",
                table: "Texts",
                newName: "Paragraph2");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Paragraph2",
                table: "Texts",
                nullable: true);

            migrationBuilder.RenameColumn(
                name: "Paragraph2",
                table: "Texts",
                newName: "Paragraph9");
        }
    }
}
