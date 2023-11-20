using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;

namespace Formularios

{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string dni = textUsuario.Text; // de momento se usa el dni de usuario
            string contrase�a = textContrase�a.Text;
            bool verificado = false;


            ControlLogin controlLogin = new();
            bool existeUsuarios = controlLogin.ExisteUsuario;

            if (existeUsuarios)
            {

                verificado = controlLogin.AutenticarUsuario(dni, contrase�a);
                if (verificado)
                {
                    Usuario usuarioActual = controlLogin.GetUsuario;
                    FormPanelUsuario frmPanelUsuario = new(usuarioActual);

                    frmPanelUsuario.FormClosed += (sender, args) =>
                    {
                        this.Close();
                    };
                    frmPanelUsuario.Show();

                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Usuario o contrase�a Incorrecta");
                    textUsuario.Text = string.Empty;
                    textContrase�a.Text = string.Empty;

                }
            }
            else
            {
                MessageBox.Show("No se puede acceder en estos momentos");
            }

        }


        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            textUsuario.Text = "44000000";
            textContrase�a.Text = "44000000";
        }

        private void BtnEstudiante_Click_1(object sender, EventArgs e)
        {
            textUsuario.Text = "12312345";
            textContrase�a.Text = "L=Y6+*3a>aF";

        }
    }
}