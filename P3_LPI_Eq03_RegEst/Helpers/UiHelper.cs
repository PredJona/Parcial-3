using System.Windows.Forms;

namespace P3_LPI_Eq03_RegEst.Helpers
{
    // Responsable: Karen Wen
    // Rol: Validaciones, utilidades del sistema y formulario de informacion general.
    public static class UiHelper
    {
        public static void MostrarInformacion(string mensaje)
        {
            // Centraliza los mensajes informativos para conservar el mismo titulo e icono.
            MessageBox.Show(mensaje, "EduRegistro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostrarAdvertencia(string mensaje)
        {
            // Las advertencias se usan para validaciones y operaciones incompletas.
            MessageBox.Show(mensaje, "EduRegistro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Confirmar(string mensaje)
        {
            // Devuelve true solo cuando el usuario confirma explicitamente la accion.
            DialogResult resultado = MessageBox.Show(
                mensaje,
                "Confirmar accion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return resultado == DialogResult.Yes;
        }
    }
}
