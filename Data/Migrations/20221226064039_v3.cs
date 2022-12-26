using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostProduct_Products_ProductsId",
                table: "ContractorPostProduct");

            migrationBuilder.DropIndex(
                name: "IX_ContractorPostProduct_ProductsId",
                table: "ContractorPostProduct");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "ContractorPostProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "ContractorPostProduct",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContractorPostProduct_ProductsId",
                table: "ContractorPostProduct",
                column: "ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostProduct_Products_ProductsId",
                table: "ContractorPostProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
