using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using P3_LPI_Eq03_RegEst.Models;

namespace P3_LPI_Eq03_RegEst.Services
{
    // Responsable: Jose Martinez
    // Rol: Validaciones, utilidades del sistema y formulario de informacion general.
    public class ValidacionEstudianteService
    {
        public bool ValidarEstudiante(Estudiante estudiante, out string mensaje)
        {
            if (estudiante == null)
            {
                mensaje = "No hay informacion de estudiante para validar.";
                return false;
            }

            if (!ValidarCodigo(estudiante.Codigo))
            {
                mensaje = "El codigo es obligatorio y debe usar el formato EST001.";
                return false;
            }

            if (!ValidarNombreCompleto(estudiante.NombreCompleto))
            {
                mensaje = "El nombre completo es obligatorio y debe contener al menos dos palabras.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(estudiante.Carrera))
            {
                mensaje = "Seleccione una carrera.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(estudiante.Genero))
            {
                mensaje = "Seleccione el genero del estudiante.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(estudiante.Modalidad))
            {
                mensaje = "Seleccione la modalidad de estudio.";
                return false;
            }

            if (!ValidarCursos(estudiante.Cursos))
            {
                mensaje = "Seleccione al menos un curso inscrito.";
                return false;
            }

            if (!ValidarActividades(estudiante.Actividades))
            {
                mensaje = "Seleccione al menos una actividad extracurricular.";
                return false;
            }

            mensaje = "Datos validos.";
            return true;
        }

        public bool ValidarCodigo(string codigo)
        {
            return !string.IsNullOrWhiteSpace(codigo) &&
                   Regex.IsMatch(codigo.Trim(), @"^EST\d{3}$", RegexOptions.IgnoreCase);
        }

        public bool ValidarNombreCompleto(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return false;
            }

            return nombre.Trim()
                .Split(new[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries)
                .Length >= 2;
        }

        public bool ValidarCursos(List<string> cursos)
        {
            return cursos != null && cursos.Any();
        }

        public bool ValidarActividades(List<string> actividades)
        {
            return actividades != null && actividades.Any();
        }
    }
}
