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
    public partial class Especialidades : Form
    {
        CN_Especialidades _CN_Especialidades = new CN_Especialidades();
        public Especialidades()
        {
            InitializeComponent();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            MostrarEspecialidades();
            MostrarCarreras();
        }

        private void MostrarCarreras()
        {
            CN_Carreras _CN_Carreras = new CN_Carreras();
            dtgCarreras.DataSource = _CN_Carreras.MostrarCarreras();
        }

        private void MostrarEspecialidades()
        {
            CN_Especialidades _CN_Especialidades = new CN_Especialidades();
            dtgEspecialidades.DataSource = _CN_Especialidades.Mostrarespecialidades();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _CN_Especialidades.Agregarespecialidades(txtNombre.Text, txtCarrera.Text);
            MostrarEspecialidades();
        }

        private void DtgCarreras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCarrera.Text = dtgCarreras.CurrentRow.Cells["idCarrera"].Value.ToString();
        }
    }
}
