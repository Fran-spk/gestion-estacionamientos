using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MODELO
{
    public class Estadia_Mensual:Estadia
    {
        public override void ActualizarEstadia(TicketBase Ticket)
        {
          
        }

        public override string ToString()
        {
            return "Mensual";
        }
    }
}
