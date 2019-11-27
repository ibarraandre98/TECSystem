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
    public partial class detGrupos : Form
    {
        CN_DetGrupos _CN_detGrupos = new CN_DetGrupos();
        String IDGrupo;
        String Matricula;

        public detGrupos()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCveGrupo.Text == "" || txtMatricula.Text == "" ||cbTipoCurso.Text == "")
            {
                MessageBox.Show("No puede ingresar Grupo, aún faltan datos por completar", "Datos incompletos",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _CN_detGrupos.AgregarGrupo(IDGrupo, Matricula, cbTipoCurso.Text.Split(':').ElementAt(0));
                MostrarTabla();
                Limpiartxt();
            }
           
        }

        private void MostrarTabla()
        {
            CN_DetGrupos _CN_detGrupos = new CN_DetGrupos();
            dtgdetGrupos.DataSource = _CN_detGrupos.MostrarTabla();
        }

        private void Limpiartxt()
        {
            txtCveGrupo.Clear();
            txtiddetGpo.Clear();
            txtMatricula.Clear();
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _CN_detGrupos.EditarGrupo(txtiddetGpo.Text, IDGrupo, Matricula, cbTipoCurso.Text.Split(':').ElementAt(0));
            MostrarTabla();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _CN_detGrupos.EliminarGrupo(txtiddetGpo.Text);
            MostrarTabla();
            Limpiartxt();
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void DetGrupos_Load(object sender, EventArgs e)
        {
            MostrarTabla();
            MostrarGrupos();
            MostrarAlumnos();
            cbTipoCurso.SelectedIndex = 0;
        }

        private void DtgdetGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtiddetGpo.Text = dtgdetGrupos.CurrentRow.Cells["idDetGpo"].Value.ToString();
            txtCveGrupo.Text = dtgdetGrupos.CurrentRow.Cells["cveGrupo"].Value.ToString();
            txtMatricula.Text = dtgdetGrupos.CurrentRow.Cells["matricula"].Value.ToString();
            cbTipoCurso.Text = dtgdetGrupos.CurrentRow.Cells["tipoCurso"].Value.ToString();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void MostrarGrupos()
        {
            CN_Grupos _CN_Grupos = new CN_Grupos();
            dgvGrupo.DataSource = _CN_Grupos.mostrarGrupos();
        }

        private void MostrarAlumnos()
        {
            CN_Alumnos _CN_Alumnos = new CN_Alumnos();
            dgvAlumnos.DataSource = _CN_Alumnos.MostrarAlumnos();
        }

        private void DgvGrupo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDGrupo = dgvGrupo.CurrentRow.Cells["cveGrupo"].Value.ToString();
            txtCveGrupo.Text = dgvGrupo.CurrentRow.Cells["nombre"].Value.ToString();
        }

        private void DgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Matricula = dgvAlumnos.CurrentRow.Cells["matricula"].Value.ToString();
            txtMatricula.Text = Matricula;
        }
    }
    }

