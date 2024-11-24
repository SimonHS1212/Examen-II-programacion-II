using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace SistemaReparaciones.Models
{
    public class DBReparacionesContext : DbContext
    {
        public DBReparacionesContext() : base("DBReparacionesContext") { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Reparacion> Reparaciones { get; set; }
        public DbSet<DetalleReparacion> DetallesReparacion { get; set; }
        public DbSet<Asignacion> Asignaciones { get; set; }
    }
}

