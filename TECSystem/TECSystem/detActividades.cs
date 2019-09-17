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
    public partial class detActividades : Form
    {
        CN_detActividades _CN_detActividades = new CN_detActividades();

        public detActividades()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _CN_detActividades.AgregarACtividad(txtActividad.Text, txtMatricula.Text, txtCalificacion.Text, txtFechaEntrega.Value);
            MostrarTabla();
            Limpiartxt();
        }

        private void MostrarTabla()
        {
            CN_detActividades _CN_detActividades = new CN_detActividades();
            dtgdetActividades.DataSource = _CN_detActividades.MostrarTabla();
        }

        private void Limpiartxt()
        {
            txtActividad.Clear();
            txtCalificacion.Clear();
            txtIddetAct.Clear();
            txtMatricula.Clear();
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _CN_detActividades.EditarActividad(txtIddetAct.Text, txtActividad.Text, txtMatricula.Text,txtCalificacion.Text, txtFechaEntrega.Value);
            MostrarTabla();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _CN_detActividades.EliminarActividad(txtIddetAct.Text);
            MostrarTabla();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void DetActividades_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }

        private void DtgdetActividades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIddetAct.Text = dtgdetActividades.CurrentRow.Cells["idDetAct"].Value.ToString();
            txtActividad.Text = dtgdetActividades.CurrentRow.Cells["actividad"].Value.ToString();
            txtMatricula.Text = dtgdetActividades.CurrentRow.Cells["matricula"].Value.ToString();
            txtCalificacion.Text = dtgdetActividades.CurrentRow.Cells["calificacion"].Value.ToString();
            txtFechaEntrega.Text = dtgdetActividades.CurrentRow.Cells["fechaEntrega"].Value.ToString();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }
    }
}
