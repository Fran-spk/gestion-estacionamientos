using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloIds.Migrations
{
    /// <inheritdoc />
    public partial class modpagosv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PagoDetalles_ServiciosConsumidos_ServicioConsumidoId",
                table: "PagoDetalles");

            migrationBuilder.AlterColumn<int>(
                name: "ServicioConsumidoId",
                table: "PagoDetalles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PagoDetalles_ServiciosConsumidos_ServicioConsumidoId",
                table: "PagoDetalles",
                column: "ServicioConsumidoId",
                principalTable: "ServiciosConsumidos",
                principalColumn: "ServicioConsumidoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PagoDetalles_ServiciosConsumidos_ServicioConsumidoId",
                table: "PagoDetalles");

            migrationBuilder.AlterColumn<int>(
                name: "ServicioConsumidoId",
                table: "PagoDetalles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PagoDetalles_ServiciosConsumidos_ServicioConsumidoId",
                table: "PagoDetalles",
                column: "ServicioConsumidoId",
                principalTable: "ServiciosConsumidos",
                principalColumn: "ServicioConsumidoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
