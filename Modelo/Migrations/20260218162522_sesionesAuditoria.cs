using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloIds.Migrations
{
    /// <inheritdoc />
    public partial class sesionesAuditoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditoriaSesiones",
                columns: table => new
                {
                    AuditoriaSesionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    FechaHoraLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHoraLogout = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TipoLogout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SesionActiva = table.Column<bool>(type: "bit", nullable: false),
                    DuracionSegundos = table.Column<int>(type: "int", nullable: true),
                    EstadoSesion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiempoInactividad = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditoriaSesiones", x => x.AuditoriaSesionId);
                    table.ForeignKey(
                        name: "FK_AuditoriaSesiones_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "PER_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditoriaSesiones_UsuarioId",
                table: "AuditoriaSesiones",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditoriaSesiones");
        }
    }
}
