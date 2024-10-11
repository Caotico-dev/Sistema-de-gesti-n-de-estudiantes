using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_estudiantes
{
    public class ColegioContext:DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Calificaciones> Calificaciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=Colegio.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            

            modelBuilder.Entity<Estudiante>().HasData(
                new Estudiante { EstudianteId = 1, Nombre = "Pedro", Apellido = "Ramirez"},
                new Estudiante { EstudianteId = 2, Nombre = "Carlos", Apellido = "Colon"},
                new Estudiante { EstudianteId = 3, Nombre = "Maria", Apellido = "Del Monte"});

            modelBuilder.Entity<Cursos>().HasData(
                new Cursos { CursoId = 1, EstudianteId = 1, Nombre_del_curso = "Lengua Española" },
                new Cursos { CursoId = 2, EstudianteId = 2, Nombre_del_curso = "Matematicas" },
                new Cursos { CursoId = 3, EstudianteId = 3, Nombre_del_curso = "Quimica" });
            modelBuilder.Entity<Calificaciones>().HasData(
                new Calificaciones { CalificacionId = 1, EstudianteId = 1, Materia = "Lengua Española", Calificacion_1 = 70, Calificacion_2 = 77, Calificacion_3 = 80 },
                new Calificaciones { CalificacionId = 2, EstudianteId = 2, Materia = "Matematicas", Calificacion_1 = 82, Calificacion_2 = 83, Calificacion_3 = 90 },
                new Calificaciones { CalificacionId = 3, EstudianteId = 3, Materia = "Quimica", Calificacion_1 = 80, Calificacion_2 = 89, Calificacion_3 = 89 });     

        }



    }
}
