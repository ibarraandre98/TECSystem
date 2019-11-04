namespace TECSystem
{
    partial class Calificaciones
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
            this.tipoevaluacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.calificacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tema = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idCalificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(628, 528);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 34);
            this.btnEliminar.TabIndex = 53;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(464, 528);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 34);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(291, 528);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 34);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tipoevaluacion
            // 
            this.tipoevaluacion.Location = new System.Drawing.Point(722, 442);
            this.tipoevaluacion.Name = "tipoevaluacion";
            this.tipoevaluacion.Size = new System.Drawing.Size(162, 20);
            this.tipoevaluacion.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(582, 442);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "tipo evaluacion:";
            // 
            // calificacion
            // 
            this.calificacion.Location = new System.Drawing.Point(722, 416);
            this.calificacion.Name = "calificacion";
            this.calificacion.Size = new System.Drawing.Size(162, 20);
            this.calificacion.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(613, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "calificacion:";
            // 
            // tema
            // 
            this.tema.Location = new System.Drawing.Point(722, 388);
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(162, 20);
            this.tema.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(662, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "tema:";
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(257, 442);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(162, 20);
            this.matricula.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "matricula:";
            // 
            // grupo
            // 
            this.grupo.Location = new System.Drawing.Point(257, 416);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(162, 20);
            this.grupo.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(196, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "grupo:";
            // 
            // idCalificacion
            // 
            this.idCalificacion.Location = new System.Drawing.Point(257, 390);
            this.idCalificacion.Name = "idCalificacion";
            this.idCalificacion.Size = new System.Drawing.Size(162, 20);
            this.idCalificacion.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "idCalificacion:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(280, 282);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "CALIFICACIONES";
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(367, 80);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(280, 282);
            this.dgvGrupos.TabIndex = 54;
            this.dgvGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupos_CellDoubleClick);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(700, 80);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(280, 282);
            this.dgvAlumnos.TabIndex = 55;
            this.dgvAlumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellDoubleClick);
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1064, 669);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.dgvGrupos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tipoevaluacion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.calificacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tema);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idCalificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calificaciones";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.Calificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tipoevaluacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox calificacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox grupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idCalificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.DataGridView dgvAlumnos;
    }
}