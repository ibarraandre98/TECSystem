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
    public partial class Estados : Form
    {

        CN_Estados estados = new CN_Estados();
        public Estados()
        {
            InitializeComponent();
            MostrarEstados();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DtgEstados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            estados.agregar_estado(Nombre.Text);
            limpiar();
            MostrarEstados();
        }

        void MostrarEstados()
        {
            CN_Estados estados = new CN_Estados();
            dtgEstados.DataSource = estados.mostrarEstados();
        }

        void limpiar()
        {
            idEstados.Clear();
            Nombre.Clear();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            estados.editar_alumno(Convert.ToInt32(idEstados.Text), Nombre.Text);
            limpiar();
            MostrarEstados();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            estados.eliminar_alumno(Convert.ToInt32(idEstados.Text));
            limpiar();
            MostrarEstados();
        }

        private void DtgEstados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idEstados.Text = dtgEstados.CurrentRow.Cells["idEstados"].Value.ToString();
            Nombre.Text = dtgEstados.CurrentRow.Cells["nombre"].Value.ToString();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            estados.agregar_estado(Nombre.Text);
            limpiar();
            MostrarEstados();
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            estados.editar_alumno(Convert.ToInt32(idEstados.Text), Nombre.Text);
            limpiar();
            MostrarEstados();
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            estados.eliminar_alumno(Convert.ToInt32(idEstados.Text));
            limpiar();
            MostrarEstados();
        }
    }
}
