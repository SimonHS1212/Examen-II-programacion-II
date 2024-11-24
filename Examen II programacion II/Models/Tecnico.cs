using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SistemaReparaciones.Models
{
    public class Tecnico
    {
        [Key]
        public int TecnicoID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Especialidad { get; set; }
    }
}
