using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MODELO.seguridad;

namespace MODELO
{
    public class AuditoriaTicket
    {
        public int AuditoriaTicketId { get; set; }
        public int TicketBaseId { get; set; }
        public virtual TicketBase Ticket { get; set; }
        public string Operacion { get; set; }
        public string? CampoModificado { get; set; }
        public string? ValorAnterior { get; set; }
        public string? ValorNuevo { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaHora { get; set; }
        public virtual Usuario Usuario { get; set; }



        public AuditoriaTicket()
        {
            
        }

        public AuditoriaTicket(
            int idTicket,
            string operacion,
            string valorNuevo,
            int idUsuario,
            string campoModificado = null,
            string valorAnterior = null)
        {
            TicketBaseId = idTicket;
            Operacion = operacion;
            ValorNuevo = valorNuevo;
            UsuarioId = idUsuario;
            CampoModificado = campoModificado;
            ValorAnterior = valorAnterior;
            FechaHora = DateTime.Now;
        }

        public static AuditoriaTicket RegistrarCreacion(
            int idTicket,
            string estadoInicial,
            int idUsuario)
        {
            return new AuditoriaTicket(
                idTicket: idTicket,
                operacion: "INSERT",
                valorNuevo: estadoInicial,
                idUsuario: idUsuario
            );
        }

        public static AuditoriaTicket RegistrarModificacion(
            int idTicket,
            string campo,
            string valorAnterior,
            string valorNuevo,
            int idUsuario)
        {
            return new AuditoriaTicket(
                idTicket: idTicket,
                operacion: "UPDATE",
                valorNuevo: valorNuevo,
                idUsuario: idUsuario,
                campoModificado: campo,
                valorAnterior: valorAnterior
            );
        }

        public static AuditoriaTicket RegistrarAgregarServicio(
            int idTicket,
            string nombreServicio,
            decimal precio,
            int idUsuario)
        {
            string detalle = $"servicio={nombreServicio}, tarifa={precio:F2}";
            return new AuditoriaTicket(
                idTicket: idTicket,
                operacion: "agrego_servicio",
                valorNuevo: detalle,
                idUsuario: idUsuario
            );
        }

       
        public static AuditoriaTicket RegistrarEliminarServicio(
            int idTicket,
            string nombreServicio,
            string motivo,
            int idUsuario)
        {
            string detalle = string.IsNullOrEmpty(motivo)
                ? $"servicio={nombreServicio}"
                : $"servicio={nombreServicio}, motivo={motivo}";

            return new AuditoriaTicket(
                idTicket: idTicket,
                operacion: "elimino_servicio",
                valorNuevo: null,
                idUsuario: idUsuario,
                campoModificado: "servicios",
                valorAnterior: detalle
            );
        }


        public override string ToString()
        {
            return $"[{FechaHora:yyyy-MM-dd HH:mm:ss}] Ticket #{TicketBaseId} - {Operacion}" +
                   (string.IsNullOrEmpty(CampoModificado)
                       ? $": {ValorNuevo}"
                       : $" ({CampoModificado}): {ValorAnterior} → {ValorNuevo}");
        }


    }


}