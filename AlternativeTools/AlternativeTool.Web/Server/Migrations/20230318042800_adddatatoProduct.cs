using Microsoft.EntityFrameworkCore.Migrations;

namespace AlternativeTool.Web.Server.Migrations
{
    public partial class adddatatoProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureUrl",
                table: "Products",
                newName: "ImageURL");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "CompetitiveProducts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "CompetitiveProducts");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Products",
                newName: "PictureUrl");
        }
    }
}
