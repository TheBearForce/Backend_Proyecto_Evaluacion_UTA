using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Backend_Proyecto.Models
{
    public class BaseUTAContext : DbContext
    {
        public BaseUTAContext() : base("name=BaseUTA")
        {
        }

        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Carreras> Carreras { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Asignaciones> Asignaciones { get; set; }
        public DbSet<Notas> Notas { get; set; }

    }
}