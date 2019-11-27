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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Admin"))
                MessageBox.Show("No puede editar este usuario");
            else
            {
                _CN_Login.EditarUsuario(txtUsuario.Text, txtNombre.Text, txtApellidos.Text, txtEmail.Text, txtContraseña.Text);
                HabilitarAgregar();
                MostrarUsuarios();
                limpiarCampos();
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["usuario"].Value.ToString();
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells["pass"].Value.ToString();
            txtApellidos.Text = dgvUsuarios.CurrentRow.Cells["apellidos"].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
            txtEmail.Text = dgvUsuarios.CurrentRow.Cells["email"].Value.ToString();
            DeshabilitarAgregar();
        }

        private void HabilitarAgregar()
        {
            txtUsuario.Enabled = false;
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void DeshabilitarAgregar()
        {
            txtUsuario.Enabled = false;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Admin"))
                MessageBox.Show("No puede eliminar este usuario");
            else
            {
                _CN_Login.EliminarUsuario(txtUsuario.Text);
                HabilitarAgregar();
                MostrarUsuarios();
                limpiarCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarAgregar();
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            _CN_Login.AgregarUsuario(txtUsuario.Text, txtNombre.Text, txtApellidos.Text, txtEmail.Text, txtContraseña.Text);
            MostrarUsuarios();
            limpiarCampos();
        }

        private void btnEditar3_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Admin"))
                MessageBox.Show("No puede editar este usuario");
            else
            {
                _CN_Login.EditarUsuario(txtUsuario.Text, txtNombre.Text, txtApellidos.Text, txtEmail.Text, txtContraseña.Text);
                HabilitarAgregar();
                MostrarUsuarios();
                limpiarCampos();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Admin"))
                MessageBox.Show("No puede eliminar este usuario");
            else
            {
                _CN_Login.EliminarUsuario(txtUsuario.Text);
                HabilitarAgregar();
                MostrarUsuarios();
                limpiarCampos();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            HabilitarAgregar();
        }
    }
}
