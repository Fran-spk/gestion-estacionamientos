using MODELO;
using MODELO.contexto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraDescuentos
    {
        private static ControladoraDescuentos instancia;
        private ControladoraDescuentos()
        {

        }
        public static ControladoraDescuentos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraDescuentos();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Descuento> getAllDescuentos()
        {         
            return Estacionamiento.Contexto.Descuentos.ToList().AsReadOnly();
        }

        public ReadOnlyCollection<Descuento> getAllDescuentosActivos()
        {            
            return Estacionamiento.Contexto.Descuentos.ToList().Where(x=>x.Estado==true).ToList().AsReadOnly();
        }


        public bool AgregarDescuento(Descuento descuento)
        {
            var ok = false;
            var existingDescuento = Estacionamiento.Contexto.Descuentos.ToList().FirstOrDefault(x => x.NombreDescuento == descuento.NombreDescuento);
            if (existingDescuento == null)
            {
                Estacionamiento.Contexto.Descuentos.Add(descuento);
                Estacionamiento.Contexto.SaveChanges();
                ok = true;
            }
            return ok;
        }

        public bool ModificarDescuento(Descuento descuento)
        {
            var ok = false;
            var miDescuento = Estacionamiento.Contexto.Descuentos.ToList().FirstOrDefault(x => x.DescuentoId == descuento.DescuentoId);
            if (miDescuento != null)
            {
                Estacionamiento.Contexto.Descuentos.Update(descuento);
                Estacionamiento.Contexto.SaveChanges();
                ok = true;
            }
            return ok;
        }

        public bool EliminarDescuento(Descuento descuento)
        {
            var ok = false;
            var existingDescuento = Estacionamiento.Contexto.Descuentos.ToList().FirstOrDefault(x => x.DescuentoId == descuento.DescuentoId);
            if (existingDescuento != null)
            {
                var planAsociado = ControladoraPlanes.Instancia.getAllPlanes().FirstOrDefault
                    (x => x.Descuento?.DescuentoId == existingDescuento.DescuentoId);
                if (planAsociado == null)
                {
                    Estacionamiento.Contexto.Descuentos.Remove(descuento);
                    Estacionamiento.Contexto.SaveChanges();
                    ok = true;
                }              
            }
            return ok;
        }

    }
}
