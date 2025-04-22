using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend_Proyecto.Models
{
    public class Carreras
    {
        [Key]
        public int CarreraID { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Estudiantes> Estudiantes { get; set; }
    }
}