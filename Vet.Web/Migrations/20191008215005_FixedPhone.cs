using Microsoft.EntityFrameworkCore.Migrations;

namespace Vet.Web.Migrations
{
    public partial class FixedPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FixelPhone",
                table: "Owner",
                newName: "FixedPhone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FixedPhone",
                table: "Owner",
                newName: "FixelPhone");
        }
    }
}
