using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Traveller.API.Migrations
{
    /// <inheritdoc />
    public partial class SkillSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "IsBackgroundSkill", "Name" },
                values: new object[,]
                {
                    { 1, true, "Admin" },
                    { 2, false, "" },
                    { 3, true, "Animals" },
                    { 4, true, "Art" },
                    { 5, false, "Astrogation" },
                    { 6, true, "Athletics" },
                    { 7, false, "Broker" },
                    { 8, true, "Carouse" },
                    { 9, false, "Deception" },
                    { 10, false, "Diplomat" },
                    { 11, true, "Drive" },
                    { 12, true, "Electronics" },
                    { 13, false, "Explosives" },
                    { 14, true, "Flyer" },
                    { 15, false, "Gambler" },
                    { 16, false, "Gunner" },
                    { 17, false, "Gun Combat" },
                    { 18, false, "Heavy Weapons" },
                    { 19, false, "Investigate" },
                    { 20, false, "Jack-Of-All-Trades" },
                    { 21, true, "Language" },
                    { 22, false, "Leadership" },
                    { 23, true, "Mechanic" },
                    { 24, true, "Medic" },
                    { 25, false, "Melee" },
                    { 26, false, "Navigation" },
                    { 27, false, "Persuade" },
                    { 28, false, "Pilot" },
                    { 29, true, "Profession" },
                    { 30, false, "Recon" },
                    { 31, true, "Science" },
                    { 32, true, "Seafarer" },
                    { 33, false, "Stealth" },
                    { 34, false, "Steward" },
                    { 35, true, "Streetwise" },
                    { 36, true, "Survival" },
                    { 37, false, "Tactics" },
                    { 38, true, "Vacc Suit" }
                });

            migrationBuilder.InsertData(
                table: "skillSpecializations",
                columns: new[] { "Id", "Name", "SkillId" },
                values: new object[,]
                {
                    { 1, "Handling", 3 },
                    { 2, "Veterinary", 3 },
                    { 3, "Training", 3 },
                    { 4, "Performer", 4 },
                    { 5, "Holography", 4 },
                    { 6, "Instrument", 4 },
                    { 7, "Visual Media", 4 },
                    { 8, "Write", 4 },
                    { 9, "Dexterity", 6 },
                    { 10, "Endurance", 6 },
                    { 11, "Strength", 6 },
                    { 12, "Hovercraft", 11 },
                    { 13, "Mole", 11 },
                    { 14, "Track", 11 },
                    { 15, "Walker", 11 },
                    { 16, "Wheel", 11 },
                    { 17, "Comms", 12 },
                    { 18, "Computers", 12 },
                    { 19, "Remote Ops", 12 },
                    { 20, "Sensors", 12 },
                    { 21, "Airship", 14 },
                    { 22, "Grav", 14 },
                    { 23, "Ornithopter", 14 },
                    { 24, "Rotor", 14 },
                    { 25, "Wing", 14 },
                    { 26, "Turret", 16 },
                    { 27, "Ortillery", 16 },
                    { 28, "Screen", 16 },
                    { 29, "Capital", 16 },
                    { 30, "Archaic", 17 },
                    { 31, "Energy", 17 },
                    { 32, "Slug", 17 },
                    { 33, "Artillery", 18 },
                    { 34, "Portable", 18 },
                    { 35, "Vehicle", 18 },
                    { 36, "Galanglic", 21 },
                    { 37, "Vilani", 21 },
                    { 38, "Zdetl", 21 },
                    { 39, "Oynprith", 21 },
                    { 40, "Trokh", 21 },
                    { 41, "Gvegh", 21 },
                    { 42, "Unarmed", 25 },
                    { 43, "Blade", 25 },
                    { 44, "Bludgeon", 25 },
                    { 45, "Natural", 25 },
                    { 46, "Small Craft", 28 },
                    { 47, "Spacecraft", 28 },
                    { 48, "Capital Ships", 28 },
                    { 49, "Belter", 29 },
                    { 50, "Biologicals", 29 },
                    { 51, "Civil Engineering", 29 },
                    { 52, "Construction", 29 },
                    { 53, "Hydroponics", 29 },
                    { 54, "Polymers", 29 },
                    { 55, "Archaeology", 31 },
                    { 56, "Astronomy", 31 },
                    { 57, "Biology", 31 },
                    { 58, "Chemistry", 31 },
                    { 59, "Cosmology", 31 },
                    { 60, "Cybernetics", 31 },
                    { 61, "Economics", 31 },
                    { 62, "Genetics", 31 },
                    { 63, "History", 31 },
                    { 64, "Linguistics", 31 },
                    { 65, "Philosophy", 31 },
                    { 66, "Physics", 31 },
                    { 67, "Planetology", 31 },
                    { 68, "Psionicology", 31 },
                    { 69, "Psychology", 31 },
                    { 70, "Robotics", 31 },
                    { 71, "Sophontology", 31 },
                    { 72, "Xenology", 31 },
                    { 73, "Ocean Ships", 32 },
                    { 74, "Personal", 32 },
                    { 75, "Sail", 32 },
                    { 76, "Submarine", 32 },
                    { 77, "Military", 37 },
                    { 78, "Naval", 37 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "skillSpecializations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37);
        }
    }
}
