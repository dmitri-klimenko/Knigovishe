using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class changesinApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressOfInstitution",
                table: "UserSubscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "UserSubscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "UserSubscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserSubscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Institution",
                table: "UserSubscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Person",
                table: "UserSubscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelephoneOfInstitution",
                table: "UserSubscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "UserSubscriptions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressOfInstitution",
                table: "UserSubscriptions");

            migrationBuilder.DropColumn(
                name: "City",
                table: "UserSubscriptions");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "UserSubscriptions");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserSubscriptions");

            migrationBuilder.DropColumn(
                name: "Institution",
                table: "UserSubscriptions");

            migrationBuilder.DropColumn(
                name: "Person",
                table: "UserSubscriptions");

            migrationBuilder.DropColumn(
                name: "TelephoneOfInstitution",
                table: "UserSubscriptions");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "UserSubscriptions");
        }
    }
}
