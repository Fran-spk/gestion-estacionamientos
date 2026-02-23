using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public class CalculadorPagoMensual : CalculadorPago
    {
        public override void CalcularMonto(PagoDetalle pago)
        {
            if (pago.Ticket is Cuota cuota)
            {
                pago.Monto = cuota.TarifaEstacionamiento.PrecioMes;
                if (cuota.Plan?.Descuento != null)
                {
                    pago.MontoDescuento= Math.Truncate(
                    (cuota.TarifaEstacionamiento.PrecioMes * cuota.Plan.Descuento.Porcentaje) / 100m);
                }
            }
            pago.Detalle = "Pago de cuota";
        }
    }
}

