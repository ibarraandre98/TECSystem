using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECSystem
{
    public partial class Cargando : Form
    {
        public Cargando()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cargando_Load(object sender, EventArgs e)
        {

            timer1.Start();

            

        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer1.Stop();


            lblcargando.BringToFront();
                lblcargando.Text = "Cargando sistema .";

                lblcargando.Text = "Cargando sistema . .";

                lblcargando.Text = "Cargando sistema . . .";



            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
    }
}
