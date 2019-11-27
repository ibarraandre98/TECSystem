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
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtNombre.Text = "";
            txtCurp.Text = "";
            txtTelefono.Text = "";
            txtExt.Text = "";
            txtInt.Text = "";
            txtCP.Text = "";
            txtCalle.Text = "";
            cbLocalidad.Text = "";
            txtMatricula.Text = "";
            cbCarrera.Text = "";
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
            dgvAlumnos.DataSource = obj.MostrarAlumnos();
        }
        private void Alumnos_Load(object sender, EventArgs e)
        {
            mostrar_alumnos();
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
            var fe = dtpFechaNac.Value;
            var fe2 = DateTime.Parse(fe.ToString());
            var final = fe2.ToShortDateString();
            CN_Personas _CN_Personas = new CN_Personas();
            IDPersona = _CN_Personas.ultimoID();

            _CN_Personas.EditarPersonas(Convert.ToString(IDPersona), txtPaterno.Text, txtMaterno.Text, txtNombre.Text,
                dtpFechaNac.Value, cbSexo.SelectedIndex.ToString(), txtCurp.Text, txtTelefono.Text, txtExt.Text,
                txtInt.Text, txtCP.Text, cbEdoCivil.SelectedIndex.ToString(), cbDiscapacidad.SelectedIndex.ToString(), txtCalle.Text, cbLocalidad.SelectedIndex.ToString());



            _CN_Alumnos.editar_alumno(txtMatricula.Text, IDPersona, Convert.ToInt32(cbCarrera.SelectedValue.ToString()), IDProfesor, Convert.ToInt32(cbEspecialidad.SelectedValue.ToString()), Convert.ToInt32(cbEstatus.SelectedIndex));
            mostrar_alumnos();
            limpiar();
        }



        private void primerValorCB()
        {
            cbSexo.SelectedIndex = 0;
            cbEdoCivil.SelectedIndex = 0;
            cbDiscapacidad.SelectedIndex = 0;
            cbEstatus.SelectedIndex = 0;
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
            CN_TiposLocalidad _CN_TiposLocalidad = new CN_TiposLocalidad();
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
            CN_Especialidades _CN_Especialidades = new CN_Especialidades();
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


        private void dgvAlumnos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
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
            habilitarEdicion();

            IDProfesor = dgvAlumnos.CurrentRow.Cells["tutor"].Value.ToString();
            foreach (DataGridViewRow row in dgvProfesores.Rows)
            {
                if (dgvAlumnos.CurrentRow.Cells["tutor"].Value.ToString().Equals(row.Cells["idProfesor"].Value.ToString()))
                {
                    tutor.Text = $"{row.Cells["nombres"].Value.ToString()} {row.Cells["paterno"].Value.ToString()} {row.Cells["materno"].Value.ToString()}";
                    break;
                }
            }
        }

        private void deshabilitarEdicion()
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar2.Enabled = true;
        }

        private void habilitarEdicion()
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            r.setMatricula(txtMatricula.Text);
            r.setReporte(2);
            r.ShowDialog();

        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtPaterno.Text == "" || txtMaterno.Text == "" || txtNombre.Text == "" || txtCurp.Text == "" ||
                txtTelefono.Text == "" || txtExt.Text == "" || txtInt.Text == "" || txtCP.Text == "" ||
                txtCalle.Text == "" || cbLocalidad.Text == "" || txtMatricula.Text == "" || cbCarrera.Text == ""
                )
                {
                    MessageBox.Show("No puede ingresar Alumno, aún faltan datos por completar", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    CN_Personas _CN_Personas = new CN_Personas();
                    _CN_Personas.AgregarPersonas(txtPaterno.Text, txtMaterno.Text, txtNombre.Text, dtpFechaNac.Value,
                        cbSexo.SelectedIndex.ToString(), txtCurp.Text, txtTelefono.Text, txtExt.Text, txtInt.Text, txtCP.Text,
                        cbEdoCivil.SelectedIndex.ToString(), cbDiscapacidad.SelectedIndex.ToString(), txtCalle.Text,
                        cbLocalidad.SelectedValue.ToString());
                    IDPersona = _CN_Personas.ultimoID();

                    _CN_Alumnos.agregar_alumno(txtMatricula.Text, IDPersona, Convert.ToInt32(cbCarrera.SelectedValue.ToString()),
                        IDProfesor, Convert.ToInt32(cbEspecialidad.SelectedValue.ToString()),
                        Convert.ToInt32(cbEstatus.SelectedIndex));
                    mostrar_alumnos();
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtPaterno.Text == "" || txtMaterno.Text == "" || txtNombre.Text == "" || txtCurp.Text == "" ||
                txtTelefono.Text == "" || txtExt.Text == "" || txtInt.Text == "" || txtCP.Text == "" ||
                txtCalle.Text == "" || cbLocalidad.Text == "" || txtMatricula.Text == "" || cbCarrera.Text == ""
                )
                {
                    MessageBox.Show("No puede editar Alumno, aún faltan datos por completar", "Datos incompletos",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var fe = dtpFechaNac.Value;
                    var fe2 = DateTime.Parse(fe.ToString());
                    var final = fe2.ToShortDateString();
                    CN_Personas _CN_Personas = new CN_Personas();
                    IDPersona = _CN_Personas.ultimoID();

                    _CN_Personas.EditarPersonas(Convert.ToString(IDPersona), txtPaterno.Text, txtMaterno.Text, txtNombre.Text,
                        dtpFechaNac.Value, cbSexo.SelectedIndex.ToString(), txtCurp.Text, txtTelefono.Text, txtExt.Text,
                        txtInt.Text, txtCP.Text, cbEdoCivil.SelectedIndex.ToString(), cbDiscapacidad.SelectedIndex.ToString(), txtCalle.Text, cbLocalidad.SelectedIndex.ToString());

                    deshabilitarEdicion();

                    _CN_Alumnos.editar_alumno(txtMatricula.Text, IDPersona, Convert.ToInt32(cbCarrera.SelectedValue.ToString()), IDProfesor, Convert.ToInt32(cbEspecialidad.SelectedValue.ToString()), Convert.ToInt32(cbEstatus.SelectedIndex));
                    mostrar_alumnos();
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            _CN_Alumnos.eliminar_alumno(txtMatricula.Text);
            mostrar_alumnos();
            deshabilitarEdicion();
            limpiar();
        }

        private void soloNumeros(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        private void txtExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
    }
}

