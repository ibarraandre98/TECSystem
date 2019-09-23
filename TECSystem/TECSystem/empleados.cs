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
        CN_empleados _CN_Empleados = new CN_empleados();
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
        }
        private void MostrarEmpleados()
        {
            CN_empleados _CN_Empleados = new CN_empleados();
            dtgempleados.DataSource = _CN_Empleados.MostrarEmpleados();
        }
        public void limpiar()
        {
           
            idEmpleo.Text = "";
            idPersona.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _CN_Empleados.Agregarempleados(idPersona.Text,idEmpleo.Text);
            limpiar();
            MostrarEmpleados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            _CN_Empleados.Editarempleados(idPersona.Text, idEmpleo.Text);
            MostrarEmpleados();
            limpiar();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void dtgempleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idPersona.Text = dtgempleados.CurrentRow.Cells["idPersona"].Value.ToString();
            idEmpleo.Text = dtgempleados.CurrentRow.Cells["idEmpleo"].Value.ToString();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _CN_Empleados.Eliminarempleados(idEmpleado.Text);
            idEmpleado.Clear();
            MostrarEmpleados();
        }
    }
}
