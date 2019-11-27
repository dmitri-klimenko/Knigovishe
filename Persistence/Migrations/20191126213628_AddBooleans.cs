using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class AddBooleans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Answers");

            migrationBuilder.AddColumn<bool>(
                name: "Share",
                table: "BookOpinions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Share",
                table: "BookComments",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Share",
                table: "BookOpinions");

            migrationBuilder.DropColumn(
                name: "Share",
                table: "BookComments");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Answers",
                nullable: false,
                defaultValue: 0);
        }
    }
}
