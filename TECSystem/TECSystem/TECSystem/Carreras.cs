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

        public Carreras()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _CN_Carrera.AgregarCarrera(txtNombre.Text, txtCoordinador.Text);
            MostrarTabla();
            Limpiartxt();
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
            txtCoordinador.Clear();
            txtNombre.Clear();
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _CN_Carrera.EditarCarrera(txtIdCarrera.Text, txtNombre.Text, txtCoordinador.Text);
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();
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

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void DtgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCoordinador.Text = dtgEmpleados.CurrentRow.Cells["idEmpleado"].Value.ToString();
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            _CN_Carrera.AgregarCarrera(txtNombre.Text, txtCoordinador.Text);
            MostrarTabla();
            Limpiartxt();
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            _CN_Carrera.EditarCarrera(txtIdCarrera.Text, txtNombre.Text, txtCoordinador.Text);
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            _CN_Carrera.EliminarCarrera(txtIdCarrera.Text);
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
            MostrarTabla();
        }
    }
}
