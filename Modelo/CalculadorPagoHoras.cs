using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public class CalculadorPagoHoras : CalculadorPago
    {
        public override void CalcularMonto(PagoDetalle pago)
        {
            if (pago.Ticket is Ticket_Diario ticket)
            {
                if (ticket.Estadia is Estadia_Media_Hora)
                {
                    pago.Monto += ticket.TarifaEstacionamiento.PrecioMediaHora;
                }
                else if (ticket.Estadia is Estadia_Hora)
                {
                    pago.Monto += (Decimal)ticket.Horas * ticket.TarifaEstacionamiento.PrecioHora;

                    if (ticket.Minutos < 30 && ticket.Minutos > 0)
                    {
                        pago.Monto += ticket.TarifaEstacionamiento.PrecioMediaHora;
                    }
                    else if (ticket.Minutos >= 30)
                    {
                        pago.Monto += ticket.TarifaEstacionamiento.PrecioHora;
                    }
                }
            }
            pago.Detalle = "Pago estadia por horas";
        }
    }
}
