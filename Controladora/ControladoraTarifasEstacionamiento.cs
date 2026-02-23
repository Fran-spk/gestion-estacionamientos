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
    public class ControladoraTarifasEstacionamiento
    {
        private static ControladoraTarifasEstacionamiento instancia;
        public static ControladoraTarifasEstacionamiento Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraTarifasEstacionamiento();
                }
                return instancia;
            }
        }
        private ControladoraTarifasEstacionamiento()
        {

        }

        public ReadOnlyCollection<TarifaEstacionamiento> getAllTarifas()
        {
            return Estacionamiento.Contexto.Tarifas_Estacionamiento.Include(e => e.TipoVehiculo).ToList().AsReadOnly();
        }


        public ReadOnlyCollection<TarifaEstacionamiento> getAllTarifasActuales()
        {
            return Estacionamiento.Contexto.Tarifas_Estacionamiento.Include(e => e.TipoVehiculo).Where(x => x.Vigente).ToList().AsReadOnly();
        }


        public string ActualizarTarifa(TarifaEstacionamiento tarifa)
        {
            var TarifaEx = Estacionamiento.Contexto.Tarifas_Estacionamiento.FirstOrDefault(x => x.TarifaEstacionamientoId == tarifa.TarifaEstacionamientoId);
            if (TarifaEx == null)
            {
                var Actual = Estacionamiento.Contexto.Tarifas_Estacionamiento.FirstOrDefault(x => x.TipoVehiculo == tarifa.TipoVehiculo && x.Vigente);
                if (Actual != null)
                {
                    Actual.Vigente = false;
                    Estacionamiento.Contexto.Tarifas_Estacionamiento.Update(Actual);
                }
                Estacionamiento.Contexto.Attach(tarifa.TipoVehiculo);
                Estacionamiento.Contexto.Tarifas_Estacionamiento.Add(tarifa);
                Estacionamiento.Contexto.SaveChanges();
                return "Su tarifa fue Actualizada exitosamente";
            }
            else
            {
                return "No fue posible Actualizar su tarifa";
            }

        }



        public string EliminarTarifa(TarifaEstacionamiento tarifa)
        {
            var TarifaEx = Estacionamiento.Contexto.Tarifas_Estacionamiento.FirstOrDefault(x => x.TarifaEstacionamientoId == tarifa.TarifaEstacionamientoId);
            if (TarifaEx != null)
            {
                var Cuotas = ControladoraCuotas.Instancia.getAllCuotas().FirstOrDefault(x => x.TarifaId == tarifa.TarifaEstacionamientoId);
                var Tickets = ControladoraTicketsDiarios.Instancia.getAllTickets().FirstOrDefault(x => x.TarifaId == tarifa.TarifaEstacionamientoId);
                if (Tickets == null && Cuotas ==null)
                {
                    if (!tarifa.Vigente)
                    {
                        Estacionamiento.Contexto.Tarifas_Estacionamiento.Remove(tarifa);                       
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
