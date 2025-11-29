using Controladora;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
    public class ControladoraTicketsBase
    {
        private static ControladoraTicketsBase instancia;
        ControladoraTicketsBase()
        {

        }
        public static ControladoraTicketsBase Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTicketsBase();
                }
                return instancia;
            }
        }


        public ReadOnlyCollection<TicketBase> getAllTickets()
        {
            return Estacionamiento.Contexto.Tickets_Base.Include(x => x.Tarifa).Include(x=>x.Estado).ToList().ToList().AsReadOnly();
        }

        public ReadOnlyCollection<Estado_Ticket> getAllEstados()
        {
            return Estacionamiento.Contexto.Estados_Tickets.ToList().AsReadOnly();
        }

        public ReadOnlyCollection<Ticket> getAllTicketsPendientes()
        {
            return Estacionamiento.Contexto.Tickets_Base.Include(x=>x.Tarifa).Include(x => x.Estado)     
                .OfType<Ticket>().Where(x=>x.Estado.Nombre == "Pendiente").ToList().AsReadOnly();          
        }

        public bool IsPresenteByPatente(string patente) 
        {   
            var ticket = getAllTicketsPendientes().FirstOrDefault(x => x.Patente == patente);
            if(ticket == null)
            {  
                var plan = ControladoraPlanes.Instancia.getPlanActivoByPatente(patente);
                if(plan == null) 
                { return false; }        
                else
                {return true;}
            }
            else
            {return true;}         
        }

        public ReadOnlyCollection<Cuota> getAllCuotasByPlanId(int PlanId)
        {
            return getAllTickets().OfType<Cuota>().Where(x => x.PlanId == PlanId).ToList().AsReadOnly();
        }


        public bool AgregarTicket(TicketBase ticket)
        { 
            var ok = false;
            var Ticket = Estacionamiento.Contexto.Tickets_Base.AsNoTracking().FirstOrDefault(x => x.TicketBaseId == ticket.TicketBaseId);
            if (Ticket == null)
            {
                if (ticket is Cuota)
                {
                    Cuota cuota = (Cuota)ticket;
                    Estacionamiento.Contexto.Tickets_Base.Add(cuota);
                    Estacionamiento.Contexto.SaveChanges();
                }
                else
                {
                    Estacionamiento.Contexto.Tickets_Base.Add(ticket);
                    Estacionamiento.Contexto.SaveChanges();
                    ok = true;
                }         
            }
            return ok;        
        }



        public void ModificarTicket(TicketBase ticket)
        {
            var Ticket = Estacionamiento.Contexto.Tickets_Base.FirstOrDefault(x => x.TicketBaseId == ticket.TicketBaseId);
            if (Ticket != null)
            {
                Estacionamiento.Contexto.Tickets_Base.Update(ticket);
                Estacionamiento.Contexto.SaveChanges();
            }
        }


        public string AnularTicket(TicketBase ticket,Estado_Ticket state)
        {
            var miticket = Estacionamiento.Contexto.Tickets_Base.Include(x => x.Estado).FirstOrDefault(x => x.TicketBaseId == ticket.TicketBaseId);
            if (miticket != null)
            {            
                var ok = miticket.Estado.Nombre == "Pendiente";
                if(ok)
                {
                    ticket.Estado = state;
                    Estacionamiento.Contexto.Update(ticket);
                    Estacionamiento.Contexto.SaveChanges();
                    return "Ticket Anulado";
                }                
                else { return "No es posible anular este ticket"; }
            }         
            return "Ticket no encontrado";          
        }
    }
}