using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class ChangesInSubscription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Subscriptions");

            migrationBuilder.RenameColumn(
                name: "PriceTag",
                table: "Subscriptions",
                newName: "CurrentPrice");

            migrationBuilder.AlterColumn<string>(
                name: "ValidUntil",
                table: "Subscriptions",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionType",
                table: "Subscriptions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NumberOfTeacherProfiles",
                table: "Subscriptions",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NumberOfStudentProfiles",
                table: "Subscriptions",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NumberOfParentProfiles",
                table: "Subscriptions",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "MaxQuizzes",
                table: "Subscriptions",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "BankData",
                table: "Subscriptions",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discount",
                table: "Subscriptions",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OldPrice",
                table: "Subscriptions",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "OldPrice",
                table: "Subscriptions");

            migrationBuilder.RenameColumn(
                name: "CurrentPrice",
                table: "Subscriptions",
                newName: "PriceTag");

            migrationBuilder.AlterColumn<string>(
                name: "ValidUntil",
                table: "Subscriptions",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionType",
                table: "Subscriptions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfTeacherProfiles",
                table: "Subscriptions",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfStudentProfiles",
                table: "Subscriptions",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfParentProfiles",
                table: "Subscriptions",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "MaxQuizzes",
                table: "Subscriptions",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "BankData",
                table: "Subscriptions",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Subscriptions",
                nullable: false,
                defaultValue: 0);
        }
    }
}
