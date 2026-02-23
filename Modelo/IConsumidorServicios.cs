using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace Modelo_Ids
{
    public interface IConsumidorDeServicios
    {
        bool RegistrarServicio(TarifaServicio tarifa);
        void AnularServicio(int servicioConsumidoId);
        IReadOnlyCollection<ServicioConsumido> ObtenerServiciosPendientes();
    }

}
