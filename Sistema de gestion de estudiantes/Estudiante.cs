using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_estudiantes
{
    public class Estudiante
    {

        [Key]
        public int EstudianteId { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Apellido { get; set; }
        public ObservableCollectionListSource<Cursos> Cursos { get; } = new(); //Relacion inversa
        public ObservableCollectionListSource<Calificaciones> Calificaciones { get; } = new(); // Relacion inversa


    }
}
