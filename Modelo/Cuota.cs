
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Cuota : TicketBase
    {
        private bool actual;
        private DateTime fechahoravencimiento;
        private Plan plan;
        private int planId;


        public int PlanId
        {
            get { return planId; }
            set { planId = value; }
        }

        public bool Actual
        {
            get { return actual; }
            set { actual = value; }
        }


        public DateTime FechaHoraVencimiento
        {
            get
            {
                fechahoravencimiento = base.FechaHoraEmision.AddMonths(1);
                return fechahoravencimiento;
            }
           
        }


        public Plan Plan
        {
            get { return plan; }
            set { plan = value; }
        }


    }
}
