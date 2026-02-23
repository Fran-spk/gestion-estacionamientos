using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.contexto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Controladora
{
    public class ControladoraPagos
    {
        private static ControladoraPagos instancia;
        public static ControladoraPagos Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraPagos();
                return instancia;
            }
        }
        private ControladoraPagos() { }

     
        private IQueryable<Pago> QueryBase()
        {
            return Estacionamiento.Contexto.Pagos
                .Include(p => p.MetodoDePago)
                .Include(p => p.Detalles)
                    .ThenInclude(pd => pd.Ticket)                          
                        .ThenInclude(t => t.TarifaEstacionamiento)
                            .ThenInclude(ta => ta.TipoVehiculo)
                .Include(p => p.Detalles)
                    .ThenInclude(pd => pd.ServicioConsumido)
                        .ThenInclude(sc => sc.TarifaServicio)
                            .ThenInclude(ts => ts.ServicioVehiculo)
                                .ThenInclude(sv => sv.Servicio)
                .Include(p => p.Detalles)
                    .ThenInclude(pd => pd.ServicioConsumido)
                        .ThenInclude(sc => sc.TarifaServicio)
                            .ThenInclude(ts => ts.ServicioVehiculo)
                                .ThenInclude(sv => sv.Vehiculo);
        }

    
        public ReadOnlyCollection<Pago> getAllPagos()
        {
            return QueryBase()
                .ToList()
                .AsReadOnly();
        }



        public Pago? getPagoByTicket(int ticketId)
        {
            return QueryBase()
                .FirstOrDefault(p =>
                    p.Detalles.Any(d => d.TicketBaseId == ticketId));
        }



        public Pago? getPagoByServicioId(int servicioConsumidoId)
        {
            return QueryBase()
                .FirstOrDefault(p =>
                    p.Detalles.Any(d => d.ServicioConsumidoId == servicioConsumidoId));
        }

       
        public bool AgregarPago(Pago pago)
        {
            if (pago == null)
                throw new ArgumentNullException(nameof(pago), "El pago no puede ser nulo");

            if (pago.MetodoDePago == null)
                throw new InvalidOperationException("El pago debe tener un método de pago");

            if (!pago.Detalles.Any())
                throw new InvalidOperationException("El pago debe tener al menos un detalle");

            if (pago.MontoTotal <= 0)
                throw new InvalidOperationException("El monto total debe ser mayor a cero");

            foreach (var detalle in pago.Detalles)
            {
                if (detalle.TicketBaseId.HasValue)
                {
                    var ticketYaPagado = Estacionamiento.Contexto.PagoDetalles
                        .Any(d => d.TicketBaseId == detalle.TicketBaseId);

                    if (ticketYaPagado) return false;
                }

                if (detalle.ServicioConsumidoId.HasValue)
                {
                    var servicioYaPagado = Estacionamiento.Contexto.PagoDetalles
                        .Any(d => d.ServicioConsumidoId == detalle.ServicioConsumidoId);

                    if (servicioYaPagado) return false;
                }
            }
            foreach (var detalle in pago.Detalles.Where(d => d.ServicioConsumido != null))
            {
                detalle.ServicioConsumido!.Pagado = true;
                Estacionamiento.Contexto.ServiciosConsumidos.Update(detalle.ServicioConsumido);
            }
            try
            {
                Estacionamiento.Contexto.Pagos.Add(pago);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}