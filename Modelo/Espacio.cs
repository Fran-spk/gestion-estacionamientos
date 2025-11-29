using MODELO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Espacio : ISubject
    {
        public Espacio()
        {
            vehiculos = new List<TipoVehiculo>();
        }
        private int espacioId;
        private string nombreespacio;
        private int capacidad;
        private bool esmenusal;
        private List<TipoVehiculo>vehiculos;

        


        private List<TicketBase> tickets = new List<TicketBase>();  

        public List<TicketBase> Tickets
        {
            get { return tickets; }
            set { tickets = value; }
        }

        public int EspacioId
        {
            get { return espacioId; }
            set { espacioId = value; }
        }

        public string NombreEspacio
        {
            get { return nombreespacio; }
            set { nombreespacio = value; }
        }
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        public bool EsMenusal
        {
            get { return esmenusal; }
            set { esmenusal = value; }
        }

        public List<TipoVehiculo> Vehiculos
        {
            get { return vehiculos; }
            set { vehiculos = value; }
        }

        public int Ocupacion
        {
            get { return OcupacionActual(); }
        }

        public bool Disponibilidad
        {
            get
            {
                if (Ocupacion < Capacidad)
                {
                    return true;
                }
                else
                {
                    Notificar();
                    return false;
                }
            }
        }


        public bool Agregar(IObserver vehiculo)
        {
            var vehiculoTipo = vehiculo as TipoVehiculo;
            var vehiculoex = vehiculos.FirstOrDefault(v=>v.TipoVehiculoId== vehiculoTipo.TipoVehiculoId);
            if (vehiculoex == null) 
            {
                vehiculos.Add(vehiculoTipo);
               
                return true;
            }
            return false;
        }

        public bool Quitar(IObserver vehiculo) 
        {
            var vehiculoTipo = vehiculo as TipoVehiculo;
            var vehiculoex = vehiculos.FirstOrDefault(v => v.TipoVehiculoId == vehiculoTipo.TipoVehiculoId);
            if (vehiculoex != null)
            {
                vehiculos.Remove(vehiculoTipo);
               
                return true;
            }
            return false;
        }

    
        public void Notificar()
        {
            foreach (var tipo_vehiculo in vehiculos)
            {
                tipo_vehiculo.ActualizarEstado();
            }
        }

        int OcupacionActual()
        {
            var diarios = tickets.Count(x => x.Estado.Nombre == "Pendiente" && x is Ticket);
            var cuotas = tickets.Where(x => x is Cuota).ToList().OfType<Cuota>();
            var planesUnicos = cuotas
                .Where(x => x.Plan.EstadoPlan)
                .Select(x => x.Plan)
                .Distinct()
                .Count();          
            return diarios+planesUnicos;
        }

       

    }
}
