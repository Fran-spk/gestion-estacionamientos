using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public static class TarifaFactory
    {
        public static TarifaBase CrearTarifa(
            TipoVehiculo? tipoVehiculo = null,
            ServicioVehiculo? servicioVehiculo = null,
            decimal? precio = null,
            decimal? precioMediaHora = null,
            decimal? precioHora = null,
            decimal? precioDia = null,
            decimal? precioMes = null)
        {
            if (servicioVehiculo != null)
            {
                return new TarifaServicio
                {
                    ServicioVehiculo = servicioVehiculo,
                    Precio = precio ?? 0,
                    Vigente = true,
                    FechaHoraActualizacion = DateTime.Now
                };
            }

            return new TarifaEstacionamiento
            {
                TipoVehiculo = tipoVehiculo,
                PrecioMediaHora = precioMediaHora ?? 0,
                PrecioHora = precioHora ?? 0,
                PrecioDia = precioDia ?? 0,
                PrecioMes = precioMes ?? 0,
                Vigente = true,
                FechaHoraActualizacion = DateTime.Now
            };
        }
    }

}
