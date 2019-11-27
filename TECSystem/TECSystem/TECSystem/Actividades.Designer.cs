namespace TECSystem
{
    partial class Actividades
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.btnEliminar3 = new System.Windows.Forms.Button();
            this.btnEditar3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grupo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nombre2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.descripcion2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tema = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ponderacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 282);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.fecha.Location = new System.Drawing.Point(659, 439);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(333, 30);
            this.fecha.TabIndex = 81;
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(539, 71);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(453, 282);
            this.dgvGrupos.TabIndex = 85;
            this.dgvGrupos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGrupos_CellDoubleClick);
            // 
            // btnEliminar3
            // 
            this.btnEliminar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnEliminar3.FlatAppearance.BorderSize = 0;
            this.btnEliminar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnEliminar3.ForeColor = System.Drawing.Color.White;
            this.btnEliminar3.Image = global::TECSystem.Properties.Resources.Eliminar_new_peque;
            this.btnEliminar3.Location = new System.Drawing.Point(656, 558);
            this.btnEliminar3.Name = "btnEliminar3";
            this.btnEliminar3.Size = new System.Drawing.Size(128, 49);
            this.btnEliminar3.TabIndex = 111;
            this.btnEliminar3.Text = "Eliminar";
            this.btnEliminar3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar3.UseVisualStyleBackColor = false;
            this.btnEliminar3.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnEditar3
            // 
            this.btnEditar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnEditar3.FlatAppearance.BorderSize = 0;
            this.btnEditar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar3.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnEditar3.ForeColor = System.Drawing.Color.White;
            this.btnEditar3.Image = global::TECSystem.Properties.Resources.Editar_new_peque;
            this.btnEditar3.Location = new System.Drawing.Point(461, 558);
            this.btnEditar3.Name = "btnEditar3";
            this.btnEditar3.Size = new System.Drawing.Size(128, 49);
            this.btnEditar3.TabIndex = 110;
            this.btnEditar3.Text = "Editar";
            this.btnEditar3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar3.UseVisualStyleBackColor = false;
            this.btnEditar3.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(52, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 109;
            this.label2.Text = "ACTIVIDADES";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(99, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 108;
            this.label9.Text = "Nombre:";
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnAgregar2.FlatAppearance.BorderSize = 0;
            this.btnAgregar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnAgregar2.ForeColor = System.Drawing.Color.White;
            this.btnAgregar2.Image = global::TECSystem.Properties.Resources.Agregar_new_peque;
            this.btnAgregar2.Location = new System.Drawing.Point(265, 558);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(128, 49);
            this.btnAgregar2.TabIndex = 107;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar2.UseVisualStyleBackColor = false;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(70, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 112;
            this.label1.Text = "Descripción:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(119, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 113;
            this.label10.Text = "Tema:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(535, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 23);
            this.label11.TabIndex = 114;
            this.label11.Text = "Ponderación:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(586, 445);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 23);
            this.label12.TabIndex = 115;
            this.label12.Text = "Fecha:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(586, 492);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 23);
            this.label13.TabIndex = 116;
            this.label13.Text = "Grupo:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(661, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 1);
            this.panel2.TabIndex = 118;
            // 
            // grupo
            // 
            this.grupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.grupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grupo.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.grupo.ForeColor = System.Drawing.Color.White;
            this.grupo.Location = new System.Drawing.Point(661, 492);
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(329, 23);
            this.grupo.TabIndex = 117;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(190, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 1);
            this.panel1.TabIndex = 120;
            // 
            // nombre2
            // 
            this.nombre2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.nombre2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.nombre2.ForeColor = System.Drawing.Color.White;
            this.nombre2.Location = new System.Drawing.Point(191, 396);
            this.nombre2.Name = "nombre2";
            this.nombre2.Size = new System.Drawing.Size(308, 23);
            this.nombre2.TabIndex = 119;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(190, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 1);
            this.panel3.TabIndex = 122;
            // 
            // descripcion2
            // 
            this.descripcion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.descripcion2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcion2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.descripcion2.ForeColor = System.Drawing.Color.White;
            this.descripcion2.Location = new System.Drawing.Point(191, 439);
            this.descripcion2.Name = "descripcion2";
            this.descripcion2.Size = new System.Drawing.Size(308, 23);
            this.descripcion2.TabIndex = 121;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(189, 514);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 1);
            this.panel4.TabIndex = 124;
            // 
            // tema
            // 
            this.tema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.tema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tema.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.tema.ForeColor = System.Drawing.Color.White;
            this.tema.Location = new System.Drawing.Point(190, 492);
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(310, 23);
            this.tema.TabIndex = 123;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(661, 418);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 1);
            this.panel5.TabIndex = 126;
            // 
            // ponderacion
            // 
            this.ponderacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ponderacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ponderacion.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.ponderacion.ForeColor = System.Drawing.Color.White;
            this.ponderacion.Location = new System.Drawing.Point(661, 396);
            this.ponderacion.Name = "ponderacion";
            this.ponderacion.Size = new System.Drawing.Size(329, 23);
            this.ponderacion.TabIndex = 125;
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 708);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.ponderacion);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tema);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.descripcion2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nombre2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grupo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar3);
            this.Controls.Add(this.btnEditar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAgregar2);
            this.Controls.Add(this.dgvGrupos);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Actividades";
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.Actividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Button btnEliminar3;
        private System.Windows.Forms.Button btnEditar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox grupo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nombre2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox descripcion2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tema;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox ponderacion;
    }
}