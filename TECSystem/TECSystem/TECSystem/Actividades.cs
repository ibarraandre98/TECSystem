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
        String IDActividad;
        int IDGrupo;
        CN_Actividades _CN_Actividades = new CN_Actividades();
        public Actividades()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            nombre.Text = "";
            descripcion.Text = "";
            grupo.Text = "";
            tema.Text = "";
            ponderacion.Text = "";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _CN_Actividades.AgregarActividad(nombre.Text, descripcion.Text, grupo.Text, tema.Text,ponderacion.Text, fecha.Value);
            MostrarActividad();
            MostrarGrupos();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _CN_Actividades.EditarActividad(IDActividad, nombre.Text, descripcion.Text, grupo.Text,tema.Text,ponderacion.Text, fecha.Value);
            MostrarActividad();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _CN_Actividades.EliminarActividad(IDActividad);
            MostrarActividad();
            Limpiar();
        }
        private void MostrarActividad()
        {
            CN_Actividades obj = new CN_Actividades();
            dataGridView1.DataSource = obj.MostrarActividades();
        }

        private void Actividades_Load(object sender, EventArgs e)
        {
            MostrarActividad();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            MostrarGrupos();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            IDActividad = dataGridView1.CurrentRow.Cells["idActividad"].Value.ToString();
            nombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            descripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
            tema.Text = dataGridView1.CurrentRow.Cells["tema"].Value.ToString();
            ponderacion.Text = dataGridView1.CurrentRow.Cells["ponderacion"].Value.ToString();
            fecha.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha"].Value.ToString());
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void MostrarGrupos()
        {
            CN_Grupos _CN_Grupos = new CN_Grupos();
            dgvGrupos.DataSource = _CN_Grupos.mostrarGrupos();
        }

        private void DgvGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grupo.Text = dgvGrupos.CurrentRow.Cells["cveGrupo"].Value.ToString();
        }
    }
}

