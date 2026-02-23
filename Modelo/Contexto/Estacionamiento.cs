using Microsoft.EntityFrameworkCore;
using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MODELO.seguridad;
using Modelo_Ids;



namespace MODELO.contexto
{
    public class Estacionamiento : DbContext
    {
        private static Estacionamiento contexto;
        public static Estacionamiento Contexto
        {
            get
            {
                if (contexto == null) { contexto = new Estacionamiento(); }
                return contexto;
            }
        }
        public Estacionamiento(){}



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationHelper.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public virtual DbSet<Ticket_Diario> Tickets { get; set; }
        public virtual DbSet<Cuota> Cuotas { get; set; }
        public virtual DbSet<TicketBase> Tickets_Base { get; set; }
        public virtual DbSet<TarifaEstacionamiento> Tarifas_Estacionamiento { get; set; }
        public virtual DbSet<TarifaServicio> Tarifa_Servicios { get; set; }
        public virtual DbSet<ServicioVehiculo> ServiciosVehiculos { get; set; }
        public virtual DbSet<Plan> Planes { get; set; }
        public virtual DbSet<Descuento> Descuentos { get; set; }
        public virtual DbSet<MetodoDePago> Metodos_Pagos { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<TipoVehiculo> Tipos_Vehiculos { get; set; }
        public virtual DbSet<TipoServicio> Tipo_Servicios { get; set; }
        public virtual DbSet<Espacio> Espacios { get; set; }
        public virtual DbSet<Estado_Ticket> Estados_Tickets { get; set; }
        public virtual DbSet<PagoDetalle> PagoDetalles { get; set; }
        public virtual DbSet<ServicioConsumido> ServiciosConsumidos { get; set; }

        public virtual DbSet<Accion> Acciones { get; set; }
        public virtual DbSet<Estado_Grupo> Estados_Grupos { get; set; }
        public virtual DbSet<Estado_Usuario> Estados_Usuarios { get; set; }
        public virtual DbSet<Formulario> Formularios { get; set; }
        public virtual DbSet<Grupo> Grupos { get; set; }
        public virtual DbSet<Modulo> Modulos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<AuditoriaSesion> AuditoriaSesiones { get; set; }
        public virtual DbSet<AuditoriaTicket> AuditoriaTickets { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ServicioVehiculo>()
                .HasIndex(sc => new { sc.TipoServicioId, sc.ServicioVehiculoId })
                .IsUnique();
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Plan>().ToTable("Planes");
            modelBuilder.Entity<Persona>().ToTable("Personas");


            //tpt de tickets y cuotas
            modelBuilder.Entity<TicketBase>().ToTable("Tickets_Base");
            modelBuilder.Entity<Cuota>().ToTable("Cuotas");
            modelBuilder.Entity<Ticket_Diario>().ToTable("Tickets_Diarios");

            modelBuilder.Entity<Usuario>()
                .HasBaseType<Persona>();

            modelBuilder.Entity<Plan>()
                .HasBaseType<Persona>();

            modelBuilder.Entity<Pago>()
            .Property(nameof(Pago.Monto))
            .HasField("monto");

            modelBuilder.Entity<Pago>()
            .Property(nameof(Pago.MontoTotal))
            .HasField("montoTotal");

            modelBuilder.Entity<Pago>()
                .Property(nameof(Pago.MontoDescuento))
                .HasField("montoDescuento");


            modelBuilder.Entity<Pago>()
                .Property(nameof(Pago.FechaHoraPago))
                .HasField("fechahorapago");
        }

    }

}
