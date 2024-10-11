using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_estudiantes
{
    public class Calificaciones
    {
        [Key]
        public int CalificacionId { get; set; }

        public int EstudianteId { get; set; } // forein key 
        public virtual Estudiante Estudiante { get; set; } = null!; //Navegacion
        [Required]
        public string? Materia { get; set; }
        [Required]
        public int Calificacion_1 { get; set; }
        [Required]
        public int Calificacion_2 { get; set; }
        [Required]
        public int Calificacion_3 { get; set; }


    }
}
