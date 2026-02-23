using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public class CalculadorPagoServicio : CalculadorPago
    {
        public override void CalcularMonto(PagoDetalle pago)
        {
            if ((pago.Ticket == null) && (pago.ServicioConsumido!=null))
            {
                pago.Monto = pago.ServicioConsumido.TarifaServicio.Precio;
                pago.Detalle = "Pago por " + pago.ServicioConsumido.TarifaServicio;
            }
        }
    }
}
