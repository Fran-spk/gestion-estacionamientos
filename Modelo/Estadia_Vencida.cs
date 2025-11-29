using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Estadia_Vencida : Estadia
    {
        public override void ActualizarEstadia(TicketBase Ticket)
        {

        }

        public override string ToString()
        {
            return "Tiempo vencido";
        }
    }
}
