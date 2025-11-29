using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MetodoDePago
    {
        private int metododepagoId;
        private string nombreMetodo;
        private bool estado;

        public int MetodoDePagoId
        {
            get { return metododepagoId; }
            set { metododepagoId = value; }
        }

        public string NombreMetodo
        {
            get { return nombreMetodo; }
            set { nombreMetodo = value; }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public override string ToString()
        {
            return NombreMetodo.ToString();
        }
    }
}
