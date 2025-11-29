using Microsoft.EntityFrameworkCore;
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
    public class ControladoraTiposVehiculo
    {
        private static ControladoraTiposVehiculo instancia;

        public static ControladoraTiposVehiculo Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTiposVehiculo();
                }
                return instancia;
            }
        }

        private ControladoraTiposVehiculo()
        {

        }

        public ReadOnlyCollection<TipoVehiculo> getAllTiposVehiculo()
        {
            return Estacionamiento.Contexto.Tipos_Vehiculos.Include(x=>x.Espacios).ToList().AsReadOnly();
        }

        public ReadOnlyCollection<TipoVehiculo> getAllTiposVehiculoActivos()
        {
            return Estacionamiento.Contexto.Tipos_Vehiculos.Include(x => x.Espacios).ToList().AsReadOnly();
        }

        public bool Agregar(TipoVehiculo tipoVehiculo)
        {
            var vehiculos = Estacionamiento.Contexto.Tipos_Vehiculos.ToList();
            var Tipoexistente= Estacionamiento.Contexto.Tipos_Vehiculos.ToList().FirstOrDefault(x=>x.NombreVehiculo == tipoVehiculo.NombreVehiculo);
            if(Tipoexistente==null)
            {
                Estacionamiento.Contexto.Tipos_Vehiculos.Add(tipoVehiculo);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }
            return false;
            
        }

        public bool Modificar(TipoVehiculo tipoVehiculo)
        {
            var Tipoexistente = Estacionamiento.Contexto.Tipos_Vehiculos.FirstOrDefault(x => x.TipoVehiculoId == tipoVehiculo.TipoVehiculoId);
            if (Tipoexistente != null)
            {
                Estacionamiento.Contexto.Tipos_Vehiculos.Update(tipoVehiculo);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }
            return false;

        }           
    }
}
