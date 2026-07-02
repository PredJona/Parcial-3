using System.Collections.Generic;
using System.Linq;

namespace P3_LPI_Eq03_RegEst.Models
{
    // Responsable: Davis Batista
    // Rol: Modelo de datos y estructura de la entidad Estudiante.
    public class Estudiante
    {
        public Estudiante()
        {
            // Se inicializan listas vacias para evitar errores al agregar cursos o actividades.
            Cursos = new List<string>();
            Actividades = new List<string>();
        }

        public Estudiante(
            string codigo,
            string nombreCompleto,
            string carrera,
            string genero,
            string modalidad,
            List<string> cursos,
            List<string> actividades,
            string tipoCurso,
            string jornada)
        {
            Codigo = codigo;
            NombreCompleto = nombreCompleto;
            Carrera = carrera;
            Genero = genero;
            Modalidad = modalidad;
            // Si alguna lista llega nula desde la interfaz, se reemplaza por una lista vacia.
            Cursos = cursos ?? new List<string>();
            Actividades = actividades ?? new List<string>();
            TipoCurso = tipoCurso;
            Jornada = jornada;
        }

        public string Codigo { get; set; }

        public string NombreCompleto { get; set; }

        public string Carrera { get; set; }

        public string Genero { get; set; }

        public string Modalidad { get; set; }

        public List<string> Cursos { get; set; }

        public List<string> Actividades { get; set; }

        public string TipoCurso { get; set; }

        public string Jornada { get; set; }

        public string ObtenerCursosComoTexto()
        {
            // El DataGridView necesita una cadena legible, no la lista completa de objetos.
            return Cursos != null && Cursos.Any() ? string.Join(", ", Cursos) : "Sin cursos";
        }

        public string ObtenerActividadesComoTexto()
        {
            // Mantiene la misma transformacion para mostrar varias actividades en una sola celda.
            return Actividades != null && Actividades.Any() ? string.Join(", ", Actividades) : "Sin actividades";
        }
    }
}
