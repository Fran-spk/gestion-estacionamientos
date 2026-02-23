using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo_Ids;

namespace MODELO
{
    public class Ticket_Diario : TicketBase, IConsumidorDeServicios
    {
        private DateTime fechahorasalida;
        private double minutos;
        private double horas;
        private List<ServicioConsumido> serviciosConsumidos = new List<ServicioConsumido>();
        
        public List<ServicioConsumido> ServiciosConsumidos
        {
            get { return serviciosConsumidos; }
            set { serviciosConsumidos = value; }
        }
        public DateTime FechaHoraSalida
        {
            get { return fechahorasalida; }
            set { fechahorasalida = value; }
        }

        public bool RegistrarServicio(TarifaServicio tarifa)
        {
            var ok = serviciosConsumidos.Any(x => x.Pendiente &&(x.TarifaServicio.ServicioVehiculoId == tarifa.ServicioVehiculo.ServicioVehiculoId));
            if (!ok)
            {
                ServiciosConsumidos.Add(new ServicioConsumido
                {
                    TarifaServicio = tarifa,
                    FechaHoraAsignado = DateTime.Now
                });
                return true;
            }
            return false;
           
        }

        public void AnularServicio(int servicioConsumidoId)
        {
            var servicio = ServiciosConsumidos
                .FirstOrDefault(s => s.ServicioConsumidoId == servicioConsumidoId);

            if (servicio != null)
                servicio.Anular();
            
        }

        public IReadOnlyCollection<ServicioConsumido> ObtenerServiciosPendientes()
         => ServiciosConsumidos.Where(s => !s.Pagado && !s.Anulado).ToList();
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