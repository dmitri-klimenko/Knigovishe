using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class correctPropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfWriteResponses",
                table: "Answers",
                newName: "NumberOfRightResponses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfRightResponses",
                table: "Answers",
                newName: "NumberOfWriteResponses");
        }
    }
}
