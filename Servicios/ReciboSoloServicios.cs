using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Servicios
{
    // ─── Recibo Solo Servicios ───────────────────────────────────
    public class ReciboSoloServicios : IGeneradorRecibo
    {
        public string Generar(Pago pago)
        {
            var servicios = pago.Detalles.Where(d => d.ServicioConsumido != null).ToList();

            var sb = new StringBuilder();
            sb.AppendLine("******* RECIBO DE PAGO *******");
            sb.AppendLine("Software de Estacionamiento");
            sb.AppendLine("Calle white 222");
            sb.AppendLine("--------------------------------");
            sb.AppendLine($"Patente: {pago.Patente}");
            sb.AppendLine($"Fecha de Pago: {pago.FechaHoraPago:dd/MM/yyyy HH:mm}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine("Servicios Liquidados:");
            foreach (var s in servicios)
                sb.AppendLine($"  - {s.Detalle}: ${s.Monto:F2}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine($"Forma de Pago: {pago.MetodoDePago}");
            sb.AppendLine($"TOTAL PAGADO: ${pago.MontoTotal:F2}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine("Gracias por su visita");
            return sb.ToString();
        }
    }
}
