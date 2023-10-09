using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Traveller.API.Migrations
{
    /// <inheritdoc />
    public partial class AddingCharacteristicstoCharacters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DEX",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EDU",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "END",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "INT",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SOC",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STR",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DEX",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "EDU",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "END",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "INT",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SOC",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "STR",
                table: "Characters");
        }
    }
}
