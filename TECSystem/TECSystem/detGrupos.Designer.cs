namespace TECSystem
{
    partial class detGrupos
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCveGrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgdetGrupos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtiddetGpo = new System.Windows.Forms.TextBox();
            this.dgvGrupo = new System.Windows.Forms.DataGridView();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.cbTipoCurso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdetGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(569, 634);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 34);
            this.btnEliminar.TabIndex = 80;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(405, 634);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 34);
            this.btnEditar.TabIndex = 79;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(232, 634);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 34);
            this.btnAgregar.TabIndex = 78;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "tipoCurso";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(145, 461);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(162, 20);
            this.txtMatricula.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "matricula";
            // 
            // txtCveGrupo
            // 
            this.txtCveGrupo.Location = new System.Drawing.Point(145, 435);
            this.txtCveGrupo.Name = "txtCveGrupo";
            this.txtCveGrupo.Size = new System.Drawing.Size(162, 20);
            this.txtCveGrupo.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "cveGrupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "idDetGpo";
            // 
            // dtgdetGrupos
            // 
            this.dtgdetGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdetGrupos.Location = new System.Drawing.Point(43, 91);
            this.dtgdetGrupos.Name = "dtgdetGrupos";
            this.dtgdetGrupos.Size = new System.Drawing.Size(264, 282);
            this.dtgdetGrupos.TabIndex = 68;
            this.dtgdetGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgdetGrupos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 67;
            this.label1.Text = "DETGRUPOS";
            // 
            // txtiddetGpo
            // 
            this.txtiddetGpo.Location = new System.Drawing.Point(145, 409);
            this.txtiddetGpo.Name = "txtiddetGpo";
            this.txtiddetGpo.ReadOnly = true;
            this.txtiddetGpo.Size = new System.Drawing.Size(162, 20);
            this.txtiddetGpo.TabIndex = 81;
            // 
            // dgvGrupo
            // 
            this.dgvGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupo.Location = new System.Drawing.Point(375, 91);
            this.dgvGrupo.Name = "dgvGrupo";
            this.dgvGrupo.Size = new System.Drawing.Size(264, 282);
            this.dgvGrupo.TabIndex = 82;
            this.dgvGrupo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupo_CellDoubleClick);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(700, 91);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(264, 282);
            this.dgvAlumnos.TabIndex = 83;
            this.dgvAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlumnos_CellDoubleClick);
            // 
            // cbTipoCurso
            // 
            this.cbTipoCurso.FormattingEnabled = true;
            this.cbTipoCurso.Items.AddRange(new object[] {
            "CN: Curso Normal",
            "CR: Curso Repetición",
            "CE: Curso Especial",
            "CA: Curso Autodidacta"});
            this.cbTipoCurso.Location = new System.Drawing.Point(145, 489);
            this.cbTipoCurso.Name = "cbTipoCurso";
            this.cbTipoCurso.Size = new System.Drawing.Size(162, 21);
            this.cbTipoCurso.TabIndex = 84;
            // 
            // detGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 708);
            this.Controls.Add(this.cbTipoCurso);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.dgvGrupo);
            this.Controls.Add(this.txtiddetGpo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCveGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgdetGrupos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "detGrupos";
            this.Text = "detGrupos";
            this.Load += new System.EventHandler(this.DetGrupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdetGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCveGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgdetGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtiddetGpo;
        private System.Windows.Forms.DataGridView dgvGrupo;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.ComboBox cbTipoCurso;
    }
}