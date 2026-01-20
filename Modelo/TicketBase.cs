
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public abstract class TicketBase
    {
        public TicketBase() 
        {
            estadia= new Estadia_Media_Hora();
            tarifasAdicionales = new List<TarifaServicio>();
        }
        private int ticketbaseId;
        private DateTime fechahoraemision;
        private string patente;
        private TarifaEstacionamiento tarifaEstacionamiento;
        private int tarifaEstacionamientoId;
        private List<TarifaServicio> tarifasAdicionales;
        private Estadia estadia;
        private Estado_Ticket estado;
        private int estadoId;
        private string codigo;
        private Espacio espacio;
        private int espacioId;

        public int TicketBaseId
        {
            get { return ticketbaseId; }
            set { ticketbaseId = value; }
        }

        public List<TarifaServicio> TarifasAdicionales
        {
            get { return tarifasAdicionales; }
            set { tarifasAdicionales = value; }
        }
        public int TarifaId
        {
            get { return tarifaEstacionamientoId; }
            set { tarifaEstacionamientoId = value; }
        }

      
        public DateTime FechaHoraEmision
        {
            get { return fechahoraemision; }
            set { fechahoraemision = value; }
        }

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }
  

        public TarifaEstacionamiento TarifaEstacionamiento
        {
            get { return tarifaEstacionamiento; }
            set { tarifaEstacionamiento = value; }
        }

 

        public Estadia Estadia
        {
            get 
            {
                CambiarEstadia();
                return estadia; 
            }

            set { estadia = value; }
        }

        public Estado_Ticket Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int EstadoId
        {
            get { return estadoId; }
            set { estadoId = value; }
        }


        public Espacio Espacio
        {
            get { return espacio; }
            set { espacio = value; }
        }

        public int EspacioId 
        {
            get { return espacioId; }
            set { espacioId = value; }
        }

        public string Codigo
        {
            get 
            {
                codigo = $"{Patente}{FechaHoraEmision}";
                return codigo; 
            }
        }



       void CambiarEstadia()
       {
            estadia.ActualizarEstadia(this);
       }


    }
}

