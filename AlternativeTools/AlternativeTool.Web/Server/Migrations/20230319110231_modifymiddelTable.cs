using Microsoft.EntityFrameworkCore.Migrations;

namespace AlternativeTool.Web.Server.Migrations
{
    public partial class modifymiddelTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitiveProducts_Products_ProductId",
                table: "CompetitiveProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CompetitiveProducts_CompetitiveProductId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "MiddelTable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CompetitiveProductId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompetitiveProducts",
                table: "CompetitiveProducts");

            migrationBuilder.DropIndex(
                name: "IX_CompetitiveProducts_ProductId",
                table: "CompetitiveProducts");

            migrationBuilder.DropColumn(
                name: "CompetitiveProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CompetitiveProducts");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "T_Product");

            migrationBuilder.RenameTable(
                name: "CompetitiveProducts",
                newName: "T_CompetitiveProduct");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_Product",
                table: "T_Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_CompetitiveProduct",
                table: "T_CompetitiveProduct",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "T_CPP",
                columns: table => new
                {
                    CompetitiveProductsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_CPP", x => new { x.CompetitiveProductsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_T_CPP_T_CompetitiveProduct_CompetitiveProductsId",
                        column: x => x.CompetitiveProductsId,
                        principalTable: "T_CompetitiveProduct",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_CPP_T_Product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "T_Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_CPP_ProductsId",
                table: "T_CPP",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_CPP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_Product",
                table: "T_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_CompetitiveProduct",
                table: "T_CompetitiveProduct");

            migrationBuilder.RenameTable(
                name: "T_Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "T_CompetitiveProduct",
                newName: "CompetitiveProducts");

            migrationBuilder.AddColumn<int>(
                name: "CompetitiveProductId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "CompetitiveProducts",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompetitiveProducts",
                table: "CompetitiveProducts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MiddelTable",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CompetitiveId = table.Column<int>(type: "int", nullable: false),
                    CompetitiveProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiddelTable", x => new { x.ProductId, x.CompetitiveId });
                    table.ForeignKey(
                        name: "FK_MiddelTable_CompetitiveProducts_CompetitiveProductId",
                        column: x => x.CompetitiveProductId,
                        principalTable: "CompetitiveProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MiddelTable_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompetitiveProductId",
                table: "Products",
                column: "CompetitiveProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitiveProducts_ProductId",
                table: "CompetitiveProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_MiddelTable_CompetitiveProductId",
                table: "MiddelTable",
                column: "CompetitiveProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompetitiveProducts_Products_ProductId",
                table: "CompetitiveProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CompetitiveProducts_CompetitiveProductId",
                table: "Products",
                column: "CompetitiveProductId",
                principalTable: "CompetitiveProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
