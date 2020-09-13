using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;

namespace Cookbook.WebAPI.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "script.sql")));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
