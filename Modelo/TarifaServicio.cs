using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class TarifaServicio: TarifaBase
    {
  
        private decimal precio;
        private int tarifaServicioId;
        private TipoServicio ?servicio;
        private List<TicketBase> ?tickets = new List<TicketBase>();
        public override string ToString()
        {
            return base.TipoVehiculo.NombreVehiculo;
        }
        public int TarifaServicioId
        {
            get { return tarifaServicioId; }
            set { tarifaServicioId = value; }
        }

        public List<TicketBase> Tickets
        {
            get { return tickets; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public TipoServicio ? Servicio
        { 
            get { return servicio; }
            set { servicio = value; }
        }
    }
}

