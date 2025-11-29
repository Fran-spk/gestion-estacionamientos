
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public interface IObserver
    {
        protected abstract void ActualizarEstado();
    }
}
