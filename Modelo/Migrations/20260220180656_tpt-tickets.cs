using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloIds.Migrations
{
    /// <inheritdoc />
    public partial class tpttickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Base_TicketDiarioTicketBaseId",
                table: "ServiciosConsumidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Base_Planes_PlanId",
                table: "Tickets_Base");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_Base_PlanId",
                table: "Tickets_Base");

            migrationBuilder.DropColumn(
                name: "Actual",
                table: "Tickets_Base");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Tickets_Base");

            migrationBuilder.DropColumn(
                name: "FechaHoraSalida",
                table: "Tickets_Base");

            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "Tickets_Base");

            migrationBuilder.CreateTable(
                name: "Cuotas",
                columns: table => new
                {
                    TicketBaseId = table.Column<int>(type: "int", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    Actual = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuotas", x => x.TicketBaseId);
                    table.ForeignKey(
                        name: "FK_Cuotas_Planes_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Planes",
                        principalColumn: "PER_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cuotas_Tickets_Base_TicketBaseId",
                        column: x => x.TicketBaseId,
                        principalTable: "Tickets_Base",
                        principalColumn: "TicketBaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets_Diarios",
                columns: table => new
                {
                    TicketBaseId = table.Column<int>(type: "int", nullable: false),
                    FechaHoraSalida = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets_Diarios", x => x.TicketBaseId);
                    table.ForeignKey(
                        name: "FK_Tickets_Diarios_Tickets_Base_TicketBaseId",
                        column: x => x.TicketBaseId,
                        principalTable: "Tickets_Base",
                        principalColumn: "TicketBaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_PlanId",
                table: "Cuotas",
                column: "PlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Diarios_TicketDiarioTicketBaseId",
                table: "ServiciosConsumidos",
                column: "TicketDiarioTicketBaseId",
                principalTable: "Tickets_Diarios",
                principalColumn: "TicketBaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Diarios_TicketDiarioTicketBaseId",
                table: "ServiciosConsumidos");

            migrationBuilder.DropTable(
                name: "Cuotas");

            migrationBuilder.DropTable(
                name: "Tickets_Diarios");

            migrationBuilder.AddColumn<bool>(
                name: "Actual",
                table: "Tickets_Base",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Tickets_Base",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaHoraSalida",
                table: "Tickets_Base",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlanId",
                table: "Tickets_Base",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Base_PlanId",
                table: "Tickets_Base",
                column: "PlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Base_TicketDiarioTicketBaseId",
                table: "ServiciosConsumidos",
                column: "TicketDiarioTicketBaseId",
                principalTable: "Tickets_Base",
                principalColumn: "TicketBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Base_Planes_PlanId",
                table: "Tickets_Base",
                column: "PlanId",
                principalTable: "Planes",
                principalColumn: "PER_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
