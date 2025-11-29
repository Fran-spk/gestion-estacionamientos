using MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.seguridad
{
    public class Sesion
    {
        private static Sesion instancia;
        public static Sesion Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Sesion();
                }
                return instancia;
            }
        }
        private Sesion()
        {

        }

        Usuario perfil;
        int sesionId;
        

        public Usuario Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }

        public int SesionId
        {
            get { return sesionId; }
            set { sesionId = value; }
        }

        public IReadOnlyCollection<Accion> Acciones
        {
            get 
            {
                var acciones = perfil.getAllGruposActivos()
                    .SelectMany(ac => ac.Acciones)
                    .Concat(perfil.Acciones)
                    .ToList();
                return acciones;

            }
        }

    }

}
