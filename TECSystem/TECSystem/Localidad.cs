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
        }
        private void MostrarLocalidad()
        {
            CN_Localidades _CN_Localidades = new CN_Localidades();
            dtgPersonas.DataSource = _CN_Localidades.MostrarLocalidades();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Localidades _CN_Localidad = new CN_Localidades();
            _CN_Localidad.AgregarLocalidad(Convert.ToInt32(txtMunicipio.Text),txtNombre.Text, Convert.ToInt32(txtTipo.Text));
            MostrarLocalidad();
        }

        private void dtgPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMunicipio.Text = dtgPersonas.CurrentRow.Cells["Municipio"].Value.ToString();
            txtNombre.Text = dtgPersonas.CurrentRow.Cells["nombre"].Value.ToString();
            txtTipo.Text = dtgPersonas.CurrentRow.Cells["tipo"].Value.ToString();
            id= Convert.ToInt32(dtgPersonas.CurrentRow.Cells["idLocalidad"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CN_Localidades _CN_Localidades = new CN_Localidades();
            _CN_Localidades.EditarMunicipio(Convert.ToInt32(txtMunicipio.Text), txtNombre.Text, id,Convert.ToInt32(txtTipo.Text));
            MostrarLocalidad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CN_Localidades _CN_Localidades = new CN_Localidades();
            _CN_Localidades.Eliminar(id);
            MostrarLocalidad();
        }
    }
}
