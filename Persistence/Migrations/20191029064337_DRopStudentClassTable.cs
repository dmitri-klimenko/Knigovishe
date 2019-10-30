using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class DRopStudentClassTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_FamilyId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "StudentClass");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FamilyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FamilyId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "StudentFamily",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<string>(nullable: true),
                    FamilyId = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentFamily", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentFamily_AspNetUsers_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentFamily_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentFamily_FamilyId",
                table: "StudentFamily",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentFamily_StudentId",
                table: "StudentFamily",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentFamily");

            migrationBuilder.AddColumn<string>(
                name: "FamilyId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentClass",
                columns: table => new
                {
                    ClassId = table.Column<string>(nullable: false),
                    StudentId = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClass", x => new { x.ClassId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_StudentClass_AspNetUsers_ClassId",
                        column: x => x.ClassId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentClass_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FamilyId",
                table: "AspNetUsers",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClass_StudentId",
                table: "StudentClass",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_FamilyId",
                table: "AspNetUsers",
                column: "FamilyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
