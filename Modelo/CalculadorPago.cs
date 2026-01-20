using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public abstract class CalculadorPago
    {
        public abstract void CalcularMonto(Pago pago);

    }
}
