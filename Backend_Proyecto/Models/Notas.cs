using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend_Proyecto.Models
{
    public class Notas
    {
        [Key]
        public int NotaID { get; set; }
        public int EstudianteID { get; set; }
        public decimal? Nota1 { get; set; }
        public decimal? Asistencia1 { get; set; }
        public decimal? Nota2 { get; set; }
        public decimal? Asistencia2 { get; set; }
        public decimal? Supletorio { get; set; }
        public string Observacion { get; set; }
        public virtual Estudiantes Estudiante { get; set; }
    }
}