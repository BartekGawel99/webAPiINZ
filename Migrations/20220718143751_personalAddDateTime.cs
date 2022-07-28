using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webAPiINZ.Migrations
{
    public partial class personalAddDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SaveTime",
                table: "Personals",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaveTime",
                table: "Personals");
        }
    }
}
