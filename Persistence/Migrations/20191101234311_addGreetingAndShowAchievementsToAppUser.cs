using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class addGreetingAndShowAchievementsToAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GreetingName",
                table: "AspNetUsers",
                newName: "Greeting");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Greeting",
                table: "AspNetUsers",
                newName: "GreetingName");
        }
    }
}
