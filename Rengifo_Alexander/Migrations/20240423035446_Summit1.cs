using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Rengifo_Alexander.Migrations
{
    /// <inheritdoc />
    public partial class Summit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    idCarrea = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numero_semestres = table.Column<int>(type: "integer", nullable: true),
                    campus = table.Column<string>(type: "text", nullable: true),
                    nombre_carrera = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.idCarrea);
                });

            migrationBuilder.CreateTable(
                name: "ARengifo",
                columns: table => new
                {
                    idEst = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameEst = table.Column<string>(type: "text", nullable: false),
                    yearEst = table.Column<int>(type: "integer", nullable: false),
                    promGeneral = table.Column<double>(type: "double precision", nullable: true),
                    Beca = table.Column<bool>(type: "boolean", nullable: true),
                    dateInscripcion = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    carreraEstidCarrea = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARengifo", x => x.idEst);
                    table.ForeignKey(
                        name: "FK_ARengifo_Carrera_carreraEstidCarrea",
                        column: x => x.carreraEstidCarrea,
                        principalTable: "Carrera",
                        principalColumn: "idCarrea");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ARengifo_carreraEstidCarrea",
                table: "ARengifo",
                column: "carreraEstidCarrea");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ARengifo");

            migrationBuilder.DropTable(
                name: "Carrera");
        }
    }
}
