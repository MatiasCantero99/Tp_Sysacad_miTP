namespace Formularios
{
    partial class FrmGestionarRequisitosAcademics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarRequisitosAcademics));
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PromedioRequerido = new DataGridViewTextBoxColumn();
            Correlatividades = new DataGridViewTextBoxColumn();
            CreditosRequeridos = new DataGridViewTextBoxColumn();
            lblListaVacia = new Label();
            btnSalir = new Button();
            btnEditarPromedio = new Button();
            btnEditarCreditos = new Button();
            btnEditarCorrelativas = new Button();
            txtNuevoPromedio = new TextBox();
            btnGuardar = new Button();
            txtNuevoCredito = new TextBox();
            btnGuardarCredito = new Button();
            btnGuardarCorrelativa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SandyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, PromedioRequerido, Correlatividades, CreditosRequeridos });
            dataGridView1.Location = new Point(43, 245);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(909, 250);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 8;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // PromedioRequerido
            // 
            PromedioRequerido.HeaderText = "PromedioRequerido";
            PromedioRequerido.MinimumWidth = 8;
            PromedioRequerido.Name = "PromedioRequerido";
            PromedioRequerido.ReadOnly = true;
            PromedioRequerido.Width = 120;
            // 
            // Correlatividades
            // 
            Correlatividades.HeaderText = "CreditosRequeridos";
            Correlatividades.MinimumWidth = 8;
            Correlatividades.Name = "Correlatividades";
            Correlatividades.ReadOnly = true;
            Correlatividades.Width = 120;
            // 
            // CreditosRequeridos
            // 
            CreditosRequeridos.HeaderText = "Correlatividades";
            CreditosRequeridos.MinimumWidth = 8;
            CreditosRequeridos.Name = "CreditosRequeridos";
            CreditosRequeridos.ReadOnly = true;
            CreditosRequeridos.Width = 1000;
            // 
            // lblListaVacia
            // 
            lblListaVacia.BackColor = Color.Transparent;
            lblListaVacia.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblListaVacia.Location = new Point(183, 245);
            lblListaVacia.Margin = new Padding(4, 0, 4, 0);
            lblListaVacia.Name = "lblListaVacia";
            lblListaVacia.Size = new Size(679, 147);
            lblListaVacia.TabIndex = 1;
            lblListaVacia.Text = "label1";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(17, 645);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEditarPromedio
            // 
            btnEditarPromedio.BackColor = Color.SandyBrown;
            btnEditarPromedio.FlatStyle = FlatStyle.Flat;
            btnEditarPromedio.Location = new Point(159, 574);
            btnEditarPromedio.Margin = new Padding(4, 5, 4, 5);
            btnEditarPromedio.Name = "btnEditarPromedio";
            btnEditarPromedio.Size = new Size(174, 38);
            btnEditarPromedio.TabIndex = 3;
            btnEditarPromedio.Text = "Editar Promedio";
            btnEditarPromedio.UseVisualStyleBackColor = false;
            btnEditarPromedio.Click += btnEditarPromedio_Click;
            // 
            // btnEditarCreditos
            // 
            btnEditarCreditos.BackColor = Color.SandyBrown;
            btnEditarCreditos.FlatStyle = FlatStyle.Flat;
            btnEditarCreditos.Location = new Point(379, 574);
            btnEditarCreditos.Margin = new Padding(4, 5, 4, 5);
            btnEditarCreditos.Name = "btnEditarCreditos";
            btnEditarCreditos.Size = new Size(196, 38);
            btnEditarCreditos.TabIndex = 4;
            btnEditarCreditos.Text = "Editar Creditos";
            btnEditarCreditos.UseVisualStyleBackColor = false;
            btnEditarCreditos.Click += btnEditarCreditos_Click_1;
            // 
            // btnEditarCorrelativas
            // 
            btnEditarCorrelativas.BackColor = Color.SandyBrown;
            btnEditarCorrelativas.FlatStyle = FlatStyle.Flat;
            btnEditarCorrelativas.Location = new Point(621, 574);
            btnEditarCorrelativas.Margin = new Padding(4, 5, 4, 5);
            btnEditarCorrelativas.Name = "btnEditarCorrelativas";
            btnEditarCorrelativas.Size = new Size(194, 38);
            btnEditarCorrelativas.TabIndex = 5;
            btnEditarCorrelativas.Text = "Editar Correlativas";
            btnEditarCorrelativas.UseVisualStyleBackColor = false;
            btnEditarCorrelativas.Click += btnEditarCorrelativas_Click_1;
            // 
            // txtNuevoPromedio
            // 
            txtNuevoPromedio.Location = new Point(379, 430);
            txtNuevoPromedio.Margin = new Padding(4, 5, 4, 5);
            txtNuevoPromedio.Name = "txtNuevoPromedio";
            txtNuevoPromedio.PlaceholderText = "Ingrese Nuevo Promedio";
            txtNuevoPromedio.Size = new Size(218, 31);
            txtNuevoPromedio.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Gold;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(373, 507);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(196, 38);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar Promedio";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNuevoCredito
            // 
            txtNuevoCredito.Location = new Point(379, 430);
            txtNuevoCredito.Margin = new Padding(4, 5, 4, 5);
            txtNuevoCredito.Name = "txtNuevoCredito";
            txtNuevoCredito.PlaceholderText = "Nuevo Credito";
            txtNuevoCredito.Size = new Size(190, 31);
            txtNuevoCredito.TabIndex = 9;
            // 
            // btnGuardarCredito
            // 
            btnGuardarCredito.BackColor = Color.Gold;
            btnGuardarCredito.FlatStyle = FlatStyle.Flat;
            btnGuardarCredito.Location = new Point(146, 507);
            btnGuardarCredito.Margin = new Padding(4, 5, 4, 5);
            btnGuardarCredito.Name = "btnGuardarCredito";
            btnGuardarCredito.Size = new Size(187, 38);
            btnGuardarCredito.TabIndex = 10;
            btnGuardarCredito.Text = "Guardar Credito";
            btnGuardarCredito.UseVisualStyleBackColor = false;
            btnGuardarCredito.Click += btnGuardarCredito_Click;
            // 
            // btnGuardarCorrelativa
            // 
            btnGuardarCorrelativa.BackColor = Color.Gold;
            btnGuardarCorrelativa.FlatStyle = FlatStyle.Flat;
            btnGuardarCorrelativa.Location = new Point(619, 507);
            btnGuardarCorrelativa.Margin = new Padding(4, 5, 4, 5);
            btnGuardarCorrelativa.Name = "btnGuardarCorrelativa";
            btnGuardarCorrelativa.Size = new Size(196, 38);
            btnGuardarCorrelativa.TabIndex = 11;
            btnGuardarCorrelativa.Text = "Guardar Correlativa";
            btnGuardarCorrelativa.UseVisualStyleBackColor = false;
            btnGuardarCorrelativa.Click += btnGuardarCorrelativa_Click;
            // 
            // FrmGestionarRequisitosAcademics
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(btnGuardarCorrelativa);
            Controls.Add(btnGuardarCredito);
            Controls.Add(txtNuevoCredito);
            Controls.Add(btnGuardar);
            Controls.Add(txtNuevoPromedio);
            Controls.Add(btnEditarCorrelativas);
            Controls.Add(btnEditarCreditos);
            Controls.Add(btnEditarPromedio);
            Controls.Add(btnSalir);
            Controls.Add(lblListaVacia);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGestionarRequisitosAcademics";
            Text = "FrmGestionarRequisitosAcademics";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblListaVacia;
        private Button btnSalir;
        private Button btnEditarPromedio;
        private Button btnEditarCreditos;
        private Button btnEditarCorrelativas;
        private TextBox txtNuevoPromedio;
        private Button btnGuardar;
        private TextBox txtNuevoCredito;
        private Button btnGuardarCredito;
        private Button btnGuardarCorrelativa;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PromedioRequerido;
        private DataGridViewTextBoxColumn Correlatividades;
        private DataGridViewTextBoxColumn CreditosRequeridos;
    }
}