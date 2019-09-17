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
using System.Data.SqlClient;

namespace TECSystem
{
    public partial class Academia : Form
    {
        CN_Academia obj = new CN_Academia();
        public Academia()
        {
            InitializeComponent();
        }

        private void mostraracademias()
        {
            dataGridView1.DataSource = obj.mostrarAcademias();
        }

        private void Academia_Load(object sender, EventArgs e)
        {
            mostraracademias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.agregar_academia(textBox1.Text);
        }
    }
}
