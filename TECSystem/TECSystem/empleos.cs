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
    public partial class empleos : Form
    {
        CN_empleos _CN_empleos = new CN_empleos();
        public empleos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _CN_empleos.Agregarempleos(Puesto.Text);
            limpiartxt();
            Mostrarempleos();
        }
        public void limpiartxt()
        {
            idEmpleo.Clear();
            Puesto.Clear();
        }
        private void Mostrarempleos()
        {
            CN_empleos _CN_empleos = new CN_empleos();
            dtgempleos.DataSource = _CN_empleos.Mostrarempleos();
            
        }

        private void empleos_Load(object sender, EventArgs e)
        {
            Mostrarempleos();
            //ll
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _CN_empleos.Eliminarempleos(idEmpleo.Text);
            Mostrarempleos();
        }

        private void dtgempleos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Puesto.Text = dtgempleos.CurrentRow.Cells["puesto"].Value.ToString();
            idEmpleo.Text = dtgempleos.CurrentRow.Cells["idEmpleo"].Value.ToString();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            Mostrarempleos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _CN_empleos.Editarempleos(idEmpleo.Text, Puesto.Text);
            Mostrarempleos();
        }
    }
}
