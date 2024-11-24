using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaReparaciones.Models
{
    public class Asignacion
    {
        [Key]
        public int AsignacionID { get; set; }

        [ForeignKey("Reparacion")]
        public int ReparacionID { get; set; }

        [ForeignKey("Tecnico")]
        public int TecnicoID { get; set; }

        public virtual Reparacion Reparacion { get; set; }

        public virtual Tecnico Tecnico { get; set; }

        public DateTime FechaAsignacion { get; set; } = DateTime.Now;
    }
}

