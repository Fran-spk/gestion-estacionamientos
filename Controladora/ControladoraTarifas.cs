using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.contexto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraTarifas
    {
        private static ControladoraTarifas instancia;
        public static ControladoraTarifas Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTarifas();
                }
                return instancia;
            }
        }
        private ControladoraTarifas()
        {

        }

        public ReadOnlyCollection<Tarifa> getAllTarifas()
        {
            return Estacionamiento.Contexto.Tarifas.Include(e => e.TipoVehiculo).ToList().AsReadOnly();
        }


        public ReadOnlyCollection<Tarifa> getAllTarifasActuales()
        {
            return Estacionamiento.Contexto.Tarifas.Include(e => e.TipoVehiculo).Where(x => x.Vigente).ToList().AsReadOnly();
        }


        public string ActualizarTarifa(Tarifa tarifa)
        {
            var TarifaEx = Estacionamiento.Contexto.Tarifas.FirstOrDefault(x => x.TarifaId == tarifa.TarifaId);
            if (TarifaEx == null)
            {
                var Actual = Estacionamiento.Contexto.Tarifas.FirstOrDefault(x => x.TipoVehiculo == tarifa.TipoVehiculo && x.Vigente);
                if (Actual != null)
                {
                    Actual.Vigente = false;
                    Estacionamiento.Contexto.Tarifas.Update(Actual);
                }
                Estacionamiento.Contexto.Attach(tarifa.TipoVehiculo);
                Estacionamiento.Contexto.Tarifas.Add(tarifa);
                Estacionamiento.Contexto.SaveChanges();
                return "Su tarifa fue Actualizada exitosamente";
            }
            else
            {
                return "No fue posible Actualizar su tarifa";
            }

        }



        public string EliminarTarifa(Tarifa tarifa)
        {
            var TarifaEx = Estacionamiento.Contexto.Tarifas.FirstOrDefault(x => x.TarifaId == tarifa.TarifaId);
            if (TarifaEx != null)
            {
                var Ticket = ControladoraTicketsBase.Instancia.getAllTickets().FirstOrDefault(x => x.TarifaId == tarifa.TarifaId);
                if (Ticket == null)
                {
                    if (!tarifa.Vigente)
                    {
                        Estacionamiento.Contexto.Tarifas.Remove(tarifa);                       
                        Estacionamiento.Contexto.SaveChanges();                       
                    }
                    else
                    {
                        return "No es posible eliminar tarifas actuales";
                    }
                    return "Su tarifa fue eliminada exitosamente";
                }
                else { return "No pudo ser eliminada, existen tickets asociados a esta tarifa"; }
            }
            else
            {
                return "La tarifa seleccionada no fue encontrada";
            }               
        }      
    }
}
