using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class ChangeAcceptedPropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Accepted",
                table: "BookOpinions",
                newName: "Approved");

            migrationBuilder.RenameColumn(
                name: "Accepted",
                table: "BookComments",
                newName: "Approved");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Approved",
                table: "BookOpinions",
                newName: "Accepted");

            migrationBuilder.RenameColumn(
                name: "Approved",
                table: "BookComments",
                newName: "Accepted");
        }
    }
}
