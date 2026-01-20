using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public class CalculadorMensual : CalculadorPago
    {
        public override void CalcularMonto(Pago pago)
        {
            if (pago.Ticket is Cuota cuota)
            {
                pago.MontoEstacionamiento = cuota.TarifaEstacionamiento.PrecioMes;
                if (cuota.Plan?.Descuento != null)
                {
                    pago.MontoDescuento = pago.MontoEstacionamiento * (cuota.Plan.Descuento.Porcentaje / 100);
                }
            }
        }
    }
}

