using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.contexto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraPagos
    {     
        private static ControladoraPagos instancia;

        public static ControladoraPagos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraPagos();
                }
                return instancia;
            }
        }

        private ControladoraPagos() { }

        public ReadOnlyCollection<Pago> getAllPagos()
        {
            return Estacionamiento.Contexto.Pagos.Include(x => x.MetodoDePago).Include(x=>x.Ticket).ToList().AsReadOnly();
        }

        public Pago? getPagoByTicket(int ticketId)
        {
            return Estacionamiento.Contexto.Pagos.Include(x => x.MetodoDePago).Include(x => x.Ticket).FirstOrDefault(x => x.Ticket.TicketBaseId == ticketId);
        }

        public bool AgregarPago(Pago pago)
        {
            var pagoExistente = Estacionamiento.Contexto.Pagos.ToList().FirstOrDefault(x=>x.PagoId==pago.PagoId);
            if (pagoExistente == null)
            {
                Estacionamiento.Contexto.Attach(pago.Ticket);
                Estacionamiento.Contexto.Attach(pago.MetodoDePago);
                Estacionamiento.Contexto.Pagos.Add(pago);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
