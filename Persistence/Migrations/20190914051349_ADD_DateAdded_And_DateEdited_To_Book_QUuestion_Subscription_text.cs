using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class ADD_DateAdded_And_DateEdited_To_Book_QUuestion_Subscription_text : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateAdded",
                table: "Texts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateEdited",
                table: "Texts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateAdded",
                table: "Subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateEdited",
                table: "Subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateAdded",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateEdited",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateEdited",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "DateEdited",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "DateEdited",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "DateEdited",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "DateEdited",
                table: "Books");
        }
    }
}
