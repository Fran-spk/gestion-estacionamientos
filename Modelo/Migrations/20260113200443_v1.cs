using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModeloIds.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Descuentos",
                columns: table => new
                {
                    DescuentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    NombreDescuento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Porcentaje = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descuentos", x => x.DescuentoId);
                });

            migrationBuilder.CreateTable(
                name: "Espacios",
                columns: table => new
                {
                    EspacioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEspacio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false),
                    EsMenusal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Espacios", x => x.EspacioId);
                });

            migrationBuilder.CreateTable(
                name: "Estados_Grupos",
                columns: table => new
                {
                    ESTGRUID = table.Column<int>(name: "EST_GRU_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ESTGRUNOMBRE = table.Column<string>(name: "EST_GRU_NOMBRE", type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_Grupos", x => x.ESTGRUID);
                });

            migrationBuilder.CreateTable(
                name: "Estados_Tickets",
                columns: table => new
                {
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_Tickets", x => x.EstadoId);
                });

            migrationBuilder.CreateTable(
                name: "Estados_Usuarios",
                columns: table => new
                {
                    ESTUSUID = table.Column<int>(name: "EST_USU_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ESTUSUNOMBRE = table.Column<string>(name: "EST_USU_NOMBRE", type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_Usuarios", x => x.ESTUSUID);
                });

            migrationBuilder.CreateTable(
                name: "Metodos_Pagos",
                columns: table => new
                {
                    MetodoDePagoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMetodo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metodos_Pagos", x => x.MetodoDePagoId);
                });

            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    MODID = table.Column<int>(name: "MOD_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MODNOMBRE = table.Column<string>(name: "MOD_NOMBRE", type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.MODID);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PERID = table.Column<int>(name: "PER_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PERNOMBRE = table.Column<string>(name: "PER_NOMBRE", type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PERID);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Servicios",
                columns: table => new
                {
                    TipoServicioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiempoEstimado = table.Column<double>(type: "float", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Servicios", x => x.TipoServicioId);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Vehiculos",
                columns: table => new
                {
                    TipoVehiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreVehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Vehiculos", x => x.TipoVehiculoId);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    GRUID = table.Column<int>(name: "GRU_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GRUNOMBRE = table.Column<string>(name: "GRU_NOMBRE", type: "nvarchar(60)", maxLength: 60, nullable: false),
                    GRUDESCRIPCION = table.Column<string>(name: "GRU_DESCRIPCION", type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ESTGRUID = table.Column<int>(name: "EST_GRU_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.GRUID);
                    table.ForeignKey(
                        name: "FK_Grupos_Estados_Grupos_EST_GRU_ID",
                        column: x => x.ESTGRUID,
                        principalTable: "Estados_Grupos",
                        principalColumn: "EST_GRU_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Formularios",
                columns: table => new
                {
                    FORID = table.Column<int>(name: "FOR_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FORNOMBRE = table.Column<string>(name: "FOR_NOMBRE", type: "nvarchar(60)", maxLength: 60, nullable: false),
                    MODID = table.Column<int>(name: "MOD_ID", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formularios", x => x.FORID);
                    table.ForeignKey(
                        name: "FK_Formularios_Modulos_MOD_ID",
                        column: x => x.MODID,
                        principalTable: "Modulos",
                        principalColumn: "MOD_ID");
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    PERID = table.Column<int>(name: "PER_ID", type: "int", nullable: false),
                    DescuentoId = table.Column<int>(type: "int", nullable: true),
                    FechaHoraAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHoraBaja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoPlan = table.Column<bool>(type: "bit", nullable: false),
                    Patente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.PERID);
                    table.ForeignKey(
                        name: "FK_Planes_Descuentos_DescuentoId",
                        column: x => x.DescuentoId,
                        principalTable: "Descuentos",
                        principalColumn: "DescuentoId");
                    table.ForeignKey(
                        name: "FK_Planes_Personas_PER_ID",
                        column: x => x.PERID,
                        principalTable: "Personas",
                        principalColumn: "PER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    PERID = table.Column<int>(name: "PER_ID", type: "int", nullable: false),
                    USUUSUARIO = table.Column<string>(name: "USU_USUARIO", type: "nvarchar(60)", maxLength: 60, nullable: false),
                    USUCLAVE = table.Column<string>(name: "USU_CLAVE", type: "nvarchar(64)", maxLength: 64, nullable: false),
                    USUMAIL = table.Column<string>(name: "USU_MAIL", type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ESTUSUID = table.Column<int>(name: "EST_USU_ID", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.PERID);
                    table.ForeignKey(
                        name: "FK_Usuarios_Estados_Usuarios_EST_USU_ID",
                        column: x => x.ESTUSUID,
                        principalTable: "Estados_Usuarios",
                        principalColumn: "EST_USU_ID");
                    table.ForeignKey(
                        name: "FK_Usuarios_Personas_PER_ID",
                        column: x => x.PERID,
                        principalTable: "Personas",
                        principalColumn: "PER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EspacioTipoVehiculo",
                columns: table => new
                {
                    EspaciosEspacioId = table.Column<int>(type: "int", nullable: false),
                    VehiculosTipoVehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspacioTipoVehiculo", x => new { x.EspaciosEspacioId, x.VehiculosTipoVehiculoId });
                    table.ForeignKey(
                        name: "FK_EspacioTipoVehiculo_Espacios_EspaciosEspacioId",
                        column: x => x.EspaciosEspacioId,
                        principalTable: "Espacios",
                        principalColumn: "EspacioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EspacioTipoVehiculo_Tipos_Vehiculos_VehiculosTipoVehiculoId",
                        column: x => x.VehiculosTipoVehiculoId,
                        principalTable: "Tipos_Vehiculos",
                        principalColumn: "TipoVehiculoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarifa_Servicios",
                columns: table => new
                {
                    TarifaServicioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServicioTipoServicioId = table.Column<int>(type: "int", nullable: true),
                    Vigente = table.Column<bool>(type: "bit", nullable: false),
                    FechaHoraActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoVehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifa_Servicios", x => x.TarifaServicioId);
                    table.ForeignKey(
                        name: "FK_Tarifa_Servicios_Tipo_Servicios_ServicioTipoServicioId",
                        column: x => x.ServicioTipoServicioId,
                        principalTable: "Tipo_Servicios",
                        principalColumn: "TipoServicioId");
                    table.ForeignKey(
                        name: "FK_Tarifa_Servicios_Tipos_Vehiculos_TipoVehiculoId",
                        column: x => x.TipoVehiculoId,
                        principalTable: "Tipos_Vehiculos",
                        principalColumn: "TipoVehiculoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarifas_Estacionamiento",
                columns: table => new
                {
                    TarifaEstacionamientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecioMediaHora = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioHora = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioDia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioMes = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Vigente = table.Column<bool>(type: "bit", nullable: false),
                    FechaHoraActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoVehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifas_Estacionamiento", x => x.TarifaEstacionamientoId);
                    table.ForeignKey(
                        name: "FK_Tarifas_Estacionamiento_Tipos_Vehiculos_TipoVehiculoId",
                        column: x => x.TipoVehiculoId,
                        principalTable: "Tipos_Vehiculos",
                        principalColumn: "TipoVehiculoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Acciones",
                columns: table => new
                {
                    ACCID = table.Column<int>(name: "ACC_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACCNOMBRE = table.Column<string>(name: "ACC_NOMBRE", type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FORID = table.Column<int>(name: "FOR_ID", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acciones", x => x.ACCID);
                    table.ForeignKey(
                        name: "FK_Acciones_Formularios_FOR_ID",
                        column: x => x.FORID,
                        principalTable: "Formularios",
                        principalColumn: "FOR_ID");
                });

            migrationBuilder.CreateTable(
                name: "GrupoUsuario",
                columns: table => new
                {
                    GruposGRUID = table.Column<int>(name: "GruposGRU_ID", type: "int", nullable: false),
                    UsuariosPERID = table.Column<int>(name: "UsuariosPER_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrupoUsuario", x => new { x.GruposGRUID, x.UsuariosPERID });
                    table.ForeignKey(
                        name: "FK_GrupoUsuario_Grupos_GruposGRU_ID",
                        column: x => x.GruposGRUID,
                        principalTable: "Grupos",
                        principalColumn: "GRU_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GrupoUsuario_Usuarios_UsuariosPER_ID",
                        column: x => x.UsuariosPERID,
                        principalTable: "Usuarios",
                        principalColumn: "PER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets_Base",
                columns: table => new
                {
                    TicketBaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TarifaId = table.Column<int>(type: "int", nullable: false),
                    FechaHoraEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Patente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarifaEstacionamientoId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    EspacioId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: true),
                    Actual = table.Column<bool>(type: "bit", nullable: true),
                    FechaHoraSalida = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets_Base", x => x.TicketBaseId);
                    table.ForeignKey(
                        name: "FK_Tickets_Base_Espacios_EspacioId",
                        column: x => x.EspacioId,
                        principalTable: "Espacios",
                        principalColumn: "EspacioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Base_Estados_Tickets_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados_Tickets",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Base_Planes_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Planes",
                        principalColumn: "PER_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Base_Tarifas_Estacionamiento_TarifaEstacionamientoId",
                        column: x => x.TarifaEstacionamientoId,
                        principalTable: "Tarifas_Estacionamiento",
                        principalColumn: "TarifaEstacionamientoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccionGrupo",
                columns: table => new
                {
                    AccionesACCID = table.Column<int>(name: "AccionesACC_ID", type: "int", nullable: false),
                    GruposGRUID = table.Column<int>(name: "GruposGRU_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccionGrupo", x => new { x.AccionesACCID, x.GruposGRUID });
                    table.ForeignKey(
                        name: "FK_AccionGrupo_Acciones_AccionesACC_ID",
                        column: x => x.AccionesACCID,
                        principalTable: "Acciones",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccionGrupo_Grupos_GruposGRU_ID",
                        column: x => x.GruposGRUID,
                        principalTable: "Grupos",
                        principalColumn: "GRU_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccionUsuario",
                columns: table => new
                {
                    AccionesACCID = table.Column<int>(name: "AccionesACC_ID", type: "int", nullable: false),
                    UsuariosPERID = table.Column<int>(name: "UsuariosPER_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccionUsuario", x => new { x.AccionesACCID, x.UsuariosPERID });
                    table.ForeignKey(
                        name: "FK_AccionUsuario_Acciones_AccionesACC_ID",
                        column: x => x.AccionesACCID,
                        principalTable: "Acciones",
                        principalColumn: "ACC_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccionUsuario_Usuarios_UsuariosPER_ID",
                        column: x => x.UsuariosPERID,
                        principalTable: "Usuarios",
                        principalColumn: "PER_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    PagoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetodoDePagoId = table.Column<int>(type: "int", nullable: false),
                    TicketBaseId = table.Column<int>(type: "int", nullable: false),
                    MontoEstacionamiento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MontoServicios = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MontoDescuento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MontoFinal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaHoraPago = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.PagoId);
                    table.ForeignKey(
                        name: "FK_Pagos_Metodos_Pagos_MetodoDePagoId",
                        column: x => x.MetodoDePagoId,
                        principalTable: "Metodos_Pagos",
                        principalColumn: "MetodoDePagoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_Tickets_Base_TicketBaseId",
                        column: x => x.TicketBaseId,
                        principalTable: "Tickets_Base",
                        principalColumn: "TicketBaseId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TarifaServicioTicketBase_Tickets_Base_TicketsTicketBaseId",
                        column: x => x.TicketsTicketBaseId,
                        principalTable: "Tickets_Base",
                        principalColumn: "TicketBaseId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acciones_FOR_ID",
                table: "Acciones",
                column: "FOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AccionGrupo_GruposGRU_ID",
                table: "AccionGrupo",
                column: "GruposGRU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AccionUsuario_UsuariosPER_ID",
                table: "AccionUsuario",
                column: "UsuariosPER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_EspacioTipoVehiculo_VehiculosTipoVehiculoId",
                table: "EspacioTipoVehiculo",
                column: "VehiculosTipoVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Formularios_MOD_ID",
                table: "Formularios",
                column: "MOD_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_EST_GRU_ID",
                table: "Grupos",
                column: "EST_GRU_ID");

            migrationBuilder.CreateIndex(
                name: "IX_GrupoUsuario_UsuariosPER_ID",
                table: "GrupoUsuario",
                column: "UsuariosPER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_MetodoDePagoId",
                table: "Pagos",
                column: "MetodoDePagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_TicketBaseId",
                table: "Pagos",
                column: "TicketBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_DescuentoId",
                table: "Planes",
                column: "DescuentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarifa_Servicios_ServicioTipoServicioId",
                table: "Tarifa_Servicios",
                column: "ServicioTipoServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarifa_Servicios_TipoVehiculoId",
                table: "Tarifa_Servicios",
                column: "TipoVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarifas_Estacionamiento_TipoVehiculoId",
                table: "Tarifas_Estacionamiento",
                column: "TipoVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_TarifaServicioTicketBase_TicketsTicketBaseId",
                table: "TarifaServicioTicketBase",
                column: "TicketsTicketBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Base_EspacioId",
                table: "Tickets_Base",
                column: "EspacioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Base_EstadoId",
                table: "Tickets_Base",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Base_PlanId",
                table: "Tickets_Base",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_Base_TarifaEstacionamientoId",
                table: "Tickets_Base",
                column: "TarifaEstacionamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EST_USU_ID",
                table: "Usuarios",
                column: "EST_USU_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccionGrupo");

            migrationBuilder.DropTable(
                name: "AccionUsuario");

            migrationBuilder.DropTable(
                name: "EspacioTipoVehiculo");

            migrationBuilder.DropTable(
                name: "GrupoUsuario");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "TarifaServicioTicketBase");

            migrationBuilder.DropTable(
                name: "Acciones");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Metodos_Pagos");

            migrationBuilder.DropTable(
                name: "Tarifa_Servicios");

            migrationBuilder.DropTable(
                name: "Tickets_Base");

            migrationBuilder.DropTable(
                name: "Formularios");

            migrationBuilder.DropTable(
                name: "Estados_Grupos");

            migrationBuilder.DropTable(
                name: "Estados_Usuarios");

            migrationBuilder.DropTable(
                name: "Tipo_Servicios");

            migrationBuilder.DropTable(
                name: "Espacios");

            migrationBuilder.DropTable(
                name: "Estados_Tickets");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "Tarifas_Estacionamiento");

            migrationBuilder.DropTable(
                name: "Modulos");

            migrationBuilder.DropTable(
                name: "Descuentos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Tipos_Vehiculos");
        }
    }
}
