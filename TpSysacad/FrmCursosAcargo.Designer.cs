namespace Formularios
{
    partial class FrmCursosAcargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursosAcargo));
            btnSalir = new Button();
            dtgCrusos_alumnos = new DataGridView();
            btnMostrarAlumnos = new Button();
            btnIngresarNota = new Button();
            btnAsistancia = new Button();
            CbxTipoEvaluacion = new ComboBox();
            textBoxNota = new TextBox();
            btnGuardarNota = new Button();
            cbxAsistencia = new ComboBox();
            btnGuardarAsistencia = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCrusos_alumnos).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = SystemColors.ActiveCaptionText;
            btnSalir.Location = new Point(34, 662);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dtgCrusos_alumnos
            // 
            dtgCrusos_alumnos.BackgroundColor = Color.ForestGreen;
            dtgCrusos_alumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCrusos_alumnos.Location = new Point(49, 197);
            dtgCrusos_alumnos.Margin = new Padding(4, 5, 4, 5);
            dtgCrusos_alumnos.Name = "dtgCrusos_alumnos";
            dtgCrusos_alumnos.RowHeadersWidth = 62;
            dtgCrusos_alumnos.RowTemplate.Height = 25;
            dtgCrusos_alumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCrusos_alumnos.Size = new Size(914, 250);
            dtgCrusos_alumnos.TabIndex = 1;
            dtgCrusos_alumnos.CellClick += dtgCrusos_alumnos_CellClick;
            // 
            // btnMostrarAlumnos
            // 
            btnMostrarAlumnos.BackColor = Color.SeaGreen;
            btnMostrarAlumnos.FlatStyle = FlatStyle.Flat;
            btnMostrarAlumnos.Location = new Point(360, 547);
            btnMostrarAlumnos.Margin = new Padding(4, 5, 4, 5);
            btnMostrarAlumnos.Name = "btnMostrarAlumnos";
            btnMostrarAlumnos.Size = new Size(179, 38);
            btnMostrarAlumnos.TabIndex = 2;
            btnMostrarAlumnos.Text = "Mostrar Alumnos ";
            btnMostrarAlumnos.UseVisualStyleBackColor = false;
            btnMostrarAlumnos.Click += btnMostrarAlumnos_Click;
            // 
            // btnIngresarNota
            // 
            btnIngresarNota.BackColor = Color.SeaGreen;
            btnIngresarNota.FlatStyle = FlatStyle.Flat;
            btnIngresarNota.Location = new Point(101, 477);
            btnIngresarNota.Margin = new Padding(4, 5, 4, 5);
            btnIngresarNota.Name = "btnIngresarNota";
            btnIngresarNota.Size = new Size(157, 38);
            btnIngresarNota.TabIndex = 3;
            btnIngresarNota.Text = "ingresar Nota";
            btnIngresarNota.UseVisualStyleBackColor = false;
            btnIngresarNota.Visible = false;
            btnIngresarNota.Click += btnIngresarNota_Click;
            // 
            // btnAsistancia
            // 
            btnAsistancia.BackColor = Color.SeaGreen;
            btnAsistancia.FlatStyle = FlatStyle.Flat;
            btnAsistancia.Location = new Point(716, 477);
            btnAsistancia.Margin = new Padding(4, 5, 4, 5);
            btnAsistancia.Name = "btnAsistancia";
            btnAsistancia.Size = new Size(133, 38);
            btnAsistancia.TabIndex = 4;
            btnAsistancia.Text = "Asistencia";
            btnAsistancia.UseVisualStyleBackColor = false;
            btnAsistancia.Visible = false;
            btnAsistancia.Click += btnAsistancia_Click;
            // 
            // CbxTipoEvaluacion
            // 
            CbxTipoEvaluacion.BackColor = Color.Green;
            CbxTipoEvaluacion.FlatStyle = FlatStyle.Flat;
            CbxTipoEvaluacion.FormattingEnabled = true;
            CbxTipoEvaluacion.Location = new Point(101, 115);
            CbxTipoEvaluacion.Margin = new Padding(4, 5, 4, 5);
            CbxTipoEvaluacion.Name = "CbxTipoEvaluacion";
            CbxTipoEvaluacion.Size = new Size(258, 33);
            CbxTipoEvaluacion.TabIndex = 5;
            CbxTipoEvaluacion.Text = "Seleccione tipo Evaluacion";
            CbxTipoEvaluacion.Visible = false;
            // 
            // textBoxNota
            // 
            textBoxNota.BackColor = Color.SeaGreen;
            textBoxNota.BorderStyle = BorderStyle.FixedSingle;
            textBoxNota.Location = new Point(442, 117);
            textBoxNota.Margin = new Padding(4, 5, 4, 5);
            textBoxNota.Name = "textBoxNota";
            textBoxNota.PlaceholderText = "Ingrese la nota";
            textBoxNota.Size = new Size(141, 31);
            textBoxNota.TabIndex = 6;
            textBoxNota.Visible = false;
            // 
            // btnGuardarNota
            // 
            btnGuardarNota.BackColor = Color.SeaGreen;
            btnGuardarNota.FlatStyle = FlatStyle.Flat;
            btnGuardarNota.Location = new Point(410, 477);
            btnGuardarNota.Margin = new Padding(4, 5, 4, 5);
            btnGuardarNota.Name = "btnGuardarNota";
            btnGuardarNota.Size = new Size(191, 38);
            btnGuardarNota.TabIndex = 7;
            btnGuardarNota.Text = "Guardar Nota";
            btnGuardarNota.UseVisualStyleBackColor = false;
            btnGuardarNota.Visible = false;
            btnGuardarNota.Click += btnGuardarNota_Click;
            // 
            // cbxAsistencia
            // 
            cbxAsistencia.BackColor = Color.Green;
            cbxAsistencia.FlatStyle = FlatStyle.Flat;
            cbxAsistencia.FormattingEnabled = true;
            cbxAsistencia.Location = new Point(683, 120);
            cbxAsistencia.Margin = new Padding(4, 5, 4, 5);
            cbxAsistencia.Name = "cbxAsistencia";
            cbxAsistencia.Size = new Size(227, 33);
            cbxAsistencia.TabIndex = 8;
            cbxAsistencia.Text = "Seleccione la Asistencia";
            cbxAsistencia.Visible = false;
            // 
            // btnGuardarAsistencia
            // 
            btnGuardarAsistencia.BackColor = Color.SeaGreen;
            btnGuardarAsistencia.FlatStyle = FlatStyle.Flat;
            btnGuardarAsistencia.Location = new Point(591, 547);
            btnGuardarAsistencia.Margin = new Padding(4, 5, 4, 5);
            btnGuardarAsistencia.Name = "btnGuardarAsistencia";
            btnGuardarAsistencia.Size = new Size(184, 38);
            btnGuardarAsistencia.TabIndex = 9;
            btnGuardarAsistencia.Text = "Guardar Asistencia";
            btnGuardarAsistencia.UseVisualStyleBackColor = false;
            btnGuardarAsistencia.Visible = false;
            btnGuardarAsistencia.Click += btnGuardarAsistencia_Click;
            // 
            // FrmCursosAcargo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(btnGuardarAsistencia);
            Controls.Add(cbxAsistencia);
            Controls.Add(btnGuardarNota);
            Controls.Add(textBoxNota);
            Controls.Add(CbxTipoEvaluacion);
            Controls.Add(btnAsistancia);
            Controls.Add(btnIngresarNota);
            Controls.Add(btnMostrarAlumnos);
            Controls.Add(dtgCrusos_alumnos);
            Controls.Add(btnSalir);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmCursosAcargo";
            Text = "FrmCursosAcargo";
            Load += FrmCursosAcargo_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCrusos_alumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private DataGridView dtgCrusos_alumnos;
        private Button btnMostrarAlumnos;
        private Button btnIngresarNota;
        private Button btnAsistancia;
        private ComboBox CbxTipoEvaluacion;
        private TextBox textBoxNota;
        private Button btnGuardarNota;
        private ComboBox cbxAsistencia;
        private Button btnGuardarAsistencia;
    }
}