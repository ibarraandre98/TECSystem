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
    public partial class Horarios : Form
    {
        CN_Horarios horarios = new CN_Horarios();
        public Horarios()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtGrupo.Text == "" || txtanula.Text == "" || txtDia.Text == "" || txthora.Text == "")
            {
                MessageBox.Show("No puede ingresar Horarios, aún faltan datos por completar", "Datos incompletos",
                          MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                horarios.agregar_horarios(txtGrupo.Text, Convert.ToInt32(txtDia.SelectedIndex.ToString()), Convert.ToInt32(txthora.SelectedIndex.ToString()), Convert.ToString(txtanula.SelectedIndex.ToString()));
                MostrarTabla();
                limpiar();
            }
            
        }

        private void MostrarTabla()
        {
            CN_Horarios grupos = new CN_Horarios();
            dtgHorarios.DataSource = grupos.mostrarHorarios();
        }

        void limpiar()
        {
            idHorarios.Clear();
            txtGrupo.Clear();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            horarios.editar_horarios(Convert.ToInt32(idHorarios.Text), txtGrupo.Text, Convert.ToInt32(txtDia.SelectedItem), Convert.ToInt32(txthora.SelectedItem), Convert.ToString(txtanula.SelectedItem));
            limpiar();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            horarios.eliminar_horarios(Convert.ToInt32(idHorarios.Text));
            limpiar();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();
        }

        CN_Horarios grupos = new CN_Horarios();
        private void Horarios_Load(object sender, EventArgs e)
        {
            dtgHorarios.DataSource = grupos.mostrarHorarios();
            MostrarGrupos();
        }

        private void DtgHorarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idHorarios.Text = dtgHorarios.CurrentRow.Cells["idHorario"].Value.ToString();
            txtGrupo.Text = dtgHorarios.CurrentRow.Cells["grupo"].Value.ToString();
            txtDia.Text = dtgHorarios.CurrentRow.Cells["dia"].Value.ToString();
            txthora.Text = dtgHorarios.CurrentRow.Cells["hora"].Value.ToString();
            txtanula.Text = dtgHorarios.CurrentRow.Cells["aula"].Value.ToString();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void MostrarGrupos()
        {
            CN_Grupos _CN_Grupos = new CN_Grupos();
            dgvGrupos.DataSource = _CN_Grupos.mostrarGrupos();
        }

        private void DgvGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGrupo.Text = dgvGrupos.CurrentRow.Cells["cveGrupo"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            r.setReporte(5);
            r.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            r.setReporte(6);
            r.ShowDialog();
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            horarios.agregar_horarios(Grupo.Text, Convert.ToInt32(comboBox1.SelectedIndex.ToString()), Convert.ToInt32(comboBox2.SelectedIndex.ToString()), Convert.ToString(comboBox3.SelectedIndex.ToString()));
            MostrarTabla();
            limpiar();
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            horarios.editar_horarios(Convert.ToInt32(idHorarios.Text), Grupo.Text, Convert.ToInt32(comboBox1.SelectedItem), Convert.ToInt32(comboBox2.SelectedItem), Convert.ToString(comboBox3.SelectedItem));
            limpiar();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            horarios.eliminar_horarios(Convert.ToInt32(idHorarios.Text));
            limpiar();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();
        }
    }
}
