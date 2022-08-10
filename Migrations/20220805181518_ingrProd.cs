using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webAPiINZ.Migrations
{
    public partial class ingrProd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "IngrProds",
                newName: "IngrProd");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "IngrProd",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngrProd",
                table: "IngrProd",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IngrProd",
                table: "IngrProd");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "IngrProd");

            migrationBuilder.RenameTable(
                name: "IngrProd",
                newName: "IngrProds");
        }
    }
}
