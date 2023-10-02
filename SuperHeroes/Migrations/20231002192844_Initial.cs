using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Super_Heroes.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superheroes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComicUniverse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Superpowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SuperPower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superpowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Superpowers_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Villains",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Background = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Villains_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "ComicUniverse", "Description", "Name", "RealName" },
                values: new object[] { new Guid("25bf6212-9051-45f4-aced-88b0b3cb6179"), "DC", "Last Son of Krypton with superhuman strength and more.", "Superman", "Clark Kent" });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("26b1e5a2-8d28-464b-b49d-ce6fe021ccb6"), "Super hearing is a heightened auditory ability that allows individuals to perceive sounds at frequencies and volumes beyond the normal human range. Characters with super hearing can detect faint sounds from great distances, hear frequencies outside the human spectrum, and focus on specific sounds amidst background noise. This power grants users an extraordinary level of situational awareness, making them adept at eavesdropping, detecting hidden threats, and responding to emergencies based on auditory cues. Super hearing is a valuable asset in crime-fighting and surveillance.", "Super Hearing", new Guid("25bf6212-9051-45f4-aced-88b0b3cb6179") },
                    { new Guid("679ff9a1-0b17-454e-8976-38b6251f199e"), "Heat vision is a superpower that allows an individual to emit beams of intense heat and energy from their eyes. This ability enables the user to generate focused beams that can reach extremely high temperatures, capable of melting or vaporizing objects. Heat vision is often depicted as red or orange beams that emanate from the eyes. Characters with this power can use it for offensive purposes, such as attacking adversaries, and for practical applications like welding or cutting through obstacles.", "Heat Vision", new Guid("25bf6212-9051-45f4-aced-88b0b3cb6179") },
                    { new Guid("a4343990-7ebe-4bfe-8aac-8dcae3061ca1"), "Superhuman speed is the ability to move, react, and operate at speeds far beyond those of ordinary humans. Individuals with this power can run, fly, or perform any physical activity at velocities that exceed the capabilities of normal human beings. This power often grants the user enhanced reflexes, allowing them to perceive and react to events in the blink of an eye. Superhuman speed is a versatile ability, useful in combat, rescue missions, and various other situations.", "Superhuman Speed", new Guid("25bf6212-9051-45f4-aced-88b0b3cb6179") }
                });

            migrationBuilder.InsertData(
                table: "Villains",
                columns: new[] { "Id", "Background", "Name", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("3503f8ed-52ec-442a-85a3-92b3dfc4914d"), "A Kryptonian military leader with superhuman abilities similar to Superman. Zod seeks to establish Kryptonian dominance on Earth and considers Superman an obstacle.", "General Zod", new Guid("25bf6212-9051-45f4-aced-88b0b3cb6179") },
                    { new Guid("37213080-c2bd-4314-a0e9-735ec6d6712f"), "A brilliant and wealthy businessman who despises Superman", "Lex Luthor", new Guid("25bf6212-9051-45f4-aced-88b0b3cb6179") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId");

            migrationBuilder.CreateIndex(
                name: "IX_Villains_SuperheroId",
                table: "Villains",
                column: "SuperheroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Superpowers");

            migrationBuilder.DropTable(
                name: "Villains");

            migrationBuilder.DropTable(
                name: "Superheroes");
        }
    }
}
