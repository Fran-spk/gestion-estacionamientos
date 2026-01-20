using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public class CalculadorHoras : CalculadorPago
    {
        public override void CalcularMonto(Pago pago)
        {
            if (pago.Ticket is Ticket ticket)
            {
                if (ticket.Estadia is Estadia_Media_Hora)
                {
                    pago.MontoEstacionamiento += ticket.TarifaEstacionamiento.PrecioMediaHora;
                }
                else if (ticket.Estadia is Estadia_Hora)
                {
                    pago.MontoEstacionamiento += (Decimal)ticket.Horas * ticket.TarifaEstacionamiento.PrecioHora;

                    if (ticket.Minutos < 30 && ticket.Minutos > 0)
                    {
                        pago.MontoEstacionamiento += ticket.TarifaEstacionamiento.PrecioMediaHora;
                    }
                    else if (ticket.Minutos >= 30)
                    {
                        pago.MontoEstacionamiento += ticket.TarifaEstacionamiento.PrecioHora;
                    }
                }
            }
        }
    }
}
