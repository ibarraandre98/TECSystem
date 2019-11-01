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
    public partial class Academias : Form
    {
        CN_Academia _CN_Academia = new CN_Academia();
        public Academias()
        {
            InitializeComponent();
        }
        private void MostrarAcademias()
        {
            CN_Academia _CN_Academia = new CN_Academia();
            dataGridView1.DataSource = _CN_Academia.MostrarAcademias();
        }
        public void Limpiar()
        {
            idAcademia.Text = "";
            nombre.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _CN_Academia.AgregarAcademia(nombre.Text);
            MostrarAcademias();
            Limpiar();
        }

        private void Academias_Load(object sender, EventArgs e)
        {
            MostrarAcademias();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _CN_Academia.EliminarAcademia(idAcademia.Text);
            MostrarAcademias();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _CN_Academia.EditarAcademia((idAcademia.Text), nombre.Text);
            Limpiar();
            MostrarAcademias();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            idAcademia.Text = dataGridView1.CurrentRow.Cells["idAcademia"].Value.ToString();
            nombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }
    }
}
