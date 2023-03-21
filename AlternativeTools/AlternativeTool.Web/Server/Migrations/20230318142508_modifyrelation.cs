using Microsoft.EntityFrameworkCore.Migrations;

namespace AlternativeTool.Web.Server.Migrations
{
    public partial class modifyrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "CompetitiveProducts",
                type: "int",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompetitiveProducts_Products_ProductId",
                table: "CompetitiveProducts");

            migrationBuilder.DropTable(
                name: "MiddelTable");

            migrationBuilder.DropIndex(
                name: "IX_CompetitiveProducts_ProductId",
                table: "CompetitiveProducts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CompetitiveProducts");
        }
    }
}
