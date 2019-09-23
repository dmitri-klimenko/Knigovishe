using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class AddColumnDateEditedToApplicationUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfAnswers",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "DateEdited",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEdited",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfAnswers",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
