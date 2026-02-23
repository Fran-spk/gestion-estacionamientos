using Microsoft.EntityFrameworkCore;
using MODELO;
using MODELO.contexto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Controladora
{
    public class ControladoraPlanes
    {
        private static ControladoraPlanes instancia;

        public static ControladoraPlanes Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControladoraPlanes();
                }
                return instancia;
            }
        }

        private ControladoraPlanes()
        {

        }


        public ReadOnlyCollection<Plan> getAllPlanes()
        {
            return Estacionamiento.Contexto.Planes.
                Include("Descuento")
                .Include(x=>x.ServiciosConsumidos)
                .Include(c=>c.Cuotas)
                . ToList().AsReadOnly();
        }

        public Plan? getPlanActivoByPatente(string Patente)
        {
            var plan = Estacionamiento.Contexto.Planes.Include("Descuento")
                                .Include(x => x.ServiciosConsumidos)
                .Include(c => c.Cuotas)
                .Include(s => s.ServiciosConsumidos)
                    .ThenInclude(m => m.TarifaServicio)
                .FirstOrDefault(p => p.Patente == Patente && p.EstadoPlan);
            if (plan != null)
            {
                return plan;
            }
            else { return null; }
        }


        public ReadOnlyCollection<Plan> getAllPlanesActivos()
        {
            return Estacionamiento.Contexto.Planes.Include("Descuento")
                .Include(x => x.ServiciosConsumidos)
                     .ThenInclude(m => m.TarifaServicio)
                     .ThenInclude(sv => sv.ServicioVehiculo)
                     .ThenInclude(v=>v.Vehiculo)
                .Include(x => x.ServiciosConsumidos)
                     .ThenInclude(m => m.TarifaServicio)
                     .ThenInclude(sv => sv.ServicioVehiculo)
                     .ThenInclude(v => v.Servicio)
                .Include(c => c.Cuotas).Where(x => x.EstadoPlan).ToList().AsReadOnly();
        }
        


        public bool AgregarPlan(Plan plan)
        {
            var planExistente = Estacionamiento.Contexto.Planes.AsNoTracking().FirstOrDefault(x =>  x.Patente == plan.Patente && x.EstadoPlan==true);
            if(planExistente == null)
            {
                Estacionamiento.Contexto.Planes.Add(plan);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


        public string ModificarPlan(Plan plan)
        {
            var planExistente = Estacionamiento.Contexto.Planes.AsNoTracking().FirstOrDefault(x => x.PER_ID == plan.PER_ID);
            if (planExistente != null)
            {             
                Estacionamiento.Contexto.Planes.Update(plan);
                Estacionamiento.Contexto.SaveChanges();
                return "El plan fue modificado exitosamente";
            }
            else
            {
                return "El plan seleccionado no fue encontrado o está dado de baja";
            }
        }

        public bool BajarPlan(Plan plan)
        {
            var planExistente = Estacionamiento.Contexto.Planes.FirstOrDefault(x => x.PER_ID==plan.PER_ID);
            if (planExistente != null)
            {
                var cuota = plan.Cuotas.FirstOrDefault( x=>x.Estado.Nombre=="Pendiente");
                if (cuota != null)
                {
                    return false;
                }
                plan.EstadoPlan = false;
                plan.FechaHoraBaja = DateTime.Now;
                Estacionamiento.Contexto.Planes.Update(plan);
                Estacionamiento.Contexto.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }    
    }
}

