using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public static class PagoFactory
    {
        public static Pago CrearPagoCuota(Cuota cuota, MetodoDePago metodo)
        {
            var pago = new Pago { MetodoDePago = metodo };
            pago.Patente = cuota.Patente;
            pago.AgregarTicketCuota(cuota);
            pago.CalcularMontos();
            return pago;
        }

        public static Pago CrearPagoCuotaConServicios(Cuota cuota, List<ServicioConsumido> servicios, MetodoDePago metodo)
        {
            var pago = new Pago { MetodoDePago = metodo };
            pago.Patente = cuota.Patente;
            pago.AgregarTicketCuota(cuota);
            foreach (var s in servicios)
                pago.AgregarServicio(s);
            pago.CalcularMontos();
            return pago;
        }

        public static Pago CrearPagoServiciosPlan(List<ServicioConsumido> servicios, MetodoDePago metodo, Plan plan)
        {
            if (!servicios.Any())
                throw new InvalidOperationException("No hay servicios para liquidar");

            var pago = new Pago { MetodoDePago = metodo };
            pago.Patente = plan.Patente;
            foreach (var s in servicios)
                pago.AgregarServicio(s);
            pago.CalcularMontos();
            return pago;
        }
        public static Pago CrearPagoTicketDiario(Ticket_Diario ticket, MetodoDePago metodo)
        {
            var pago = new Pago { MetodoDePago = metodo };
            pago.Patente = ticket.Patente;
            pago.AgregarTicketCuota(ticket);
            foreach (var s in ticket.ServiciosConsumidos) 
                pago.AgregarServicio(s);
            pago.CalcularMontos();
            return pago;
        }
    }
}
