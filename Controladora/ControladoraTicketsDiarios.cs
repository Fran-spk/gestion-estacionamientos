using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO.contexto;
using MODELO;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using Servicios;

namespace Controladora
{
    public class ControladoraTicketsDiarios
    {
        private static ControladoraTicketsDiarios instancia;

        private ControladoraTicketsDiarios() { }

        public static ControladoraTicketsDiarios Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraTicketsDiarios();
                return instancia;
            }
        }
        public ReadOnlyCollection<Ticket_Diario> getAllTicketsPendientes()
        {
            return Estacionamiento.Contexto.Tickets
                .Include(x => x.TarifaEstacionamiento)
                .Include(x => x.Estado)
                .Include(x => x.ServiciosConsumidos)
                  .ThenInclude(a => a.TarifaServicio)
                      .ThenInclude(a => a.ServicioVehiculo)
                      .ThenInclude(a => a.Vehiculo)
             .Include(x => x.ServiciosConsumidos)
                    .ThenInclude(a => a.TarifaServicio)
                      .ThenInclude(a => a.ServicioVehiculo)
                      .ThenInclude(a => a.Servicio)
                .Where(x => x.Estado.Nombre == "Pendiente")
                .ToList()
                .AsReadOnly();
        }

        public ReadOnlyCollection<Ticket_Diario> getAllTickets()
        {
            return Estacionamiento.Contexto.Tickets
                .Include(x => x.TarifaEstacionamiento)
                .Include(x => x.Estado)
                .Include(x => x.ServiciosConsumidos)
                    .ThenInclude(a=>a.TarifaServicio)
                      .ThenInclude(a=>a.ServicioVehiculo)
                      .ThenInclude(a=>a.Vehiculo)
             .Include(x => x.ServiciosConsumidos)
                    .ThenInclude(a => a.TarifaServicio)
                      .ThenInclude(a => a.ServicioVehiculo)
                      .ThenInclude(a => a.Servicio)
                .ToList()
                .AsReadOnly();
        }

        public Ticket_Diario? getTicketPendienteByPatente(string patente)
        {
            return getAllTicketsPendientes().FirstOrDefault(x => x.Patente == patente);
        }

        public bool AgregarTicket(Ticket_Diario ticket, int idUsuario)
        {
            var existe = Estacionamiento.Contexto.Tickets
                .AsNoTracking()
                .Any(x => x.TicketBaseId == ticket.TicketBaseId);

            if (existe)
                return false;

            Estacionamiento.Contexto.Tickets_Base.Add(ticket);
            Estacionamiento.Contexto.SaveChanges();
            // crear
            var auditoria = AuditoriaTicket.RegistrarCreacion(
                idTicket: ticket.TicketBaseId,
                estadoInicial: $"Patente={ticket.Patente}, TarifaId={ticket.TarifaEstacionamiento.TarifaEstacionamientoId}, EstadoId={ticket.EstadoId}",
                idUsuario: idUsuario
            );
            Estacionamiento.Contexto.AuditoriaTickets.Add(auditoria);
            Estacionamiento.Contexto.SaveChanges();
            return true;
        }

        public bool RegistrarSalida(Ticket_Diario ticket, DateTime fechaHoraSalida, int idUsuario)
        {
            var ticketEx = Estacionamiento.Contexto.Tickets
                .Include(t => t.Estado)
                .FirstOrDefault(t => t.TicketBaseId == ticket.TicketBaseId);

            if (ticket == null)
                return false;

            // Obtener estado "Pagado"
            var estadoPagado = Estacionamiento.Contexto.Estados_Tickets
                .FirstOrDefault(e => e.Nombre == "Pagado");

            if (estadoPagado == null)
                return false;
            // 2. Cambiar estado a Pagado
            var estadoAnterior = ticket.Estado;
            ticket.Estado = estadoPagado;

            // Auditar: cambio de estado
            var auditoriaEstado = AuditoriaTicket.RegistrarModificacion(
                idTicket: ticket.TicketBaseId,
                campo: "EstadoId",
                valorAnterior: estadoAnterior.Nombre.ToString(),
                valorNuevo: estadoPagado.Nombre.ToString(),
                idUsuario: idUsuario
            );
            Estacionamiento.Contexto.AuditoriaTickets.Add(auditoriaEstado);
            Estacionamiento.Contexto.SaveChanges();
            return true;
        }

        public string AnularTicket(TicketBase ticket, Estado_Ticket estadoAnulado, int idUsuario)
        {
            var existente = Estacionamiento.Contexto.Tickets
                .Include(x => x.Estado)
                .FirstOrDefault(x => x.TicketBaseId == ticket.TicketBaseId);

            if (existente == null)
                return "Ticket no encontrado";

            if (existente.Estado.Nombre != "Pendiente")
                return "No es posible anular este ticket";

            var estadoAnterior = existente.Estado;
            existente.Estado = estadoAnulado;

            // Auditar anulación
            var auditoria = AuditoriaTicket.RegistrarModificacion(
                idTicket: existente.TicketBaseId,
                campo: "EstadoId",
                valorAnterior: estadoAnterior.Nombre.ToString(),
                valorNuevo: estadoAnulado.Nombre.ToString(),
                idUsuario: idUsuario
            );
            Estacionamiento.Contexto.AuditoriaTickets.Add(auditoria);

            Estacionamiento.Contexto.SaveChanges();

            return "Ticket anulado";
        }

        public ReadOnlyCollection<AuditoriaTicket> ObtenerHistorialTicketById(int ?ticketId)
        {
            return Estacionamiento.Contexto.AuditoriaTickets
                .Include(a => a.Usuario)
                .Where(a => a.TicketBaseId == ticketId)
                .OrderBy(a => a.FechaHora)
                .ToList()
                .AsReadOnly();
        }
        public ReadOnlyCollection<AuditoriaTicket> AllHistorialTicket()
        {
            return Estacionamiento.Contexto.AuditoriaTickets
                .Include(a => a.Usuario)
                .OrderBy(a => a.FechaHora)
                .ToList()
                .AsReadOnly();
        }
        public bool AgregarServicio(Ticket_Diario ticket, TarifaServicio tarifa, int idUsuario)
        {
            var ticketEx = Estacionamiento.Contexto.Tickets
                .Include(t => t.ServiciosConsumidos)
                .FirstOrDefault(t => t.TicketBaseId == ticket.TicketBaseId);

            if (ticketEx == null)
                return false;

            bool resultado = ticket.RegistrarServicio(tarifa);

            if (resultado)
            {
                // Auditar: agregar servicio
                var auditoria = AuditoriaTicket.RegistrarAgregarServicio(
                    idTicket: ticket.TicketBaseId,
                    nombreServicio: tarifa.ServicioVehiculo.Servicio.Descripcion,
                    precio: tarifa.Precio,
                    idUsuario: idUsuario
                );
                Estacionamiento.Contexto.AuditoriaTickets.Add(auditoria);

                Estacionamiento.Contexto.SaveChanges();
            }

            return resultado;
        }


        public bool QuitarServicio(int ticketId, int servicioConsumidoId, int idUsuario, string motivo = null)
        {
            var ticket = Estacionamiento.Contexto.Tickets
                .Include(t => t.ServiciosConsumidos)
                    .ThenInclude(sc => sc.TarifaServicio)
                    .ThenInclude(ts => ts.ServicioVehiculo)
                .FirstOrDefault(t => t.TicketBaseId == ticketId);

            if (ticket == null)
                return false;

            var servicio = ticket.ServiciosConsumidos
                .FirstOrDefault(s => s.ServicioConsumidoId == servicioConsumidoId);

            if (servicio == null || servicio.Anulado)
                return false;
            ticket.AnularServicio(servicioConsumidoId);

            var auditoria = AuditoriaTicket.RegistrarEliminarServicio(
                idTicket: ticketId,
                nombreServicio: servicio.TarifaServicio.ServicioVehiculo.Servicio.Descripcion,
                motivo: motivo,
                idUsuario: idUsuario
            );
            Estacionamiento.Contexto.AuditoriaTickets.Add(auditoria);

            Estacionamiento.Contexto.SaveChanges();
            return true;
        }

        public bool IsPresenteByPatente(string patente)
        {
            var ticketPendiente = getAllTicketsPendientes()
                .FirstOrDefault(x => x.Patente == patente);

            if (ticketPendiente != null)
                return true;
            var plan = ControladoraPlanes.Instancia
                .getPlanActivoByPatente(patente);

            return plan != null;
        }

        public void ActualizarTicketsVencidos()
        {
            var estadoCancelado = Estacionamiento.Contexto.Estados_Tickets
                .FirstOrDefault(x => x.Nombre == "Cancelado");

            if (estadoCancelado == null)
                return;

            var tickets = Estacionamiento.Contexto.Tickets
                .Include(x => x.Estado)
                .ToList();

            bool huboCambios = false;

            foreach (var ticket in tickets)
            {
                // 1. Vencido → Cancelado (máxima prioridad)
                if (ticket.Estadia is Estadia_Vencida &&
                    ticket.Estado.Nombre != "Cancelado")
                {
                    ticket.Estado = estadoCancelado;
                    huboCambios = true;
                    continue;
                }
            }

            if (huboCambios)
                Estacionamiento.Contexto.SaveChanges();
        }

    }
}
