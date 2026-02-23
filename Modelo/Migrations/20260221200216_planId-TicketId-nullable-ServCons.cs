using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloIds.Migrations
{
    /// <inheritdoc />
    public partial class planIdTicketIdnullableServCons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosConsumidos_Planes_PlanPER_ID",
                table: "ServiciosConsumidos");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Diarios_TicketBaseId",
                table: "ServiciosConsumidos");

            migrationBuilder.RenameColumn(
                name: "PlanPER_ID",
                table: "ServiciosConsumidos",
                newName: "PlanId");

            migrationBuilder.RenameIndex(
                name: "IX_ServiciosConsumidos_PlanPER_ID",
                table: "ServiciosConsumidos",
                newName: "IX_ServiciosConsumidos_PlanId");

            migrationBuilder.AlterColumn<int>(
                name: "TicketBaseId",
                table: "ServiciosConsumidos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosConsumidos_Planes_PlanId",
                table: "ServiciosConsumidos",
                column: "PlanId",
                principalTable: "Planes",
                principalColumn: "PER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Diarios_TicketBaseId",
                table: "ServiciosConsumidos",
                column: "TicketBaseId",
                principalTable: "Tickets_Diarios",
                principalColumn: "TicketBaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosConsumidos_Planes_PlanId",
                table: "ServiciosConsumidos");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Diarios_TicketBaseId",
                table: "ServiciosConsumidos");

            migrationBuilder.RenameColumn(
                name: "PlanId",
                table: "ServiciosConsumidos",
                newName: "PlanPER_ID");

            migrationBuilder.RenameIndex(
                name: "IX_ServiciosConsumidos_PlanId",
                table: "ServiciosConsumidos",
                newName: "IX_ServiciosConsumidos_PlanPER_ID");

            migrationBuilder.AlterColumn<int>(
                name: "TicketBaseId",
                table: "ServiciosConsumidos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosConsumidos_Planes_PlanPER_ID",
                table: "ServiciosConsumidos",
                column: "PlanPER_ID",
                principalTable: "Planes",
                principalColumn: "PER_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosConsumidos_Tickets_Diarios_TicketBaseId",
                table: "ServiciosConsumidos",
                column: "TicketBaseId",
                principalTable: "Tickets_Diarios",
                principalColumn: "TicketBaseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
