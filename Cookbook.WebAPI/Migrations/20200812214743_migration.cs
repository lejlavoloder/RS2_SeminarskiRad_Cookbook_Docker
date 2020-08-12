using Microsoft.EntityFrameworkCore.Migrations;

namespace Cookbook.WebAPI.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Odobreno",
                table: "Komentar",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Odobreno",
                table: "Komentar");
        }
    }
}
