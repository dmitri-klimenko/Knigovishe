using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class Add3PropertiesToAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "CreatedBooks",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<int>(
                name: "TotalAnswers",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPercentage",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalPoints",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalPercentage",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalPoints",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<byte>(
                name: "Points",
                table: "CreatedBooks",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
