using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rengifo_Alexander.Migrations
{
    /// <inheritdoc />
    public partial class Summit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "yearEst",
                table: "ARengifo",
                newName: "Edad");

            migrationBuilder.RenameColumn(
                name: "promGeneral",
                table: "ARengifo",
                newName: "Promedio_General");

            migrationBuilder.RenameColumn(
                name: "nameEst",
                table: "ARengifo",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "dateInscripcion",
                table: "ARengifo",
                newName: "FechaIncripcion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Promedio_General",
                table: "ARengifo",
                newName: "promGeneral");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "ARengifo",
                newName: "nameEst");

            migrationBuilder.RenameColumn(
                name: "FechaIncripcion",
                table: "ARengifo",
                newName: "dateInscripcion");

            migrationBuilder.RenameColumn(
                name: "Edad",
                table: "ARengifo",
                newName: "yearEst");
        }
    }
}
