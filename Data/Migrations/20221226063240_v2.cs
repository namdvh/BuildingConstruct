using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostProduct_Products_ProductID",
                table: "ContractorPostProduct");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "ContractorPostProduct",
                newName: "ProductSystemID");

            migrationBuilder.AlterColumn<string>(
                name: "Salaries",
                table: "ContractorPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "ContractorPostProduct",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromSystem = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSystemCategories",
                columns: table => new
                {
                    CategoriesID = table.Column<int>(type: "int", nullable: false),
                    ProductSystemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSystemCategories", x => new { x.ProductSystemID, x.CategoriesID });
                    table.ForeignKey(
                        name: "FK_ProductSystemCategories_Categories_CategoriesID",
                        column: x => x.CategoriesID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSystemCategories_ProductSystems_ProductSystemID",
                        column: x => x.ProductSystemID,
                        principalTable: "ProductSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContractorPostProduct_ProductsId",
                table: "ContractorPostProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSystemCategories_CategoriesID",
                table: "ProductSystemCategories",
                column: "CategoriesID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostProduct_Products_ProductsId",
                table: "ContractorPostProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostProduct_ProductSystems_ProductSystemID",
                table: "ContractorPostProduct",
                column: "ProductSystemID",
                principalTable: "ProductSystems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostProduct_Products_ProductsId",
                table: "ContractorPostProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractorPostProduct_ProductSystems_ProductSystemID",
                table: "ContractorPostProduct");

            migrationBuilder.DropTable(
                name: "ProductSystemCategories");

            migrationBuilder.DropTable(
                name: "ProductSystems");

            migrationBuilder.DropIndex(
                name: "IX_ContractorPostProduct_ProductsId",
                table: "ContractorPostProduct");

            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "ContractorPostProduct");

            migrationBuilder.RenameColumn(
                name: "ProductSystemID",
                table: "ContractorPostProduct",
                newName: "ProductID");

            migrationBuilder.AlterColumn<string>(
                name: "Salaries",
                table: "ContractorPosts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorPostProduct_Products_ProductID",
                table: "ContractorPostProduct",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
