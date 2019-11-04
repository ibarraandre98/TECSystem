using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECSystem
{
    public partial class empleados : Form
    {
        CN_Empleados _CN_Empleados = new CN_Empleados();
        DataTable MostrarLocalidadesMunicipio;
        DataRow row;
        int IDPersona;
        int IDEmpleado;
        public empleados()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void empleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            MostrarEmpleos();
            MostrarEstados();
            MostrarMunicipio(cbEstado.SelectedValue.ToString());
            MostrarTiposLocalidades();
            primerValorCB();
            MostrarAcademias();
        }

        private void primerValorCB()
        {
            cbSexo.SelectedIndex = 0;
            cbEdoCivil.SelectedIndex = 0;
            cbDiscapacidad.SelectedIndex = 0;
            cbTipoMemb.SelectedIndex = 0;
        }

        private void MostrarAcademias()
        {
            CN_Academia _CN_Academia = new CN_Academia();
            cbAcademia.DataSource = _CN_Academia.mostrarAcademias();
            cbAcademia.ValueMember = "idAcademia";
            cbAcademia.DisplayMember = "nombre";
        }

        private void MostrarEmpleados()
        {
            CN_Empleados _CN_Empleados = new CN_Empleados();
            dtgempleados.DataSource = _CN_Empleados.MostrarEmpleados();
        }

        public void MostrarEmpleos()
        {
            CN_Empleos _CN_empleos = new CN_Empleos();
            cbEmpleo.DataSource = _CN_empleos.Mostrarempleos();
            cbEmpleo.ValueMember = "idEmpleo";
            cbEmpleo.DisplayMember = "puesto";
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


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CN_Personas _CN_Personas = new CN_Personas();
            CN_Profesores _CN_Profesores = new CN_Profesores();
            _CN_Personas.AgregarPersonas(txtPaterno.Text, txtMaterno.Text, txtNombre.Text, dtpFechaNac.Value, 
                cbSexo.SelectedIndex.ToString(), txtCurp.Text, txtTelefono.Text, txtExt.Text, txtInt.Text, txtCP.Text, 
                cbEdoCivil.SelectedIndex.ToString(), cbDiscapacidad.SelectedIndex.ToString(), txtCalle.Text, 
                cbLocalidad.SelectedValue.ToString());
            IDPersona = _CN_Personas.ultimoID();
            _CN_Empleados.Agregarempleados(IDPersona.ToString(),cbEmpleo.SelectedValue.ToString());
            IDEmpleado = _CN_Empleados.UltimoID();
            _CN_Profesores.AgregarProfesores(txtIDProfesor.Text, IDEmpleado.ToString(), cbAcademia.SelectedValue.ToString(), 
                cbTipoMemb.SelectedIndex.ToString());
            MostrarEmpleados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            MostrarEmpleados();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void dtgempleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            cbEmpleo.SelectedValue = dtgempleados.CurrentRow.Cells["idEmpleo"].Value.ToString();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            MostrarEmpleados();
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
            row = MostrarLocalidadesMunicipio.Rows[Convert.ToInt32(cbLocalidad.SelectedValue)-1];
            cbTipoLocalidad.SelectedValue = Convert.ToInt32(row["tipo"].ToString());
            //MessageBox.Show(row["nombre"].ToString());
        }
    }
}
