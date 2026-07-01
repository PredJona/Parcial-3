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
            return Cursos != null && Cursos.Any() ? string.Join(", ", Cursos) : "Sin cursos";
        }

        public string ObtenerActividadesComoTexto()
        {
            return Actividades != null && Actividades.Any() ? string.Join(", ", Actividades) : "Sin actividades";
        }
    }
}
