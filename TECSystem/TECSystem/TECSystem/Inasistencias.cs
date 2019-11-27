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
        String IDGrupo;
        String Matricula;
        public Inasistencias()
        {
            InitializeComponent();
            MostrarInasistencias();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            inasistencias.agregar_inasistencias(IDGrupo, Matricula, dtpFecha.Value, Convert.ToInt32(tipoInasistencia.Text));

            limpiar();
            MostrarInasistencias();
        }

        

        void limpiar()
        {
            idInasistencia.Clear();
            Grupo.Clear();
            txtMatricula.Clear();
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
            MostrarGrupos();
            MostrarAlumnos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            inasistencias.editar_inasistencias(Convert.ToInt32(idInasistencia.Text),Grupo.Text, Matricula,dtpFecha.Value,Convert.ToInt32(tipoInasistencia.Text));
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
            txtMatricula.Text = dtgInasistencias.CurrentRow.Cells["matricula"].Value.ToString();
            tipoInasistencia.Text = dtgInasistencias.CurrentRow.Cells["tipoInasistencia"].Value.ToString();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void MostrarGrupos()
        {
            CN_Grupos _CN_Grupos = new CN_Grupos();
            dgvGrupo.DataSource = _CN_Grupos.mostrarGrupos();
        }

        private void MostrarAlumnos()
        {
            CN_Alumnos _CN_Alumnos = new CN_Alumnos();
            dgvAlumnos.DataSource = _CN_Alumnos.MostrarAlumnos();
        }

        private void DgvGrupo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDGrupo = dgvGrupo.CurrentRow.Cells["cveGrupo"].Value.ToString();
            Grupo.Text = dgvGrupo.CurrentRow.Cells["nombre"].Value.ToString();
        }

        private void DgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Matricula = dgvAlumnos.CurrentRow.Cells["matricula"].Value.ToString();
            txtMatricula.Text = Matricula;
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            inasistencias.agregar_inasistencias(IDGrupo, Matricula, dtpFecha.Value, Convert.ToInt32(tipoInasistencia.Text));

            limpiar();
            MostrarInasistencias();
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            inasistencias.editar_inasistencias(Convert.ToInt32(idInasistencia.Text), Grupo.Text, Matricula, dtpFecha.Value, Convert.ToInt32(tipoInasistencia.Text));
            MostrarInasistencias();
            limpiar();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            inasistencias.eliminar_inasistencias(Convert.ToInt32(idInasistencia.Text));
            idInasistencia.Clear();
            MostrarInasistencias();
        }
    }
}
