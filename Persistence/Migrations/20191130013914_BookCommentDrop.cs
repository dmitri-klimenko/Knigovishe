using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class BookCommentDrop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookComments_Books_BookId",
                table: "BookComments");

            migrationBuilder.DropTable(
                name: "BookOpinions");

            migrationBuilder.AddForeignKey(
                name: "FK_BookComments_Books_BookId",
                table: "BookComments",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookComments_Books_BookId",
                table: "BookComments");

            migrationBuilder.CreateTable(
                name: "BookOpinions",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Accepted = table.Column<bool>(nullable: false),
                    AnswerText = table.Column<string>(nullable: true),
                    Share = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookOpinions", x => new { x.BookId, x.UserId });
                    table.ForeignKey(
                        name: "FK_BookOpinions_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookOpinions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookOpinions_UserId",
                table: "BookOpinions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookComments_Books_BookId",
                table: "BookComments",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
