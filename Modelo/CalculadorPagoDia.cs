using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public class CalculadorPagoDia: CalculadorPago
    {
        public override void CalcularMonto(PagoDetalle pago)
        {
            if (pago.Ticket is Ticket_Diario ticket)
            {
                if (ticket.Estadia is Estadia_Dia)
                {
                    pago.Monto = ticket.TarifaEstacionamiento.PrecioDia;
                }
            }
            pago.Detalle= "Pago estadia por dia";
        }
        
    }
}
