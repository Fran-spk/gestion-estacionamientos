using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MODELO.seguridad;
using Modelo_Ids;

namespace Servicios
{
    public static class DemoraByServicioService
    {
        public static string CalcularDemora(TarifaServicio tarifa, ReadOnlyCollection<Ticket_Diario> tickets) //busco cuantos hay adentro con el servicio (FUNCION PARA TICKETS DIARIOS)
        {
            var ticketsConServicio = tickets
                .Where(ticket => ticket.ServiciosConsumidos != null &&
                                ticket.ServiciosConsumidos.Any(ts => ts.TarifaServicio.ServicioVehiculoId == tarifa.ServicioVehiculoId)).Count();

            var tiempoEstimadoTotal = tarifa.ServicioVehiculo.TiempoEstimado * (ticketsConServicio == 0 ? 1 : ticketsConServicio);

            if (ticketsConServicio == 0)
                return "No hay vehículos en espera para este servicio. Atención inmediata disponible.";

            string vehiculoTexto = ticketsConServicio == 1 ? "vehículo" : "vehículos";

            return $"⏱️ Hay {ticketsConServicio} {vehiculoTexto} {tarifa.ServicioVehiculo.Vehiculo} en espera.\n" +
                   $"Tiempo estimado de demora: {tiempoEstimadoTotal} minutoa";
        }
    }
}
