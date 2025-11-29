using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MODELO.contexto;
using MODELO.seguridad;
using Servicios;


namespace Controladora
{
    public class ControladoraUsuarios
    {
        private static ControladoraUsuarios instancia;

        public static ControladoraUsuarios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraUsuarios();
                }
                return instancia;
            }
        }

        private ControladoraUsuarios()
        {

        }

        public ReadOnlyCollection<Usuario> getAllUsuarios()
        {
            return Estacionamiento.Contexto.Usuarios
                .Include(u => u.Estado_Usuario)
                .Include(u => u.Grupos)
                .ThenInclude(g => g.Acciones)
                .Include(u => u.Grupos)
                .ThenInclude(g => g.Estado_Grupo)
                .Include(u => u.Acciones)
                .ToList()
                .AsReadOnly();
        }

        public ReadOnlyCollection<Usuario> getAllUsuariosByGrupo(string nombre, Grupo grupo)
        {
            var usuarios = getAllUsuarios().Where(x => x.PER_NOMBRE == nombre && x.Grupos.Contains(grupo)).ToList();
            return usuarios.AsReadOnly();
        }

        public ReadOnlyCollection<Estado_Usuario> getAllEstadosUsuario()
        {
            return Estacionamiento.Contexto.Estados_Usuarios.ToList().AsReadOnly();
        }


        public string AgregarUsuario(Usuario usuario)
        {
            var UsuarioExistente = Estacionamiento.Contexto.Usuarios.ToList().FirstOrDefault(x => x.USU_MAIL == usuario.USU_MAIL);
            if (UsuarioExistente == null)
            {
                if (ServiciosUsuario.Instancia.SendMail(usuario))
                {
                    usuario.USU_CLAVE = ServiciosUsuario.Instancia.EncriptarClave(usuario.USU_CLAVE);
                    Estacionamiento.Contexto.Usuarios.Add(usuario);
                    Estacionamiento.Contexto.SaveChanges();
                    return "Usuario agregado correctamente";
                }
                else { return "No fue posible realizar la accion"; }

            }
            return "Email ya registrado";

        }

        public bool ModificarUsuario(Usuario usuario)
        {
            var UsuarioExistente = Estacionamiento.Contexto.Usuarios.ToList().FirstOrDefault(x => x.USU_MAIL == usuario.USU_MAIL);
            if (UsuarioExistente != null)
            {
                Estacionamiento.Contexto.Usuarios.Update(usuario);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }
            return false;

        }


        public string EliminarUsuario(Usuario usuario)
        {
            var UsuarioExistente = Estacionamiento.Contexto.Usuarios.ToList().FirstOrDefault(x => x.USU_MAIL == usuario.USU_MAIL);
            if (UsuarioExistente != null)
            {
                Estacionamiento.Contexto.Usuarios.Remove(usuario);
                Estacionamiento.Contexto.SaveChanges();
                return "Usuario eliminado correctamente";
            }
            return "Email no registrado";
        }

        public bool ResetearUsuarios()
        {
            var usuarios = Estacionamiento.Contexto.Usuarios.ToList();
            if (usuarios.Any())
            {
                Estacionamiento.Contexto.Usuarios.RemoveRange(usuarios);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public Usuario? IniciarSesion(string Usuario, string Clave)
        {
            Clave = ServiciosUsuario.Instancia.EncriptarClave(Clave);
            var usuario = getAllUsuarios().Where(x => x.USU_USUARIO.Equals(Usuario) && x.USU_CLAVE.Equals(Clave)).FirstOrDefault();
            if (usuario == null)
            {
                return null;
            }
            else
            {
                if (usuario.Estado_Usuario.EST_USU_NOMBRE == "Inactivo")
                {
                    return null;
                }
                else
                {
                    if (!usuario.getAllGruposActivos().Any()) { return null; } //si el usuario no pertenece a algun grupo activo no se iniciara sesion
                }
            }
            return usuario;
        }


        public bool RecuperarClave(string Usuario, string mail, string claveNueva)
        {
            var usuario = getAllUsuarios().Where(x => x.USU_USUARIO.Equals(Usuario) && x.USU_MAIL.Equals(mail)).FirstOrDefault();
            if (usuario != null)
            {
                if (Servicios.ServiciosUsuario.Instancia.SendMail(usuario))
                {
                    claveNueva = ServiciosUsuario.Instancia.EncriptarClave(claveNueva);
                    usuario.USU_CLAVE = claveNueva;
                    Estacionamiento.Contexto.Usuarios.Update(usuario);
                    Estacionamiento.Contexto.SaveChanges();
                    return true;
                }
                else { return false; }
            }
            return false;
        }






       
    }
}
