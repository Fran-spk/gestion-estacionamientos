using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Ticket : TicketBase
    {
        private DateTime fechahorasalida;
        private double minutos;
        private double horas;

        public DateTime FechaHoraSalida
        {
            get { return fechahorasalida; }
            set { fechahorasalida = value; }
        }



        public double Minutos
        {
            get 
            {
                if (fechahorasalida == DateTime.MinValue) 
                {
                    TimeSpan result = (DateTime.Now - base.FechaHoraEmision);
                    minutos = (result.TotalHours - Math.Truncate(result.TotalHours)) * 60;
                }
                else
                {
                    TimeSpan result = (fechahorasalida - base.FechaHoraEmision);
                    minutos = (result.TotalHours - Math.Truncate(result.TotalHours)) * 60;                 
                }
                return minutos;
            }

        }

        public double Horas
        {
            get 
            {
                if (fechahorasalida == DateTime.MinValue)
                {
                    TimeSpan result = DateTime.Now - base.FechaHoraEmision;
                    horas = Math.Truncate(result.TotalHours);
                }
                else
                {
                    TimeSpan result = fechahorasalida - base.FechaHoraEmision;
                    horas = Math.Truncate(result.TotalHours);
                    
                }
                return horas;
            }
        }

 

    }
}
