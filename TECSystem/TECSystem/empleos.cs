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
        }
        public void limpiartxt()
        {
            idEmpleo.Clear();
            Puesto.Clear();
        }
        private void MostrarPersonas()
        {
            CN_empleos _CN_empleos = new CN_empleos();
            dtgempleos.DataSource = _CN_empleos.Mostrarempleos();
            
        }
    }
}
