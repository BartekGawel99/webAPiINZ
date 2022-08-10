using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webAPiINZ.Migrations
{
    public partial class ingrv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Product_ProductBarcode",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_ProductBarcode",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ProductBarcode",
                table: "Ingredients");

            migrationBuilder.CreateTable(
                name: "IngredientProduct",
                columns: table => new
                {
                    IngredientsIdIgredient = table.Column<int>(type: "int", nullable: false),
                    ProductsBarcode = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientProduct", x => new { x.IngredientsIdIgredient, x.ProductsBarcode });
                    table.ForeignKey(
                        name: "FK_IngredientProduct_Ingredients_IngredientsIdIgredient",
                        column: x => x.IngredientsIdIgredient,
                        principalTable: "Ingredients",
                        principalColumn: "IdIgredient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientProduct_Product_ProductsBarcode",
                        column: x => x.ProductsBarcode,
                        principalTable: "Product",
                        principalColumn: "Barcode",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientProduct_ProductsBarcode",
                table: "IngredientProduct",
                column: "ProductsBarcode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientProduct");

            migrationBuilder.AddColumn<string>(
                name: "ProductBarcode",
                table: "Ingredients",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_ProductBarcode",
                table: "Ingredients",
                column: "ProductBarcode");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Product_ProductBarcode",
                table: "Ingredients",
                column: "ProductBarcode",
                principalTable: "Product",
                principalColumn: "Barcode");
        }
    }
}
