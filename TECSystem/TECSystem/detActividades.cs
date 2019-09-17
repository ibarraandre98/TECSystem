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
    public partial class detActividades : Form
    {
        CN_detActividades _CN_detActividades = new CN_detActividades();

        public detActividades()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _CN_detActividades.AgregarACtividad(txtActividad.Text, txtMatricula.Text, txtCalificacion.Text, txtFechaEntrega.Text);
            MostrarTabla();
            Limpiartxt();
        }

        private void MostrarTabla()
        {
            CN_detActividades _CN_detActividades = new CN_detActividades();
            dtgdetActividades.DataSource = _CN_detActividades.MostrarTabla();
        }

        private void Limpiartxt()
        {
            txtActividad.Clear();
            txtCalificacion.Clear();
            txtIddetAct.Clear();
            txtMatricula.Clear();
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _CN_detActividades.EditarActividad(txtIddetAct.Text, txtActividad.Text, txtMatricula.Text,txtCalificacion.Text, txtFechaEntrega.Text);
            MostrarTabla();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _CN_detActividades.EliminarActividad(txtIddetAct.Text);
            MostrarTabla();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void DetActividades_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }
    }
}
