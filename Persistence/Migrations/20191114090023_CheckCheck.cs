using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class CheckCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "TotalPoints",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<float>(
                name: "Points",
                table: "Answers",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "Answers");

            migrationBuilder.AlterColumn<int>(
                name: "TotalPoints",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
