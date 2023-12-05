namespace Formularios
{
    partial class FrmAgregarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCurso));
            textNombre = new TextBox();
            textCodigo = new TextBox();
            textDescripcion = new TextBox();
            textCupoMax = new TextBox();
            BtnAgregar = new Button();
            label1 = new Label();
            cBAula = new ComboBox();
            cBHorarios = new ComboBox();
            cBDias = new ComboBox();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.Khaki;
            textNombre.BorderStyle = BorderStyle.FixedSingle;
            textNombre.Location = new Point(604, 143);
            textNombre.Margin = new Padding(4);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(155, 31);
            textNombre.TabIndex = 0;
            textNombre.TextChanged += textBox1_TextChanged;
            // 
            // textCodigo
            // 
            textCodigo.BackColor = Color.Khaki;
            textCodigo.BorderStyle = BorderStyle.FixedSingle;
            textCodigo.Location = new Point(604, 228);
            textCodigo.Margin = new Padding(4);
            textCodigo.Name = "textCodigo";
            textCodigo.PlaceholderText = "Código";
            textCodigo.Size = new Size(155, 31);
            textCodigo.TabIndex = 1;
            // 
            // textDescripcion
            // 
            textDescripcion.BackColor = Color.Khaki;
            textDescripcion.BorderStyle = BorderStyle.FixedSingle;
            textDescripcion.Location = new Point(604, 329);
            textDescripcion.Margin = new Padding(4);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.PlaceholderText = "Descripción";
            textDescripcion.Size = new Size(155, 31);
            textDescripcion.TabIndex = 2;
            // 
            // textCupoMax
            // 
            textCupoMax.BackColor = Color.Khaki;
            textCupoMax.BorderStyle = BorderStyle.FixedSingle;
            textCupoMax.Location = new Point(604, 433);
            textCupoMax.Margin = new Padding(4);
            textCupoMax.Name = "textCupoMax";
            textCupoMax.PlaceholderText = "Cupo Máximo";
            textCupoMax.Size = new Size(155, 31);
            textCupoMax.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Gold;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Location = new Point(735, 550);
            BtnAgregar.Margin = new Padding(4);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(118, 36);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(749, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 5;
            label1.Text = "Nuevo Curso";
            // 
            // cBAula
            // 
            cBAula.BackColor = Color.Gold;
            cBAula.FlatStyle = FlatStyle.Flat;
            cBAula.FormattingEnabled = true;
            cBAula.Location = new Point(831, 185);
            cBAula.Name = "cBAula";
            cBAula.Size = new Size(182, 33);
            cBAula.TabIndex = 6;
            cBAula.Text = "Aula";
            cBAula.KeyPress += cBAula_KeyPress;
            // 
            // cBHorarios
            // 
            cBHorarios.BackColor = Color.Gold;
            cBHorarios.FlatStyle = FlatStyle.Flat;
            cBHorarios.FormattingEnabled = true;
            cBHorarios.Location = new Point(831, 277);
            cBHorarios.Name = "cBHorarios";
            cBHorarios.Size = new Size(182, 33);
            cBHorarios.TabIndex = 7;
            cBHorarios.Text = "Horarios";
            cBHorarios.KeyPress += cBHorarios_KeyPress;
            // 
            // cBDias
            // 
            cBDias.BackColor = Color.Gold;
            cBDias.FlatStyle = FlatStyle.Flat;
            cBDias.FormattingEnabled = true;
            cBDias.Location = new Point(831, 380);
            cBDias.Name = "cBDias";
            cBDias.Size = new Size(182, 33);
            cBDias.TabIndex = 8;
            cBDias.Text = "Dias";
            cBDias.KeyPress += cBDias_KeyPress;
            // 
            // FrmAgregarCurso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(cBDias);
            Controls.Add(cBHorarios);
            Controls.Add(cBAula);
            Controls.Add(label1);
            Controls.Add(BtnAgregar);
            Controls.Add(textCupoMax);
            Controls.Add(textDescripcion);
            Controls.Add(textCodigo);
            Controls.Add(textNombre);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAgregarCurso";
            Text = "FrmAgregarCurso";
            Load += FrmAgregarCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNombre;
        private TextBox textCodigo;
        private TextBox textDescripcion;
        private TextBox textCupoMax;
        private Button BtnAgregar;
        private Label label1;
        private ComboBox cBAula;
        private ComboBox cBHorarios;
        private ComboBox cBDias;
    }
}