using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SistemaReparaciones.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string CorreoElectronico { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }
    }
}
