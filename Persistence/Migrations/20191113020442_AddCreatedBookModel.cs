using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class AddCreatedBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfCreatedBooks",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PointsForCreatedBooks",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "IsArchive",
                table: "Answers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CreatedBooks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Points = table.Column<byte>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    IsArchive = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatedBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatedBooks_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreatedBooks_UserId",
                table: "CreatedBooks",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreatedBooks");

            migrationBuilder.DropColumn(
                name: "IsArchive",
                table: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfCreatedBooks",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PointsForCreatedBooks",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }
    }
}
