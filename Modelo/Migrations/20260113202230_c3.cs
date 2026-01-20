using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloIds.Migrations
{
    /// <inheritdoc />
    public partial class c3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TarifaServicioTicketBase");

            migrationBuilder.CreateTable(
                name: "TicketTarifaServicio",
                columns: table => new
                {
                    TicketBaseId = table.Column<int>(type: "int", nullable: false),
                    TarifaServicioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTarifaServicio", x => new { x.TicketBaseId, x.TarifaServicioId });
                    table.ForeignKey(
                        name: "FK_TicketTarifaServicio_Tarifa_Servicios_TarifaServicioId",
                        column: x => x.TarifaServicioId,
                        principalTable: "Tarifa_Servicios",
                        principalColumn: "TarifaServicioId");
                    table.ForeignKey(
                        name: "FK_TicketTarifaServicio_Tickets_Base_TicketBaseId",
                        column: x => x.TicketBaseId,
                        principalTable: "Tickets_Base",
                        principalColumn: "TicketBaseId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TicketTarifaServicio_TarifaServicioId",
                table: "TicketTarifaServicio",
                column: "TarifaServicioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketTarifaServicio");

            migrationBuilder.CreateTable(
                name: "TarifaServicioTicketBase",
                columns: table => new
                {
                    TarifasAdicionalesTarifaServicioId = table.Column<int>(type: "int", nullable: false),
                    TicketsTicketBaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarifaServicioTicketBase", x => new { x.TarifasAdicionalesTarifaServicioId, x.TicketsTicketBaseId });
                    table.ForeignKey(
                        name: "FK_TarifaServicioTicketBase_Tarifa_Servicios_TarifasAdicionalesTarifaServicioId",
                        column: x => x.TarifasAdicionalesTarifaServicioId,
                        principalTable: "Tarifa_Servicios",
                        principalColumn: "TarifaServicioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TarifaServicioTicketBase_Tickets_Base_TicketsTicketBaseId",
                        column: x => x.TicketsTicketBaseId,
                        principalTable: "Tickets_Base",
                        principalColumn: "TicketBaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TarifaServicioTicketBase_TicketsTicketBaseId",
                table: "TarifaServicioTicketBase",
                column: "TicketsTicketBaseId");
        }
    }
}
