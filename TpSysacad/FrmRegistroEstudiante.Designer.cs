namespace Formularios
{
    partial class FrmRegistroEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroEstudiante));
            label1 = new Label();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textDni = new TextBox();
            textDireccion = new TextBox();
            textTelefono = new TextBox();
            textEmail = new TextBox();
            btnRegistro = new Button();
            RbtnCambiarcontrasenia = new RadioButton();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(718, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro Estudiante";
            // 
            // textNombre
            // 
            textNombre.BackColor = Color.Khaki;
            textNombre.BorderStyle = BorderStyle.FixedSingle;
            textNombre.Location = new Point(764, 165);
            textNombre.Margin = new Padding(4, 5, 4, 5);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(141, 31);
            textNombre.TabIndex = 1;
            // 
            // textApellido
            // 
            textApellido.BackColor = Color.Khaki;
            textApellido.BorderStyle = BorderStyle.FixedSingle;
            textApellido.Location = new Point(764, 222);
            textApellido.Margin = new Padding(4, 5, 4, 5);
            textApellido.Name = "textApellido";
            textApellido.PlaceholderText = "Apellido";
            textApellido.Size = new Size(141, 31);
            textApellido.TabIndex = 2;
            // 
            // textDni
            // 
            textDni.BackColor = Color.Khaki;
            textDni.BorderStyle = BorderStyle.FixedSingle;
            textDni.Location = new Point(764, 283);
            textDni.Margin = new Padding(4, 5, 4, 5);
            textDni.Name = "textDni";
            textDni.PlaceholderText = "DNI";
            textDni.Size = new Size(141, 31);
            textDni.TabIndex = 3;
            // 
            // textDireccion
            // 
            textDireccion.BackColor = Color.Khaki;
            textDireccion.BorderStyle = BorderStyle.FixedSingle;
            textDireccion.Location = new Point(764, 335);
            textDireccion.Margin = new Padding(4, 5, 4, 5);
            textDireccion.Name = "textDireccion";
            textDireccion.PlaceholderText = "Direccion";
            textDireccion.Size = new Size(141, 31);
            textDireccion.TabIndex = 4;
            // 
            // textTelefono
            // 
            textTelefono.BackColor = Color.Khaki;
            textTelefono.BorderStyle = BorderStyle.FixedSingle;
            textTelefono.Location = new Point(764, 385);
            textTelefono.Margin = new Padding(4, 5, 4, 5);
            textTelefono.Name = "textTelefono";
            textTelefono.PlaceholderText = "Telefono";
            textTelefono.Size = new Size(141, 31);
            textTelefono.TabIndex = 5;
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.Khaki;
            textEmail.BorderStyle = BorderStyle.FixedSingle;
            textEmail.Location = new Point(764, 438);
            textEmail.Margin = new Padding(4, 5, 4, 5);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Email";
            textEmail.Size = new Size(141, 31);
            textEmail.TabIndex = 6;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.Gold;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Location = new Point(784, 539);
            btnRegistro.Margin = new Padding(4, 5, 4, 5);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(107, 38);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += BtnRegistro_Click;
            // 
            // RbtnCambiarcontrasenia
            // 
            RbtnCambiarcontrasenia.AutoSize = true;
            RbtnCambiarcontrasenia.BackColor = Color.Transparent;
            RbtnCambiarcontrasenia.Location = new Point(642, 500);
            RbtnCambiarcontrasenia.Margin = new Padding(4, 5, 4, 5);
            RbtnCambiarcontrasenia.Name = "RbtnCambiarcontrasenia";
            RbtnCambiarcontrasenia.Size = new Size(180, 29);
            RbtnCambiarcontrasenia.TabIndex = 9;
            RbtnCambiarcontrasenia.TabStop = true;
            RbtnCambiarcontrasenia.Text = "Cambiar Contraña";
            RbtnCambiarcontrasenia.UseVisualStyleBackColor = false;
            RbtnCambiarcontrasenia.CheckedChanged += RbtnCambiarcontrasenia_CheckedChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.IndianRed;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(209, 585);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(107, 38);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmRegistroEstudiante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(btnVolver);
            Controls.Add(RbtnCambiarcontrasenia);
            Controls.Add(btnRegistro);
            Controls.Add(textEmail);
            Controls.Add(textTelefono);
            Controls.Add(textDireccion);
            Controls.Add(textDni);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistroEstudiante";
            Text = "FrmRegistroEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDni;
        private TextBox textDireccion;
        private TextBox textTelefono;
        private TextBox textEmail;
        private Button btnRegistro;
        private RadioButton RbtnCambiarcontrasenia;
        private Button btnVolver;
    }
}