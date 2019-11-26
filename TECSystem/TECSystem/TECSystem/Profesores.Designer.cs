namespace TECSystem
{
    partial class Profesores
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
            this.dtgProfesores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txttipoMem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdAcademia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProfesor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoIdProfesor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProfesores
            // 
            this.dtgProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfesores.Location = new System.Drawing.Point(37, 71);
            this.dtgProfesores.Name = "dtgProfesores";
            this.dtgProfesores.Size = new System.Drawing.Size(1014, 282);
            this.dtgProfesores.TabIndex = 3;
            this.dtgProfesores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgProfesores_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROFESORES";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(584, 606);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 34);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(420, 606);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 34);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(247, 606);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 34);
            this.btnAgregar.TabIndex = 61;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txttipoMem
            // 
            this.txttipoMem.Location = new System.Drawing.Point(160, 459);
            this.txttipoMem.Name = "txttipoMem";
            this.txttipoMem.Size = new System.Drawing.Size(162, 20);
            this.txttipoMem.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "tipo Memb";
            // 
            // txtIdAcademia
            // 
            this.txtIdAcademia.Location = new System.Drawing.Point(160, 433);
            this.txtIdAcademia.Name = "txtIdAcademia";
            this.txtIdAcademia.Size = new System.Drawing.Size(162, 20);
            this.txtIdAcademia.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "idAcademia";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(160, 407);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(162, 20);
            this.txtIdEmpleado.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "idEmpleado";
            // 
            // txtIdProfesor
            // 
            this.txtIdProfesor.Location = new System.Drawing.Point(160, 381);
            this.txtIdProfesor.Name = "txtIdProfesor";
            this.txtIdProfesor.ReadOnly = true;
            this.txtIdProfesor.Size = new System.Drawing.Size(162, 20);
            this.txtIdProfesor.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "idProfesor";
            // 
            // txtNuevoIdProfesor
            // 
            this.txtNuevoIdProfesor.Location = new System.Drawing.Point(523, 381);
            this.txtNuevoIdProfesor.Name = "txtNuevoIdProfesor";
            this.txtNuevoIdProfesor.ReadOnly = true;
            this.txtNuevoIdProfesor.Size = new System.Drawing.Size(162, 20);
            this.txtNuevoIdProfesor.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(373, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Nuevo idProfesor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(746, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 66;
            this.button1.Text = "Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 708);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNuevoIdProfesor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txttipoMem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdAcademia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdProfesor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgProfesores);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profesores";
            this.Text = "PROFESORES";
            this.Load += new System.EventHandler(this.Profesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProfesores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txttipoMem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdAcademia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProfesor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevoIdProfesor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}