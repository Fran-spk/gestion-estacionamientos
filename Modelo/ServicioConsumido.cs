using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MODELO.contexto;

namespace Modelo_Ids
{
    public class ServicioConsumido
    {
        public int ServicioConsumidoId { get; set; }
        public int? TicketBaseId { get; set; }

        [ForeignKey(nameof(TicketBaseId))]
        public Ticket_Diario? TicketDiario { get; set; }
        public Plan? Plan { get; set; }
        public int? PlanId { get; set; }
        public int TarifaServicioId { get; set; }
        public TarifaServicio TarifaServicio { get; set; }
        public bool Pagado { get; set; }

        public bool Anulado {  get; set; }
        public DateTime FechaHoraAsignado { get; set; }

        public ServicioConsumido()
        {
            FechaHoraAsignado = DateTime.Now;
            Pagado = false;
            Anulado = false;
        }


        public void MarcarPago()
        {
            if (Anulado)
                throw new InvalidOperationException("No se puede pagar un servicio anulado");
            Pagado = true;
        }

        public void Anular()
        {
            if (Pagado)
                throw new InvalidOperationException("No se puede anular un servicio pagado");
            if (Anulado)
                return;
            Anulado = true;
        }

        public bool Pendiente => !Pagado && !Anulado;

    }

}
