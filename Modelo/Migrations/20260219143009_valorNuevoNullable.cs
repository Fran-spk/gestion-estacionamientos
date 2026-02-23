using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloIds.Migrations
{
    /// <inheritdoc />
    public partial class valorNuevoNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DuracionSegundos",
                table: "AuditoriaSesiones");

            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "AuditoriaSesiones");

            migrationBuilder.AlterColumn<string>(
                name: "ValorNuevo",
                table: "AuditoriaTickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ValorNuevo",
                table: "AuditoriaTickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DuracionSegundos",
                table: "AuditoriaSesiones",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "AuditoriaSesiones",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
