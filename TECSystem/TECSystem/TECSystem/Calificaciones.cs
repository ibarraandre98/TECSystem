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
        String IDGrupo;
        String Matricula;
        public Calificaciones()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            grupo.Text = "";
            matriculaa.Text = "";
            tema.Text = "";
            calificacion.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            obj.AgregarCalificacion(grupo.Text, matriculaa.Text, tema.Text,calificacion.Text, cbEvaluacion.Text);
            MostrarCalificaciones();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            obj.EliminarCalificacion(idCalificacion.Text);
            MostrarCalificaciones();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            obj.EditarCalificacion((idCalificacion.Text),grupo.Text, matriculaa.Text, (tema.Text), (calificacion.Text), cbEvaluacion.Text);
            MostrarCalificaciones();
            Limpiar();
        }
        private void MostrarCalificaciones()
        {
            CN_Calificaciones obj = new CN_Calificaciones();
            dataGridView1.DataSource = obj.MostrarCalificaciones();
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {
            cbEvaluacion.SelectedIndex = 0;
            MostrarCalificaciones();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            MostrarGrupos();
            MostrarAlumnos();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            idCalificacion.Text = dataGridView1.CurrentRow.Cells["idCalifiacion"].Value.ToString();
            matriculaa.Text = dataGridView1.CurrentRow.Cells["matricula"].Value.ToString();
            tema.Text = dataGridView1.CurrentRow.Cells["tema"].Value.ToString();
            calificacion.Text = dataGridView1.CurrentRow.Cells["calificacion"].Value.ToString();
            grupo.Text = dataGridView1.CurrentRow.Cells["grupo"].Value.ToString();
            cbEvaluacion.Text = dataGridView1.CurrentRow.Cells["tipoEval"].Value.ToString();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void MostrarGrupos()
        {
            CN_Grupos _CN_Grupos = new CN_Grupos();
            dgvGrupos.DataSource = _CN_Grupos.mostrarGrupos();
        }

        private void dgvGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDGrupo = dgvGrupos.CurrentRow.Cells["cveGrupo"].Value.ToString();
            grupo.Text = IDGrupo;
        }

        private void MostrarAlumnos()
        {
            CN_Alumnos _CN_Alumnos = new CN_Alumnos();
            dgvAlumnos.DataSource = _CN_Alumnos.MostrarAlumnos();
        }

        private void dgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Matricula = dgvAlumnos.CurrentRow.Cells["matricula"].Value.ToString();
            matriculaa.Text = Matricula;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(grupo.Text == "" || matriculaa.Text == ""|| tema.Text == "" || calificacion.Text == "")
                {
                    MessageBox.Show("No puede ingresar calificación, aún faltan datos por completar", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    obj.AgregarCalificacion(grupo.Text, matriculaa.Text, tema.Text, calificacion.Text, cbEvaluacion.Text);
                    MostrarCalificaciones();
                    Limpiar();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEditar3_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupo.Text == "" || matriculaa.Text == "" || tema.Text == "" || calificacion.Text == "")
                {
                    MessageBox.Show("No puede ingresar calificación, aún faltan datos por completar", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    obj.EditarCalificacion((idCalificacion.Text), grupo.Text, matriculaa.Text, (tema.Text), (calificacion.Text), cbEvaluacion.Text);
                    MostrarCalificaciones();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            obj.EliminarCalificacion(idCalificacion.Text);
            MostrarCalificaciones();
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            r.setReporte(3);
            r.ShowDialog();
        }

        private void tipoevaluacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
