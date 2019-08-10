using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class AddingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfCreatedBooks",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberPointsForCreatedBooks",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<string>(
                name: "School",
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

            migrationBuilder.AddColumn<string>(
                name: "UserId",
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

            migrationBuilder.AddColumn<bool>(
                name: "ShowAchievements",
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

            migrationBuilder.AddColumn<string>(
                name: "Family_UserId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassStudentBelongsToId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyStudentBelongsToId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GreetingName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfAnswers",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParentEmail",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PercentageOfRightResponses",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Points",
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

            migrationBuilder.AddColumn<string>(
                name: "Student_School",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Student_UserId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    BookAuthor = table.Column<string>(maxLength: 255, nullable: false),
                    Publisher = table.Column<string>(maxLength: 255, nullable: false),
                    YearPublished = table.Column<string>(maxLength: 4, nullable: false),
                    Translator = table.Column<string>(nullable: true),
                    BookCategory = table.Column<int>(nullable: false),
                    Isbn1 = table.Column<string>(nullable: false),
                    Isbn2 = table.Column<string>(nullable: true),
                    NumberOfPages = table.Column<int>(nullable: false),
                    CalculatedRating = table.Column<float>(nullable: false),
                    CoverPhoto = table.Column<string>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    NumberOfContentQuestions = table.Column<int>(nullable: false),
                    NumberOfComprehensionQuestions = table.Column<int>(nullable: false),
                    IsShortForm = table.Column<bool>(nullable: false),
                    Tags = table.Column<string>(nullable: false),
                    DateAdded = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    QuestionsAuthor = table.Column<string>(nullable: false),
                    AddedByAdmin = table.Column<string>(nullable: true),
                    PartOfSchoolProgramAtGrade = table.Column<int>(nullable: false),
                    TimesCompleted = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceivedMessages",
                columns: table => new
                {
                    SenderId = table.Column<string>(nullable: false),
                    ReceiverId = table.Column<string>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Topic = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivedMessages", x => new { x.ReceiverId, x.SenderId });
                    table.ForeignKey(
                        name: "FK_ReceivedMessages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReceivedMessages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SentMessages",
                columns: table => new
                {
                    SenderId = table.Column<string>(nullable: false),
                    ReceiverId = table.Column<string>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Topic = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentMessages", x => new { x.ReceiverId, x.SenderId });
                    table.ForeignKey(
                        name: "FK_SentMessages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SentMessages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ActivationCode = table.Column<string>(nullable: true),
                    SubscribeDateTime = table.Column<DateTime>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    BankData = table.Column<string>(nullable: true),
                    SchoolYear = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    NumberOfWriteResponses = table.Column<int>(nullable: false),
                    NumberOfWrongResponses = table.Column<int>(nullable: false),
                    NumberOfSkippedQuestions = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    ReasonForRestart = table.Column<string>(nullable: true),
                    AnswerType = table.Column<int>(nullable: false),
                    QuizType = table.Column<int>(nullable: false),
                    PercentageOfRightResponses = table.Column<int>(nullable: false),
                    PercentageOfWrongResponses = table.Column<int>(nullable: false),
                    PercentageOfSkippedQuestions = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => new { x.BookId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Answers_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Answers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookNotes",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookNotes", x => new { x.BookId, x.UserId });
                    table.ForeignKey(
                        name: "FK_BookNotes_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookNotes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookRatings",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRatings", x => new { x.BookId, x.UserId });
                    table.ForeignKey(
                        name: "FK_BookRatings_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookRatings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarkedBooks",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkedBooks", x => new { x.BookId, x.UserId });
                    table.ForeignKey(
                        name: "FK_MarkedBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarkedBooks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(maxLength: 255, nullable: false),
                    RightAnswer = table.Column<string>(maxLength: 255, nullable: false),
                    WrongAnswer1 = table.Column<string>(maxLength: 255, nullable: false),
                    WrongAnswer2 = table.Column<string>(maxLength: 255, nullable: false),
                    QuestionType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssociationKeys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    SubscriptionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociationKeys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssociationKeys_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SubscriptionId = table.Column<int>(nullable: false),
                    Name = table.Column<int>(nullable: false),
                    PriceTag = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    ValidUntil = table.Column<string>(maxLength: 255, nullable: false),
                    MaxQuizzes = table.Column<int>(nullable: false),
                    NumberOfStudentProfiles = table.Column<int>(nullable: false),
                    NumberOfParentProfiles = table.Column<int>(nullable: false),
                    NumberOfTeacherProfiles = table.Column<int>(nullable: false),
                    Text1 = table.Column<string>(maxLength: 255, nullable: true),
                    Text2 = table.Column<string>(maxLength: 255, nullable: true),
                    Text3 = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionTypes_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserId",
                table: "AspNetUsers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Family_UserId",
                table: "AspNetUsers",
                column: "Family_UserId",
                unique: true,
                filter: "[Family_UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClassStudentBelongsToId",
                table: "AspNetUsers",
                column: "ClassStudentBelongsToId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FamilyStudentBelongsToId",
                table: "AspNetUsers",
                column: "FamilyStudentBelongsToId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Student_UserId",
                table: "AspNetUsers",
                column: "Student_UserId",
                unique: true,
                filter: "[Student_UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_UserId",
                table: "Answers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AssociationKeys_SubscriptionId",
                table: "AssociationKeys",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_BookNotes_UserId",
                table: "BookNotes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookRatings_UserId",
                table: "BookRatings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkedBooks_UserId",
                table: "MarkedBooks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_BookId",
                table: "Questions",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivedMessages_SenderId",
                table: "ReceivedMessages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_SentMessages_SenderId",
                table: "SentMessages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionTypes_SubscriptionId",
                table: "SubscriptionTypes",
                column: "SubscriptionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_UserId",
                table: "AspNetUsers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_Family_UserId",
                table: "AspNetUsers",
                column: "Family_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ClassStudentBelongsToId",
                table: "AspNetUsers",
                column: "ClassStudentBelongsToId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_FamilyStudentBelongsToId",
                table: "AspNetUsers",
                column: "FamilyStudentBelongsToId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_Student_UserId",
                table: "AspNetUsers",
                column: "Student_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_Family_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ClassStudentBelongsToId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_FamilyStudentBelongsToId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_Student_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "AssociationKeys");

            migrationBuilder.DropTable(
                name: "BookNotes");

            migrationBuilder.DropTable(
                name: "BookRatings");

            migrationBuilder.DropTable(
                name: "MarkedBooks");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "ReceivedMessages");

            migrationBuilder.DropTable(
                name: "SentMessages");

            migrationBuilder.DropTable(
                name: "SubscriptionTypes");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Family_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClassStudentBelongsToId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FamilyStudentBelongsToId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_Student_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumberOfCreatedBooks",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumberPointsForCreatedBooks",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
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
                name: "School",
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
                name: "UserId",
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
                name: "ShowAchievements",
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
                name: "Family_UserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ClassStudentBelongsToId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FamilyStudentBelongsToId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GreetingName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumberOfAnswers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ParentEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PercentageOfRightResponses",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Points",
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
                name: "Student_School",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Student_UserId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);
        }
    }
}
