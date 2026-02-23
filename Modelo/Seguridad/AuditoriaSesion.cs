using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODELO.seguridad
{
    public class AuditoriaSesion
    {
        public int AuditoriaSesionId { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime FechaHoraLogin { get; set; }
        public DateTime? FechaHoraLogout { get; set; } 
        public string? TipoLogout { get; set; } 
        public bool SesionActiva { get; set; }
        public int? TiempoSesion { get; set; }
    }
}