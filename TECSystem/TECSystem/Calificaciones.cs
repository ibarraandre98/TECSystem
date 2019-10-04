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
    public partial class Calificaciones : Form
    {
        CN_Calificaciones obj = new CN_Calificaciones();
        public Calificaciones()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            grupo.Text = "";
            matricula.Text = "";
            tema.Text = "";
            calificacion.Text = "";
            tipoevaluacion.Text = "";


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            obj.agregar_calificacion(grupo.Text, matricula.Text, Convert.ToInt32(tema.Text), Convert.ToDouble(calificacion.Text), tipoevaluacion.Text);
            mostrarCalificaciones();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            obj.eliminar_calificacion(Convert.ToInt32(idCalificacion.Text));
            mostrarCalificaciones();
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            obj.editar_calificacion(Convert.ToInt32(idCalificacion.Text),grupo.Text, matricula.Text, Convert.ToInt32(tema.Text), Convert.ToDouble(calificacion.Text), tipoevaluacion.Text);
            mostrarCalificaciones();
            limpiar();
        }
        private void mostrarCalificaciones()
        {
            CN_Calificaciones obj = new CN_Calificaciones();
            dataGridView1.DataSource = obj.mostrarCalificaciones();
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {
            mostrarCalificaciones();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            idCalificacion.Text = dataGridView1.CurrentRow.Cells["idCalifiacion"].Value.ToString();
            grupo.Text = dataGridView1.CurrentRow.Cells["grupo"].Value.ToString();
            matricula.Text = dataGridView1.CurrentRow.Cells["matricula"].Value.ToString();
            tema.Text = dataGridView1.CurrentRow.Cells["tema"].Value.ToString();
            calificacion.Text = dataGridView1.CurrentRow.Cells["calificacion"].Value.ToString();
            tipoevaluacion.Text = dataGridView1.CurrentRow.Cells["tipoEval"].Value.ToString();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }
    }
}
