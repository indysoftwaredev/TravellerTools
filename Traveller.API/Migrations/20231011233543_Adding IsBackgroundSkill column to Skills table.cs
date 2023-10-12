using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingIsBackgroundSkillcolumntoSkillstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBackgroundSkill",
                table: "Skills",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBackgroundSkill",
                table: "Skills");
        }
    }
}
