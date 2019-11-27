using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class ChangesInBookNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "BookNotes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateTime",
                table: "BookNotes",
                nullable: true);
        }
    }
}
