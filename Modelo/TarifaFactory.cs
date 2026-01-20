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
            TipoVehiculo tipoVehiculo,
            decimal precio,
            TipoServicio? servicio = null,
            decimal? precioHora = null,
            decimal? precioDia = null,
            decimal? precioMes = null)
        {
            if (servicio != null)
            {
                return new TarifaServicio
                {
                    TipoVehiculo = tipoVehiculo,
                    Precio = precio,
                    Servicio = servicio,
                    Vigente = true,
                    FechaHoraActualizacion = DateTime.Now
                };
            }

            return new TarifaEstacionamiento
            {
                TipoVehiculo = tipoVehiculo,
                PrecioHora = precioHora ?? 0,
                PrecioDia = precioDia ?? 0,
                PrecioMes = precioMes ?? 0,
                Vigente = true,
                FechaHoraActualizacion = DateTime.Now
            };
        }
    }

}
