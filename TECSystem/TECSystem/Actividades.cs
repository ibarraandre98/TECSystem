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
    public partial class Actividades : Form
    {
        CN_Actividades obj = new CN_Actividades();
        public Actividades()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            nombre.Text = "";
            descripcion.Text = "";
            grupo.Text = "";
            tema.Text = "";
            ponderacion.Text = "";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            obj.agregar_actividad(nombre.Text, descripcion.Text, grupo.Text, Convert.ToInt32(tema.Text), Convert.ToInt32(ponderacion.Text), fecha.Value);
            mostrar_actividad();
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            obj.editar_actividad(Convert.ToInt32(idActividad.Text), nombre.Text, descripcion.Text, grupo.Text, Convert.ToInt32(tema.Text), Convert.ToInt32(ponderacion.Text), fecha.Value);
            mostrar_actividad();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            obj.eliminar_actividad(Convert.ToInt32(idActividad.Text));
            mostrar_actividad();
            limpiar();
        }
        private void mostrar_actividad()
        {
            CN_Actividades obj = new CN_Actividades();
            dataGridView1.DataSource = obj.mostrarActividades();
        }

        private void Actividades_Load(object sender, EventArgs e)
        {
            mostrar_actividad();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            idActividad.Text = dataGridView1.CurrentRow.Cells["idActividad"].Value.ToString();
            nombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            descripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
            grupo.Text = dataGridView1.CurrentRow.Cells["grupo"].Value.ToString();
            tema.Text = dataGridView1.CurrentRow.Cells["tema"].Value.ToString();
            ponderacion.Text = dataGridView1.CurrentRow.Cells["ponderacion"].Value.ToString();
            fecha.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha"].Value.ToString());
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }
    }
}

