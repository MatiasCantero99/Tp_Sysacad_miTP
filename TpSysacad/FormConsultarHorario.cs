﻿using BibliotecaCLases.Controlador;
using BibliotecaCLases.DataBase;
using BibliotecaCLases.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormConsultarHorario : Form
    {
        private Usuario _usuario;
        private CrudEstudiante _crudEstudiante;
        private CrudCurso _crudCurso;
        private DBCursosInscriptos _dBCusoInscripto = new DBCursosInscriptos();

        public FormConsultarHorario(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            _crudEstudiante = new CrudEstudiante();
            _crudCurso = new CrudCurso();
        }

        private void FormConsultarHorario_Load(object sender, EventArgs e)
        {
            Estudiante estudiante = _crudEstudiante.ObtenerEstudiantePorLegajo(_usuario.Legajo);

            if (estudiante != null && _dBCusoInscripto.ContarCursosInscriptosPorLegajo(_usuario.Legajo))
            {
                labelHorarioVacio.Visible = false;
                MostrarHorario(_dBCusoInscripto.VerCursosInscriptosPorLegajo(_usuario.Legajo));
            }
            else
            {
                labelHorario.Visible = false;
                dataGridViewHorario.Visible = false;
                labelHorarioVacio.Visible = true;
            }
        }

        private void MostrarHorario(List<Curso> cursosInscriptos)
        {
            foreach (var curso in cursosInscriptos)
            {
                if (curso != null && curso.Activo != "False")
                {
                    dataGridViewHorario.Rows.Add(curso.Nombre, curso.Horario, curso.Dia, curso.Aula);
                }
            }
        }

        private void dataGridViewHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelHorarioVacio_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPanelUsuario formPanelUsuario = new FormPanelUsuario(_usuario);

            formPanelUsuario.FormClosed += (s, args) =>
            {
                this.Close();
            };

            formPanelUsuario.Show();
            this.Hide();
        }
    }
}
