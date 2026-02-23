
using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Estadia_Media_Hora : Estadia
    {
        public override void ActualizarEstadia(TicketBase Ticket)
        {

            if (Ticket is Cuota)
            {
                Ticket.Estadia = new Estadia_Mensual();
            }
            else
            {
                var ticket = Ticket as Ticket_Diario;
                if (ticket.Horas>= 1 || ticket.Minutos > 30)
                {
                    Ticket.Estadia = new Estadia_Hora();
                }
            }
        }

        public override string ToString()
        {
            return "Por Media Hora";
        }
    }
}
