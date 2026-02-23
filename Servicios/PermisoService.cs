using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO.seguridad;

namespace Servicios
{
    public static class PermisoService
    {
        public static bool TienePermiso(string nombreAccion) =>
            Sesion.Instancia.Acciones
                .Any(x => x.ACC_NOMBRE == nombreAccion);
    }
}
