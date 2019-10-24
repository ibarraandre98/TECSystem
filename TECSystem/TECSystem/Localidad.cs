using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECSystem
{
    public partial class Localidad : Form
    {
        int id;
        public Localidad()
        {
            InitializeComponent();
        }

        private void Localidad_Load(object sender, EventArgs e)
        {
            MostrarLocalidad();
            MostrarEstados();
            MostrarMunicipio();
        }
        private void MostrarLocalidad()
        {
            CN_Localidades _CN_Localidades = new CN_Localidades();
            dtgPersonas.DataSource = _CN_Localidades.MostrarLocalidades();
        }

        private void MostrarEstados()
        {
            CN_Estados _CN_Estados = new CN_Estados();
            cbEstado.DataSource = _CN_Estados.mostrarEstados();
            cbEstado.ValueMember = "idEstado";
            cbEstado.DisplayMember = "nombre";
        }

        private void MostrarMunicipio()
        {
            CN_Municipio _CN_Municipios = new CN_Municipio();
            cbMunicipio.DataSource = _CN_Municipios.MostrarMunicipiosEstado(cbEstado.SelectedValue.ToString());
            cbMunicipio.ValueMember = "idMunicipio";
            cbMunicipio.DisplayMember = "nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Localidades _CN_Localidad = new CN_Localidades();
            _CN_Localidad.AgregarLocalidad(Convert.ToInt32(cbMunicipio.Text),txtNombre.Text, Convert.ToInt32(cbTipo.Text));
            MostrarLocalidad();
        }

        private void dtgPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMunicipio.Text = dtgPersonas.CurrentRow.Cells["Municipio"].Value.ToString();
            txtNombre.Text = dtgPersonas.CurrentRow.Cells["nombre"].Value.ToString();
            cbTipo.Text = dtgPersonas.CurrentRow.Cells["tipo"].Value.ToString();
            id = Convert.ToInt32(dtgPersonas.CurrentRow.Cells["idLocalidad"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CN_Localidades _CN_Localidades = new CN_Localidades();
            _CN_Localidades.EditarMunicipio(Convert.ToInt32(cbMunicipio.Text), txtNombre.Text, id,Convert.ToInt32(cbTipo.Text));
            MostrarLocalidad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CN_Localidades _CN_Localidades = new CN_Localidades();
            _CN_Localidades.Eliminar(id);
            MostrarLocalidad();
        }

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MostrarMunicipio();
        }

        private void cbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(cbTipo.SelectedIndex + 1));
        }
    }
}
