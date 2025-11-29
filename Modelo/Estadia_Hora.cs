
using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Estadia_Hora : Estadia
    {
        public override void ActualizarEstadia(TicketBase Ticket)
        {
            var ticket = Ticket as Ticket;
            if (ticket.Horas >= 6)
            {
                Ticket.Estadia = new Estadia_Dia();
            }
        }

        public override string ToString()
        {
            return "Por Hora";
        }
    }
}
