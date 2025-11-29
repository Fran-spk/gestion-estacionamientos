
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public interface ISubject
    {
        public abstract bool Agregar(IObserver observer);
        public abstract bool Quitar(IObserver observer);
        public abstract void Notificar();
    }
}
