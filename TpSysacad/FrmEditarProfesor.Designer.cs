namespace Formularios
{
    partial class FrmEditarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarProfesor));
            btnSalir = new Button();
            btnGuardarProfesor = new Button();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxDni = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxTelefono = new TextBox();
            txtEspecializacion = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(17, 663);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardarProfesor
            // 
            btnGuardarProfesor.BackColor = Color.Gold;
            btnGuardarProfesor.FlatStyle = FlatStyle.Flat;
            btnGuardarProfesor.Location = new Point(736, 568);
            btnGuardarProfesor.Margin = new Padding(4, 5, 4, 5);
            btnGuardarProfesor.Name = "btnGuardarProfesor";
            btnGuardarProfesor.Size = new Size(206, 38);
            btnGuardarProfesor.TabIndex = 1;
            btnGuardarProfesor.Text = "Guardar Profesor";
            btnGuardarProfesor.UseVisualStyleBackColor = false;
            btnGuardarProfesor.Click += btnGuardarProfesor_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.SandyBrown;
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Location = new Point(759, 172);
            textBoxNombre.Margin = new Padding(4, 5, 4, 5);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(160, 31);
            textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = Color.SandyBrown;
            textBoxApellido.BorderStyle = BorderStyle.FixedSingle;
            textBoxApellido.Location = new Point(759, 329);
            textBoxApellido.Margin = new Padding(4, 5, 4, 5);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(160, 31);
            textBoxApellido.TabIndex = 3;
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = Color.SandyBrown;
            textBoxDni.BorderStyle = BorderStyle.FixedSingle;
            textBoxDni.Location = new Point(759, 226);
            textBoxDni.Margin = new Padding(4, 5, 4, 5);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(160, 31);
            textBoxDni.TabIndex = 4;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BackColor = Color.SandyBrown;
            textBoxDireccion.BorderStyle = BorderStyle.FixedSingle;
            textBoxDireccion.Location = new Point(759, 381);
            textBoxDireccion.Margin = new Padding(4, 5, 4, 5);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(160, 31);
            textBoxDireccion.TabIndex = 5;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BackColor = Color.SandyBrown;
            textBoxCorreo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCorreo.Location = new Point(759, 278);
            textBoxCorreo.Margin = new Padding(4, 5, 4, 5);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(160, 31);
            textBoxCorreo.TabIndex = 6;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.BackColor = Color.SandyBrown;
            textBoxTelefono.BorderStyle = BorderStyle.FixedSingle;
            textBoxTelefono.Location = new Point(759, 492);
            textBoxTelefono.Margin = new Padding(4, 5, 4, 5);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(160, 31);
            textBoxTelefono.TabIndex = 7;
            // 
            // txtEspecializacion
            // 
            txtEspecializacion.BackColor = Color.SandyBrown;
            txtEspecializacion.BorderStyle = BorderStyle.FixedSingle;
            txtEspecializacion.Location = new Point(759, 435);
            txtEspecializacion.Margin = new Padding(4, 5, 4, 5);
            txtEspecializacion.Name = "txtEspecializacion";
            txtEspecializacion.PlaceholderText = "Especializacion";
            txtEspecializacion.Size = new Size(160, 31);
            txtEspecializacion.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(746, 87);
            label1.Name = "label1";
            label1.Size = new Size(173, 26);
            label1.TabIndex = 9;
            label1.Text = "Editor Profesor";
            // 
            // FrmEditarProfesor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(label1);
            Controls.Add(txtEspecializacion);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxDni);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(btnGuardarProfesor);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmEditarProfesor";
            Text = "FrmEditarProfesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnGuardarProfesor;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxDni;
        private TextBox textBoxDireccion;
        private TextBox textBoxCorreo;
        private TextBox textBoxTelefono;
        private TextBox txtEspecializacion;
        private Label label1;
    }
}