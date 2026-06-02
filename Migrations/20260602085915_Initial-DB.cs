using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Circuits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CircuitName = table.Column<string>(type: "TEXT", nullable: false),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Circuits_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Season = table.Column<int>(type: "INTEGER", nullable: false),
                    Round = table.Column<int>(type: "INTEGER", nullable: false),
                    RaceName = table.Column<string>(type: "TEXT", nullable: false),
                    RaceDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CircuitId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => new { x.Season, x.Round });
                    table.ForeignKey(
                        name: "FK_Races_Circuits_CircuitId",
                        column: x => x.CircuitId,
                        principalTable: "Circuits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Circuits_LocationId",
                table: "Circuits",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_CircuitId",
                table: "Races",
                column: "CircuitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Circuits");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
