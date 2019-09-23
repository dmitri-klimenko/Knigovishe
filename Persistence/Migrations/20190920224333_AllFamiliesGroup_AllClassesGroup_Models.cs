using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class AllFamiliesGroup_AllClassesGroup_Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Books_BookId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookRatings_Books_BookId",
                table: "BookRatings");

            migrationBuilder.DropColumn(
                name: "CalculatedRating",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "TimesCompleted",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumberPointsForCreatedBooks",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PercentageOfRightResponses",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumberOfClassesInAgeGroup",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumberOfStudentsInClass",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionInAgeGroupAccordingToTotalNumberOfAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionInAgeGroupAccordingToTotalNumberOfRightResponses",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionInAgeGroupAccordingToTotalPoints",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TopPercentageInAgeGroupAccordingToTotalNumberOfAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TopPercentageInAgeGroupAccordingToTotalNumberOfRightResponses",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TopPercentageInAgeGroupAccordingToTotalPoints",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalNumberOfAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalPercentageOfRightResponses",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalPoints",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumberOfFamiliesInAgeGroup",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumberOfStudentsInFamily",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Family_PositionInAgeGroupAccordingToTotalNumberOfAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Family_PositionInAgeGroupAccordingToTotalNumberOfRightResponses",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Family_PositionInAgeGroupAccordingToTotalPoints",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Family_TopPercentageInAgeGroupAccordingToTotalNumberOfAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Family_TopPercentageInAgeGroupAccordingToTotalNumberOfRightResponses",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Family_TopPercentageInAgeGroupAccordingToTotalPoints",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Family_TotalNumberOfAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Family_TotalPercentageOfRightResponses",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Family_TotalPoints",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionInClassAccordingToNumberOfAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionInClassAccordingToPercentageOfRightResponses",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionInClassAccordingToPoints",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionInFamilyAccordingToNumberOfAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionInFamilyAccordingToPercentageOfRightResponses",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PositionInFamilyAccordingToPoints",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PercentageOfRightResponses",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "PercentageOfSkippedQuestions",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "PercentageOfWrongResponses",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "Points",
                table: "AspNetUsers",
                newName: "PointsForCreatedBooks");

            migrationBuilder.AddColumn<int>(
                name: "AllClassesGroupId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AllFamiliesGroupId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AllCLassesGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllCLassesGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AllFamiliesGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllFamiliesGroup", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AllCLassesGroup",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "AllFamiliesGroup",
                column: "Id",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AllClassesGroupId",
                table: "AspNetUsers",
                column: "AllClassesGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AllFamiliesGroupId",
                table: "AspNetUsers",
                column: "AllFamiliesGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Books_BookId",
                table: "Answers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AllCLassesGroup_AllClassesGroupId",
                table: "AspNetUsers",
                column: "AllClassesGroupId",
                principalTable: "AllCLassesGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AllFamiliesGroup_AllFamiliesGroupId",
                table: "AspNetUsers",
                column: "AllFamiliesGroupId",
                principalTable: "AllFamiliesGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookRatings_Books_BookId",
                table: "BookRatings",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Books_BookId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AllCLassesGroup_AllClassesGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AllFamiliesGroup_AllFamiliesGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookRatings_Books_BookId",
                table: "BookRatings");

            migrationBuilder.DropTable(
                name: "AllCLassesGroup");

            migrationBuilder.DropTable(
                name: "AllFamiliesGroup");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AllClassesGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AllFamiliesGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AllClassesGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AllFamiliesGroupId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "PointsForCreatedBooks",
                table: "AspNetUsers",
                newName: "Points");

            migrationBuilder.AddColumn<float>(
                name: "CalculatedRating",
                table: "Books",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "TimesCompleted",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberPointsForCreatedBooks",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PercentageOfRightResponses",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfClassesInAgeGroup",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfStudentsInClass",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionInAgeGroupAccordingToTotalNumberOfAnswers",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionInAgeGroupAccordingToTotalNumberOfRightResponses",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionInAgeGroupAccordingToTotalPoints",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopPercentageInAgeGroupAccordingToTotalNumberOfAnswers",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopPercentageInAgeGroupAccordingToTotalNumberOfRightResponses",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopPercentageInAgeGroupAccordingToTotalPoints",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalNumberOfAnswers",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalPercentageOfRightResponses",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalPoints",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfFamiliesInAgeGroup",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfStudentsInFamily",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Family_PositionInAgeGroupAccordingToTotalNumberOfAnswers",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Family_PositionInAgeGroupAccordingToTotalNumberOfRightResponses",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Family_PositionInAgeGroupAccordingToTotalPoints",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Family_TopPercentageInAgeGroupAccordingToTotalNumberOfAnswers",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Family_TopPercentageInAgeGroupAccordingToTotalNumberOfRightResponses",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Family_TopPercentageInAgeGroupAccordingToTotalPoints",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Family_TotalNumberOfAnswers",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Family_TotalPercentageOfRightResponses",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Family_TotalPoints",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionInClassAccordingToNumberOfAnswers",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionInClassAccordingToPercentageOfRightResponses",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionInClassAccordingToPoints",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionInFamilyAccordingToNumberOfAnswers",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionInFamilyAccordingToPercentageOfRightResponses",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionInFamilyAccordingToPoints",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PercentageOfRightResponses",
                table: "Answers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PercentageOfSkippedQuestions",
                table: "Answers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PercentageOfWrongResponses",
                table: "Answers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Books_BookId",
                table: "Answers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookRatings_Books_BookId",
                table: "BookRatings",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
