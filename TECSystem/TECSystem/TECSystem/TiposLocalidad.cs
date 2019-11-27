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
    public partial class TiposLocalidad : Form
    {
        CN_TiposLocalidad _CN_TiposLocalidad = new CN_TiposLocalidad();
        public TiposLocalidad()
        {
            InitializeComponent();
        }

        private void TiposLocalidad_Load(object sender, EventArgs e)
        {
            MostrarTiposLocalidades();
        }

        private void MostrarTiposLocalidades()
        {
            CN_TiposLocalidad _CN_TiposLocalidad = new CN_TiposLocalidad();
            dtgtiposLoca.DataSource = _CN_TiposLocalidad.MostrarTiposLocalidad();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIdTipoLocalidad.TextLength <= 0 || txtTipo.TextLength <= 0)
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
            else { 
            _CN_TiposLocalidad.AgregarTiposLocalidad(txtTipo.Text);
            MostrarTiposLocalidades();
            Limpiartxt();
        }
        }

        private void Limpiartxt()
        {
            txtIdTipoLocalidad.Clear();
            txtTipo.Clear();
        }

        private void DtgtiposLoca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdTipoLocalidad.Text = dtgtiposLoca.CurrentRow.Cells["idTipoLoc"].Value.ToString();
            txtTipo.Text = dtgtiposLoca.CurrentRow.Cells["tipo"].Value.ToString();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (txtIdTipoLocalidad.TextLength <= 0 || txtTipo.TextLength <= 0)
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
            else { 
            _CN_TiposLocalidad.EditarTiposLocalidad(txtIdTipoLocalidad.Text, txtTipo.Text);
            MostrarTiposLocalidades();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdTipoLocalidad.TextLength <= 0 || txtTipo.TextLength <= 0)
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
            else
            {
                _CN_TiposLocalidad.EliminarTiposLocalidad(txtIdTipoLocalidad.Text);
                MostrarTiposLocalidades();
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        
    }
}
