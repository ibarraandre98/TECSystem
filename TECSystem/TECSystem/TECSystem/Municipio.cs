using CapaNegocio;
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

namespace TECSystem
{
    public partial class Municipio : Form
    {
        int id;
        public Municipio()
        {
            InitializeComponent();
        }

        private void Municipio_Load(object sender, EventArgs e)
        {
            MostrarMunicipio();
            MostrarEstados();
        }
        private void MostrarMunicipio()
        {
            CN_Municipio _CN_Municipio = new CN_Municipio();
            dtgPersonas.DataSource = _CN_Municipio.MostrarMunicipios();
        }
        private void MostrarEstados()
        {
            CN_Estados _CN_Estados = new CN_Estados();
            cbEstado.DataSource = _CN_Estados.mostrarEstados();
            cbEstado.ValueMember = "idEstado";
            cbEstado.DisplayMember = "nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.TextLength<=0 || txtNumero.TextLength<=0 || cbEstado.Text.Length<=0)
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
            else
            {
                CN_Municipio _CN_Municipio = new CN_Municipio();
                _CN_Municipio.AgregarMunicipio(Convert.ToInt32(txtNumero.Text), Convert.ToInt32(cbEstado.SelectedValue.ToString()), txtNombre.Text);
                MostrarMunicipio();
                limpiar();
            }
        }

        private void dtgPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumero.Text = dtgPersonas.CurrentRow.Cells["NumeroMunicipio"].Value.ToString();
            txtNombre.Text = dtgPersonas.CurrentRow.Cells["Municipio"].Value.ToString();
            cbEstado.SelectedValue = dtgPersonas.CurrentRow.Cells["idEstado"].Value.ToString();
            id = Convert.ToInt32(dtgPersonas.CurrentRow.Cells["idMunicipio"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.TextLength <= 0 || txtNumero.TextLength <= 0 || cbEstado.Text.Length <= 0)
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
            else
            {
                CN_Municipio _CN_Municipio = new CN_Municipio();
                _CN_Municipio.EditarMunicipio(txtNombre.Text, id, Convert.ToInt32(txtNumero.Text), Convert.ToInt32(cbEstado.SelectedValue.ToString()));
                MostrarMunicipio();
                limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNombre.TextLength <= 0 || txtNumero.TextLength <= 0 || cbEstado.Text.Length <= 0)
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
            else
            {
                CN_Municipio _CN_Municipio = new CN_Municipio();
                _CN_Municipio.eliminarMunicipio(id);
                MostrarMunicipio();
                limpiar();
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MessageBox.Show(cbEstado.SelectedValue.ToString());
        }

        

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void limpiar()
        {
            txtNumero.Clear();
            
            txtNombre.Clear();
        }
    }
}
