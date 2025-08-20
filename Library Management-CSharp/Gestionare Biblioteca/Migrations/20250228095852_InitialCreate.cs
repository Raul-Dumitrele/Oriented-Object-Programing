using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestionare_Biblioteca.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titlu = table.Column<string>(type: "TEXT", nullable: false),
                    Autor = table.Column<string>(type: "TEXT", nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", nullable: false),
                    Disponibil = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Membri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nume = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Imprumuturi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarteId = table.Column<int>(type: "INTEGER", nullable: false),
                    MembruId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataImprumut = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataReturnare = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imprumuturi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imprumuturi_Carti_CarteId",
                        column: x => x.CarteId,
                        principalTable: "Carti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Imprumuturi_Membri_MembruId",
                        column: x => x.MembruId,
                        principalTable: "Membri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imprumuturi_CarteId",
                table: "Imprumuturi",
                column: "CarteId");

            migrationBuilder.CreateIndex(
                name: "IX_Imprumuturi_MembruId",
                table: "Imprumuturi",
                column: "MembruId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imprumuturi");

            migrationBuilder.DropTable(
                name: "Carti");

            migrationBuilder.DropTable(
                name: "Membri");
        }
    }
}
