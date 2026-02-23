using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Estadia_Dia : Estadia
    {
        public override void ActualizarEstadia(TicketBase Ticket)
        {
            var ticket = Ticket as Ticket_Diario;
            if(ticket.Horas > 24)
            {
                ticket.Estadia = new Estadia_Vencida();
            }           
        }

        public override string ToString()
        {
            return "Por Dia";
        }
    }
}
