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
                .Include(e => e.Tickets)
                    .ThenInclude(t => (t as Cuota).Plan)
                .ToList();

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
                var Cuotas = ControladoraCuotas.Instancia.getAllCuotas().FirstOrDefault(x => x.EspacioId == espacio.EspacioId);
                var Tickets = ControladoraTicketsDiarios.Instancia.getAllTickets().FirstOrDefault(x => x.EspacioId == espacio.EspacioId);
                if (Tickets == null && Cuotas==null)
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
