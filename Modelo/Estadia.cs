using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    [NotMapped]
    public abstract class Estadia
    {
        public abstract void ActualizarEstadia(TicketBase Ticket);
        public abstract override string ToString();
    }
}
