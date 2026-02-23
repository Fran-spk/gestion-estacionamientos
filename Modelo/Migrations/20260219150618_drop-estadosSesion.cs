using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloIds.Migrations
{
    /// <inheritdoc />
    public partial class dropestadosSesion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoSesion",
                table: "AuditoriaSesiones");

            migrationBuilder.RenameColumn(
                name: "TiempoInactividad",
                table: "AuditoriaSesiones",
                newName: "TiempoSesion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TiempoSesion",
                table: "AuditoriaSesiones",
                newName: "TiempoInactividad");

            migrationBuilder.AddColumn<string>(
                name: "EstadoSesion",
                table: "AuditoriaSesiones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
