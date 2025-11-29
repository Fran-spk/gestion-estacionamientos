using Microsoft.EntityFrameworkCore;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Estado_Ticket
    {

        private int estadoId;
        private string nombre;

        public override string ToString()
        {
            return nombre.ToString();
        }

        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EstadoId
        {
            get { return estadoId; }
            set { estadoId = value; }
        }

     
     
    }
}
