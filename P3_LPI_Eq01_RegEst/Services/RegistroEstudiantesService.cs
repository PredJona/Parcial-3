using System;
using System.Collections.Generic;
using System.Linq;
using P3_LPI_Eq03_RegEst.Models;

namespace P3_LPI_Eq03_RegEst.Services
{
    // Responsable: Davis Batista
    // Rol: Logica de registro, consulta, listado y eliminacion de estudiantes.
    public class RegistroEstudiantesService
    {
        private readonly List<Estudiante> _estudiantes;

        public RegistroEstudiantesService()
        {
            _estudiantes = new List<Estudiante>();
        }

        public List<Estudiante> ObtenerTodos()
        {
            // Se devuelve una copia ordenada para que la interfaz no manipule la lista interna directamente.
            return _estudiantes.OrderBy(estudiante => estudiante.Codigo).ToList();
        }

        public bool ExisteCodigo(string codigo)
        {
            // La comparacion ignora mayusculas para evitar duplicados como EST001 y est001.
            return _estudiantes.Any(estudiante =>
                string.Equals(estudiante.Codigo, codigo, StringComparison.OrdinalIgnoreCase));
        }

        public void Agregar(Estudiante estudiante)
        {
            // La validacion detallada se realiza antes en ValidacionEstudianteService.
            if (estudiante == null)
            {
                throw new ArgumentNullException("estudiante");
            }

            _estudiantes.Add(estudiante);
        }

        public List<Estudiante> Consultar(string criterio, string valor)
        {
            // Si no se recibe texto de busqueda, se restaura el listado completo.
            if (string.IsNullOrWhiteSpace(valor))
            {
                return ObtenerTodos();
            }

            string filtro = valor.Trim();
            IEnumerable<Estudiante> consulta = _estudiantes;

            // El criterio viene del ComboBox; cada caso filtra sobre una propiedad distinta.
            switch ((criterio ?? string.Empty).Trim().ToLowerInvariant())
            {
                case "codigo":
                    consulta = consulta.Where(estudiante => Contiene(estudiante.Codigo, filtro));
                    break;
                case "nombre":
                    consulta = consulta.Where(estudiante => Contiene(estudiante.NombreCompleto, filtro));
                    break;
                case "carrera":
                    consulta = consulta.Where(estudiante => Contiene(estudiante.Carrera, filtro));
                    break;
                case "modalidad":
                    consulta = consulta.Where(estudiante => Contiene(estudiante.Modalidad, filtro));
                    break;
                default:
                    // Si el criterio no coincide, se realiza una busqueda general defensiva.
                    consulta = consulta.Where(estudiante =>
                        Contiene(estudiante.Codigo, filtro) ||
                        Contiene(estudiante.NombreCompleto, filtro) ||
                        Contiene(estudiante.Carrera, filtro) ||
                        Contiene(estudiante.Modalidad, filtro));
                    break;
            }

            return consulta.OrderBy(estudiante => estudiante.Codigo).ToList();
        }

        public bool EliminarPorCodigo(string codigo)
        {
            // La eliminacion se hace por codigo porque es el identificador unico del estudiante.
            Estudiante encontrado = _estudiantes.FirstOrDefault(estudiante =>
                string.Equals(estudiante.Codigo, codigo, StringComparison.OrdinalIgnoreCase));

            if (encontrado == null)
            {
                return false;
            }

            _estudiantes.Remove(encontrado);
            return true;
        }

        private static bool Contiene(string texto, string filtro)
        {
            // Centraliza la busqueda parcial sin distinguir mayusculas o minusculas.
            return !string.IsNullOrWhiteSpace(texto) &&
                   texto.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
