using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloIds.Migrations
{
    /// <inheritdoc />
    public partial class modulopagov2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Tickets_Base_TicketBaseId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_TicketBaseId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "MontoEstacionamiento",
                table: "Pagos");

            migrationBuilder.RenameColumn(
                name: "MontoServicios",
                table: "Pagos",
                newName: "MontoTotal");

            migrationBuilder.RenameColumn(
                name: "MontoFinal",
                table: "Pagos",
                newName: "Monto");

            migrationBuilder.AddColumn<string>(
                name: "Patente",
                table: "Pagos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Detalle",
                table: "PagoDetalles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "MontoDescuento",
                table: "PagoDetalles",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "TicketBaseId",
                table: "PagoDetalles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PagoDetalles_TicketBaseId",
                table: "PagoDetalles",
                column: "TicketBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_PagoDetalles_Tickets_Base_TicketBaseId",
                table: "PagoDetalles",
                column: "TicketBaseId",
                principalTable: "Tickets_Base",
                principalColumn: "TicketBaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PagoDetalles_Tickets_Base_TicketBaseId",
                table: "PagoDetalles");

            migrationBuilder.DropIndex(
                name: "IX_PagoDetalles_TicketBaseId",
                table: "PagoDetalles");

            migrationBuilder.DropColumn(
                name: "Patente",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "Detalle",
                table: "PagoDetalles");

            migrationBuilder.DropColumn(
                name: "MontoDescuento",
                table: "PagoDetalles");

            migrationBuilder.DropColumn(
                name: "TicketBaseId",
                table: "PagoDetalles");

            migrationBuilder.RenameColumn(
                name: "MontoTotal",
                table: "Pagos",
                newName: "MontoServicios");

            migrationBuilder.RenameColumn(
                name: "Monto",
                table: "Pagos",
                newName: "MontoFinal");

            migrationBuilder.AddColumn<decimal>(
                name: "MontoEstacionamiento",
                table: "Pagos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_TicketBaseId",
                table: "Pagos",
                column: "TicketBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Tickets_Base_TicketBaseId",
                table: "Pagos",
                column: "TicketBaseId",
                principalTable: "Tickets_Base",
                principalColumn: "TicketBaseId");
        }
    }
}
