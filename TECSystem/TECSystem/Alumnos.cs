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
    public partial class Alumnos : Form
    {
        CN_Alumnos obj = new CN_Alumnos();
        public Alumnos()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            matricula.Text = "";
            idPersona.Text = "";
            idCarrera.Text = "";
            tutor.Text = "";
            idEspecialidad.Text = "";
            estatus.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            obj.agregar_alumno(matricula.Text, Convert.ToInt32(idPersona.Text), Convert.ToInt32(idCarrera.Text), tutor.Text, Convert.ToInt32(idEspecialidad.Text), Convert.ToInt32(estatus.Text));
            mostrar_alumnos();
            limpiar();
        }

        private void mostrar_alumnos()
        {
            CN_Alumnos obj = new CN_Alumnos();
            dataGridView1.DataSource = obj.mostrarAlumnos();
        }
        private void Alumnos_Load(object sender, EventArgs e)
        {
            mostrar_alumnos();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            obj.eliminar_alumno(matricula.Text);
            mostrar_alumnos();
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            obj.editar_alumno(matricula.Text, Convert.ToInt32(idPersona.Text), Convert.ToInt32(idCarrera.Text), tutor.Text, Convert.ToInt32(idEspecialidad.Text), Convert.ToInt32(estatus.Text));
            mostrar_alumnos();
            limpiar();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            matricula.Text = dataGridView1.CurrentRow.Cells["matricula"].Value.ToString();
            idPersona.Text = dataGridView1.CurrentRow.Cells["idPersona"].Value.ToString();
            idCarrera.Text = dataGridView1.CurrentRow.Cells["idCarrera"].Value.ToString();
            tutor.Text = dataGridView1.CurrentRow.Cells["tutor"].Value.ToString();
            idEspecialidad.Text = dataGridView1.CurrentRow.Cells["idEspecialidad"].Value.ToString();
            estatus.Text = dataGridView1.CurrentRow.Cells["estatus"].Value.ToString();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;

        }
    }
}
