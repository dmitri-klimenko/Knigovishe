using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class ChangesInBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfComprehensionQuestions",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "NumberOfContentQuestions",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "NumberOfOpinionQuestions",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfComprehensionQuestions",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfContentQuestions",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfOpinionQuestions",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }
    }
}
