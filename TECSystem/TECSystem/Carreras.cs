using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace TECSystem
{
    public partial class Carreras : Form
    {
        CN_Carreras _CN_Carrera = new CN_Carreras();

        public Carreras()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _CN_Carrera.AgregarCarrera(txtNombre.Text, txtCoordinador.Text);
            MostrarCalles();
            Limpiartxt();
        }

        private void MostrarCalles()
        {
            CN_Calles _CN_Calles = new CN_Calles();
            dtgCarreras.DataSource = _CN_Calles.MostrarTabla();
        }

        private void Limpiartxt()
        {
            txtIdCarrera.Clear();
            txtCoordinador.Clear();
            txtNombre.Clear();
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _CN_Carrera.EditarCarrera(txtIdCarrera.Text, txtNombre.Text, txtCoordinador.Text);
            MostrarCalles();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _CN_Carrera.EliminarCarrera(txtIdCarrera.Text);
            MostrarCalles();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            MostrarCalles();
        }
    }
}
