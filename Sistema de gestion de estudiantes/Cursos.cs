using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_estudiantes
{
    public class Cursos
    {
        [Key]
        public int CursoId { get; set; }
        [Required]
        public int EstudianteId { get; set; } // forein key 
        public virtual Estudiante Estudiante { get; set; } = null!; //Navegacion
        [Required]
        public string? Nombre_del_curso { get; set; }
    }
}
