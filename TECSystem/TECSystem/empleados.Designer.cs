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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbEmpleo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbMunicipio = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbTipoLocalidad = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEdoCivil = new System.Windows.Forms.ComboBox();
            this.cbDiscapacidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAcademia = new System.Windows.Forms.ComboBox();
            this.txtIDProfesor = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbTipoMemb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgempleados
            // 
            this.dtgempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgempleados.Location = new System.Drawing.Point(39, 72);
            this.dtgempleados.Name = "dtgempleados";
            this.dtgempleados.Size = new System.Drawing.Size(371, 267);
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
            // cbEmpleo
            // 
            this.cbEmpleo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleo.FormattingEnabled = true;
            this.cbEmpleo.Location = new System.Drawing.Point(439, 385);
            this.cbEmpleo.Name = "cbEmpleo";
            this.cbEmpleo.Size = new System.Drawing.Size(162, 21);
            this.cbEmpleo.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(438, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 81;
            this.label2.Text = "Nombre(s):";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(441, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 82;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(653, 72);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(160, 20);
            this.txtPaterno.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(650, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "A. Paterno:";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(866, 72);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(160, 20);
            this.txtMaterno.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(861, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 85;
            this.label6.Text = "A. Materno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(437, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 87;
            this.label7.Text = "Fecha de nac:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(440, 143);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(160, 20);
            this.dtpFechaNac.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(650, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 89;
            this.label8.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbSexo.Location = new System.Drawing.Point(653, 143);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(160, 21);
            this.cbSexo.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(863, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 91;
            this.label9.Text = "CURP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(437, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 93;
            this.label10.Text = "Teléfono:";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(864, 144);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(160, 20);
            this.txtCurp.TabIndex = 95;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(441, 206);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(160, 20);
            this.txtTelefono.TabIndex = 96;
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(864, 331);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(63, 20);
            this.txtExt.TabIndex = 98;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(860, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 97;
            this.label11.Text = "Num Ext:";
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(961, 331);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(63, 20);
            this.txtInt.TabIndex = 100;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(957, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 99;
            this.label12.Text = "Num Int:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(649, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 101;
            this.label13.Text = "Estado civil:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(860, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 15);
            this.label14.TabIndex = 103;
            this.label14.Text = "Discapacidad:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(441, 270);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(160, 21);
            this.cbEstado.TabIndex = 106;
            this.cbEstado.SelectionChangeCommitted += new System.EventHandler(this.CbEstado_SelectionChangeCommitted);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(438, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 15);
            this.label15.TabIndex = 105;
            this.label15.Text = "Estado:";
            // 
            // cbMunicipio
            // 
            this.cbMunicipio.FormattingEnabled = true;
            this.cbMunicipio.Location = new System.Drawing.Point(652, 270);
            this.cbMunicipio.Name = "cbMunicipio";
            this.cbMunicipio.Size = new System.Drawing.Size(160, 21);
            this.cbMunicipio.TabIndex = 108;
            this.cbMunicipio.SelectionChangeCommitted += new System.EventHandler(this.CbMunicipio_SelectionChangeCommitted);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(649, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 15);
            this.label16.TabIndex = 107;
            this.label16.Text = "Municipio:";
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(863, 270);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(160, 21);
            this.cbLocalidad.TabIndex = 110;
            this.cbLocalidad.SelectionChangeCommitted += new System.EventHandler(this.CbLocalidad_SelectionChangeCommitted);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(860, 252);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 15);
            this.label17.TabIndex = 109;
            this.label17.Text = "Localidad:";
            // 
            // cbTipoLocalidad
            // 
            this.cbTipoLocalidad.FormattingEnabled = true;
            this.cbTipoLocalidad.Location = new System.Drawing.Point(440, 330);
            this.cbTipoLocalidad.Name = "cbTipoLocalidad";
            this.cbTipoLocalidad.Size = new System.Drawing.Size(160, 21);
            this.cbTipoLocalidad.TabIndex = 112;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(437, 312);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 15);
            this.label18.TabIndex = 111;
            this.label18.Text = "Tipo Localidad:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(652, 331);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(160, 20);
            this.txtCalle.TabIndex = 114;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(648, 313);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 15);
            this.label19.TabIndex = 113;
            this.label19.Text = "Calle:";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(914, 375);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(63, 20);
            this.txtCP.TabIndex = 116;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(910, 357);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 15);
            this.label20.TabIndex = 115;
            this.label20.Text = "CP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(436, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 117;
            this.label4.Text = "Empleo:";
            // 
            // cbEdoCivil
            // 
            this.cbEdoCivil.FormattingEnabled = true;
            this.cbEdoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado"});
            this.cbEdoCivil.Location = new System.Drawing.Point(651, 206);
            this.cbEdoCivil.Name = "cbEdoCivil";
            this.cbEdoCivil.Size = new System.Drawing.Size(162, 21);
            this.cbEdoCivil.TabIndex = 118;
            // 
            // cbDiscapacidad
            // 
            this.cbDiscapacidad.FormattingEnabled = true;
            this.cbDiscapacidad.Items.AddRange(new object[] {
            "Ninguna",
            "Auditiva",
            "Visual",
            "Intelectual",
            "Visceral",
            "Motriz"});
            this.cbDiscapacidad.Location = new System.Drawing.Point(863, 206);
            this.cbDiscapacidad.Name = "cbDiscapacidad";
            this.cbDiscapacidad.Size = new System.Drawing.Size(162, 21);
            this.cbDiscapacidad.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(436, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 123;
            this.label3.Text = "Academia:";
            // 
            // cbAcademia
            // 
            this.cbAcademia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcademia.FormattingEnabled = true;
            this.cbAcademia.Location = new System.Drawing.Point(439, 442);
            this.cbAcademia.Name = "cbAcademia";
            this.cbAcademia.Size = new System.Drawing.Size(162, 21);
            this.cbAcademia.TabIndex = 122;
            // 
            // txtIDProfesor
            // 
            this.txtIDProfesor.Location = new System.Drawing.Point(652, 386);
            this.txtIDProfesor.Name = "txtIDProfesor";
            this.txtIDProfesor.Size = new System.Drawing.Size(160, 20);
            this.txtIDProfesor.TabIndex = 125;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(648, 368);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 15);
            this.label21.TabIndex = 124;
            this.label21.Text = "ID Profesor:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(650, 424);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 15);
            this.label22.TabIndex = 127;
            this.label22.Text = "Tipo Memb:";
            // 
            // cbTipoMemb
            // 
            this.cbTipoMemb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMemb.FormattingEnabled = true;
            this.cbTipoMemb.Items.AddRange(new object[] {
            "Miembro",
            "Vocal 2",
            "Vocal 1",
            "Secretario (a)",
            "Presidente"});
            this.cbTipoMemb.Location = new System.Drawing.Point(653, 442);
            this.cbTipoMemb.Name = "cbTipoMemb";
            this.cbTipoMemb.Size = new System.Drawing.Size(162, 21);
            this.cbTipoMemb.TabIndex = 126;
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1064, 669);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cbTipoMemb);
            this.Controls.Add(this.txtIDProfesor);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAcademia);
            this.Controls.Add(this.cbDiscapacidad);
            this.Controls.Add(this.cbEdoCivil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbTipoLocalidad);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbLocalidad);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbMunicipio);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEmpleo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cbEmpleo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbMunicipio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbTipoLocalidad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEdoCivil;
        private System.Windows.Forms.ComboBox cbDiscapacidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAcademia;
        private System.Windows.Forms.TextBox txtIDProfesor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbTipoMemb;
    }
}