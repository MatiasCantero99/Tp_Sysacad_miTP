﻿namespace Formularios
{
    partial class FrmGestionarProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarProfesores));
            btnSalir = new Button();
            btnAgregarProfesor = new Button();
            btnEditarProfesor = new Button();
            btnEliminarProfesor = new Button();
            btnAgregarCurso = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtDireccion = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            btnRegistrarProfesor = new Button();
            dtgProfesores = new DataGridView();
            txtEspecializacion = new TextBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgProfesores).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(17, 630);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregarProfesor
            // 
            btnAgregarProfesor.BackColor = Color.SandyBrown;
            btnAgregarProfesor.FlatStyle = FlatStyle.Flat;
            btnAgregarProfesor.Location = new Point(87, 505);
            btnAgregarProfesor.Margin = new Padding(4, 5, 4, 5);
            btnAgregarProfesor.Name = "btnAgregarProfesor";
            btnAgregarProfesor.Size = new Size(164, 38);
            btnAgregarProfesor.TabIndex = 2;
            btnAgregarProfesor.Text = "Agregar Profesor";
            btnAgregarProfesor.UseVisualStyleBackColor = false;
            btnAgregarProfesor.Click += btnAgregarProfesor_Click;
            // 
            // btnEditarProfesor
            // 
            btnEditarProfesor.BackColor = Color.SandyBrown;
            btnEditarProfesor.FlatStyle = FlatStyle.Flat;
            btnEditarProfesor.Location = new Point(293, 505);
            btnEditarProfesor.Margin = new Padding(4, 5, 4, 5);
            btnEditarProfesor.Name = "btnEditarProfesor";
            btnEditarProfesor.Size = new Size(159, 38);
            btnEditarProfesor.TabIndex = 3;
            btnEditarProfesor.Text = "Editar Profesor";
            btnEditarProfesor.UseVisualStyleBackColor = false;
            btnEditarProfesor.Click += btnEditarProfesor_Click;
            // 
            // btnEliminarProfesor
            // 
            btnEliminarProfesor.BackColor = Color.SandyBrown;
            btnEliminarProfesor.FlatStyle = FlatStyle.Flat;
            btnEliminarProfesor.Location = new Point(529, 505);
            btnEliminarProfesor.Margin = new Padding(4, 5, 4, 5);
            btnEliminarProfesor.Name = "btnEliminarProfesor";
            btnEliminarProfesor.Size = new Size(167, 38);
            btnEliminarProfesor.TabIndex = 4;
            btnEliminarProfesor.Text = "Eliminar Profesor";
            btnEliminarProfesor.UseVisualStyleBackColor = false;
            btnEliminarProfesor.Click += btnEliminarProfesor_Click;
            // 
            // btnAgregarCurso
            // 
            btnAgregarCurso.BackColor = Color.SandyBrown;
            btnAgregarCurso.FlatStyle = FlatStyle.Flat;
            btnAgregarCurso.Location = new Point(818, 505);
            btnAgregarCurso.Margin = new Padding(4, 5, 4, 5);
            btnAgregarCurso.Name = "btnAgregarCurso";
            btnAgregarCurso.Size = new Size(247, 38);
            btnAgregarCurso.TabIndex = 5;
            btnAgregarCurso.Text = "Agregar Curso en Profesor";
            btnAgregarCurso.UseVisualStyleBackColor = false;
            btnAgregarCurso.Click += btnAgregarCurso_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Khaki;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(224, 50);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(141, 31);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.Khaki;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.ForeColor = SystemColors.ActiveCaptionText;
            txtApellido.Location = new Point(224, 143);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(141, 31);
            txtApellido.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.BackColor = Color.Khaki;
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.ForeColor = SystemColors.ActiveCaptionText;
            txtDni.Location = new Point(433, 50);
            txtDni.Margin = new Padding(4, 5, 4, 5);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(141, 31);
            txtDni.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.Khaki;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.ForeColor = SystemColors.ActiveCaptionText;
            txtDireccion.Location = new Point(433, 143);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(141, 31);
            txtDireccion.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.Khaki;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.ForeColor = SystemColors.ActiveCaptionText;
            txtCorreo.Location = new Point(684, 50);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(141, 31);
            txtCorreo.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Khaki;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.ForeColor = SystemColors.ActiveCaptionText;
            txtTelefono.Location = new Point(684, 143);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(141, 31);
            txtTelefono.TabIndex = 11;
            // 
            // btnRegistrarProfesor
            // 
            btnRegistrarProfesor.BackColor = Color.SandyBrown;
            btnRegistrarProfesor.FlatStyle = FlatStyle.Flat;
            btnRegistrarProfesor.Location = new Point(387, 630);
            btnRegistrarProfesor.Margin = new Padding(4, 5, 4, 5);
            btnRegistrarProfesor.Name = "btnRegistrarProfesor";
            btnRegistrarProfesor.Size = new Size(219, 38);
            btnRegistrarProfesor.TabIndex = 12;
            btnRegistrarProfesor.Text = "Registrar Profesor";
            btnRegistrarProfesor.UseVisualStyleBackColor = false;
            btnRegistrarProfesor.Click += btnRegistrarProfesor_Click;
            // 
            // dtgProfesores
            // 
            dtgProfesores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProfesores.Location = new Point(31, 210);
            dtgProfesores.Margin = new Padding(4, 5, 4, 5);
            dtgProfesores.Name = "dtgProfesores";
            dtgProfesores.RowHeadersWidth = 62;
            dtgProfesores.RowTemplate.Height = 25;
            dtgProfesores.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgProfesores.Size = new Size(1021, 250);
            dtgProfesores.TabIndex = 13;
            dtgProfesores.CellClick += dtgProfesores_CellClick;
            // 
            // txtEspecializacion
            // 
            txtEspecializacion.BackColor = Color.Khaki;
            txtEspecializacion.BorderStyle = BorderStyle.FixedSingle;
            txtEspecializacion.ForeColor = SystemColors.ActiveCaptionText;
            txtEspecializacion.Location = new Point(933, 97);
            txtEspecializacion.Margin = new Padding(4, 5, 4, 5);
            txtEspecializacion.Name = "txtEspecializacion";
            txtEspecializacion.PlaceholderText = "Especializacion";
            txtEspecializacion.Size = new Size(141, 31);
            txtEspecializacion.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Gold;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(433, 553);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(107, 38);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmGestionarProfesores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(btnGuardar);
            Controls.Add(txtEspecializacion);
            Controls.Add(dtgProfesores);
            Controls.Add(btnRegistrarProfesor);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtDireccion);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregarCurso);
            Controls.Add(btnEliminarProfesor);
            Controls.Add(btnEditarProfesor);
            Controls.Add(btnAgregarProfesor);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGestionarProfesores";
            Text = "FrmGestionarProfesores";
            Load += FrmGestionarProfesores_Load;
            ((System.ComponentModel.ISupportInitialize)dtgProfesores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnAgregarProfesor;
        private Button btnEditarProfesor;
        private Button btnEliminarProfesor;
        private Button btnAgregarCurso;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtDireccion;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Button btnRegistrarProfesor;
        private DataGridView dtgProfesores;
        private TextBox txtEspecializacion;
        private Button btnGuardar;
    }
}