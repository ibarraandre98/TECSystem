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
    }
}
