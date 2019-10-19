using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class AddNameOfGroupPropertyTOClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameOfGroup",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameOfGroup",
                table: "AspNetUsers");
        }
    }
}
