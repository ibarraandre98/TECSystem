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
    public partial class Personas : Form
    {
        CN_Personas _CN_Personas = new CN_Personas();
        public Personas()
        {
            InitializeComponent();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            MostrarPersonas();
        }

        private void MostrarPersonas()
        {
            CN_Personas _CN_Personas = new CN_Personas();
            dtgPersonas.DataSource = _CN_Personas.MostrarPersonas();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //_CN_Personas.AgregarPersonas(txtPaterno.Text, txtMaterno.Text, txtNombre.Text, txtNacimiento.Value, txtSexo.Text,
            //    txtCURP.Text, txtTel.Text, txtCalle.Text, txtnumExterior.Text, txtInterior.Text, txtCP.Text, txtEdoCivil.Text, txtDiscapacidad.Text);
            MostrarPersonas();
            Limpiartxt();
        }

        private void DtgPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPersona.Text = dtgPersonas.CurrentRow.Cells["idPersona"].Value.ToString();
            txtPaterno.Text = dtgPersonas.CurrentRow.Cells["paterno"].Value.ToString();
            txtMaterno.Text = dtgPersonas.CurrentRow.Cells["materno"].Value.ToString();
            txtNombre.Text = dtgPersonas.CurrentRow.Cells["nombres"].Value.ToString();
            txtNacimiento.Value = Convert.ToDateTime(dtgPersonas.CurrentRow.Cells["fecha_nac"].Value.ToString());
            txtSexo.Text = dtgPersonas.CurrentRow.Cells["sexo"].Value.ToString();
            txtCURP.Text = dtgPersonas.CurrentRow.Cells["curp"].Value.ToString();
            txtTel.Text = dtgPersonas.CurrentRow.Cells["telefono"].Value.ToString();
            txtCalle.Text = dtgPersonas.CurrentRow.Cells["idcalle"].Value.ToString();
            txtnumExterior.Text = dtgPersonas.CurrentRow.Cells["numExt"].Value.ToString();
            txtInterior.Text = dtgPersonas.CurrentRow.Cells["numint"].Value.ToString();
            txtCP.Text = dtgPersonas.CurrentRow.Cells["cp"].Value.ToString();
            txtEdoCivil.Text = dtgPersonas.CurrentRow.Cells["edoCivil"].Value.ToString();
            txtDiscapacidad.Text = dtgPersonas.CurrentRow.Cells["discapacidad"].Value.ToString();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void Limpiartxt()
        {
            txtIdPersona.Clear();
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtNombre.Clear();
            txtSexo.Clear();
            txtCURP.Clear();
            txtTel.Clear();
            txtCalle.Clear();
            txtnumExterior.Clear();
            txtInterior.Clear();
            txtCP.Clear();
            txtEdoCivil.Clear();
            txtDiscapacidad.Clear();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
           
            MostrarPersonas();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _CN_Personas.EliminarPersona(txtIdPersona.Text);
            MostrarPersonas();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void dtgPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
