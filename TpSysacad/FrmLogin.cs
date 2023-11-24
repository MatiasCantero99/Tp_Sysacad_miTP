using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;
using System.Configuration;

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
            string usuario = ConfigurationManager.AppSettings["administradorUsuario"]!;
            string password = ConfigurationManager.AppSettings["administradorPassword"]!;
            textUsuario.Text = usuario;
            textContrase�a.Text = password;
        }

        private void BtnEstudiante_Click_1(object sender, EventArgs e)
        {
            string usuario = ConfigurationManager.AppSettings["estudianteUsuario"]!;
            string password = ConfigurationManager.AppSettings["estudiantePassword"]!;
            textUsuario.Text = usuario;
            textContrase�a.Text = password;

        }
    }
}