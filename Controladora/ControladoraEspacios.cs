using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
    public class ControladoraEspacios
    {
        private static ControladoraEspacios instancia;
        private ControladoraEspacios() { }
        public static ControladoraEspacios Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraEspacios();
                }
                return instancia;
            }
        }

        public ReadOnlyCollection<Espacio> getAllEspacios()
        {
            var espacios = Estacionamiento.Contexto.Espacios
                .Include(e => e.Vehiculos)
                .Include(e => e.Tickets)
                    .ThenInclude(t => t.Estado) 
                .ToList();

            foreach (var espacio in espacios)
            {
                foreach (var ticket in espacio.Tickets)
                {
                    if (ticket is Cuota cuota)
                    {
                        cuota.Plan = Estacionamiento.Contexto.Planes.Find(cuota.PlanId);
                    }
                }
            }

            return espacios.AsReadOnly();
        }


        public ReadOnlyCollection<Espacio> getAllEspaciosByTipoVehiculo(TipoVehiculo tipo)
        {
            return getAllEspacios()
                .Where(x => x.Vehiculos.Contains(tipo)) 
                .ToList()
                .AsReadOnly();
        }


        public bool AgregarEspacio(Espacio espacio)
        {
            var espacioExistente = Estacionamiento.Contexto.Espacios.ToList().FirstOrDefault(x => x.NombreEspacio == espacio.NombreEspacio);
            if (espacioExistente == null)
            {
                Estacionamiento.Contexto.Espacios.Add(espacio);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }
            return false;
        }


        public bool ModificarEspacio(Espacio espacio)
        {
            var espacioExistente = Estacionamiento.Contexto.Espacios.AsNoTracking().FirstOrDefault(x => x.EspacioId == espacio.EspacioId);
            if (espacioExistente != null)
            {
                Estacionamiento.Contexto.Espacios.Update(espacio);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EliminarEspacio(Espacio espacio)
        {
            var espacioExistente = Estacionamiento.Contexto.Espacios.FirstOrDefault(x => x.EspacioId == espacio.EspacioId);
            if (espacioExistente != null)
            {
                var Ticket = ControladoraTicketsBase.Instancia.getAllTickets().FirstOrDefault(x => x.EspacioId == espacio.EspacioId);
                if (Ticket == null)
                {
                    Estacionamiento.Contexto.Espacios.Remove(espacio);
                    Estacionamiento.Contexto.SaveChanges(true);
                    return true;
                }
            }
            return false;
        }
    }
}
