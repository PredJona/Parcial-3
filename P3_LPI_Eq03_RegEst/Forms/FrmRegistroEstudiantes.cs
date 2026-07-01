using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using P3_LPI_Eq03_RegEst.Helpers;
using P3_LPI_Eq03_RegEst.Models;
using P3_LPI_Eq03_RegEst.Services;

namespace P3_LPI_Eq03_RegEst.Forms
{
    // Responsable: Jonathan Romero
    // Rol: Diseno de interfaz grafica, eventos visuales y experiencia de usuario.
    public partial class FrmRegistroEstudiantes : Form
    {
        private readonly RegistroEstudiantesService _registroService;
        private readonly ValidacionEstudianteService _validacionService;

        public FrmRegistroEstudiantes()
        {
            InitializeComponent();
            _registroService = new RegistroEstudiantesService();
            _validacionService = new ValidacionEstudianteService();

            ConfigurarMaterialSkin();
            ConfigurarCombos();
            ConfigurarCursos();
            CargarDatosDePrueba();
            MostrarEstudiantes(_registroService.ObtenerTodos());
            LimpiarCampos(true);
            ActualizarBarraEstado();
            timerReloj.Start();
        }

        private void ConfigurarMaterialSkin()
        {
            MaterialSkinManager gestor = MaterialSkinManager.Instance;
            gestor.Theme = MaterialSkinManager.Themes.LIGHT;
            gestor.ColorScheme = new ColorScheme(
                Primary.Blue700,
                Primary.Blue900,
                Primary.Blue500,
                Accent.Green400,
                TextShade.WHITE);
        }

        private void ConfigurarCombos()
        {
            cmbCarrera.Items.AddRange(new object[]
            {
                "Ingenieria de Sistemas",
                "Administracion",
                "Contabilidad",
                "Derecho",
                "Arquitectura"
            });

            cmbModalidad.Items.AddRange(new object[]
            {
                "Presencial",
                "Virtual",
                "Semipresencial"
            });

            cmbTipoCurso.Items.AddRange(new object[]
            {
                "Normal",
                "Seminario"
            });

            cmbJornada.Items.AddRange(new object[]
            {
                "Matutina",
                "Vespertina",
                "Nocturna"
            });

            cmbCriterioBusqueda.Items.AddRange(new object[]
            {
                "Codigo",
                "Nombre",
                "Carrera",
                "Modalidad"
            });

            SeleccionarPrimerElemento(cmbCarrera);
            SeleccionarPrimerElemento(cmbModalidad);
            SeleccionarPrimerElemento(cmbTipoCurso);
            SeleccionarPrimerElemento(cmbJornada);
            SeleccionarPrimerElemento(cmbCriterioBusqueda);
        }

        private void ConfigurarCursos()
        {
            clbCursos.Items.AddRange(new object[]
            {
                "Programacion I",
                "Base de Datos",
                "Redes de Computadoras",
                "Sistemas Operativos",
                "Administracion Financiera",
                "Arte Digital",
                "Diseno Arquitectonico",
                "Contabilidad General"
            });
        }

        private static void SeleccionarPrimerElemento(ComboBox comboBox)
        {
            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        private void CargarDatosDePrueba()
        {
            _registroService.Agregar(new Estudiante(
                "EST001",
                "Juan Perez Lopez",
                "Ingenieria de Sistemas",
                "Masculino",
                "Presencial",
                new List<string> { "Programacion I", "Base de Datos" },
                new List<string> { "Deportes" },
                "Normal",
                "Matutina"));

            _registroService.Agregar(new Estudiante(
                "EST002",
                "Maria Gonzalez Ruiz",
                "Administracion",
                "Femenino",
                "Virtual",
                new List<string> { "Administracion Financiera", "Arte Digital" },
                new List<string> { "Musica", "Arte" },
                "Seminario",
                "Vespertina"));

            _registroService.Agregar(new Estudiante(
                "EST003",
                "Carlos Diaz Ortega",
                "Contabilidad",
                "Masculino",
                "Semipresencial",
                new List<string> { "Contabilidad General", "Sistemas Operativos" },
                new List<string> { "Investigacion" },
                "Normal",
                "Nocturna"));
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante estudiante = ConstruirEstudianteDesdeFormulario();
                string mensaje;

                if (!_validacionService.ValidarEstudiante(estudiante, out mensaje))
                {
                    UiHelper.MostrarAdvertencia(mensaje);
                    return;
                }

                if (_registroService.ExisteCodigo(estudiante.Codigo))
                {
                    UiHelper.MostrarAdvertencia("Ya existe un estudiante registrado con ese codigo.");
                    txtCodigo.Focus();
                    return;
                }

                _registroService.Agregar(estudiante);
                MostrarEstudiantes(_registroService.ObtenerTodos());
                LimpiarCampos(true);
                UiHelper.MostrarInformacion("Estudiante registrado correctamente.");
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo registrar el estudiante.", ex);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = txtBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(valor))
                {
                    UiHelper.MostrarAdvertencia("Ingrese un valor para consultar.");
                    txtBuscar.Focus();
                    return;
                }

                List<Estudiante> resultados = _registroService.Consultar(
                    cmbCriterioBusqueda.Text,
                    valor);

                if (!resultados.Any())
                {
                    UiHelper.MostrarInformacion("No se encontraron estudiantes con el criterio indicado.");
                    return;
                }

                MostrarEstudiantes(resultados);
                lblEstado.Text = "Consulta realizada";
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo consultar la informacion.", ex);
            }
        }

        private void BtnMostrarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                txtBuscar.Clear();
                MostrarEstudiantes(_registroService.ObtenerTodos());
                lblEstado.Text = "Listado completo";
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo mostrar el listado completo.", ex);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEstudiantes.CurrentRow == null || dgvEstudiantes.CurrentRow.IsNewRow)
                {
                    UiHelper.MostrarAdvertencia("Seleccione una fila para eliminar.");
                    return;
                }

                string codigo = Convert.ToString(dgvEstudiantes.CurrentRow.Cells["Codigo"].Value);

                if (string.IsNullOrWhiteSpace(codigo))
                {
                    UiHelper.MostrarAdvertencia("No se pudo identificar el codigo del estudiante seleccionado.");
                    return;
                }

                if (!UiHelper.Confirmar("Desea eliminar el estudiante seleccionado?"))
                {
                    return;
                }

                if (_registroService.EliminarPorCodigo(codigo))
                {
                    MostrarEstudiantes(_registroService.ObtenerTodos());
                    LimpiarCampos(true);
                    UiHelper.MostrarInformacion("Estudiante eliminado correctamente.");
                }
                else
                {
                    UiHelper.MostrarAdvertencia("El estudiante seleccionado ya no existe en el registro.");
                }
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo eliminar el estudiante.", ex);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(true);
            lblEstado.Text = "Campos limpios";
        }

        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {
            using (FrmAcercaDe acercaDe = new FrmAcercaDe())
            {
                acercaDe.ShowDialog(this);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmRegistroEstudiantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!UiHelper.Confirmar("Desea salir de EduRegistro?"))
            {
                e.Cancel = true;
            }
        }

        private Estudiante ConstruirEstudianteDesdeFormulario()
        {
            return new Estudiante(
                txtCodigo.Text.Trim().ToUpperInvariant(),
                txtNombreCompleto.Text.Trim(),
                cmbCarrera.Text.Trim(),
                ObtenerGeneroSeleccionado(),
                cmbModalidad.Text.Trim(),
                ObtenerCursosSeleccionados(),
                ObtenerActividadesSeleccionadas(),
                cmbTipoCurso.Text.Trim(),
                cmbJornada.Text.Trim());
        }

        private string ObtenerGeneroSeleccionado()
        {
            if (rbtnMasculino.Checked)
            {
                return "Masculino";
            }

            if (rbtnFemenino.Checked)
            {
                return "Femenino";
            }

            return string.Empty;
        }

        private List<string> ObtenerCursosSeleccionados()
        {
            return clbCursos.CheckedItems.Cast<object>()
                .Select(item => item.ToString())
                .ToList();
        }

        private List<string> ObtenerActividadesSeleccionadas()
        {
            List<string> actividades = new List<string>();

            if (chkDeportes.Checked)
            {
                actividades.Add("Deportes");
            }

            if (chkMusica.Checked)
            {
                actividades.Add("Musica");
            }

            if (chkArte.Checked)
            {
                actividades.Add("Arte");
            }

            if (chkInvestigacion.Checked)
            {
                actividades.Add("Investigacion");
            }

            return actividades;
        }

        private void MostrarEstudiantes(IEnumerable<Estudiante> estudiantes)
        {
            List<EstudianteGridRow> datos = estudiantes
                .Select(estudiante => new EstudianteGridRow
                {
                    Codigo = estudiante.Codigo,
                    NombreCompleto = estudiante.NombreCompleto,
                    Carrera = estudiante.Carrera,
                    Genero = estudiante.Genero,
                    Modalidad = estudiante.Modalidad,
                    TipoCurso = estudiante.TipoCurso,
                    Jornada = estudiante.Jornada,
                    Cursos = estudiante.ObtenerCursosComoTexto(),
                    Actividades = estudiante.ObtenerActividadesComoTexto()
                })
                .ToList();

            dgvEstudiantes.DataSource = datos;
            ConfigurarColumnasGrid();
            dgvEstudiantes.ClearSelection();
            ActualizarBarraEstado();
        }

        private void ConfigurarColumnasGrid()
        {
            if (dgvEstudiantes.Columns.Count == 0)
            {
                return;
            }

            ConfigurarColumna("Codigo", "Codigo", 75);
            ConfigurarColumna("NombreCompleto", "Nombre completo", 170);
            ConfigurarColumna("Carrera", "Carrera", 140);
            ConfigurarColumna("Genero", "Genero", 85);
            ConfigurarColumna("Modalidad", "Modalidad", 95);
            ConfigurarColumna("TipoCurso", "Tipo de curso", 90);
            ConfigurarColumna("Jornada", "Jornada", 90);
            ConfigurarColumna("Cursos", "Cursos", 220);
            ConfigurarColumna("Actividades", "Actividades", 160);
        }

        private void ConfigurarColumna(string nombre, string encabezado, int peso)
        {
            if (!dgvEstudiantes.Columns.Contains(nombre))
            {
                return;
            }

            dgvEstudiantes.Columns[nombre].HeaderText = encabezado;
            dgvEstudiantes.Columns[nombre].FillWeight = peso;
        }

        private void LimpiarCampos(bool limpiarSeleccion)
        {
            txtCodigo.Clear();
            txtNombreCompleto.Clear();
            rbtnMasculino.Checked = false;
            rbtnFemenino.Checked = false;
            SeleccionarPrimerElemento(cmbCarrera);
            SeleccionarPrimerElemento(cmbModalidad);
            SeleccionarPrimerElemento(cmbTipoCurso);
            SeleccionarPrimerElemento(cmbJornada);

            for (int indice = 0; indice < clbCursos.Items.Count; indice++)
            {
                clbCursos.SetItemChecked(indice, false);
            }

            chkDeportes.Checked = false;
            chkMusica.Checked = false;
            chkArte.Checked = false;
            chkInvestigacion.Checked = false;

            if (limpiarSeleccion)
            {
                dgvEstudiantes.ClearSelection();
            }

            txtCodigo.Focus();
        }

        private void DgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            string codigo = Convert.ToString(dgvEstudiantes.Rows[e.RowIndex].Cells["Codigo"].Value);
            Estudiante estudiante = _registroService.ObtenerTodos().FirstOrDefault(item => item.Codigo == codigo);

            if (estudiante != null)
            {
                CargarEstudianteEnFormulario(estudiante);
                lblEstado.Text = "Estudiante seleccionado";
            }
        }

        private void CargarEstudianteEnFormulario(Estudiante estudiante)
        {
            txtCodigo.Text = estudiante.Codigo;
            txtNombreCompleto.Text = estudiante.NombreCompleto;
            cmbCarrera.Text = estudiante.Carrera;
            cmbModalidad.Text = estudiante.Modalidad;
            cmbTipoCurso.Text = estudiante.TipoCurso;
            cmbJornada.Text = estudiante.Jornada;
            rbtnMasculino.Checked = estudiante.Genero == "Masculino";
            rbtnFemenino.Checked = estudiante.Genero == "Femenino";

            for (int indice = 0; indice < clbCursos.Items.Count; indice++)
            {
                string curso = clbCursos.Items[indice].ToString();
                clbCursos.SetItemChecked(indice, estudiante.Cursos.Contains(curso));
            }

            chkDeportes.Checked = estudiante.Actividades.Contains("Deportes");
            chkMusica.Checked = estudiante.Actividades.Contains("Musica");
            chkArte.Checked = estudiante.Actividades.Contains("Arte");
            chkInvestigacion.Checked = estudiante.Actividades.Contains("Investigacion");
        }

        private void TimerReloj_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void ActualizarBarraEstado()
        {
            lblUsuario.Text = "Usuario: " + SistemaHelper.ObtenerNombreUsuario();
            lblMaquina.Text = "Maquina: " + SistemaHelper.ObtenerNombreMaquina();
            lblTotal.Text = "Total de estudiantes registrados: " + _registroService.ObtenerTodos().Count;
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");

            if (string.IsNullOrWhiteSpace(lblEstado.Text))
            {
                lblEstado.Text = "Sistema listo para usar";
            }
        }

        private static void MostrarError(string contexto, Exception ex)
        {
            UiHelper.MostrarAdvertencia(contexto + Environment.NewLine + ex.Message);
        }

        private sealed class EstudianteGridRow
        {
            public string Codigo { get; set; }

            public string NombreCompleto { get; set; }

            public string Carrera { get; set; }

            public string Genero { get; set; }

            public string Modalidad { get; set; }

            public string TipoCurso { get; set; }

            public string Jornada { get; set; }

            public string Cursos { get; set; }

            public string Actividades { get; set; }
        }
    }
}
