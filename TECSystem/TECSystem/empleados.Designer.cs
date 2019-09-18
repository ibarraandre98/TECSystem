namespace TECSystem
{
    partial class empleados
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
            this.dtgempleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idPersona = new System.Windows.Forms.TextBox();
            this.idEmpleo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.idEmpleado = new System.Windows.Forms.TextBox();
            this.Empleado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgempleados
            // 
            this.dtgempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgempleados.Location = new System.Drawing.Point(39, 72);
            this.dtgempleados.Name = "dtgempleados";
            this.dtgempleados.Size = new System.Drawing.Size(532, 267);
            this.dtgempleados.TabIndex = 0;
            this.dtgempleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgempleados_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLEADOS";
            // 
            // idPersona
            // 
            this.idPersona.Location = new System.Drawing.Point(179, 445);
            this.idPersona.Name = "idPersona";
            this.idPersona.Size = new System.Drawing.Size(100, 20);
            this.idPersona.TabIndex = 3;
            // 
            // idEmpleo
            // 
            this.idEmpleo.Location = new System.Drawing.Point(179, 471);
            this.idEmpleo.Name = "idEmpleo";
            this.idEmpleo.Size = new System.Drawing.Size(100, 20);
            this.idEmpleo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "idPersona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(70, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "idEmpleo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(238, 568);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(138, 34);
            this.btnAgregar.TabIndex = 75;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(564, 568);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 34);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(400, 568);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 34);
            this.btnEditar.TabIndex = 76;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // idEmpleado
            // 
            this.idEmpleado.Location = new System.Drawing.Point(179, 419);
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.Size = new System.Drawing.Size(100, 20);
            this.idEmpleado.TabIndex = 78;
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado.ForeColor = System.Drawing.Color.White;
            this.Empleado.Location = new System.Drawing.Point(56, 417);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(103, 20);
            this.Empleado.TabIndex = 79;
            this.Empleado.Text = "idEmpleado";
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1064, 669);
            this.Controls.Add(this.Empleado);
            this.Controls.Add(this.idEmpleado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idEmpleo);
            this.Controls.Add(this.idPersona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgempleados);
            this.Name = "empleados";
            this.Text = "empleados";
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgempleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgempleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idPersona;
        private System.Windows.Forms.TextBox idEmpleo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox idEmpleado;
        private System.Windows.Forms.Label Empleado;
    }
}