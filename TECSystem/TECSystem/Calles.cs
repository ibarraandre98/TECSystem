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
            Limpiartxt();
            MostrarTabla();

        }

        private void MostrarTabla()
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
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _CN_Calles.EliminarCalles(txtIdCalle.Text);
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();
        }

        private void Calles_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }

        private void DtgCalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCalle.Text = dtgCalles.CurrentRow.Cells["idCalle"].Value.ToString();
            txtLocalidad.Text = dtgCalles.CurrentRow.Cells["Localidad"].Value.ToString();
            txtNombre.Text = dtgCalles.CurrentRow.Cells["nombre"].Value.ToString();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }
    }
}
