
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MODELO
{
    public class Tarifa
    {
        private int tipovehiculoId;
        private decimal preciomediahora;
        private decimal preciohora;
        private decimal preciodia;
        private decimal preciomes;
        private bool vigente;
        private TipoVehiculo tipovehiculo;
        private int taridaId;
        private DateTime fechahoraactualizacion;

        public int TarifaId
        {
            get { return taridaId; }
            set { taridaId = value; }
        }

        public bool Vigente
        {
            get { return vigente; }
            set { vigente = value; }
        }

        public TipoVehiculo TipoVehiculo
        {
            get { return tipovehiculo; }
            set { tipovehiculo = value; }
        }

        public DateTime FechaHoraActualizacion
        {
            get { return fechahoraactualizacion; }
            set { fechahoraactualizacion = value; }
        }

        public override string ToString()
        {
            return tipovehiculo.NombreVehiculo;
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
