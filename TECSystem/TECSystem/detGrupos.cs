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
        CN_detGrupos _CN_detGrupos = new CN_detGrupos();

        public detGrupos()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            _CN_detGrupos.AgregarGrupo(txtCveGrupo.Text, txtMatricula.Text, txtTipoCurso.Text);
            MostrarTabla();
            Limpiartxt();
        }

        private void MostrarTabla()
        {
            CN_detGrupos _CN_detGrupos = new CN_detGrupos();
            dtgdetGrupos.DataSource = _CN_detGrupos.MostrarTabla();
        }

        private void Limpiartxt()
        {
            txtCveGrupo.Clear();
            txtiddetGpo.Clear();
            txtMatricula.Clear();
            txtTipoCurso.Clear();
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            _CN_detGrupos.EditarGrupo(txtiddetGpo.Text, txtCveGrupo.Text, txtMatricula.Text, txtTipoCurso.Text);
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

        }

        private void DtgdetGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtiddetGpo.Text = dtgdetGrupos.CurrentRow.Cells["idDetGpo"].Value.ToString();
            txtCveGrupo.Text = dtgdetGrupos.CurrentRow.Cells["cveGrupo"].Value.ToString();
            txtMatricula.Text = dtgdetGrupos.CurrentRow.Cells["matricula"].Value.ToString();
            txtTipoCurso.Text = dtgdetGrupos.CurrentRow.Cells["tipoCurso"].Value.ToString();

            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
        }
    }
    }

