using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class Remove2Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AllCLassesGroup_AllClassesGroupId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AllFamiliesGroup_AllFamiliesGroupId",
                table: "AspNetUsers");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
