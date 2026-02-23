using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.contexto;
using Modelo_Ids;
using System.Collections.ObjectModel;
using System.Linq;

namespace Controladora
{
    public class ControladoraTiposServicio
    {
        private static ControladoraTiposServicio instancia;

        public static ControladoraTiposServicio Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTiposServicio();
                }
                return instancia;
            }
        }

        private ControladoraTiposServicio()
        {
        }

        public ReadOnlyCollection<TipoServicio> getAllTiposServicio()
        {
            return Estacionamiento.Contexto.Tipo_Servicios
                .ToList()
                .AsReadOnly();
        }

        public ReadOnlyCollection<TipoServicio> getAllTiposServicioActivos()
        {
            return Estacionamiento.Contexto.Tipo_Servicios
                .Where(x => x.Estado)
                .ToList()
                .AsReadOnly();
        }
        public ReadOnlyCollection<ServicioConsumido> getAllServiciosConsumidos()
        {
            return Estacionamiento.Contexto.ServiciosConsumidos
                .Include(x => x.TarifaServicio)
                  .ThenInclude(t => t.ServicioVehiculo)
                .Include(p => p.Plan)
                .Include(t => t.TicketDiario)
                .ToList().AsReadOnly();
        }
        public bool Agregar(TipoServicio tipoServicio)
        {
            var tipoExistente = Estacionamiento.Contexto.Tipo_Servicios
                .FirstOrDefault(x => x.Descripcion == tipoServicio.Descripcion);

            if (tipoExistente == null)
            {
                tipoServicio.Estado = true;
                Estacionamiento.Contexto.Tipo_Servicios.Add(tipoServicio);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Modificar(TipoServicio tipoServicio)
        {
            var tipoExistente = Estacionamiento.Contexto.Tipo_Servicios
                .FirstOrDefault(x => x.TipoServicioId == tipoServicio.TipoServicioId);

            if (tipoExistente != null)
            {
                Estacionamiento.Contexto.Tipo_Servicios.Update(tipoServicio);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
