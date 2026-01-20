using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace MODELO
{
    public abstract class TarifaBase
    {
        [NotMapped]
        private int tipovehiculoId;
        private bool vigente;
        private TipoVehiculo tipovehiculo;
        private DateTime fechahoraactualizacion;

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
    }
}
