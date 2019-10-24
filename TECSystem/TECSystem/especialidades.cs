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
    public partial class especialidades : Form
    {
        CN_especialidades _CN_especialidades = new CN_especialidades();
        public especialidades()
        {
            InitializeComponent();
        }

        private void especialidades_Load(object sender, EventArgs e)
        {
            MostrarEspecialidades();
        }
        private void MostrarEspecialidades()
        {
            CN_especialidades _CN_especialidades = new CN_especialidades();
            dtgespecialidades.DataSource = _CN_especialidades.Mostrarespecialidades();
        }
        public void limpiar()
        {
            Carrera.Clear();
            nombre.Clear();
            idEspecialidad.Clear();
        }

        private void dtgespecialidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idEspecialidad.Text = dtgespecialidades.CurrentRow.Cells["idEspecialidad"].Value.ToString();
            nombre.Text = dtgespecialidades.CurrentRow.Cells["nombre"].Value.ToString();
            Carrera.Text = dtgespecialidades.CurrentRow.Cells["carrera"].Value.ToString();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _CN_especialidades.Agregarespecialidades(nombre.Text, Carrera.Text);
            MostrarEspecialidades();
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _CN_especialidades.Editarespecialidades(idEspecialidad.Text, nombre.Text, Carrera.Text);
            limpiar();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _CN_especialidades.Eliminarespecialidades(idEspecialidad.Text);
            limpiar();
            MostrarEspecialidades();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }
    }
}
