using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostSkill_BuilderPosts_SkillID",
                table: "BuilderPostSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostSkill_Skills_SkillsId",
                table: "BuilderPostSkill");

            migrationBuilder.DropIndex(
                name: "IX_BuilderPostSkill_SkillsId",
                table: "BuilderPostSkill");

            migrationBuilder.DropColumn(
                name: "SkillsId",
                table: "BuilderPostSkill");

            migrationBuilder.CreateIndex(
                name: "IX_BuilderPostSkill_BuilderPostID",
                table: "BuilderPostSkill",
                column: "BuilderPostID");

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostSkill_BuilderPosts_BuilderPostID",
                table: "BuilderPostSkill",
                column: "BuilderPostID",
                principalTable: "BuilderPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostSkill_Skills_SkillID",
                table: "BuilderPostSkill",
                column: "SkillID",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostSkill_BuilderPosts_BuilderPostID",
                table: "BuilderPostSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_BuilderPostSkill_Skills_SkillID",
                table: "BuilderPostSkill");

            migrationBuilder.DropIndex(
                name: "IX_BuilderPostSkill_BuilderPostID",
                table: "BuilderPostSkill");

            migrationBuilder.AddColumn<int>(
                name: "SkillsId",
                table: "BuilderPostSkill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BuilderPostSkill_SkillsId",
                table: "BuilderPostSkill",
                column: "SkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostSkill_BuilderPosts_SkillID",
                table: "BuilderPostSkill",
                column: "SkillID",
                principalTable: "BuilderPosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuilderPostSkill_Skills_SkillsId",
                table: "BuilderPostSkill",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
