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
    public partial class Inasistencias : Form
    {
        CN_Inasistencias inasistencias = new CN_Inasistencias();
        public Inasistencias()
        {
            InitializeComponent();
            MostrarInasistencias();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            inasistencias.agregar_inasistencias(Grupo.Text, Matricula.Text, Fecha.Text, Convert.ToInt32(tipoInasistencia.Text));

            limpiar();
            MostrarInasistencias();
        }

        

        void limpiar()
        {
            idInasistencia.Clear();
            Grupo.Clear();
            Matricula.Clear();
            Fecha.Clear();
            tipoInasistencia.Clear();
        }

        private void MostrarInasistencias()
        {
            CN_Inasistencias inasistencias = new CN_Inasistencias();
            dtgInasistencias.DataSource = inasistencias.mostrarInasistencias();
        }

        private void Inasistencias_Load(object sender, EventArgs e)
        {
            MostrarInasistencias();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            inasistencias.editar_inasistencias(Convert.ToInt32(idInasistencia.Text),Grupo.Text,Matricula.Text,Fecha.Text,Convert.ToInt32(tipoInasistencia.Text));
            MostrarInasistencias();
            limpiar();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            inasistencias.eliminar_inasistencias(Convert.ToInt32(idInasistencia.Text));
            idInasistencia.Clear();
            MostrarInasistencias();
        }

        private void DtgInasistencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idInasistencia.Text = dtgInasistencias.CurrentRow.Cells["idInasistencia"].Value.ToString();
            Grupo.Text = dtgInasistencias.CurrentRow.Cells["grupo"].Value.ToString();
            Matricula.Text = dtgInasistencias.CurrentRow.Cells["matricula"].Value.ToString();
            Fecha.Text = dtgInasistencias.CurrentRow.Cells["fecha"].Value.ToString();
            tipoInasistencia.Text = dtgInasistencias.CurrentRow.Cells["tipoInasistencia"].Value.ToString();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }
    }
}
