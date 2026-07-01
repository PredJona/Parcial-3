using System;
using System.Collections.Generic;
using System.Linq;
using P3_LPI_Eq03_RegEst.Models;

namespace P3_LPI_Eq03_RegEst.Services
{
    // Responsable: __________________________
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
            return _estudiantes.OrderBy(estudiante => estudiante.Codigo).ToList();
        }

        public bool ExisteCodigo(string codigo)
        {
            return _estudiantes.Any(estudiante =>
                string.Equals(estudiante.Codigo, codigo, StringComparison.OrdinalIgnoreCase));
        }

        public void Agregar(Estudiante estudiante)
        {
            if (estudiante == null)
            {
                throw new ArgumentNullException("estudiante");
            }

            _estudiantes.Add(estudiante);
        }

        public List<Estudiante> Consultar(string criterio, string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return ObtenerTodos();
            }

            string filtro = valor.Trim();
            IEnumerable<Estudiante> consulta = _estudiantes;

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
            return !string.IsNullOrWhiteSpace(texto) &&
                   texto.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
