using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaReparaciones.Models
{
    public class Equipo
    {
        [Key]
        public int EquipoID { get; set; }

        [Required]
        [MaxLength(50)]
        public string TipoEquipo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Modelo { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
