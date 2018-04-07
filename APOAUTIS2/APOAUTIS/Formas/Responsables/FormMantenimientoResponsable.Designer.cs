namespace APOAUTIS.Formas.Responsables
{
    partial class FormMantenimientoResponsable
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.DGV_ShowResponsables = new System.Windows.Forms.DataGridView();
            this.txtBusqResp = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Pest1_Grupo_ShowAlumno = new System.Windows.Forms.GroupBox();
            this.DGV_ShowAlumnosResp = new System.Windows.Forms.DataGridView();
            this.Pest1_Grupo_DatosEncargado = new System.Windows.Forms.GroupBox();
            this.txtCorrResp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEstResp = new System.Windows.Forms.ComboBox();
            this.cmbTrabResp = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
           
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelTrabResp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelCelResp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDomResp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProfResp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelCasResp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLugResp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomResp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdResp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodResp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowResponsables)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Pest1_Grupo_ShowAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowAlumnosResp)).BeginInit();
            this.Pest1_Grupo_DatosEncargado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(684, 463);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 35);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 445);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.DGV_ShowResponsables);
            this.tabPage1.Controls.Add(this.txtBusqResp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Busqueda de Responsable";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Busqueda por nombre";
            // 
            // DGV_ShowResponsables
            // 
            this.DGV_ShowResponsables.AllowUserToAddRows = false;
            this.DGV_ShowResponsables.AllowUserToDeleteRows = false;
            this.DGV_ShowResponsables.AllowUserToResizeColumns = false;
            this.DGV_ShowResponsables.AllowUserToResizeRows = false;
            this.DGV_ShowResponsables.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_ShowResponsables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_ShowResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowResponsables.Location = new System.Drawing.Point(10, 99);
            this.DGV_ShowResponsables.MultiSelect = false;
            this.DGV_ShowResponsables.Name = "DGV_ShowResponsables";
            this.DGV_ShowResponsables.ReadOnly = true;
            this.DGV_ShowResponsables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ShowResponsables.Size = new System.Drawing.Size(746, 292);
            this.DGV_ShowResponsables.TabIndex = 28;
            this.DGV_ShowResponsables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ShowResponsables_CellDoubleClick);
            // 
            // txtBusqResp
            // 
            this.txtBusqResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqResp.Location = new System.Drawing.Point(174, 32);
            this.txtBusqResp.Name = "txtBusqResp";
            this.txtBusqResp.Size = new System.Drawing.Size(267, 20);
            this.txtBusqResp.TabIndex = 24;
            this.txtBusqResp.TextChanged += new System.EventHandler(this.txtBusqResp_TextChanged);
            this.txtBusqResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqResp_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Pest1_Grupo_ShowAlumno);
            this.tabPage2.Controls.Add(this.Pest1_Grupo_DatosEncargado);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos de Responsable";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Pest1_Grupo_ShowAlumno
            // 
            this.Pest1_Grupo_ShowAlumno.Controls.Add(this.DGV_ShowAlumnosResp);
            this.Pest1_Grupo_ShowAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Grupo_ShowAlumno.Location = new System.Drawing.Point(6, 275);
            this.Pest1_Grupo_ShowAlumno.Name = "Pest1_Grupo_ShowAlumno";
            this.Pest1_Grupo_ShowAlumno.Size = new System.Drawing.Size(755, 138);
            this.Pest1_Grupo_ShowAlumno.TabIndex = 4;
            this.Pest1_Grupo_ShowAlumno.TabStop = false;
            this.Pest1_Grupo_ShowAlumno.Text = "Alumnos bajo su cuidado";
            // 
            // DGV_ShowAlumnosResp
            // 
            this.DGV_ShowAlumnosResp.AllowUserToAddRows = false;
            this.DGV_ShowAlumnosResp.AllowUserToDeleteRows = false;
            this.DGV_ShowAlumnosResp.AllowUserToResizeColumns = false;
            this.DGV_ShowAlumnosResp.AllowUserToResizeRows = false;
            this.DGV_ShowAlumnosResp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_ShowAlumnosResp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_ShowAlumnosResp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_ShowAlumnosResp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowAlumnosResp.Location = new System.Drawing.Point(6, 19);
            this.DGV_ShowAlumnosResp.MultiSelect = false;
            this.DGV_ShowAlumnosResp.Name = "DGV_ShowAlumnosResp";
            this.DGV_ShowAlumnosResp.ReadOnly = true;
            this.DGV_ShowAlumnosResp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ShowAlumnosResp.Size = new System.Drawing.Size(743, 113);
            this.DGV_ShowAlumnosResp.TabIndex = 2;
            // 
            // Pest1_Grupo_DatosEncargado
            // 
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.txtCorrResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label12);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.cmbEstResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.cmbTrabResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.btnLimpiar);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.btnAceptar);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label7);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.txtTelTrabResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label8);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.txtTelCelResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label9);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.txtDomResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label10);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.txtProfResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label11);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.txtTelCasResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label6);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.txtLugResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label5);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label4);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.txtNomResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label3);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.txtIdResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label2);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.txtCodResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label1);
            this.Pest1_Grupo_DatosEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Grupo_DatosEncargado.Location = new System.Drawing.Point(6, 6);
            this.Pest1_Grupo_DatosEncargado.Name = "Pest1_Grupo_DatosEncargado";
            this.Pest1_Grupo_DatosEncargado.Size = new System.Drawing.Size(755, 263);
            this.Pest1_Grupo_DatosEncargado.TabIndex = 3;
            this.Pest1_Grupo_DatosEncargado.TabStop = false;
            this.Pest1_Grupo_DatosEncargado.Text = "Datos de los Encargados";
            // 
            // txtCorrResp
            // 
            this.txtCorrResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrResp.Location = new System.Drawing.Point(189, 167);
            this.txtCorrResp.MaxLength = 45;
            this.txtCorrResp.Name = "txtCorrResp";
            this.txtCorrResp.Size = new System.Drawing.Size(158, 22);
            this.txtCorrResp.TabIndex = 30;
            this.txtCorrResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorrResp_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Correo";
            // 
            // cmbEstResp
            // 
            this.cmbEstResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstResp.FormattingEnabled = true;
            this.cmbEstResp.Items.AddRange(new object[] {
            "Responsable-Activo",
            "Responsable-Inactivo"});
            this.cmbEstResp.Location = new System.Drawing.Point(539, 54);
            this.cmbEstResp.Name = "cmbEstResp";
            this.cmbEstResp.Size = new System.Drawing.Size(193, 24);
            this.cmbEstResp.TabIndex = 28;
            // 
            // cmbTrabResp
            // 
            this.cmbTrabResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrabResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrabResp.FormattingEnabled = true;
            this.cmbTrabResp.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbTrabResp.Location = new System.Drawing.Point(539, 28);
            this.cmbTrabResp.Name = "cmbTrabResp";
            this.cmbTrabResp.Size = new System.Drawing.Size(101, 24);
            this.cmbTrabResp.TabIndex = 27;
            this.cmbTrabResp.SelectedIndexChanged += new System.EventHandler(this.cmbTrabResp_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(528, 208);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 35);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(633, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 35);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Estado";
            // 
            // txtTelTrabResp
            // 
            this.txtTelTrabResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelTrabResp.Location = new System.Drawing.Point(539, 167);
            this.txtTelTrabResp.MaxLength = 11;
            this.txtTelTrabResp.Name = "txtTelTrabResp";
            this.txtTelTrabResp.Size = new System.Drawing.Size(193, 22);
            this.txtTelTrabResp.TabIndex = 21;
            this.txtTelTrabResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelTrabResp_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(384, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Telefono del trabajo";
            // 
            // txtTelCelResp
            // 
            this.txtTelCelResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCelResp.Location = new System.Drawing.Point(539, 139);
            this.txtTelCelResp.MaxLength = 11;
            this.txtTelCelResp.Name = "txtTelCelResp";
            this.txtTelCelResp.Size = new System.Drawing.Size(193, 22);
            this.txtTelCelResp.TabIndex = 19;
            this.txtTelCelResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelCelResp_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(384, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefono celular";
            // 
            // txtDomResp
            // 
            this.txtDomResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomResp.Location = new System.Drawing.Point(189, 111);
            this.txtDomResp.MaxLength = 45;
            this.txtDomResp.Name = "txtDomResp";
            this.txtDomResp.Size = new System.Drawing.Size(158, 22);
            this.txtDomResp.TabIndex = 17;
            this.txtDomResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomResp_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Domicilio";
            // 
            // txtProfResp
            // 
            this.txtProfResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfResp.Location = new System.Drawing.Point(189, 137);
            this.txtProfResp.MaxLength = 45;
            this.txtProfResp.Name = "txtProfResp";
            this.txtProfResp.Size = new System.Drawing.Size(158, 22);
            this.txtProfResp.TabIndex = 15;
            this.txtProfResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfResp_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Profesion u Oficio";
            // 
            // txtTelCasResp
            // 
            this.txtTelCasResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCasResp.Location = new System.Drawing.Point(539, 111);
            this.txtTelCasResp.MaxLength = 11;
            this.txtTelCasResp.Name = "txtTelCasResp";
            this.txtTelCasResp.Size = new System.Drawing.Size(193, 22);
            this.txtTelCasResp.TabIndex = 11;
            this.txtTelCasResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelCasResp_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono casa";
            // 
            // txtLugResp
            // 
            this.txtLugResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugResp.Location = new System.Drawing.Point(539, 83);
            this.txtLugResp.MaxLength = 45;
            this.txtLugResp.Name = "txtLugResp";
            this.txtLugResp.Size = new System.Drawing.Size(193, 22);
            this.txtLugResp.TabIndex = 9;
            this.txtLugResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLugResp_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lugar de Trabajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "¿Trabaja?";
            // 
            // txtNomResp
            // 
            this.txtNomResp.Enabled = false;
            this.txtNomResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomResp.Location = new System.Drawing.Point(189, 57);
            this.txtNomResp.MaxLength = 45;
            this.txtNomResp.Name = "txtNomResp";
            this.txtNomResp.Size = new System.Drawing.Size(158, 22);
            this.txtNomResp.TabIndex = 5;
            this.txtNomResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomResp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre completo";
            // 
            // txtIdResp
            // 
            this.txtIdResp.Enabled = false;
            this.txtIdResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdResp.Location = new System.Drawing.Point(189, 83);
            this.txtIdResp.MaxLength = 13;
            this.txtIdResp.Name = "txtIdResp";
            this.txtIdResp.Size = new System.Drawing.Size(158, 22);
            this.txtIdResp.TabIndex = 3;
            this.txtIdResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdResp_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de ID";
            // 
            // txtCodResp
            // 
            this.txtCodResp.Enabled = false;
            this.txtCodResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodResp.Location = new System.Drawing.Point(189, 32);
            this.txtCodResp.MaxLength = 10;
            this.txtCodResp.Name = "txtCodResp";
            this.txtCodResp.Size = new System.Drawing.Size(98, 22);
            this.txtCodResp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // FormMantenimientoResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(803, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMantenimientoResponsable";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mantenimiento de Responsable";
            this.Load += new System.EventHandler(this.FormMantenimientoResponsable_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowResponsables)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.Pest1_Grupo_ShowAlumno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowAlumnosResp)).EndInit();
            this.Pest1_Grupo_DatosEncargado.ResumeLayout(false);
            this.Pest1_Grupo_DatosEncargado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox Pest1_Grupo_ShowAlumno;
        private System.Windows.Forms.DataGridView DGV_ShowAlumnosResp;
        private System.Windows.Forms.GroupBox Pest1_Grupo_DatosEncargado;
        private System.Windows.Forms.ComboBox cmbEstResp;
        private System.Windows.Forms.ComboBox cmbTrabResp;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtCodResp;
        public System.Windows.Forms.TextBox txtTelTrabResp;
        public System.Windows.Forms.TextBox txtTelCelResp;
        public System.Windows.Forms.TextBox txtDomResp;
        public System.Windows.Forms.TextBox txtProfResp;
        public System.Windows.Forms.TextBox txtTelCasResp;
        public System.Windows.Forms.TextBox txtLugResp;
        public System.Windows.Forms.TextBox txtNomResp;
        public System.Windows.Forms.TextBox txtIdResp;
        public System.Windows.Forms.TextBox txtCorrResp;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtBusqResp;
        public System.Windows.Forms.DataGridView DGV_ShowResponsables;
    }
}