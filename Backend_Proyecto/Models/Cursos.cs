using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend_Proyecto.Models
{
    public class Cursos
    {
        [Key]
        public int CursoID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Asignaciones> Asignaciones { get; set; }
    }
}