using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECSystem
{
    public partial class Municipio : Form
    {
        int id;
        public Municipio()
        {
            InitializeComponent();
        }

        private void Municipio_Load(object sender, EventArgs e)
        {
            MostrarMunicipio();
            MostrarEstados();
        }
        private void MostrarMunicipio()
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            dtgPersonas.DataSource = _CN_Municipio.MostrarMunicipios();
        }
        private void MostrarEstados()
        {
            CN_Estados _CN_Estados = new CN_Estados();
            cbEstado.DataSource = _CN_Estados.mostrarEstados();
            cbEstado.ValueMember = "idEstado";
            cbEstado.DisplayMember = "nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            _CN_Municipio.AgregarMunicipio(Convert.ToInt32(txtNumero.Text), Convert.ToInt32(cbEstado.SelectedValue.ToString()), txtNombre.Text);
            MostrarMunicipio();
        }

        private void dtgPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumero.Text = dtgPersonas.CurrentRow.Cells["NumeroMunicipio"].Value.ToString();
            txtNombre.Text = dtgPersonas.CurrentRow.Cells["Municipio"].Value.ToString();
            cbEstado.SelectedValue = dtgPersonas.CurrentRow.Cells["idEstado"].Value.ToString();
            id = Convert.ToInt32(dtgPersonas.CurrentRow.Cells["idMunicipio"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            _CN_Municipio.EditarMunicipio(txtNombre.Text, id, Convert.ToInt32(txtNumero.Text), Convert.ToInt32(cbEstado.SelectedValue.ToString()));
            MostrarMunicipio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            _CN_Municipio.eliminarMunicipio(id);
            MostrarMunicipio();
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show(cbEstado.SelectedValue.ToString());
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            _CN_Municipio.AgregarMunicipio(Convert.ToInt32(txtNumero.Text), Convert.ToInt32(cbEstado.SelectedValue.ToString()), txtNombre.Text);
            MostrarMunicipio();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            _CN_Municipio.EditarMunicipio(txtNombre.Text, id, Convert.ToInt32(txtNumero.Text), Convert.ToInt32(cbEstado.SelectedValue.ToString()));
            MostrarMunicipio();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            _CN_Municipio.eliminarMunicipio(id);
            MostrarMunicipio();
        }
    }
}
