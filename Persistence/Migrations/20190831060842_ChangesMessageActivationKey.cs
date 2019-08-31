using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class ChangesMessageActivationKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivationKeys_Subscriptions_SubscriptionId",
                table: "ActivationKeys");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_ActivationKeys_ClassActivationKeyId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_ActivationKeys_FamilyActivationKeyId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_ActivationKeys_StudentActivationKeyId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_SubscriptionTypes_SubscriptionTypeId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_AspNetUsers_UserId",
                table: "Subscriptions");

            migrationBuilder.DropTable(
                name: "SubscriptionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_ClassActivationKeyId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_FamilyActivationKeyId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_StudentActivationKeyId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_SubscriptionTypeId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_ActivationKeys_SubscriptionId",
                table: "ActivationKeys");

            migrationBuilder.DropColumn(
                name: "ClassActivationKeyId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "FamilyActivationKeyId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "MadeOn",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "SchoolYear",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "StudentActivationKeyId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "ActivationKeys");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "ActivationKeys");

            migrationBuilder.RenameColumn(
                name: "SubscriptionTypeId",
                table: "Subscriptions",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Subscriptions",
                newName: "NumberOfTeacherProfiles");

            migrationBuilder.RenameColumn(
                name: "PaymentType",
                table: "Subscriptions",
                newName: "NumberOfStudentProfiles");

            migrationBuilder.AlterColumn<string>(
                name: "ValidUntil",
                table: "Subscriptions",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "MaxQuizzes",
                table: "Subscriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfParentProfiles",
                table: "Subscriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PriceTag",
                table: "Subscriptions",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionType",
                table: "Subscriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Text1",
                table: "Subscriptions",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text2",
                table: "Subscriptions",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text3",
                table: "Subscriptions",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateTime",
                table: "SentMessages",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "DateTime",
                table: "ReceivedMessages",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "DateTime",
                table: "MarkedBooks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateTime",
                table: "BookRatings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateTime",
                table: "BookNotes",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateTime",
                table: "Answers",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "UserSubscriptionId",
                table: "ActivationKeys",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    SubscriptionId = table.Column<int>(nullable: false),
                    OrderedOn = table.Column<string>(nullable: true),
                    PaymentType = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    IsPaid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSubscriptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivationKeys_UserSubscriptionId",
                table: "ActivationKeys",
                column: "UserSubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_SubscriptionId",
                table: "UserSubscriptions",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSubscriptions_UserId",
                table: "UserSubscriptions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivationKeys_UserSubscriptions_UserSubscriptionId",
                table: "ActivationKeys",
                column: "UserSubscriptionId",
                principalTable: "UserSubscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivationKeys_UserSubscriptions_UserSubscriptionId",
                table: "ActivationKeys");

            migrationBuilder.DropTable(
                name: "UserSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_ActivationKeys_UserSubscriptionId",
                table: "ActivationKeys");

            migrationBuilder.DropColumn(
                name: "MaxQuizzes",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "NumberOfParentProfiles",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "PriceTag",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "SubscriptionType",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "Text1",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "Text2",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "Text3",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "MarkedBooks");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "BookRatings");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "BookNotes");

            migrationBuilder.DropColumn(
                name: "UserSubscriptionId",
                table: "ActivationKeys");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Subscriptions",
                newName: "SubscriptionTypeId");

            migrationBuilder.RenameColumn(
                name: "NumberOfTeacherProfiles",
                table: "Subscriptions",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "NumberOfStudentProfiles",
                table: "Subscriptions",
                newName: "PaymentType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidUntil",
                table: "Subscriptions",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassActivationKeyId",
                table: "Subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyActivationKeyId",
                table: "Subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MadeOn",
                table: "Subscriptions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchoolYear",
                table: "Subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentActivationKeyId",
                table: "Subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Subscriptions",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "SentMessages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "ReceivedMessages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Answers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "ActivationKeys",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionId",
                table: "ActivationKeys",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubscriptionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MaxQuizzes = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    NumberOfParentProfiles = table.Column<int>(nullable: false),
                    NumberOfStudentProfiles = table.Column<int>(nullable: false),
                    NumberOfTeacherProfiles = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    PriceTag = table.Column<string>(maxLength: 255, nullable: false),
                    Text1 = table.Column<string>(maxLength: 255, nullable: true),
                    Text2 = table.Column<string>(maxLength: 255, nullable: true),
                    Text3 = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_ClassActivationKeyId",
                table: "Subscriptions",
                column: "ClassActivationKeyId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_FamilyActivationKeyId",
                table: "Subscriptions",
                column: "FamilyActivationKeyId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_StudentActivationKeyId",
                table: "Subscriptions",
                column: "StudentActivationKeyId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_SubscriptionTypeId",
                table: "Subscriptions",
                column: "SubscriptionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivationKeys_SubscriptionId",
                table: "ActivationKeys",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivationKeys_Subscriptions_SubscriptionId",
                table: "ActivationKeys",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_ActivationKeys_ClassActivationKeyId",
                table: "Subscriptions",
                column: "ClassActivationKeyId",
                principalTable: "ActivationKeys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_ActivationKeys_FamilyActivationKeyId",
                table: "Subscriptions",
                column: "FamilyActivationKeyId",
                principalTable: "ActivationKeys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_ActivationKeys_StudentActivationKeyId",
                table: "Subscriptions",
                column: "StudentActivationKeyId",
                principalTable: "ActivationKeys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_SubscriptionTypes_SubscriptionTypeId",
                table: "Subscriptions",
                column: "SubscriptionTypeId",
                principalTable: "SubscriptionTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_AspNetUsers_UserId",
                table: "Subscriptions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
