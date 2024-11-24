using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaReparaciones.Models
{
    public class Reparacion
    {
        [Key]
        public int ReparacionID { get; set; }

        [ForeignKey("Equipo")]
        public int EquipoID { get; set; }

        public virtual Equipo Equipo { get; set; }

        public DateTime FechaSolicitud { get; set; } = DateTime.Now;

        [Required]
        [MaxLength(50)]
        public string Estado { get; set; }
    }
}

