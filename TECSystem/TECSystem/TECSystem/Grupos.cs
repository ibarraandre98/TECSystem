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
        String idMateria, idProfesor;

        public Grupos()
        {
            InitializeComponent();
            dtgGrupos.DataSource = grupos.mostrarGrupos();
        }

        void limpiar()
        {
            txtcveGrupo.Clear();
            txtProfesor.Clear();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtMateria.Text==""||txtProfesor.Text==""||txtcveGrupo.Text=="")
            {
                MessageBox.Show("No puede ingresar Grupo, aún faltan datos por completar", "Datos incompletos",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                grupos.agregar_grupo(txtcveGrupo.Text, idMateria.ToString(), idProfesor.ToString());
                limpiar();
                MostrarTabla();
            }
           
        }

        private void MostrarTabla()
        {
            CN_Grupos grupos = new CN_Grupos();
            dtgGrupos.DataSource = grupos.mostrarGrupos();
        }

        private void MostrarMateria()
        {
            CN_Materia _CN_Materia = new CN_Materia();
            dgvMaterias.DataSource = _CN_Materia.MostrarMaterias();
        }

        private void MostrarProfesores()
        {
            CN_Profesores _CN_Profesores = new CN_Profesores();
            dgvProfesores.DataSource = _CN_Profesores.MostrarProfesores();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (txtMateria.Text == "" || txtProfesor.Text == "" || txtcveGrupo.Text == "")
            {
                MessageBox.Show("No puede editar Grupo, aún faltan datos por completar", "Datos incompletos",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                grupos.editar_grupo(txtcveGrupo.Text, idMateria.ToString(), idProfesor.ToString());
                limpiar();
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
                btnAgregar.Enabled = true;
                MostrarTabla();
            }
         
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            grupos.eliminar_grupo(txtcveGrupo.Text);
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
            txtcveGrupo.Text = dtgGrupos.CurrentRow.Cells["cveGrupo"].Value.ToString();
            
            txtProfesor.Text = dtgGrupos.CurrentRow.Cells["profesor"].Value.ToString();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            dtgGrupos.DataSource = grupos.mostrarGrupos();
            MostrarMateria();
            MostrarProfesores();
        }

        private void DgvMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMateria.Text = dgvMaterias.CurrentRow.Cells["nombre"].Value.ToString();
            idMateria = dgvMaterias.CurrentRow.Cells["cveMateria"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            r.setReporte(7);
            r.ShowDialog();
        }

        private void DgvProfesores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProfesor.Text = dgvProfesores.CurrentRow.Cells["nombres"].Value.ToString() +" "+
                dgvProfesores.CurrentRow.Cells["paterno"].Value.ToString() + " "+
                dgvProfesores.CurrentRow.Cells["materno"].Value.ToString();
            idProfesor = dgvProfesores.CurrentRow.Cells["idProfesor"].Value.ToString();
        }
    }
}
