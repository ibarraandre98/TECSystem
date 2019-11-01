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
    public partial class Usuarios : Form
    {
        CN_Login _CN_Login = new CN_Login();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            CN_Login _CN_Login = new CN_Login();
            dgvUsuarios.DataSource = _CN_Login.MostrarUsuarios();
        }

        private void limpiarCampos()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _CN_Login.AgregarUsuario(txtUsuario.Text, txtNombre.Text, txtApellidos.Text, txtEmail.Text, txtContraseña.Text);
            MostrarUsuarios();
            limpiarCampos();
        }
    }
}
