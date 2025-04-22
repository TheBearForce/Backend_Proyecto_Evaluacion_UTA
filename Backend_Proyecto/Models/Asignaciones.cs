using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend_Proyecto.Models
{
    public class Asignaciones
    {
        [Key]
        public int AsignacionID { get; set; }
        public int EstudianteID { get; set; }
        public int CursoID { get; set; }
        public int? NotaID { get; set; }
        public virtual Estudiantes Estudiante { get; set; }
        public virtual Cursos Curso { get; set; }
        public virtual Notas Nota { get; set; }  
    }
}