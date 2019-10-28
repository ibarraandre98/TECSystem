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
        CN_Alumnos _CN_Alumnos = new CN_Alumnos();
        DataTable MostrarLocalidadesMunicipio;
        DataRow row;
        int IDPersona;
        String IDProfesor;
        public Alumnos()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtMatricula.Text = "";
            tutor.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Personas _CN_Personas = new CN_Personas();
            _CN_Personas.AgregarPersonas(txtPaterno.Text, txtMaterno.Text, txtNombre.Text, dtpFechaNac.Value,
                cbSexo.SelectedIndex.ToString(), txtCurp.Text, txtTelefono.Text, txtExt.Text, txtInt.Text, txtCP.Text,
                cbEdoCivil.SelectedIndex.ToString(), cbDiscapacidad.SelectedIndex.ToString(), txtCalle.Text,
                cbLocalidad.SelectedValue.ToString());
            IDPersona = _CN_Personas.ultimoID();
            _CN_Alumnos.agregar_alumno(txtMatricula.Text, IDPersona, Convert.ToInt32(cbCarrera.SelectedValue.ToString()), IDProfesor, Convert.ToInt32(cbEspecialidad.SelectedValue.ToString()), Convert.ToInt32(cbEstatus.SelectedIndex));
            mostrar_alumnos();
            limpiar();
        }

        private void mostrar_alumnos()
        {
            CN_Alumnos obj = new CN_Alumnos();
            dgvAlumnos.DataSource = obj.mostrarAlumnos();
        }
        private void Alumnos_Load(object sender, EventArgs e)
        {
            mostrar_alumnos();
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            MostrarEstados();
            MostrarMunicipio(cbEstado.SelectedValue.ToString());
            MostrarTiposLocalidades();
            primerValorCB();
            MostrarCarreras();
            MostrarProfesores();
            MostrarEspecialidades();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _CN_Alumnos.eliminar_alumno(txtMatricula.Text);
            mostrar_alumnos();
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _CN_Alumnos.editar_alumno(txtMatricula.Text, IDPersona, Convert.ToInt32(cbCarrera.SelectedValue.ToString()), tutor.Text, Convert.ToInt32(cbEspecialidad.SelectedValue.ToString()), Convert.ToInt32(cbEstatus.SelectedIndex));
            mostrar_alumnos();
            limpiar();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtMatricula.Text = dgvAlumnos.CurrentRow.Cells["matricula"].Value.ToString();
            cbCarrera.SelectedValue = dgvAlumnos.CurrentRow.Cells["idCarrera"].Value.ToString();
            tutor.Text = dgvAlumnos.CurrentRow.Cells["tutor"].Value.ToString();
            cbEspecialidad.SelectedValue = dgvAlumnos.CurrentRow.Cells["idEspecialidad"].Value.ToString();
            cbEstatus.SelectedIndex = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["estatus"].Value.ToString());
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;

        }


        private void primerValorCB()
        {
            cbSexo.SelectedIndex = 0;
            cbEdoCivil.SelectedIndex = 0;
            cbDiscapacidad.SelectedIndex = 0;
        }

        private void MostrarEstados()
        {
            CN_Estados _CN_Estados = new CN_Estados();
            cbEstado.DataSource = _CN_Estados.mostrarEstados();
            cbEstado.ValueMember = "idEstado";
            cbEstado.DisplayMember = "nombre";
        }

        private void MostrarMunicipio(String id)
        {
            CN_Municipio _CN_Municipios = new CN_Municipio();
            cbMunicipio.DataSource = _CN_Municipios.MostrarMunicipiosEstado(id);
            cbMunicipio.ValueMember = "idMunicipio";
            cbMunicipio.DisplayMember = "nombre";
        }

        private void MostrarTiposLocalidades()
        {
            CN_tiposLocalidad _CN_TiposLocalidad = new CN_tiposLocalidad();
            cbTipoLocalidad.DataSource = _CN_TiposLocalidad.MostrarTiposLocalidad();
            cbTipoLocalidad.ValueMember = "idTipoLoc";
            cbTipoLocalidad.DisplayMember = "tipo";
        }

        private void MostrarLocalidades(String idMunicipio)
        {
            CN_Localidades _CN_Localidades = new CN_Localidades();
            MostrarLocalidadesMunicipio = new DataTable();
            MostrarLocalidadesMunicipio = _CN_Localidades.MostrarLocalidadesMunicipio(idMunicipio);
            cbLocalidad.DataSource = MostrarLocalidadesMunicipio;
            cbLocalidad.ValueMember = "idLocalidad";
            cbLocalidad.DisplayMember = "nombre";
        }

        private void CbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MostrarMunicipio(cbEstado.SelectedValue.ToString());
        }

        private void CbMunicipio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MostrarLocalidades(cbMunicipio.SelectedValue.ToString());
        }

        private void CbLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            row = MostrarLocalidadesMunicipio.Rows[Convert.ToInt32(cbLocalidad.SelectedValue) - 1];
            cbTipoLocalidad.SelectedValue = Convert.ToInt32(row["tipo"].ToString());
        }

        private void MostrarCarreras()
        {
            CN_Carreras _CN_Carreras = new CN_Carreras();
            cbCarrera.DataSource = _CN_Carreras.MostrarCarreras();
            cbCarrera.ValueMember = "idCarrera";
            cbCarrera.DisplayMember = "nombre";
        }

        private void MostrarProfesores()
        {
            CN_Profesores _CN_Profesores = new CN_Profesores();
            dgvProfesores.DataSource = _CN_Profesores.MostrarProfesores();
        }

        private void MostrarEspecialidades()
        {
            CN_especialidades _CN_Especialidades = new CN_especialidades();
            cbEspecialidad.DataSource = _CN_Especialidades.MostrarEspecialidadesCarrera(cbCarrera.SelectedValue.ToString());
            cbEspecialidad.ValueMember = "idEspecialidad";
            cbEspecialidad.DisplayMember = "nombre";
        }

        private void DgvProfesores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDProfesor = dgvProfesores.CurrentRow.Cells["idProfesor"].Value.ToString();
            tutor.Text = dgvProfesores.CurrentRow.Cells["nombres"].Value.ToString()
                + " "
                + dgvProfesores.CurrentRow.Cells["paterno"].Value.ToString()
                + " "
                + dgvProfesores.CurrentRow.Cells["materno"].Value.ToString();
        }

        private void CbCarrera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MostrarEspecialidades();
        }
    }
}
