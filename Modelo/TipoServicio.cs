using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace MODELO
{
    public class TipoServicio
    {
        private int tipoServicioId;
        private string descripcion;
        private bool estado;


        public int TipoServicioId
        {
            get { return tipoServicioId; }
            set { tipoServicioId = value; }
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

        public override string ToString()
        {
            return descripcion.ToString();
        }
    }
}
