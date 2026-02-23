using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo_Ids;

namespace MODELO
{
    public class TarifaServicio: TarifaBase
    {
  
        private decimal precio;
        private int tarifaServicioId;
        private ServicioVehiculo servicioVehiculo;
        private int servicioVehiculoId;
        public override string ToString()
        {
            return servicioVehiculo.Servicio.Descripcion;
        }

        public ServicioVehiculo ServicioVehiculo 
        { 
            get { return servicioVehiculo; }
            set { servicioVehiculo = value; }
        }

        public int ServicioVehiculoId
        {
            get { return servicioVehiculoId; }
            set { servicioVehiculoId = value; }
        }
        public int TarifaServicioId
        {
            get { return tarifaServicioId; }
            set { tarifaServicioId = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

      
    }
}

