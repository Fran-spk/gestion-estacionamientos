using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloIds.Migrations
{
    /// <inheritdoc />
    public partial class correcionserv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Diarios_TicketDiarioTicketBaseId",
                table: "ServiciosConsumidos");

            migrationBuilder.DropIndex(
                name: "IX_ServiciosConsumidos_TicketDiarioTicketBaseId",
                table: "ServiciosConsumidos");

            migrationBuilder.DropColumn(
                name: "TicketDiarioTicketBaseId",
                table: "ServiciosConsumidos");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaHoraVencimiento",
                table: "Cuotas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosConsumidos_TicketBaseId",
                table: "ServiciosConsumidos",
                column: "TicketBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Diarios_TicketBaseId",
                table: "ServiciosConsumidos",
                column: "TicketBaseId",
                principalTable: "Tickets_Diarios",
                principalColumn: "TicketBaseId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Diarios_TicketBaseId",
                table: "ServiciosConsumidos");

            migrationBuilder.DropIndex(
                name: "IX_ServiciosConsumidos_TicketBaseId",
                table: "ServiciosConsumidos");

            migrationBuilder.DropColumn(
                name: "FechaHoraVencimiento",
                table: "Cuotas");

            migrationBuilder.AddColumn<int>(
                name: "TicketDiarioTicketBaseId",
                table: "ServiciosConsumidos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosConsumidos_TicketDiarioTicketBaseId",
                table: "ServiciosConsumidos",
                column: "TicketDiarioTicketBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Diarios_TicketDiarioTicketBaseId",
                table: "ServiciosConsumidos",
                column: "TicketDiarioTicketBaseId",
                principalTable: "Tickets_Diarios",
                principalColumn: "TicketBaseId");
        }
    }
}
