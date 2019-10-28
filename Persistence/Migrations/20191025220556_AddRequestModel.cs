using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class AddRequestModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Requests",
                newName: "StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Requests",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_StudentId",
                table: "Requests",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_AspNetUsers_StudentId",
                table: "Requests",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_AspNetUsers_StudentId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_StudentId",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Requests",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Requests",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
