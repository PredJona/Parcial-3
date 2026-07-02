using System;

namespace P3_LPI_Eq03_RegEst.Helpers
{
    // Responsable: Jose Martinez
    // Rol: Validaciones, utilidades del sistema y formulario de informacion general.
    public static class SistemaHelper
    {
        public static string ObtenerNombreUsuario()
        {
            // Se usa en la barra inferior y en Acerca de para identificar el entorno.
            return Environment.UserName;
        }

        public static string ObtenerNombreMaquina()
        {
            // Permite mostrar en que equipo fue ejecutada la aplicacion.
            return Environment.MachineName;
        }

        public static string ObtenerFechaActual()
        {
            // Se formatea para mantener consistencia visual en toda la aplicacion.
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
