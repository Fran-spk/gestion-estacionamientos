using MODELO.seguridad;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Plan:Persona
    {
        private DateTime fechaHoraAlta;
        private DateTime fechaHoraBaja;
        private bool estadoplan;
        private Descuento ? descuento;
        private int ? descuentoId;
        private string patente;
        private int dni;
        private long telefono;

           private List<Cuota> cuotas = new List<Cuota>();  // Relación con Cuotas

            public List<Cuota> Cuotas
            {
                get { return cuotas; }
                set { cuotas = value; }
            }

  


        public int? DescuentoId
        {
            get { return descuentoId; }
            set { descuentoId = value;}
        }

        public DateTime FechaHoraAlta
        {
            get { return fechaHoraAlta; }
            set { fechaHoraAlta = value; }
        }

        public DateTime FechaHoraBaja
        {
            get { return fechaHoraBaja; }
            set { fechaHoraBaja = value; }
        }

        public bool EstadoPlan
        {
            get { return estadoplan; }
            set { estadoplan = value; }
        }

        public Descuento ? Descuento
        {
            get { if (descuento == null) { return null; }; return descuento; }
            set { descuento = value; }
        }

        public string Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        public string NombreCliente
        {
            get { return base.PER_NOMBRE; }
            set { base.PER_NOMBRE = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public override string ToString()
        {
            return Patente;
        }
    }
}
