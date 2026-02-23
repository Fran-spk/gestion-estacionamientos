using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.contexto;
using Modelo_Ids;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Controladora
{
    public class ControladoraTarifasServicio
    {
        private static ControladoraTarifasServicio instancia;
        public static ControladoraTarifasServicio Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTarifasServicio();
                }
                return instancia;
            }
        }

        private ControladoraTarifasServicio()
        {
        }

        public ReadOnlyCollection<TarifaServicio> getAllTarifas()
        {
            return Estacionamiento.Contexto.Tarifa_Servicios
                .Include(e => e.ServicioVehiculo)
                    .ThenInclude(sv => sv.Servicio)
                .Include(e => e.ServicioVehiculo)
                    .ThenInclude(sv => sv.Vehiculo)
                .ToList()
                .AsReadOnly();
        }

        public TarifaServicio? getTarifaById(int id)
        {
            return Estacionamiento.Contexto.Tarifa_Servicios
                .Include(e => e.ServicioVehiculo)
                    .ThenInclude(sv => sv.Servicio)
                .Include(e => e.ServicioVehiculo)
                    .ThenInclude(sv => sv.Vehiculo)
                    .FirstOrDefault(x => x.TarifaServicioId == id);
        }


        public ReadOnlyCollection<TarifaServicio> getAllTarifasByServicioVehiculo(TipoServicio servicio, TipoVehiculo vehiculo)
        {
            return Estacionamiento.Contexto.Tarifa_Servicios
                .Include(e => e.ServicioVehiculo)
                    .ThenInclude(sv => sv.Servicio)
                .Include(e => e.ServicioVehiculo)
                    .ThenInclude(sv => sv.Vehiculo)
                .Where(e => e.ServicioVehiculo.TipoServicioId == servicio.TipoServicioId &&
                           e.ServicioVehiculo.Vehiculo.TipoVehiculoId == vehiculo.TipoVehiculoId)
                .ToList()
                .AsReadOnly();
        }

        public ReadOnlyCollection<TarifaServicio> getAllTarifasActuales()
        {
            return Estacionamiento.Contexto.Tarifa_Servicios
                .Include(e => e.ServicioVehiculo)
                    .ThenInclude(sv => sv.Servicio)
                .Include(e => e.ServicioVehiculo)
                    .ThenInclude(sv => sv.Vehiculo)
                .Where(x => x.Vigente)
                .ToList()
                .AsReadOnly();
        }

        public ReadOnlyCollection<TarifaServicio> getAllTarifasActualesByVehiculo(TipoVehiculo vehiculo)
        {
            return Estacionamiento.Contexto.Tarifa_Servicios
                .Include(e => e.ServicioVehiculo)
                    .ThenInclude(sv => sv.Servicio)
                .Include(e => e.ServicioVehiculo)
                    .ThenInclude(sv => sv.Vehiculo)
                .Where(e => e.ServicioVehiculo.TipoVehiculoId == vehiculo.TipoVehiculoId
                && e.Vigente
                && e.ServicioVehiculo.EsActivo)
                .ToList()
                .AsReadOnly();
        }

        public string ActualizarTarifa(TarifaServicio tarifa)
        {
            var tarifaEx = Estacionamiento.Contexto.Tarifa_Servicios
                .FirstOrDefault(x => x.TarifaServicioId == tarifa.TarifaServicioId);

            if (tarifaEx != null)
            {
                return "No fue posible actualizar la tarifa de servicio";
            }

            var debeCrearNueva = SetearAnteriores(tarifa);

            if (debeCrearNueva)
            {
                Estacionamiento.Contexto.Tarifa_Servicios.Add(tarifa);
            }

            Estacionamiento.Contexto.SaveChanges();
            return "La tarifa de servicio fue actualizada exitosamente";
        }

        bool SetearAnteriores(TarifaServicio tarifa)
        {
            var anteriores = getAllTarifasByServicioVehiculo(
                tarifa.ServicioVehiculo.Servicio,
                tarifa.ServicioVehiculo.Vehiculo);

            foreach (var item in anteriores)
            {
                if (item.Vigente)
                {
                    if (item.Precio != tarifa.Precio)
                    {
                        item.Vigente = false;
                        Estacionamiento.Contexto.Tarifa_Servicios.Update(item);
                        return true; // Debe crear nueva tarifa
                    }
                    else
                    {
                        return false; // NO debe crear nueva tarifa
                    }
                }
            }
            // No hay tarifas vigentes anteriores, debe crear nueva
            return true;
        }

        public string EliminarTarifa(TarifaServicio tarifa)
        {
            var tarifaEx = Estacionamiento.Contexto.Tarifa_Servicios
                .FirstOrDefault(x => x.TarifaServicioId == tarifa.TarifaServicioId);

            if (tarifaEx != null)
            {
                var servicioConsumido = Estacionamiento.Contexto.ServiciosConsumidos.FirstOrDefault(x => x.TarifaServicioId == tarifa.TarifaServicioId);
                if (servicioConsumido == null)
                {
                    if (!tarifa.Vigente)
                    {
                        Estacionamiento.Contexto.Tarifa_Servicios.Remove(tarifa);
                        Estacionamiento.Contexto.SaveChanges();
                        return "La tarifa de servicio fue eliminada exitosamente";
                    }
                    else
                    {
                        return "No es posible eliminar tarifas de servicio vigentes";
                    }
                }
                else
                {
                    return "No pudo ser eliminada, existen tickets asociados a esta tarifa";
                }
            }
            else
            {
                return "La tarifa seleccionada no fue encontrada";
            }
        }
    }
}