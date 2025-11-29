using MODELO;
using MODELO.contexto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraMetodosDePago
    {
        private static ControladoraMetodosDePago instancia;
        public static ControladoraMetodosDePago Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraMetodosDePago();
                }
                return instancia;
            }
        }

        ControladoraMetodosDePago() {}

        public ReadOnlyCollection<MetodoDePago> getAllMetodosDePago()
        {
            return Estacionamiento.Contexto.Metodos_Pagos.ToList().AsReadOnly();
        }

        public ReadOnlyCollection<MetodoDePago> getAllMetodosDePagoActivos()
        {
            return Estacionamiento.Contexto.Metodos_Pagos.Where(x => x.Estado).ToList().AsReadOnly();
        }

        public bool AgregarMetodo(MetodoDePago metodoDePago)
        {
            var metodoExistente = Estacionamiento.Contexto.Metodos_Pagos.FirstOrDefault(x => x.NombreMetodo == metodoDePago.NombreMetodo);
            if(metodoExistente == null) 
            {
                Estacionamiento.Contexto.Metodos_Pagos.Add(metodoDePago);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ModificarMetodo(MetodoDePago metodoDePago)
        {
            var metodoExistente = Estacionamiento.Contexto.Metodos_Pagos.FirstOrDefault(x => x.MetodoDePagoId == metodoDePago.MetodoDePagoId);
            if (metodoExistente != null)
            {
                Estacionamiento.Contexto.Metodos_Pagos.Update(metodoDePago);
                Estacionamiento.Contexto.SaveChanges(true);
                return true;
            }
            return false;
        }

        public bool EliminarMetodo(MetodoDePago metodoDePago)
        {
            var ok = false;
            var metodoExistente = Estacionamiento.Contexto.Metodos_Pagos.FirstOrDefault(x => x.MetodoDePagoId == metodoDePago.MetodoDePagoId);
            if (metodoExistente != null)
            {
                var pagoAsociado = ControladoraPagos.Instancia.getAllPagos().FirstOrDefault(x => x.MetodoDePagoId == metodoDePago.MetodoDePagoId);
                if(pagoAsociado == null)
                {
                    Estacionamiento.Contexto.Metodos_Pagos.Remove(metodoDePago);
                    Estacionamiento.Contexto.SaveChanges(true);
                    ok = true;
                }              
            }
            return ok;
        }
      

    }
}
