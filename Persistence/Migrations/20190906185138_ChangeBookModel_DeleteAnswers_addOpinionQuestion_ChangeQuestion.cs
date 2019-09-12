using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class ChangeBookModel_DeleteAnswers_addOpinionQuestion_ChangeQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Books_BookId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "OpinionQuestion",
                table: "Books",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Books_BookId",
                table: "Answers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Books_BookId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "OpinionQuestion",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "QuestionType",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Books_BookId",
                table: "Answers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
