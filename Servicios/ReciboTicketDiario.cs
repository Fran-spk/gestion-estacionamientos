using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Servicios
{
    // ─── Recibo Ticket Diario ────────────────────────────────────
    public class ReciboTicketDiario : IGeneradorRecibo
    {
        public string Generar(Pago pago)
        {
            var detalleTicket = pago.Detalles.First(d => d.Ticket is Ticket_Diario);
            var ticket = (Ticket_Diario)detalleTicket.Ticket!;
            var servicios = pago.Detalles.Where(d => d.ServicioConsumido != null).ToList();

            var sb = new StringBuilder();
            sb.AppendLine("******* RECIBO DE PAGO *******");
            sb.AppendLine("Software de Estacionamiento");
            sb.AppendLine("Calle 123");
            sb.AppendLine("--------------------------------");
            sb.AppendLine($"Ticket Nro: {ticket.TicketBaseId}");
            sb.AppendLine("Datos del Vehículo");
            sb.AppendLine($"Patente: {ticket.Patente}");
            sb.AppendLine($"Tipo de vehículo: {ticket.TarifaEstacionamiento.TipoVehiculo.NombreVehiculo}");
            sb.AppendLine($"Estadía: {ticket.Estadia}");
            sb.AppendLine($"Hora llegada: {ticket.FechaHoraEmision:dd/MM/yyyy HH:mm}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine($"Fecha de Pago: {pago.FechaHoraPago:dd/MM/yyyy HH:mm}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine("Detalle del Pago:");
            sb.AppendLine($"  Estacionamiento: ${detalleTicket.Monto:F2}");

            if (servicios.Any())
            {
                sb.AppendLine("Servicios Adicionales:");
                foreach (var s in servicios)
                    sb.AppendLine($"  - {s.Detalle}: ${s.Monto:F2}");
                sb.AppendLine($"  Subtotal servicios: ${servicios.Sum(s => s.Monto):F2}");
            }
            else
            {
                sb.AppendLine("Servicios Adicionales: NO APLICAN");
            }

            sb.AppendLine("--------------------------------");
            sb.AppendLine($"Forma de Pago: {pago.MetodoDePago}");
            sb.AppendLine($"TOTAL PAGADO: ${pago.MontoTotal:F2}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine("Gracias por su visita");
            return sb.ToString();
        }
    }
}
