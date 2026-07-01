namespace P3_LPI_Eq03_RegEst.Forms
{
    partial class FrmAcercaDe
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picAcademico = new FontAwesome.Sharp.IconPictureBox();
            this.lblUniversidad = new System.Windows.Forms.Label();
            this.lblFacultad = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.lblParcial = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblIntegrantesTitulo = new System.Windows.Forms.Label();
            this.lblIntegranteUno = new System.Windows.Forms.Label();
            this.lblIntegranteDos = new System.Windows.Forms.Label();
            this.lblIntegranteTres = new System.Windows.Forms.Label();
            this.lblIntegranteCuatro = new System.Windows.Forms.Label();
            this.lblAplicacion = new System.Windows.Forms.Label();
            this.lblDescripcionTitulo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblFrameworkTitulo = new System.Windows.Forms.Label();
            this.lblFrameworkValor = new System.Windows.Forms.Label();
            this.lblVisualStudioTitulo = new System.Windows.Forms.Label();
            this.lblVisualStudioValor = new System.Windows.Forms.Label();
            this.lblMaquinaTitulo = new System.Windows.Forms.Label();
            this.lblMaquinaValor = new System.Windows.Forms.Label();
            this.lblUsuarioTitulo = new System.Windows.Forms.Label();
            this.lblUsuarioValor = new System.Windows.Forms.Label();
            this.lblFechaTitulo = new System.Windows.Forms.Label();
            this.lblFechaValor = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAcademico)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(143)))));
            this.pnlHeader.Controls.Add(this.lblSubtitulo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.picAcademico);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 96);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(94, 55);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(321, 19);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Sistema de Registro Academico de Estudiantes";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(92, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "EduRegistro";
            // 
            // picAcademico
            // 
            this.picAcademico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(143)))));
            this.picAcademico.ForeColor = System.Drawing.Color.White;
            this.picAcademico.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.picAcademico.IconColor = System.Drawing.Color.White;
            this.picAcademico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picAcademico.IconSize = 54;
            this.picAcademico.Location = new System.Drawing.Point(26, 22);
            this.picAcademico.Name = "picAcademico";
            this.picAcademico.Size = new System.Drawing.Size(54, 54);
            this.picAcademico.TabIndex = 0;
            this.picAcademico.TabStop = false;
            // 
            // lblUniversidad
            // 
            this.lblUniversidad.AutoSize = true;
            this.lblUniversidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUniversidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblUniversidad.Location = new System.Drawing.Point(28, 122);
            this.lblUniversidad.Name = "lblUniversidad";
            this.lblUniversidad.Size = new System.Drawing.Size(263, 20);
            this.lblUniversidad.TabIndex = 1;
            this.lblUniversidad.Text = "Universidad Tecnologica de Panama";
            // 
            // lblFacultad
            // 
            this.lblFacultad.AutoSize = true;
            this.lblFacultad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFacultad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblFacultad.Location = new System.Drawing.Point(28, 150);
            this.lblFacultad.Name = "lblFacultad";
            this.lblFacultad.Size = new System.Drawing.Size(321, 19);
            this.lblFacultad.TabIndex = 2;
            this.lblFacultad.Text = "Facultad de Ingenieria de Sistemas Computacionales";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblDepartamento.Location = new System.Drawing.Point(28, 176);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(277, 19);
            this.lblDepartamento.TabIndex = 3;
            this.lblDepartamento.Text = "Departamento de Programacion de Computadoras";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAsignatura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblAsignatura.Location = new System.Drawing.Point(28, 214);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(250, 19);
            this.lblAsignatura.TabIndex = 4;
            this.lblAsignatura.Text = "Asignatura: Lenguaje de Programacion I";
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblParcial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblParcial.Location = new System.Drawing.Point(28, 240);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(87, 19);
            this.lblParcial.TabIndex = 5;
            this.lblParcial.Text = "Parcial No. 3";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblGrupo.Location = new System.Drawing.Point(28, 266);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(90, 19);
            this.lblGrupo.TabIndex = 6;
            this.lblGrupo.Text = "Grupo: 1SF12";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblEquipo.Location = new System.Drawing.Point(28, 292);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(195, 19);
            this.lblEquipo.TabIndex = 7;
            this.lblEquipo.Text = "Equipo: TODO colocar numero";
            // 
            // lblIntegrantesTitulo
            // 
            this.lblIntegrantesTitulo.AutoSize = true;
            this.lblIntegrantesTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIntegrantesTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblIntegrantesTitulo.Location = new System.Drawing.Point(28, 330);
            this.lblIntegrantesTitulo.Name = "lblIntegrantesTitulo";
            this.lblIntegrantesTitulo.Size = new System.Drawing.Size(88, 19);
            this.lblIntegrantesTitulo.TabIndex = 8;
            this.lblIntegrantesTitulo.Text = "Integrantes:";
            // 
            // lblIntegranteUno
            // 
            this.lblIntegranteUno.AutoSize = true;
            this.lblIntegranteUno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIntegranteUno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblIntegranteUno.Location = new System.Drawing.Point(48, 356);
            this.lblIntegranteUno.Name = "lblIntegranteUno";
            this.lblIntegranteUno.Size = new System.Drawing.Size(122, 19);
            this.lblIntegranteUno.TabIndex = 9;
            this.lblIntegranteUno.Text = "TODO: Integrante 1";
            // 
            // lblIntegranteDos
            // 
            this.lblIntegranteDos.AutoSize = true;
            this.lblIntegranteDos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIntegranteDos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblIntegranteDos.Location = new System.Drawing.Point(48, 382);
            this.lblIntegranteDos.Name = "lblIntegranteDos";
            this.lblIntegranteDos.Size = new System.Drawing.Size(122, 19);
            this.lblIntegranteDos.TabIndex = 10;
            this.lblIntegranteDos.Text = "TODO: Integrante 2";
            // 
            // lblIntegranteTres
            // 
            this.lblIntegranteTres.AutoSize = true;
            this.lblIntegranteTres.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIntegranteTres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblIntegranteTres.Location = new System.Drawing.Point(48, 408);
            this.lblIntegranteTres.Name = "lblIntegranteTres";
            this.lblIntegranteTres.Size = new System.Drawing.Size(122, 19);
            this.lblIntegranteTres.TabIndex = 11;
            this.lblIntegranteTres.Text = "TODO: Integrante 3";
            // 
            // lblIntegranteCuatro
            // 
            this.lblIntegranteCuatro.AutoSize = true;
            this.lblIntegranteCuatro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIntegranteCuatro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblIntegranteCuatro.Location = new System.Drawing.Point(48, 434);
            this.lblIntegranteCuatro.Name = "lblIntegranteCuatro";
            this.lblIntegranteCuatro.Size = new System.Drawing.Size(122, 19);
            this.lblIntegranteCuatro.TabIndex = 12;
            this.lblIntegranteCuatro.Text = "TODO: Integrante 4";
            // 
            // lblAplicacion
            // 
            this.lblAplicacion.AutoSize = true;
            this.lblAplicacion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAplicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(57)))), ((int)(((byte)(143)))));
            this.lblAplicacion.Location = new System.Drawing.Point(426, 122);
            this.lblAplicacion.Name = "lblAplicacion";
            this.lblAplicacion.Size = new System.Drawing.Size(237, 19);
            this.lblAplicacion.TabIndex = 13;
            this.lblAplicacion.Text = "Nombre de aplicacion: EduRegistro";
            // 
            // lblDescripcionTitulo
            // 
            this.lblDescripcionTitulo.AutoSize = true;
            this.lblDescripcionTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblDescripcionTitulo.Location = new System.Drawing.Point(426, 154);
            this.lblDescripcionTitulo.Name = "lblDescripcionTitulo";
            this.lblDescripcionTitulo.Size = new System.Drawing.Size(186, 19);
            this.lblDescripcionTitulo.TabIndex = 14;
            this.lblDescripcionTitulo.Text = "Descripcion de la solucion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.txtDescripcion.Location = new System.Drawing.Point(430, 180);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(318, 126);
            this.txtDescripcion.TabIndex = 15;
            this.txtDescripcion.Text = "Sistema de escritorio para registrar estudiantes, consultar informacion academica," +
    " seleccionar cursos y actividades extracurriculares, y eliminar registros desde " +
    "una tabla centralizada.";
            // 
            // lblFrameworkTitulo
            // 
            this.lblFrameworkTitulo.AutoSize = true;
            this.lblFrameworkTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFrameworkTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblFrameworkTitulo.Location = new System.Drawing.Point(426, 328);
            this.lblFrameworkTitulo.Name = "lblFrameworkTitulo";
            this.lblFrameworkTitulo.Size = new System.Drawing.Size(82, 19);
            this.lblFrameworkTitulo.TabIndex = 16;
            this.lblFrameworkTitulo.Text = "Framework:";
            // 
            // lblFrameworkValor
            // 
            this.lblFrameworkValor.AutoSize = true;
            this.lblFrameworkValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFrameworkValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblFrameworkValor.Location = new System.Drawing.Point(540, 328);
            this.lblFrameworkValor.Name = "lblFrameworkValor";
            this.lblFrameworkValor.Size = new System.Drawing.Size(167, 19);
            this.lblFrameworkValor.TabIndex = 17;
            this.lblFrameworkValor.Text = ".NET Framework 4.8";
            // 
            // lblVisualStudioTitulo
            // 
            this.lblVisualStudioTitulo.AutoSize = true;
            this.lblVisualStudioTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVisualStudioTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblVisualStudioTitulo.Location = new System.Drawing.Point(426, 356);
            this.lblVisualStudioTitulo.Name = "lblVisualStudioTitulo";
            this.lblVisualStudioTitulo.Size = new System.Drawing.Size(95, 19);
            this.lblVisualStudioTitulo.TabIndex = 18;
            this.lblVisualStudioTitulo.Text = "Visual Studio:";
            // 
            // lblVisualStudioValor
            // 
            this.lblVisualStudioValor.AutoSize = true;
            this.lblVisualStudioValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVisualStudioValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblVisualStudioValor.Location = new System.Drawing.Point(540, 356);
            this.lblVisualStudioValor.Name = "lblVisualStudioValor";
            this.lblVisualStudioValor.Size = new System.Drawing.Size(219, 19);
            this.lblVisualStudioValor.TabIndex = 19;
            this.lblVisualStudioValor.Text = "TODO colocar version real";
            // 
            // lblMaquinaTitulo
            // 
            this.lblMaquinaTitulo.AutoSize = true;
            this.lblMaquinaTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMaquinaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblMaquinaTitulo.Location = new System.Drawing.Point(426, 384);
            this.lblMaquinaTitulo.Name = "lblMaquinaTitulo";
            this.lblMaquinaTitulo.Size = new System.Drawing.Size(70, 19);
            this.lblMaquinaTitulo.TabIndex = 20;
            this.lblMaquinaTitulo.Text = "Maquina:";
            // 
            // lblMaquinaValor
            // 
            this.lblMaquinaValor.AutoSize = true;
            this.lblMaquinaValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaquinaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblMaquinaValor.Location = new System.Drawing.Point(540, 384);
            this.lblMaquinaValor.Name = "lblMaquinaValor";
            this.lblMaquinaValor.Size = new System.Drawing.Size(56, 19);
            this.lblMaquinaValor.TabIndex = 21;
            this.lblMaquinaValor.Text = "Equipo";
            // 
            // lblUsuarioTitulo
            // 
            this.lblUsuarioTitulo.AutoSize = true;
            this.lblUsuarioTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblUsuarioTitulo.Location = new System.Drawing.Point(426, 412);
            this.lblUsuarioTitulo.Name = "lblUsuarioTitulo";
            this.lblUsuarioTitulo.Size = new System.Drawing.Size(61, 19);
            this.lblUsuarioTitulo.TabIndex = 22;
            this.lblUsuarioTitulo.Text = "Usuario:";
            // 
            // lblUsuarioValor
            // 
            this.lblUsuarioValor.AutoSize = true;
            this.lblUsuarioValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsuarioValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblUsuarioValor.Location = new System.Drawing.Point(540, 412);
            this.lblUsuarioValor.Name = "lblUsuarioValor";
            this.lblUsuarioValor.Size = new System.Drawing.Size(57, 19);
            this.lblUsuarioValor.TabIndex = 23;
            this.lblUsuarioValor.Text = "Usuario";
            // 
            // lblFechaTitulo
            // 
            this.lblFechaTitulo.AutoSize = true;
            this.lblFechaTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFechaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblFechaTitulo.Location = new System.Drawing.Point(426, 440);
            this.lblFechaTitulo.Name = "lblFechaTitulo";
            this.lblFechaTitulo.Size = new System.Drawing.Size(50, 19);
            this.lblFechaTitulo.TabIndex = 24;
            this.lblFechaTitulo.Text = "Fecha:";
            // 
            // lblFechaValor
            // 
            this.lblFechaValor.AutoSize = true;
            this.lblFechaValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFechaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.lblFechaValor.Location = new System.Drawing.Point(540, 440);
            this.lblFechaValor.Name = "lblFechaValor";
            this.lblFechaValor.Size = new System.Drawing.Size(79, 19);
            this.lblFechaValor.TabIndex = 25;
            this.lblFechaValor.Text = "01/07/2026";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(96)))), ((int)(((byte)(223)))));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(96)))), ((int)(((byte)(223)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 18;
            this.btnCerrar.Location = new System.Drawing.Point(616, 500);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(132, 42);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(780, 568);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblFechaValor);
            this.Controls.Add(this.lblFechaTitulo);
            this.Controls.Add(this.lblUsuarioValor);
            this.Controls.Add(this.lblUsuarioTitulo);
            this.Controls.Add(this.lblMaquinaValor);
            this.Controls.Add(this.lblMaquinaTitulo);
            this.Controls.Add(this.lblVisualStudioValor);
            this.Controls.Add(this.lblVisualStudioTitulo);
            this.Controls.Add(this.lblFrameworkValor);
            this.Controls.Add(this.lblFrameworkTitulo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcionTitulo);
            this.Controls.Add(this.lblAplicacion);
            this.Controls.Add(this.lblIntegranteCuatro);
            this.Controls.Add(this.lblIntegranteTres);
            this.Controls.Add(this.lblIntegranteDos);
            this.Controls.Add(this.lblIntegranteUno);
            this.Controls.Add(this.lblIntegrantesTitulo);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblFacultad);
            this.Controls.Add(this.lblUniversidad);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de EduRegistro";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAcademico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconPictureBox picAcademico;
        private System.Windows.Forms.Label lblUniversidad;
        private System.Windows.Forms.Label lblFacultad;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblIntegrantesTitulo;
        private System.Windows.Forms.Label lblIntegranteUno;
        private System.Windows.Forms.Label lblIntegranteDos;
        private System.Windows.Forms.Label lblIntegranteTres;
        private System.Windows.Forms.Label lblIntegranteCuatro;
        private System.Windows.Forms.Label lblAplicacion;
        private System.Windows.Forms.Label lblDescripcionTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFrameworkTitulo;
        private System.Windows.Forms.Label lblFrameworkValor;
        private System.Windows.Forms.Label lblVisualStudioTitulo;
        private System.Windows.Forms.Label lblVisualStudioValor;
        private System.Windows.Forms.Label lblMaquinaTitulo;
        private System.Windows.Forms.Label lblMaquinaValor;
        private System.Windows.Forms.Label lblUsuarioTitulo;
        private System.Windows.Forms.Label lblUsuarioValor;
        private System.Windows.Forms.Label lblFechaTitulo;
        private System.Windows.Forms.Label lblFechaValor;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}
