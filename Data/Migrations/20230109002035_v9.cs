using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Experience",
                table: "Builders",
                newName: "ExperienceDetail");

            migrationBuilder.AddColumn<string>(
                name: "Certificate",
                table: "Builders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YearOfExperience",
                table: "Builders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Certificate",
                table: "Builders");

            migrationBuilder.DropColumn(
                name: "YearOfExperience",
                table: "Builders");

            migrationBuilder.RenameColumn(
                name: "ExperienceDetail",
                table: "Builders",
                newName: "Experience");
        }
    }
}
