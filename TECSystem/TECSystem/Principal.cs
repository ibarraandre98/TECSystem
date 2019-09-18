using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECSystem
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        #region SOMBRAS DE BORDE
        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        #region ANIMACION DE MENU
        private void FormularioCerrar_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 25;
            FormularioCerrar.Visible = false;
            FormularioAbrir.Visible = true;
            Logo.Visible = false;
            
        }

        private void FormularioAbrir_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 200;
            FormularioCerrar.Visible = !false;
            FormularioAbrir.Visible = !true;
            Logo.Visible = !false;
        }
        #endregion

        #region ABRIR FORMULARIOS DENTRO DEL PANEL Y EJEMPLO
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormulariosFondo.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormulariosFondo.Controls.Add(formulario);
                panelFormulariosFondo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }


            /*
            Ejemplo para llamar este metodo
   
                private void button2_Click(object sender, EventArgs e)
                {
                    AbrirFormulario<Form2>();
                }

            */
        }
        #endregion

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton21_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Personas>();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Calles>();

        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Carreras>();

        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<detActividades>();

        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {
            AbrirFormulario<detGrupos>();

        }

        private void BunifuFlatButton17_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Estados>();
        }

        private void BunifuFlatButton15_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Horarios>();
        }

        private void BunifuFlatButton14_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Inasistencias>();
        }

        private void BunifuFlatButton16_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Grupos>();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            AbrirFormulario<empleados>();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Municipio>();
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Localidad>();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Materias>();
        }
    }
}
