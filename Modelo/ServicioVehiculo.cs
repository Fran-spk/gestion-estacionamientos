using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public class ServicioVehiculo
    {
        private int servicioVehiculoId;
        private TipoServicio tipoServicio;
        private int tipoServicioId;
        private TipoVehiculo tipoVehiculo;
        private int tipoVehiculoId;
        private bool esActivo;
        private double tiempoEstimado;
        private List<TarifaServicio> tarifas = new List<TarifaServicio>();

        public ICollection<TarifaServicio> Tarifas
        {
            get { return tarifas; }
            private set { tarifas = value?.ToList() ?? new List<TarifaServicio>(); }
        }

        public override string ToString()
        {
            return tipoServicio.Descripcion +" Para "+ tipoVehiculo.ToString();
        }
        public TarifaServicio? getTarifaActual() //
        {
            if (EsActivo) 
            {
                var Tarifa = tarifas.FirstOrDefault(t => t.Vigente);
                return Tarifa ?? null;
            }
            else {  return null; } 
        }

        public int ServicioVehiculoId
        {
            get { return servicioVehiculoId; }
            set { servicioVehiculoId = value; }
        }
        public TipoServicio Servicio
        {
            get { return tipoServicio; }
            set { tipoServicio = value; }
        }

        public int TipoServicioId
        {
            get { return tipoServicioId; }
            set { tipoServicioId = value; }
        }
        public int TipoVehiculoId
        {
            get { return tipoVehiculoId; }
            set { tipoVehiculoId = value; }
        }

        public double TiempoEstimado
        {
            get { return tiempoEstimado; }
            set { tiempoEstimado = value; }
        }
        public TipoVehiculo Vehiculo
        {
            get { return tipoVehiculo; }
            set { tipoVehiculo = value; }
        }

        public bool EsActivo
        {
            get { return esActivo; }
            set { esActivo = value; }
        }
    }

}
