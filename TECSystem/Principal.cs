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
            Logo.Visible = false;
            
        }

        private void FormularioAbrir_Click(object sender, EventArgs e)
        {
            panelMenu.Width = 200;
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
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de salir?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void hideSubMenu()
        {
            if (panelUbicacion.Visible == true)
                panelUbicacion.Visible = false;
            if (panelCarreras.Visible == true)
                panelCarreras.Visible = false;
            if (panelEmpleados.Visible == true)
                panelEmpleados.Visible = false;
            if (panelAlumnos.Visible == true)
                panelAlumnos.Visible = false;
            if (panelMaterias.Visible == true)
                panelMaterias.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void BtnPrinUbicacion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUbicacion);
        }

        private void BtnPrinCarreras_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCarreras);
        }

        private void BtnPrinEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpleados);
        }

        private void BtnPrinAlumnos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAlumnos);
        }

        private void BtnPrinMaterias_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMaterias);
        }

        private void BtnEstados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Estados>();
            hideSubMenu();
        }

        private void BtnMunicipios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Municipio>();
            hideSubMenu();
        }

        private void BtnLocalidades_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Localidad>();
            hideSubMenu();
        }

        private void BtnTiposLocalidad_Click(object sender, EventArgs e)
        {
            AbrirFormulario<TiposLocalidad>();
            hideSubMenu();
        }

        private void BtnCarreras_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Carreras>();
            hideSubMenu();
        }

        private void BtnEspecialidades_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Especialidades>();
            hideSubMenu();
        }

        private void BtnAcademias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Academias>();
            hideSubMenu();
        }

        private void BtnEmpleos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Empleos>();
            hideSubMenu();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<empleados>();
            hideSubMenu();
        }

        private void BtnProfesores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Profesores>();
            hideSubMenu();
        }

        private void BtnAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Alumnos>();
            hideSubMenu();
        }

        private void BtnCalificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Calificaciones>();
            hideSubMenu();
        }

        private void BtnInasistencias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Inasistencias>();
            hideSubMenu();
        }

        private void BtnGrupos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Grupos>();
            hideSubMenu();
        }

        private void BtnDetGrupos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<detGrupos>();
            hideSubMenu();
        }

        private void BtnHorarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Horarios>();
            hideSubMenu();
        }

        private void BtnActividades_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Actividades>();
            hideSubMenu();
        }

        private void BtnDetActividades_Click(object sender, EventArgs e)
        {
            AbrirFormulario<detActividades>();
            hideSubMenu();
        }

        private void BtnMaterias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Materias>();
            hideSubMenu();
        }

        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
