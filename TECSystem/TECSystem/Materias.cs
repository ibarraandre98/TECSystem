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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Materia _CN_Materia = new CN_Materia();
            _CN_Materia.AgregarMateria(Convert.ToInt32(txtMateria.Text),txtNombre.Text,Convert.ToInt32(txtTeoricas.Text),Convert.ToInt32(txtPracticas.Text),Convert.ToInt32(txtCreditos.Text),Convert.ToInt32(txtCarrera.Text));
            MostrarMaterias();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            MostrarMaterias();
        }
        private void MostrarMaterias()
        {
            CN_Materia _CN_Materias = new CN_Materia();
            dtgPersonas.DataSource = _CN_Materias.MostrarMaterias();
        }

        private void dtgPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMateria.Text = dtgPersonas.CurrentRow.Cells["cveMateria"].Value.ToString();
            txtNombre.Text = dtgPersonas.CurrentRow.Cells["nombre"].Value.ToString();
            txtTeoricas.Text = dtgPersonas.CurrentRow.Cells["hTeoricas"].Value.ToString();
            txtPracticas.Text = dtgPersonas.CurrentRow.Cells["hPracticas"].Value.ToString();
            txtCreditos.Text = dtgPersonas.CurrentRow.Cells["creditos"].Value.ToString();
            txtCarrera.Text = dtgPersonas.CurrentRow.Cells["carrera"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CN_Materia _CN_Materia = new CN_Materia();
            _CN_Materia.EditarMateria(Convert.ToInt32(txtMateria.Text),txtNombre.Text, Convert.ToInt32(txtTeoricas.Text), Convert.ToInt32(txtPracticas.Text), Convert.ToInt32(txtCreditos.Text), Convert.ToInt32(txtCarrera.Text));
            MostrarMaterias();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CN_Materia _CN_Materia = new CN_Materia();
            _CN_Materia.EliminarMateria(Convert.ToInt32(txtMateria.Text));
            MostrarMaterias();
        }
    }
}
