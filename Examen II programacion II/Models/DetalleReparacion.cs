using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaReparaciones.Models
{
    public class DetalleReparacion
    {
        [Key]
        public int DetalleID { get; set; }

        [ForeignKey("Reparacion")]
        public int ReparacionID { get; set; }

        public virtual Reparacion Reparacion { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }
    }
}
