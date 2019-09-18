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
        CN_Academia obj = new CN_Academia();
        public Academias()
        {
            InitializeComponent();
        }
        private void mostraracademias()
        {
            CN_Academia obj = new CN_Academia();
            dataGridView1.DataSource = obj.mostrarAcademias();
        }
        public void limpiar()
        {
            idAcademia.Text = "";
            nombre.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            obj.agregar_academia(nombre.Text);
            mostraracademias();
            limpiar();
        }

        private void Academias_Load(object sender, EventArgs e)
        {
            mostraracademias();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            obj.eliminar_academia(Convert.ToInt32(idAcademia.Text));
            mostraracademias();
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            obj.editar_academia(Convert.ToInt32(idAcademia.Text), nombre.Text);
            limpiar();
            mostraracademias();
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
