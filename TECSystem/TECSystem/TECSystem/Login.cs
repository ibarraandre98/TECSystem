using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace TECSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            CN_Login _CD_Login = new CN_Login();
            SqlDataReader sdrLeer;
            sdrLeer = _CD_Login.leerLogin(txtUsuario.Text, txtContraseña.Text);
            if (sdrLeer.Read() == true)
            {
                Program.user = txtUsuario.Text;
                Program.pass = txtContraseña.Text;
                Program.nombre = sdrLeer["nombre"].ToString();
                Program.apellidos = sdrLeer["apellidos"].ToString();
                Program.correo = sdrLeer["email"].ToString();
                Principal _Pri = new Principal();
                _Pri.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlTransparente_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnCer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
