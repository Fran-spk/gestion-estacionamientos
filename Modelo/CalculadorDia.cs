using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public class CalculadorDia: CalculadorPago
    {
        public override void CalcularMonto(Pago pago)
        {
            if (pago.Ticket is Ticket ticket)
            {
                if (ticket.Estadia is Estadia_Dia)
                {
                    pago.MontoEstacionamiento = ticket.TarifaEstacionamiento.PrecioDia;
                }
            }
        }
    }
}
