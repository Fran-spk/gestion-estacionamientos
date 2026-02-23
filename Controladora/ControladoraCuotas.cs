using Controladora;
using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.contexto;
using Modelo_Ids;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Controladora
{
    public class ControladoraCuotas
    {
        private static ControladoraCuotas instancia;

        private ControladoraCuotas() { }

        public static ControladoraCuotas Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new ControladoraCuotas();
                return instancia;
            }
        }

        public ReadOnlyCollection<Cuota> getAllCuotas()
        {
            return Estacionamiento.Contexto.Cuotas
                .Include(x => x.TarifaEstacionamiento)
                .Include(x => x.Estado)
                .ToList()
                .AsReadOnly();
        }


        public ReadOnlyCollection<Estado_Ticket> getAllEstados()
        {
            return Estacionamiento.Contexto.Estados_Tickets
                .ToList()
                .AsReadOnly();
        }

        public ReadOnlyCollection<Cuota> getAllCuotasByPlanId(int planId)
        {
            return Estacionamiento.Contexto.Tickets_Base
                .OfType<Cuota>()
                .Include(x => x.TarifaEstacionamiento)
                .Include(x => x.Estado)
                .Where(x => x.PlanId == planId)
                .ToList()
                .AsReadOnly();
        }




        public bool AgregarCuota(Cuota cuota)
        {
            var existe = Estacionamiento.Contexto.Cuotas
                .AsNoTracking()
                .Any(x => x.TicketBaseId == cuota.TicketBaseId);

            if (existe)
                return false;

            Estacionamiento.Contexto.Tickets_Base.Add(cuota);
            Estacionamiento.Contexto.SaveChanges();
            return true;
        }

        public void ModificarCuota(Cuota cuota)
        {
            Estacionamiento.Contexto.Cuotas.Update(cuota);
            Estacionamiento.Contexto.SaveChanges();
        }



        public void ProcesarCuotasVencidas()
        {
            var tarifas = ControladoraTarifasEstacionamiento.Instancia
                .getAllTarifasActuales();

            var estadoPendiente = getAllEstados()
                .FirstOrDefault(x => x.Nombre == "Pendiente");

            if (estadoPendiente == null)
                return;

            var cuotasActuales = Estacionamiento.Contexto.Tickets_Base
                .OfType<Cuota>()
                .Include(c => c.TarifaEstacionamiento)
                .Where(c => c.Actual)
                .ToList();

            foreach (var cuotaInicial in cuotasActuales)
            {
                var cuotaActual = cuotaInicial;

                while (true)
                {
                    var cuotaNueva = cuotaActual.RenovarCuota();
                    if (cuotaNueva == null)
                        break;

                    var tarifa = tarifas.FirstOrDefault(t =>
                        t.TipoVehiculo.TipoVehiculoId ==
                        cuotaActual.TarifaEstacionamiento.TipoVehiculoId);

                    if (tarifa == null)
                        break;

                    cuotaNueva.TarifaEstacionamiento = tarifa;
                    cuotaNueva.Estado = estadoPendiente;

                    Estacionamiento.Contexto.Tickets_Base.Add(cuotaNueva);
                    Estacionamiento.Contexto.SaveChanges();

                    cuotaActual = cuotaNueva;
                }
            }
        }
    }
}