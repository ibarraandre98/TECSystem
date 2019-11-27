namespace TECSystem
{
    partial class Grupos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cveGrupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgGrupos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(592, 516);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 34);
            this.btnEliminar.TabIndex = 85;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(428, 516);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 34);
            this.btnEditar.TabIndex = 84;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(255, 516);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 34);
            this.btnAgregar.TabIndex = 83;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "Materia";
            // 
            // cveGrupo
            // 
            this.cveGrupo.Location = new System.Drawing.Point(126, 401);
            this.cveGrupo.MaxLength = 10;
            this.cveGrupo.Name = "cveGrupo";
            this.cveGrupo.Size = new System.Drawing.Size(162, 20);
            this.cveGrupo.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "cveGrupo";
            // 
            // dtgGrupos
            // 
            this.dtgGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrupos.Location = new System.Drawing.Point(12, 77);
            this.dtgGrupos.Name = "dtgGrupos";
            this.dtgGrupos.Size = new System.Drawing.Size(276, 282);
            this.dtgGrupos.TabIndex = 78;
            this.dtgGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgGrupos_CellContentClick);
            this.dtgGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgGrupos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 77;
            this.label1.Text = "GRUPOS";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(126, 453);
            this.txtProfesor.MaxLength = 40;
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(162, 20);
            this.txtProfesor.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Profesor";
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(310, 77);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(276, 282);
            this.dgvMaterias.TabIndex = 89;
            this.dgvMaterias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMaterias_CellDoubleClick);
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(126, 427);
            this.txtMateria.MaxLength = 8;
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(162, 20);
            this.txtMateria.TabIndex = 90;
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Location = new System.Drawing.Point(615, 77);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.Size = new System.Drawing.Size(276, 282);
            this.dgvProfesores.TabIndex = 91;
            this.dgvProfesores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProfesores_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(755, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 92;
            this.button1.Text = "ReporteHorarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(903, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cveGrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgGrupos);
            this.Controls.Add(this.label1);
            this.Name = "Grupos";
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.Grupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cveGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.Button button1;
    }
}