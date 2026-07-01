using System;
using System.Windows.Forms;
using P3_LPI_Eq03_RegEst.Forms;

namespace P3_LPI_Eq03_RegEst
{
    internal static class Program
    {
        // TODO: Colocar numero real del equipo.

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmRegistroEstudiantes());
        }
    }
}
