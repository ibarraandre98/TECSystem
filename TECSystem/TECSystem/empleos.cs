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
    public partial class Empleos : Form
    {
        CN_Empleos _CN_Empleos = new CN_Empleos();
        String IDEmpleo;
        public Empleos()
        {
            InitializeComponent();
        }

        private void MostrarEmpleos()
        {
            CN_Empleos _CN_Empleos = new CN_Empleos();
            dtgEmpleos.DataSource = _CN_Empleos.Mostrarempleos();
        }

        private void Empleos_Load(object sender, EventArgs e)
        {
            MostrarEmpleos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _CN_Empleos.Agregarempleos(txtEmpleo.Text);
            limpiarCampos();
            MostrarEmpleos();
        }

        private void limpiarCampos()
        {
            txtEmpleo.Clear();
            IDEmpleo = null;
        }

        private void DtgEmpleos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDEmpleo = dtgEmpleos.CurrentRow.Cells["idEmpleo"].Value.ToString();
            txtEmpleo.Text = dtgEmpleos.CurrentRow.Cells["puesto"].Value.ToString();
            inhabilitarAgregar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _CN_Empleos.Editarempleos(IDEmpleo, txtEmpleo.Text);
            limpiarCampos();
            habilitarAgregar();
            MostrarEmpleos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarAgregar();
        }

        private void inhabilitarAgregar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void habilitarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _CN_Empleos.Eliminarempleos(IDEmpleo);
            limpiarCampos();
            habilitarAgregar();
            MostrarEmpleos();
        }
    }
}
