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
    public partial class Calles : Form
    {
        CN_Calles _CN_Calles = new CN_Calles();

        public Calles()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _CN_Calles.AgregarCalles(txtLocalidad.Text,txtNombre.Text);
            MostrarCalles();
            Limpiartxt();
        }

        private void MostrarCalles()
        {
            CN_Calles _CN_Calles = new CN_Calles();
            dtgCalles.DataSource = _CN_Calles.MostrarTabla();
        }

        private void Limpiartxt()
        {
            txtIdCalle.Clear();
            txtLocalidad.Clear();
            txtNombre.Clear();
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _CN_Calles.EditarCalles(txtIdCalle.Text, txtLocalidad.Text, txtNombre.Text);
            MostrarCalles();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _CN_Calles.EliminarCalles(txtIdCalle.Text);
            MostrarCalles();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void Calles_Load(object sender, EventArgs e)
        {
            MostrarCalles();
        }
    }
}
