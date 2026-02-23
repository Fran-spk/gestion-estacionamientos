using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MODELO.contexto;
using MODELO.seguridad;

namespace Controladora
{
    public class ControladoraSesiones
    {
        private static ControladoraSesiones instancia;
        private int? sesionActualId;
        private System.Threading.Timer timerActividad;
        private DateTime ultimaActividad;
        private const int TIMEOUT_MINUTOS = 15;
        public Action<string> OnSesionExpirada { get; set; }
        public static ControladoraSesiones Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraSesiones();
                return instancia;
            }
        }

        private ControladoraSesiones() { }




        public int RegistrarLogin(Usuario usuario)
        {

                CerrarSesionesAbandonadas(usuario.PER_ID);

                var auditoria = new AuditoriaSesion
                {
                    Usuario = usuario,
                    FechaHoraLogin = DateTime.Now,
                    SesionActiva = true
                };
                Estacionamiento.Contexto.AuditoriaSesiones.Add(auditoria);
                Estacionamiento.Contexto.SaveChanges();
                sesionActualId = auditoria.AuditoriaSesionId;
                ultimaActividad = DateTime.Now;
                IniciarMonitoreoActividad();    

                return auditoria.AuditoriaSesionId;

           
        }

        public void RegistrarLogout(string motivo = "Normal")
        {
            if (!sesionActualId.HasValue)
                return;

            try
            {
                var auditoria = Estacionamiento.Contexto.AuditoriaSesiones
                    .FirstOrDefault(a => a.AuditoriaSesionId == sesionActualId.Value);

                if (auditoria != null)
                {
                    auditoria.FechaHoraLogout = DateTime.Now;
                    auditoria.SesionActiva = false;
                    auditoria.TipoLogout = motivo;    
                    if (auditoria.FechaHoraLogout is DateTime logout)
                    {
                        auditoria.TiempoSesion = (int)(logout - auditoria.FechaHoraLogin).TotalSeconds;
                    }
                    Estacionamiento.Contexto.AuditoriaSesiones.Update(auditoria);
                    Estacionamiento.Contexto.SaveChanges();
                }
                DetenerMonitoreoActividad();
                sesionActualId = null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en RegistrarLogout: {ex.Message}");
            }
        }

        public void RegistrarActividad()
        {
            ultimaActividad = DateTime.Now;
        }

        private void CerrarSesionesAbandonadas(int usuarioId)
        {
            try
            {
                var sesionesAbiertas = Estacionamiento.Contexto.AuditoriaSesiones
                            .Where(a => a.UsuarioId == usuarioId && a.SesionActiva)
                            .ToList();
                foreach (var sesion in sesionesAbiertas)
                {
                    sesion.SesionActiva = false;
                    sesion.TipoLogout = "Cierre forzado";
                    sesion.FechaHoraLogout = null;
                    Estacionamiento.Contexto.Update(sesion);
                }
                Estacionamiento.Contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en CerrarSesionesAbandonadas: {ex.Message}");
            }
        }

        private void IniciarMonitoreoActividad()
        {
            timerActividad = new System.Threading.Timer(VerificarTimeout, null,
                TimeSpan.FromMinutes(0.5), TimeSpan.FromMinutes(0.5));
        }

        private void DetenerMonitoreoActividad()
        {
            timerActividad?.Dispose();
            timerActividad = null;
        }

        private void VerificarTimeout(object state)
        {
            if (!sesionActualId.HasValue)
                return;

            var tiempoInactivo = DateTime.Now - ultimaActividad;

            if (tiempoInactivo.TotalMinutes >= TIMEOUT_MINUTOS)
            {
                RegistrarLogout("Timeout por inactividad");
                OnSesionExpirada?.Invoke("Su sesión ha expirado por inactividad");
            }
        }


        public IReadOnlyCollection<AuditoriaSesion> AllHistorialSesiones()
        {
            return Estacionamiento.Contexto.AuditoriaSesiones.ToList().AsReadOnly();
        }
    }
}
