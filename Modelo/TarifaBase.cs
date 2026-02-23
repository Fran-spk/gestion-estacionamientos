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
        
        private bool vigente;
        private DateTime fechahoraactualizacion;

        public bool Vigente
        {
            get { return vigente; }
            set { vigente = value; }
        }

        public DateTime FechaHoraActualizacion
        {
            get { return fechahoraactualizacion; }
            set { fechahoraactualizacion = value; }
        }


    }
}
