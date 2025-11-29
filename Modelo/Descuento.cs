using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Descuento
    {
        private int descuentoId;
        private string nombredescuento;
        private bool estado;
        private decimal porcentaje;

        public int DescuentoId
        {
            get { return descuentoId; }
            set { descuentoId = value;}
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public string NombreDescuento
        {
            get { return nombredescuento; }
            set { nombredescuento = value; }
        }

    
        public decimal Porcentaje
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        }

        public override string ToString()
        {
            return NombreDescuento;
        }
    }
}
