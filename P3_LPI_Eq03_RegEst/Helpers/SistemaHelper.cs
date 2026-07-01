using System;

namespace P3_LPI_Eq03_RegEst.Helpers
{
    // Responsable: __________________________
    // Rol: Validaciones, utilidades del sistema y formulario de informacion general.
    public static class SistemaHelper
    {
        public static string ObtenerNombreUsuario()
        {
            return Environment.UserName;
        }

        public static string ObtenerNombreMaquina()
        {
            return Environment.MachineName;
        }

        public static string ObtenerFechaActual()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
