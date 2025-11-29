using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class TipoVehiculo: IObserver
    {
        private int tipovehiculoId;
        private string nombrevehiculo;
        private string descripcion;
        private bool estado;
        private bool disponibilidad;
        

        private List<Espacio> espacios;

        public TipoVehiculo()
        {
            espacios = new List<Espacio>();
        }

        public bool Disponibilidad
        {
            get 
            {
                ActualizarEstado();
                return disponibilidad;
            }       
        }
        public List<Espacio> Espacios
        {
            get { return espacios; }
            set { espacios = value; }
        }
         
        public int TipoVehiculoId
        {
            get { return tipovehiculoId; }
            set { tipovehiculoId = value; }
        }

        public string NombreVehiculo
        {
            get { return nombrevehiculo; }
            set { nombrevehiculo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public void ActualizarEstado()
        {
            bool libre = espacios.Any(x => x.Ocupacion < x.Capacidad);
            disponibilidad = libre;
        }

        public override string ToString()
        {
            return NombreVehiculo.ToString();
        }
    }
}
