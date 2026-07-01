using System;
using System.Windows.Forms;
using P3_LPI_Eq03_RegEst.Helpers;

namespace P3_LPI_Eq03_RegEst.Forms
{
    // Responsable:     Karen Wen
    // Rol: Validaciones, utilidades del sistema y formulario de informacion general.
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
            // Estos datos se cargan al abrir el formulario porque dependen del equipo actual.
            lblFrameworkValor.Text = ".NET Framework 4.8 - Windows Forms";
            lblVisualStudioValor.Text = "TODO colocar version real de Visual Studio";
            lblMaquinaValor.Text = SistemaHelper.ObtenerNombreMaquina();
            lblUsuarioValor.Text = SistemaHelper.ObtenerNombreUsuario();
            lblFechaValor.Text = SistemaHelper.ObtenerFechaActual();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
