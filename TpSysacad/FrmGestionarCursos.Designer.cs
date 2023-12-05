﻿namespace Formularios
{
    partial class FrmGestionarCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarCursos));
            dataGridViewCursos = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            curso = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            cuposDisponibles = new DataGridViewTextBoxColumn();
            cupoMaximo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnInscripcion = new Button();
            BtnEditarCursos = new Button();
            BtnEliminarCursos = new Button();
            BtnAgregarCurso = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCursos
            // 
            dataGridViewCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCursos.Columns.AddRange(new DataGridViewColumn[] { codigo, curso, descripcion, cuposDisponibles, cupoMaximo });
            dataGridViewCursos.Location = new Point(133, 147);
            dataGridViewCursos.Margin = new Padding(4, 3, 4, 3);
            dataGridViewCursos.Name = "dataGridViewCursos";
            dataGridViewCursos.RowHeadersWidth = 51;
            dataGridViewCursos.RowTemplate.Height = 29;
            dataGridViewCursos.Size = new Size(904, 372);
            dataGridViewCursos.TabIndex = 0;
            dataGridViewCursos.CellContentClick += dataGridView1_CellContentClick;
            dataGridViewCursos.SelectionChanged += dataGridViewCursos_SelectionChanged;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 75;
            // 
            // curso
            // 
            curso.HeaderText = "Curso";
            curso.MinimumWidth = 6;
            curso.Name = "curso";
            curso.ReadOnly = true;
            curso.Width = 125;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripción";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 155;
            // 
            // cuposDisponibles
            // 
            cuposDisponibles.HeaderText = "Cupos Disponibles";
            cuposDisponibles.MinimumWidth = 6;
            cuposDisponibles.Name = "cuposDisponibles";
            cuposDisponibles.ReadOnly = true;
            cuposDisponibles.Width = 165;
            // 
            // cupoMaximo
            // 
            cupoMaximo.HeaderText = "Cupo Máximo";
            cupoMaximo.MinimumWidth = 6;
            cupoMaximo.Name = "cupoMaximo";
            cupoMaximo.ReadOnly = true;
            cupoMaximo.Width = 155;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(484, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 32);
            label1.TabIndex = 5;
            label1.Text = "Lista de cursos";
            label1.Click += label1_Click;
            // 
            // btnInscripcion
            // 
            btnInscripcion.BackColor = Color.MediumSlateBlue;
            btnInscripcion.FlatStyle = FlatStyle.Flat;
            btnInscripcion.Location = new Point(133, 562);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(181, 43);
            btnInscripcion.TabIndex = 7;
            btnInscripcion.Text = "inscripcion";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // BtnEditarCursos
            // 
            BtnEditarCursos.BackColor = Color.SandyBrown;
            BtnEditarCursos.FlatStyle = FlatStyle.Flat;
            BtnEditarCursos.Location = new Point(506, 567);
            BtnEditarCursos.Margin = new Padding(4, 5, 4, 5);
            BtnEditarCursos.Name = "BtnEditarCursos";
            BtnEditarCursos.Size = new Size(169, 38);
            BtnEditarCursos.TabIndex = 8;
            BtnEditarCursos.Text = "Editar Curso";
            BtnEditarCursos.UseVisualStyleBackColor = false;
            BtnEditarCursos.Click += BtnEditarCursos_Click;
            // 
            // BtnEliminarCursos
            // 
            BtnEliminarCursos.BackColor = Color.SandyBrown;
            BtnEliminarCursos.FlatStyle = FlatStyle.Flat;
            BtnEliminarCursos.Location = new Point(904, 567);
            BtnEliminarCursos.Margin = new Padding(4, 5, 4, 5);
            BtnEliminarCursos.Name = "BtnEliminarCursos";
            BtnEliminarCursos.Size = new Size(133, 38);
            BtnEliminarCursos.TabIndex = 9;
            BtnEliminarCursos.Text = "Eliminar curso";
            BtnEliminarCursos.UseVisualStyleBackColor = false;
            BtnEliminarCursos.Click += BtnEliminarCursos_Click;
            // 
            // BtnAgregarCurso
            // 
            BtnAgregarCurso.BackColor = Color.SandyBrown;
            BtnAgregarCurso.FlatStyle = FlatStyle.Flat;
            BtnAgregarCurso.Location = new Point(133, 564);
            BtnAgregarCurso.Margin = new Padding(4, 5, 4, 5);
            BtnAgregarCurso.Name = "BtnAgregarCurso";
            BtnAgregarCurso.Size = new Size(181, 38);
            BtnAgregarCurso.TabIndex = 10;
            BtnAgregarCurso.Text = "Agregar Curso";
            BtnAgregarCurso.UseVisualStyleBackColor = false;
            BtnAgregarCurso.Click += BtnAgregarCurso_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.IndianRed;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(133, 617);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(181, 38);
            btnVolver.TabIndex = 11;
            btnVolver.TabStop = false;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmGestionarCursos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(btnVolver);
            Controls.Add(BtnAgregarCurso);
            Controls.Add(BtnEliminarCursos);
            Controls.Add(BtnEditarCursos);
            Controls.Add(btnInscripcion);
            Controls.Add(label1);
            Controls.Add(dataGridViewCursos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGestionarCursos";
            Text = "FrmGestionarCurso";
            Load += FrmGestionarCurso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCursos;
        private Label label1;
        private Button btnInscripcion;
        private Button BtnEditarCursos;
        private Button BtnEliminarCursos;
        private Button BtnAgregarCurso;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn curso;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn cuposDisponibles;
        private DataGridViewTextBoxColumn cupoMaximo;
        private Button btnVolver;
    }
}