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
    public partial class Especialidades : Form
    {
        String idEspecialidad = null;
        CN_Especialidades _CN_Especialidades = new CN_Especialidades();
        public Especialidades()
        {
            InitializeComponent();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            MostrarEspecialidades();
            MostrarCarreras();
        }

        private void MostrarCarreras()
        {
            CN_Carreras _CN_Carreras = new CN_Carreras();
            dtgCarreras.DataSource = _CN_Carreras.MostrarCarreras();
        }

        private void MostrarEspecialidades()
        {
            CN_Especialidades _CN_Especialidades = new CN_Especialidades();
            dtgEspecialidades.DataSource = _CN_Especialidades.Mostrarespecialidades();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtCarrera.Text == "")
                {
                    MessageBox.Show("No puede ingresar carreras, aún faltan datos por completar", "Datos incompletos",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _CN_Especialidades.Agregarespecialidades(txtNombre.Text, txtCarrera.Text);
                    MostrarEspecialidades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DtgCarreras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCarrera.Text = dtgCarreras.CurrentRow.Cells["idCarrera"].Value.ToString();
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            _CN_Especialidades.Agregarespecialidades(txtNombre.Text, txtCarrera.Text);
            MostrarEspecialidades();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //Aquí no hay nada 
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //_CN_Especialidades.Editarespecialidades();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes r = new Reportes();
            r.setReporte(1);
            r.ShowDialog();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtCarrera.Text == "")
                {
                    MessageBox.Show("No puede ingresar carreras, aún faltan datos por completar", "Datos incompletos",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _CN_Especialidades.Eliminarespecialidades(idEspecialidad);
                    MostrarEspecialidades();
                    btnAgregar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtCarrera.Text == "")
                {
                    MessageBox.Show("No puede ingresar carreras, aún faltan datos por completar", "Datos incompletos",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    _CN_Especialidades.Editarespecialidades(idEspecialidad,txtNombre.Text, txtCarrera.Text);
                    MostrarEspecialidades();
                    btnAgregar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           // _CN_Especialidades.Eliminarespecialidades();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //No habia nada
        private void dtgEspecialidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idEspecialidad = dtgEspecialidades.CurrentRow.Cells["idEspecialidad"].Value.ToString();
            txtNombre.Text = dtgEspecialidades.CurrentRow.Cells["nombre"].Value.ToString();
            txtCarrera.Text = dtgEspecialidades.CurrentRow.Cells["carrera"].Value.ToString();
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
