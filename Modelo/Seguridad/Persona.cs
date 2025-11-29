
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MODELO.seguridad
{
 
    public abstract class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PER_ID { get; set; }

        [StringLength(60)]
        public string PER_NOMBRE { get; set; }

    }
}
