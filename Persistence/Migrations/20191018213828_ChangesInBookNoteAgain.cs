using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class ChangesInBookNoteAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookNotes",
                table: "BookNotes");

            migrationBuilder.DropIndex(
                name: "IX_BookNotes_UserId",
                table: "BookNotes");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_BookNotes_BookId_UserId",
                table: "BookNotes",
                columns: new[] { "BookId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookNotes",
                table: "BookNotes",
                columns: new[] { "UserId", "BookId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_BookNotes_BookId_UserId",
                table: "BookNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookNotes",
                table: "BookNotes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookNotes",
                table: "BookNotes",
                columns: new[] { "BookId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_BookNotes_UserId",
                table: "BookNotes",
                column: "UserId");
        }
    }
}
