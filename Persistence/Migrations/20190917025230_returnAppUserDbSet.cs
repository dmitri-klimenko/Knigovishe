using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class returnAppUserDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "UserSubscriptions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ActivationKeyType",
                table: "ActivationKeys",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivationKeyType",
                table: "ActivationKeys");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "UserSubscriptions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
