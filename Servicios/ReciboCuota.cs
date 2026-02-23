using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Servicios
{
    // ─── Recibo Cuota ────────────────────────────────────────────
    public class ReciboCuota : IGeneradorRecibo
    {
        public string Generar(Pago pago)
        {
            var detalleCuota = pago.Detalles.First(d => d.Ticket is Cuota);
            var cuota = (Cuota)detalleCuota.Ticket!;
            var servicios = pago.Detalles.Where(d => d.ServicioConsumido != null).ToList();
            var plan = cuota.Plan;
            var cuotasOrdenadas = plan.Cuotas.OrderBy(c => c.FechaHoraEmision).ToList();
            int numeroCuota = cuotasOrdenadas.IndexOf(cuota) + 1;

            var sb = new StringBuilder();
            sb.AppendLine("******* RECIBO DE PAGO *******");
            sb.AppendLine("Software de Estacionamiento");
            sb.AppendLine("Calle white 123");
            sb.AppendLine("--------------------------------");
            sb.AppendLine("Datos del Plan Mensual");
            sb.AppendLine($"Patente: {cuota.Patente}");
            sb.AppendLine($"Tipo de vehículo: {cuota.TarifaEstacionamiento.TipoVehiculo}");
            sb.AppendLine($"Cuota Nro: {numeroCuota}");
            sb.AppendLine($"Vencimiento: {cuota.FechaHoraVencimiento:dd/MM/yyyy}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine($"Fecha de Pago: {pago.FechaHoraPago:dd/MM/yyyy HH:mm}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine("Detalle del Pago:");
            sb.AppendLine($"  Cuota mensual: ${detalleCuota.Monto:F2}");

            if (pago.MontoDescuento > 0)
                sb.AppendLine($"  Descuento aplicado: -${pago.MontoDescuento:F2}");

            if (servicios.Any())
            {
                sb.AppendLine("Servicios del Plan:");
                foreach (var s in servicios)
                    sb.AppendLine($"  - {s.Detalle}: ${s.Monto:F2}");
                sb.AppendLine($"  Subtotal servicios: ${servicios.Sum(s => s.Monto):F2}");
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
