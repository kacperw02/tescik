using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_bazy.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wiek = table.Column<int>(type: "int", nullable: false),
                    Stopien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrzynaleznoscDoMagazynu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sprzety",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaSprzetu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NazwaMagazynu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataWstawienia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprzety", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienia",
                columns: table => new
                {
                    IdZamowienia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaSprzetu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataZamowienia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienia", x => x.IdZamowienia);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "Sprzety");

            migrationBuilder.DropTable(
                name: "Zamowienia");
        }
    }
}
