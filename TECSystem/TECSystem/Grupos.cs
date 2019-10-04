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
    public partial class Grupos : Form
    {
        CN_Grupos grupos = new CN_Grupos();


        public Grupos()
        {
            InitializeComponent();
            dtgGrupos.DataSource = grupos.mostrarGrupos();
        }

        void limpiar()
        {
            cveGrupo.Clear();
            Profesor.Clear();
            Materia.Clear();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            grupos.agregar_grupo(cveGrupo.Text,Materia.Text,Profesor.Text);
            limpiar();
            MostrarTabla();
        }

        private void MostrarTabla()
        {
            CN_Grupos grupos = new CN_Grupos();
            dtgGrupos.DataSource = grupos.mostrarGrupos();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            grupos.editar_grupo(Materia.Text, Profesor.Text, cveGrupo.Text);
            limpiar();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            grupos.eliminar_grupo(cveGrupo.Text);
            limpiar();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();
        }

        private void DtgGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtgGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cveGrupo.Text = dtgGrupos.CurrentRow.Cells["cveGrupo"].Value.ToString();
            Materia.Text = dtgGrupos.CurrentRow.Cells["materia"].Value.ToString();
            Profesor.Text = dtgGrupos.CurrentRow.Cells["profesor"].Value.ToString();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            dtgGrupos.DataSource = grupos.mostrarGrupos();
        }
    }
}
