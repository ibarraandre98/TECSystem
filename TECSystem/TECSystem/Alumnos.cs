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
        public void Limpiar()
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
            _CN_Alumnos.AgregarAlumno(txtMatricula.Text, IDPersona.ToString(), cbCarrera.SelectedValue.ToString(), IDProfesor,cbEspecialidad.SelectedValue.ToString(), cbEstatus.SelectedIndex.ToString());
            MostrarAlumnos();
            Limpiar();
        }

        private void MostrarAlumnos()
        {
            CN_Alumnos obj = new CN_Alumnos();
            dgvAlumnos.DataSource = obj.MostrarAlumnos();
        }
        private void Alumnos_Load(object sender, EventArgs e)
        {
            
            MostrarAlumnos();
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
            _CN_Alumnos.EliminarAlumno(txtMatricula.Text);
            MostrarAlumnos();
            Limpiar();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            _CN_Alumnos.EditarAlumno(txtMatricula.Text, IDPersona.ToString(), cbCarrera.SelectedValue.ToString(), IDProfesor, (cbEspecialidad.SelectedValue.ToString()),cbEstatus.SelectedIndex.ToString());
            MostrarAlumnos();
            Limpiar();
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

        private void dgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
            txtPaterno.Text = dgvAlumnos.CurrentRow.Cells["Paterno"].Value.ToString();
            txtMaterno.Text = dgvAlumnos.CurrentRow.Cells["Materno"].Value.ToString();
            txtCurp.Text = dgvAlumnos.CurrentRow.Cells["curp"].Value.ToString();
            txtTelefono.Text = dgvAlumnos.CurrentRow.Cells["telefono"].Value.ToString();
            dtpFechaNac.Value = Convert.ToDateTime(dgvAlumnos.CurrentRow.Cells["Fecha_Nacimiento"].Value.ToString());
            cbDiscapacidad.SelectedValue = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["discapacidad"].Value.ToString());
            cbEstado.SelectedValue = dgvAlumnos.CurrentRow.Cells["Estado"].Value.ToString();
            MostrarMunicipio(cbEstado.SelectedValue.ToString());
            cbMunicipio.SelectedValue = dgvAlumnos.CurrentRow.Cells["Municipio"].Value.ToString();
            MostrarLocalidades(cbMunicipio.SelectedValue.ToString());
            cbLocalidad.SelectedValue = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["localidades"].Value.ToString());
            cbTipoLocalidad.SelectedValue = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["tipo"].Value.ToString());
            txtCalle.Text = dgvAlumnos.CurrentRow.Cells["calle"].Value.ToString();
            txtExt.Text = dgvAlumnos.CurrentRow.Cells["numExt"].Value.ToString();
            txtInt.Text = dgvAlumnos.CurrentRow.Cells["numInt"].Value.ToString();
            txtCP.Text = dgvAlumnos.CurrentRow.Cells["cp"].Value.ToString();
            txtMatricula.Text = dgvAlumnos.CurrentRow.Cells["matricula"].Value.ToString();
            cbEstatus.SelectedIndex = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["estatus"].Value.ToString());

            IDProfesor=dgvAlumnos.CurrentRow.Cells["tutor"].Value.ToString();
            foreach (DataGridViewRow row in dgvProfesores.Rows)
            {
                if (dgvAlumnos.CurrentRow.Cells["tutor"].Value.ToString().Equals(row.Cells["idProfesor"].Value.ToString()))
                {
                    tutor.Text = $"{row.Cells["nombres"].Value.ToString()} {row.Cells["paterno"].Value.ToString()} {row.Cells["materno"].Value.ToString()}";
                    break;
                }
            }
        }
    }
}
