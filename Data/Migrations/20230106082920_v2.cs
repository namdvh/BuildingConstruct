using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Saves",
                table: "Saves");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saves",
                table: "Saves",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Saves",
                table: "Saves");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Saves",
                table: "Saves",
                columns: new[] { "Id", "UserId" });
        }
    }
}
