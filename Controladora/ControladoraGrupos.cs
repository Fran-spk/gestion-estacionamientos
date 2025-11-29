using Microsoft.EntityFrameworkCore;
using MODELO.contexto;
using MODELO.seguridad;
using System.Collections.ObjectModel;

namespace Controladora
{
    public class ControladoraGrupos
    {
        private static ControladoraGrupos instancia;

        public static ControladoraGrupos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraGrupos();
                }
                return instancia;
            }
        }

        private ControladoraGrupos()
        {

        }

        public ReadOnlyCollection<Grupo> getAllGrupos()
        {
            return Estacionamiento.Contexto.Grupos.Include("Acciones").Include("Estado_Grupo").ToList().AsReadOnly();
        }

        public ReadOnlyCollection<Grupo> getAllGruposByEstado(Estado_Grupo estado)
        {
            return Estacionamiento.Contexto.Grupos.Include("Acciones").Include("Estado_Grupo").Where(x=>x.EST_GRU_ID == estado.EST_GRU_ID).ToList().AsReadOnly();
        }

        public ReadOnlyCollection<Estado_Grupo> getAllEstadosGrupo()
        {
            return Estacionamiento.Contexto.Estados_Grupos.ToList().AsReadOnly();
        }

        public ReadOnlyCollection<Modulo> getAllModulos()
        {
            return Estacionamiento.Contexto.Modulos.Include(m=>m.Formularios).ThenInclude(f=>f.Acciones).ToList().AsReadOnly();
        }

        public string AgregarGrupo(Grupo grupo)
        {
            var GrupoExistente = Estacionamiento.Contexto.Grupos.ToList().FirstOrDefault(x => x.GRU_NOMBRE == grupo.GRU_NOMBRE);
            if (GrupoExistente == null)
            {
               Estacionamiento.Contexto.Grupos.Add(grupo);
               Estacionamiento.Contexto.SaveChanges();
                return "Grupo agreado correctamente";
            }
            return "Ya existe el grupo "+grupo.GRU_NOMBRE+" en el sistema";

        }

        public string EliminarGrupo(Grupo grupo)
        {
            var GrupoExistente = Estacionamiento.Contexto.Grupos.ToList().FirstOrDefault(x => x.GRU_ID == grupo.GRU_ID);
            if (GrupoExistente != null)
            {
                if(!GrupoExistente.Usuarios.Any())
                {
                    Estacionamiento.Contexto.Grupos.Remove(grupo);
                    Estacionamiento.Contexto.SaveChanges();
                    return "El grupo fue eliminado";
                }
                else
                {
                    return "Existen usuarios asociados a este grupo";
                }
            }
            return "El grupo solicitado no fue encontrado";
        }

        public string ModificarGrupo(Grupo grupo)
        {
            var GrupoExistente = Estacionamiento.Contexto.Grupos.ToList().FirstOrDefault(x => x.GRU_ID == grupo.GRU_ID);
            if (GrupoExistente != null)
            {
                Estacionamiento.Contexto.Grupos.Update(grupo);
                Estacionamiento.Contexto.SaveChanges();
                return "El grupo fue Modificado";
            }
            else
            {
                return "El grupo solicitado no fue encontrado";
            }
        }
    }
}