using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MODELO
{
    public class TarifaEstacionamiento: TarifaBase
    {
        private int tipovehiculoId;
        private TipoVehiculo tipovehiculo;
        private decimal preciomediahora;
        private decimal preciohora;
        private decimal preciodia;
        private decimal preciomes;
        private int tarifaEstacionamientoId;

        public override string ToString()
        {
            return TipoVehiculo.NombreVehiculo;
        }
        public int TarifaEstacionamientoId
        {
            get { return tarifaEstacionamientoId; }
            set { tarifaEstacionamientoId = value; }
        }

        public TipoVehiculo TipoVehiculo
        {
            get { return tipovehiculo; }
            set { tipovehiculo = value; }
        }
        public int TipoVehiculoId
        {
            get { return tipovehiculoId; }
            set { tipovehiculoId = value; }
        }
        public decimal PrecioMediaHora
        {
            get { return preciomediahora; }
            set { preciomediahora = value; }
        }

        public decimal PrecioHora
        {
            get { return preciohora; }
            set { preciohora = value; }
        }

        public decimal PrecioDia
        {
            get { return preciodia; }
            set { preciodia = value; }
        }

        public decimal PrecioMes
        {
            get { return preciomes; }
            set { preciomes = value; }
        }
    }
}
