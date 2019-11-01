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
    public partial class Carreras : Form
    {
        CN_Carreras _CN_Carrera = new CN_Carreras();
        string id;

        public Carreras()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                if (lblCoordinador.Text.Length > 0)
                {
                    _CN_Carrera.AgregarCarrera(txtNombre.Text, id);
                    MostrarTabla();
                    Limpiartxt();
                }
                else
                {
                    MessageBox.Show("Seleccione un coordinador");
                }
            }
            else {
                MessageBox.Show("Ingrese nombre");
            }
        }

        private void MostrarTabla()
        {
            CN_Carreras _CN_Carreras = new CN_Carreras();
            dtgCarreras.DataSource = _CN_Carreras.MostrarCarreras();
        }

        private void MostrarEmpleados()
        {
            CN_Empleados _CN_Empleados = new CN_Empleados();
            dtgEmpleados.DataSource = _CN_Empleados.MostrarEmpleados();
        }

        private void Limpiartxt()
        {
            txtIdCarrera.Clear();
            lblCoordinador.Text = "";
            txtNombre.Clear();
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (lblCoordinador.Text.Length > 0)
            {
                _CN_Carrera.EditarCarrera(txtIdCarrera.Text, txtNombre.Text, id);
                Limpiartxt();
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
                btnAgregar.Enabled = true;
                MostrarTabla();
            }
            else
            {
                MessageBox.Show("Seleccione un coordinador");
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _CN_Carrera.EliminarCarrera(txtIdCarrera.Text);
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            MostrarTabla();
            MostrarEmpleados();
        }

        private void DtgCarreras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCarrera.Text = dtgCarreras.CurrentRow.Cells["idCarrera"].Value.ToString();
            txtNombre.Text = dtgCarreras.CurrentRow.Cells["nombre"].Value.ToString();
            id = dtgCarreras.CurrentRow.Cells["coordinador"].Value.ToString();
            //MessageBox.Show(id);

            foreach (DataGridViewRow row in dtgEmpleados.Rows)
            {
                if (dtgCarreras.CurrentRow.Cells["coordinador"].Value.ToString().Equals(row.Cells["idEmpleado"].Value.ToString()))
                {
                    lblCoordinador.Text = row.Cells["nombre"].Value.ToString() + " " + row.Cells["paterno"].Value.ToString() + " " + row.Cells["materno"].Value.ToString(); 
                    break;
                }
            }
        
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }
        private void DtgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id= dtgEmpleados.CurrentRow.Cells["idEmpleado"].Value.ToString();
            lblCoordinador.Text = dtgEmpleados.CurrentRow.Cells["Nombre"].Value.ToString() +" "+ dtgEmpleados.CurrentRow.Cells["Paterno"].Value.ToString() +" "+ dtgEmpleados.CurrentRow.Cells["Materno"].Value.ToString();
            
        }
    }
}
