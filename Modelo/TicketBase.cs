
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
        }
        private int ticketbaseId;
        private DateTime fechahoraemision;
        private string patente;
        private Tarifa tarifa;
        private int taridaId;
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

        public int TarifaId
        {
            get { return taridaId; }
            set { taridaId = value; }
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
  

        public Tarifa Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
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

