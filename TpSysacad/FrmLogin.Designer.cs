namespace Formularios
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            BtnLogin = new Button();
            textUsuario = new TextBox();
            textContraseña = new TextBox();
            BtnEstudiante = new Button();
            BtnAdministrador = new Button();
            btnProfesor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(214, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(655, 54);
            label1.TabIndex = 0;
            label1.Text = "Universidad Tecnológica Nacional";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(336, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(350, 32);
            label2.TabIndex = 1;
            label2.Text = "Sistema Académico SYSACAD";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.Gold;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Location = new Point(460, 496);
            BtnLogin.Margin = new Padding(4, 5, 4, 5);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(107, 38);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // textUsuario
            // 
            textUsuario.BackColor = Color.MediumPurple;
            textUsuario.BorderStyle = BorderStyle.FixedSingle;
            textUsuario.Location = new Point(442, 252);
            textUsuario.Margin = new Padding(4, 5, 4, 5);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "Usuario";
            textUsuario.Size = new Size(141, 31);
            textUsuario.TabIndex = 3;
            // 
            // textContraseña
            // 
            textContraseña.BackColor = Color.MediumPurple;
            textContraseña.BorderStyle = BorderStyle.FixedSingle;
            textContraseña.Location = new Point(442, 356);
            textContraseña.Margin = new Padding(4, 5, 4, 5);
            textContraseña.Name = "textContraseña";
            textContraseña.PasswordChar = '*';
            textContraseña.PlaceholderText = "Contraseña";
            textContraseña.Size = new Size(141, 31);
            textContraseña.TabIndex = 4;
            // 
            // BtnEstudiante
            // 
            BtnEstudiante.BackColor = Color.MediumSlateBlue;
            BtnEstudiante.FlatStyle = FlatStyle.Flat;
            BtnEstudiante.Location = new Point(866, 376);
            BtnEstudiante.Margin = new Padding(4, 5, 4, 5);
            BtnEstudiante.Name = "BtnEstudiante";
            BtnEstudiante.Size = new Size(149, 38);
            BtnEstudiante.TabIndex = 5;
            BtnEstudiante.Text = "Estudiante";
            BtnEstudiante.UseVisualStyleBackColor = false;
            BtnEstudiante.Click += BtnEstudiante_Click_1;
            // 
            // BtnAdministrador
            // 
            BtnAdministrador.BackColor = Color.SandyBrown;
            BtnAdministrador.FlatStyle = FlatStyle.Flat;
            BtnAdministrador.Location = new Point(866, 328);
            BtnAdministrador.Margin = new Padding(4, 5, 4, 5);
            BtnAdministrador.Name = "BtnAdministrador";
            BtnAdministrador.Size = new Size(149, 38);
            BtnAdministrador.TabIndex = 6;
            BtnAdministrador.Text = "Administrador";
            BtnAdministrador.UseVisualStyleBackColor = false;
            BtnAdministrador.Click += BtnAdministrador_Click;
            // 
            // btnProfesor
            // 
            btnProfesor.BackColor = Color.SeaGreen;
            btnProfesor.FlatStyle = FlatStyle.Flat;
            btnProfesor.Location = new Point(866, 280);
            btnProfesor.Margin = new Padding(4, 5, 4, 5);
            btnProfesor.Name = "btnProfesor";
            btnProfesor.Size = new Size(149, 38);
            btnProfesor.TabIndex = 7;
            btnProfesor.Text = "Profesor";
            btnProfesor.UseVisualStyleBackColor = false;
            btnProfesor.Click += btnProfesor_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 717);
            Controls.Add(btnProfesor);
            Controls.Add(BtnAdministrador);
            Controls.Add(BtnEstudiante);
            Controls.Add(textContraseña);
            Controls.Add(textUsuario);
            Controls.Add(BtnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            Text = "Sysacad Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnLogin;
        private TextBox textUsuario;
        private TextBox textContraseña;
        private Button BtnEstudiante;
        private Button BtnAdministrador;
        private Button btnProfesor;
    }
}