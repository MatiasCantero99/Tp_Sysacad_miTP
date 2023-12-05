namespace Formularios
{
    partial class FormPanelUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelUsuario));
            btnRegistrarEstudiante = new Button();
            btnGestionarCursos = new Button();
            label2 = new Label();
            btnInscripcionCurso = new Button();
            btnConsultarHorario = new Button();
            btnRealizarPagos = new Button();
            btnSalir = new Button();
            btnGestionarListasEspera = new Button();
            btnGestionarRequisitos = new Button();
            btnGestionarProfesor = new Button();
            bttnGenerarReporte = new Button();
            btnVerCursos = new Button();
            SuspendLayout();
            // 
            // btnRegistrarEstudiante
            // 
            btnRegistrarEstudiante.BackColor = Color.SandyBrown;
            btnRegistrarEstudiante.Location = new Point(448, 234);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new Size(186, 33);
            btnRegistrarEstudiante.TabIndex = 0;
            btnRegistrarEstudiante.Text = "Registrar Estudiante";
            btnRegistrarEstudiante.UseVisualStyleBackColor = false;
            btnRegistrarEstudiante.Click += button1_Click;
            // 
            // btnGestionarCursos
            // 
            btnGestionarCursos.BackColor = Color.SandyBrown;
            btnGestionarCursos.FlatStyle = FlatStyle.Flat;
            btnGestionarCursos.Location = new Point(448, 290);
            btnGestionarCursos.Name = "btnGestionarCursos";
            btnGestionarCursos.Size = new Size(186, 33);
            btnGestionarCursos.TabIndex = 1;
            btnGestionarCursos.Text = "Gestionar Curso";
            btnGestionarCursos.UseVisualStyleBackColor = false;
            btnGestionarCursos.Click += BtnGestionarCursos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(364, 15);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 2;
            label2.Text = "Panel";
            // 
            // btnInscripcionCurso
            // 
            btnInscripcionCurso.BackColor = Color.MediumSlateBlue;
            btnInscripcionCurso.FlatStyle = FlatStyle.Flat;
            btnInscripcionCurso.Location = new Point(448, 290);
            btnInscripcionCurso.Name = "btnInscripcionCurso";
            btnInscripcionCurso.Size = new Size(186, 33);
            btnInscripcionCurso.TabIndex = 3;
            btnInscripcionCurso.Text = "Inscripcion a cursos";
            btnInscripcionCurso.UseVisualStyleBackColor = false;
            btnInscripcionCurso.Click += button2_Click;
            // 
            // btnConsultarHorario
            // 
            btnConsultarHorario.BackColor = Color.MediumSlateBlue;
            btnConsultarHorario.FlatStyle = FlatStyle.Flat;
            btnConsultarHorario.Location = new Point(448, 341);
            btnConsultarHorario.Name = "btnConsultarHorario";
            btnConsultarHorario.Size = new Size(186, 33);
            btnConsultarHorario.TabIndex = 4;
            btnConsultarHorario.Text = "Consultar Horario";
            btnConsultarHorario.UseVisualStyleBackColor = false;
            btnConsultarHorario.Click += button3_Click;
            // 
            // btnRealizarPagos
            // 
            btnRealizarPagos.BackColor = Color.MediumSlateBlue;
            btnRealizarPagos.FlatStyle = FlatStyle.Flat;
            btnRealizarPagos.Location = new Point(448, 508);
            btnRealizarPagos.Name = "btnRealizarPagos";
            btnRealizarPagos.Size = new Size(186, 33);
            btnRealizarPagos.TabIndex = 5;
            btnRealizarPagos.Text = "Realizar Pagos";
            btnRealizarPagos.UseVisualStyleBackColor = false;
            btnRealizarPagos.Click += button4_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(448, 571);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(186, 33);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGestionarListasEspera
            // 
            btnGestionarListasEspera.BackColor = Color.SandyBrown;
            btnGestionarListasEspera.FlatStyle = FlatStyle.Flat;
            btnGestionarListasEspera.Location = new Point(448, 397);
            btnGestionarListasEspera.Margin = new Padding(4, 5, 4, 5);
            btnGestionarListasEspera.Name = "btnGestionarListasEspera";
            btnGestionarListasEspera.Size = new Size(186, 38);
            btnGestionarListasEspera.TabIndex = 7;
            btnGestionarListasEspera.Text = "Gestionar Espera";
            btnGestionarListasEspera.UseVisualStyleBackColor = false;
            btnGestionarListasEspera.Click += btnGestionarListasEspera_Click;
            // 
            // btnGestionarRequisitos
            // 
            btnGestionarRequisitos.BackColor = Color.SandyBrown;
            btnGestionarRequisitos.FlatStyle = FlatStyle.Flat;
            btnGestionarRequisitos.Location = new Point(448, 457);
            btnGestionarRequisitos.Margin = new Padding(4, 5, 4, 5);
            btnGestionarRequisitos.Name = "btnGestionarRequisitos";
            btnGestionarRequisitos.Size = new Size(186, 38);
            btnGestionarRequisitos.TabIndex = 8;
            btnGestionarRequisitos.Text = "Gestionar Requisitos";
            btnGestionarRequisitos.UseVisualStyleBackColor = false;
            btnGestionarRequisitos.Click += btnGestionarRequisitos_Click;
            // 
            // btnGestionarProfesor
            // 
            btnGestionarProfesor.BackColor = Color.SandyBrown;
            btnGestionarProfesor.FlatStyle = FlatStyle.Flat;
            btnGestionarProfesor.Location = new Point(448, 505);
            btnGestionarProfesor.Margin = new Padding(4, 5, 4, 5);
            btnGestionarProfesor.Name = "btnGestionarProfesor";
            btnGestionarProfesor.Size = new Size(186, 38);
            btnGestionarProfesor.TabIndex = 9;
            btnGestionarProfesor.Text = "Gestionar Profesores";
            btnGestionarProfesor.UseVisualStyleBackColor = false;
            btnGestionarProfesor.Click += btnGestionarProfesor_Click;
            // 
            // bttnGenerarReporte
            // 
            bttnGenerarReporte.BackColor = Color.SandyBrown;
            bttnGenerarReporte.FlatStyle = FlatStyle.Flat;
            bttnGenerarReporte.Location = new Point(448, 341);
            bttnGenerarReporte.Margin = new Padding(4, 5, 4, 5);
            bttnGenerarReporte.Name = "bttnGenerarReporte";
            bttnGenerarReporte.Size = new Size(186, 33);
            bttnGenerarReporte.TabIndex = 10;
            bttnGenerarReporte.Text = "Gnerar Reporte";
            bttnGenerarReporte.UseVisualStyleBackColor = false;
            bttnGenerarReporte.Click += bttnGenerarReporte_Click;
            // 
            // btnVerCursos
            // 
            btnVerCursos.BackColor = Color.MediumSeaGreen;
            btnVerCursos.FlatStyle = FlatStyle.Flat;
            btnVerCursos.Location = new Point(488, 364);
            btnVerCursos.Margin = new Padding(4, 5, 4, 5);
            btnVerCursos.Name = "btnVerCursos";
            btnVerCursos.Size = new Size(107, 38);
            btnVerCursos.TabIndex = 11;
            btnVerCursos.Text = "Ver Cursos";
            btnVerCursos.UseVisualStyleBackColor = false;
            btnVerCursos.Click += btnVerCursos_Click;
            // 
            // FormPanelUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(btnVerCursos);
            Controls.Add(bttnGenerarReporte);
            Controls.Add(btnGestionarProfesor);
            Controls.Add(btnGestionarRequisitos);
            Controls.Add(btnGestionarListasEspera);
            Controls.Add(btnSalir);
            Controls.Add(btnRealizarPagos);
            Controls.Add(btnConsultarHorario);
            Controls.Add(btnInscripcionCurso);
            Controls.Add(label2);
            Controls.Add(btnGestionarCursos);
            Controls.Add(btnRegistrarEstudiante);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPanelUsuario";
            Text = "PanelUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarEstudiante;
        private Button btnGestionarCursos;
        private Label label2;
        private Button btnInscripcionCurso;
        private Button btnConsultarHorario;
        private Button btnRealizarPagos;
        private Button btnSalir;
        private Button btnGestionarListasEspera;
        private Button btnGestionarRequisitos;
        private Button btnGestionarProfesor;
        private Button bttnGenerarReporte;
        private Button btnVerCursos;
    }
}