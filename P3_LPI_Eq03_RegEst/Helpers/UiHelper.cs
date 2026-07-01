using System.Windows.Forms;

namespace P3_LPI_Eq03_RegEst.Helpers
{
    // Responsable: __________________________
    // Rol: Validaciones, utilidades del sistema y formulario de informacion general.
    public static class UiHelper
    {
        public static void MostrarInformacion(string mensaje)
        {
            MessageBox.Show(mensaje, "EduRegistro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "EduRegistro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Confirmar(string mensaje)
        {
            DialogResult resultado = MessageBox.Show(
                mensaje,
                "Confirmar accion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return resultado == DialogResult.Yes;
        }
    }
}
