using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class ReduceMaxCharOfTitlePropertyTo90 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Texts",
                maxLength: 90,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Texts",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 90);
        }
    }
}
