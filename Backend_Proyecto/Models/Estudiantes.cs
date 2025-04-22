using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Backend_Proyecto.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int CarreraID { get; set; }
        public int? NotaID { get; set; }

        public virtual Carreras Carrera { get; set; }
        public virtual ICollection<Asignaciones> Asignaciones { get; set; }
        public virtual ICollection<Notas> Notas { get; set; }
    }
}