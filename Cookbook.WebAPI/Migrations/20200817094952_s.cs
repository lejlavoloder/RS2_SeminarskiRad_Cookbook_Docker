using Microsoft.EntityFrameworkCore.Migrations;

namespace Cookbook.WebAPI.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sadrzaj",
                table: "Notifikacija",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sadrzaj",
                table: "Notifikacija");
        }
    }
}
