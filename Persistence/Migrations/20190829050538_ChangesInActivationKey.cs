using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class ChangesInActivationKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionTypes_Subscriptions_SubscriptionId",
                table: "SubscriptionTypes");

            migrationBuilder.DropTable(
                name: "AssociationKeys");

            migrationBuilder.DropIndex(
                name: "IX_SubscriptionTypes_SubscriptionId",
                table: "SubscriptionTypes");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "SubscriptionTypes");

            migrationBuilder.DropColumn(
                name: "ValidUntil",
                table: "SubscriptionTypes");

            migrationBuilder.DropColumn(
                name: "ActivationCode",
                table: "Subscriptions");

            migrationBuilder.RenameColumn(
                name: "SubscribeDateTime",
                table: "Subscriptions",
                newName: "ValidUntil");

            migrationBuilder.RenameColumn(
                name: "StudentCode",
                table: "AspNetUsers",
                newName: "StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SubscriptionTypes",
                nullable: false,
                oldClrType: typeof(int));

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

            migrationBuilder.AddColumn<int>(
                name: "StudentActivationKeyId",
                table: "Subscriptions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionTypeId",
                table: "Subscriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ActivationKeys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    SubscriptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivationKeys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivationKeys_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_AspNetUsers_ClassId",
                table: "AspNetUsers",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FamilyId",
                table: "AspNetUsers",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StudentId",
                table: "AspNetUsers",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivationKeys_SubscriptionId",
                table: "ActivationKeys",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ClassId",
                table: "AspNetUsers",
                column: "ClassId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_FamilyId",
                table: "AspNetUsers",
                column: "FamilyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_StudentId",
                table: "AspNetUsers",
                column: "StudentId",
                principalTable: "AspNetUsers",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ClassId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_FamilyId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_StudentId",
                table: "AspNetUsers");

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

            migrationBuilder.DropTable(
                name: "ActivationKeys");

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
                name: "IX_AspNetUsers_ClassId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FamilyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StudentId",
                table: "AspNetUsers");

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
                name: "StudentActivationKeyId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "SubscriptionTypeId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FamilyId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ValidUntil",
                table: "Subscriptions",
                newName: "SubscribeDateTime");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "AspNetUsers",
                newName: "StudentCode");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "SubscriptionTypes",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionId",
                table: "SubscriptionTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ValidUntil",
                table: "SubscriptionTypes",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ActivationCode",
                table: "Subscriptions",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StudentCode",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionTypes_SubscriptionId",
                table: "SubscriptionTypes",
                column: "SubscriptionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AssociationKeys_SubscriptionId",
                table: "AssociationKeys",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionTypes_Subscriptions_SubscriptionId",
                table: "SubscriptionTypes",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
