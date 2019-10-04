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
        }
        private void MostrarMunicipio()
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            dtgPersonas.DataSource = _CN_Municipio.MostrarMunicipios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            _CN_Municipio.AgregarMunicipio(Convert.ToInt32(txtEstado.Text), Convert.ToInt32(txtNumero.Text), txtNombre.Text);
            MostrarMunicipio();
        }

        private void dtgPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumero.Text = dtgPersonas.CurrentRow.Cells["numero"].Value.ToString();
            txtNombre.Text = dtgPersonas.CurrentRow.Cells["nombre"].Value.ToString();
            txtEstado.Text = dtgPersonas.CurrentRow.Cells["Estado"].Value.ToString();
            id = Convert.ToInt32(dtgPersonas.CurrentRow.Cells["idMunicipio"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            _CN_Municipio.EditarMunicipio(txtNombre.Text, id, Convert.ToInt32(txtNumero.Text), Convert.ToInt32(txtEstado.Text));
            MostrarMunicipio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            _CN_Municipio.eliminarMunicipio(id);
            MostrarMunicipio();
        }
    }
}
