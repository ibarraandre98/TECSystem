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
            horarios.agregar_horarios(Convert.ToInt32(idHorarios),Grupo.Text,Convert.ToInt32(comboBox1.SelectedItem),Convert.ToInt32(comboBox2.SelectedItem),Convert.ToString(comboBox3.SelectedItem));
            MostrarTabla();
            limpiar();
        }

        private void MostrarTabla()
        {
            CN_Horarios grupos = new CN_Horarios();
            dtgHorarios.DataSource = grupos.mostrarHorarios();
        }

        void limpiar()
        {
            idHorarios.Clear();
            Grupo.Clear();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            horarios.editar_horarios(Convert.ToInt32(idHorarios.Text), Grupo.Text, Convert.ToInt32(comboBox1.SelectedItem), Convert.ToInt32(comboBox2.SelectedItem), Convert.ToString(comboBox3.SelectedItem));
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
        }

        private void DtgHorarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idHorarios.Text = dtgHorarios.CurrentRow.Cells["idHorario"].Value.ToString();
            Grupo.Text = dtgHorarios.CurrentRow.Cells["grupo"].Value.ToString();
            comboBox1.Text = dtgHorarios.CurrentRow.Cells["dia"].Value.ToString();
            comboBox2.Text = dtgHorarios.CurrentRow.Cells["hora"].Value.ToString();
            comboBox3.Text = dtgHorarios.CurrentRow.Cells["aula"].Value.ToString();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }
    }
}
