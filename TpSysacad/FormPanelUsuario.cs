﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaCLases.DataBase;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;

namespace Formularios
{
    public partial class FormPanelUsuario : Form
    {
        private Usuario _usuario;
        public FormPanelUsuario(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            MostrarBtn(_usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistroEstudiante frmRegistroEstudiante = new(_usuario);

            frmRegistroEstudiante.FormClosed += (sender, args) =>
            {
                this.Close();
            };

            frmRegistroEstudiante.Show();
            this.Hide();
        }

        private void BtnGestionarCursos_Click(object sender, EventArgs e)
        {
            FrmGestionarCursos frmGestionarCurso = new(_usuario);

            frmGestionarCurso.FormClosed += (sender, args) =>
            {
                this.Close();
            };

            frmGestionarCurso.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BtnGestionarCursos_Click(sender, e);
        }
        private void MostrarBtn(Usuario usuario)
        {
            btnInscripcionCurso.Visible = false;
            btnGestionarCursos.Visible = false;
            btnRegistrarEstudiante.Visible = false;
            btnConsultarHorario.Visible = false;
            btnRealizarPagos.Visible = false;
            btnGestionarListasEspera.Visible = false;
            btnGestionarRequisitos.Visible = false;
            btnGestionarProfesor.Visible = false;
            bttnGenerarReporte.Visible = false;
            if (usuario.TipoUsuario.ToString() == "Estudiante")
            {
                btnInscripcionCurso.Visible = true;
                btnConsultarHorario.Visible = true;
                btnRealizarPagos.Visible = true;

            }
            else if (usuario.TipoUsuario.ToString() == "Administrador")
            {
                btnRegistrarEstudiante.Visible = true;
                btnGestionarCursos.Visible = true;
                btnGestionarListasEspera.Visible = true;
                btnGestionarRequisitos.Visible = true;
                btnGestionarProfesor.Visible = true;
                bttnGenerarReporte.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormConsultarHorario frmConsultarHorario = new(_usuario);

            frmConsultarHorario.FormClosed += (sender, args) =>
            {
                this.Close();
            };

            frmConsultarHorario.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmPago frmPago = new(_usuario);
            frmPago.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();

            frmLogin.FormClosed += (s, args) =>
            {
                this.Close();
            };

            frmLogin.Show();
            this.Hide();
        }

        private void btnGestionarListasEspera_Click(object sender, EventArgs e)
        {

            FrmGestionListaEspera gestionListasEsperaForm = new(_usuario);
            gestionListasEsperaForm.Show();
            this.Hide();

        }

        private void btnGestionarRequisitos_Click(object sender, EventArgs e)
        {
            FrmGestionarRequisitosAcademics frmGestionarRequisitosAcademics = new(_usuario);
            frmGestionarRequisitosAcademics.Show();
            this.Hide();
        }

        private void btnGestionarProfesor_Click(object sender, EventArgs e)
        {
            FrmGestionarProfesores frmGestionarProfesores = new(_usuario);
            frmGestionarProfesores.Show();
            this.Hide();
        }

        private void bttnGenerarReporte_Click(object sender, EventArgs e)
        {
            FormGenerarReportes formGenerarReportes = new FormGenerarReportes(_usuario);
            formGenerarReportes.Show();
            this.Hide();
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            FrmCursosAcargo frmAgregarCurso = new(_usuario);
            frmAgregarCurso.Show();
            this.Hide();
        }
    }
}
