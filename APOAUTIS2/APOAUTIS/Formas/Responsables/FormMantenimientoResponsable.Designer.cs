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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantenimientoResponsable));
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGV_ShowResponsables = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Pest1_Grupo_DatosEncargado = new System.Windows.Forms.GroupBox();
            this.cmbParentesco = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCorrResp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEstResp = new System.Windows.Forms.ComboBox();
            this.cmbTrabResp = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Pest1_Txt_TelefonoTrabajo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Pest1_Txt_Celular = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Pest1_Txt_Domicilio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Pest1_Txt_Profesion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Pest1_Txt_TelefonoCasa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pest1_Txt_LugarTrabajo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pest1_Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pest1_Txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pest1_Txt_Cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pest1_DGV_ShowResponsables)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Pest1_Grupo_DatosEncargado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bttn_Salir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(16, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 96);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 430);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGV_ShowResponsables);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1005, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Busqueda de Responsable";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGV_ShowResponsables
            // 
            this.DGV_ShowResponsables.AllowUserToAddRows = false;
            this.DGV_ShowResponsables.AllowUserToDeleteRows = false;
            this.DGV_ShowResponsables.AllowUserToResizeColumns = false;
            this.DGV_ShowResponsables.AllowUserToResizeRows = false;
            this.DGV_ShowResponsables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_ShowResponsables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ShowResponsables.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV_ShowResponsables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_ShowResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowResponsables.Location = new System.Drawing.Point(22, 22);
            this.DGV_ShowResponsables.MultiSelect = false;
            this.DGV_ShowResponsables.Name = "DGV_ShowResponsables";
            this.DGV_ShowResponsables.ReadOnly = true;
            this.DGV_ShowResponsables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ShowResponsables.Size = new System.Drawing.Size(959, 362);
            this.DGV_ShowResponsables.TabIndex = 28;
            this.DGV_ShowResponsables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ShowResponsables_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Pest1_Grupo_DatosEncargado);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1005, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos del responsable";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Pest1_Grupo_DatosEncargado
            // 
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label16);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label15);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.cmbParentesco);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label13);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.txtCorrResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label12);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.cmbEstResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.cmbTrabResp);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.btnLimpiar);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.btnAceptar);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label7);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.Pest1_Txt_TelefonoTrabajo);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label8);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.Pest1_Txt_Celular);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label9);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.Pest1_Txt_Domicilio);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label10);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.Pest1_Txt_Profesion);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label11);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.Pest1_Txt_TelefonoCasa);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label6);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.Pest1_Txt_LugarTrabajo);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label5);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label4);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.Pest1_Txt_Nombre);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label3);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.Pest1_Txt_ID);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label2);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.Pest1_Txt_Cod);
            this.Pest1_Grupo_DatosEncargado.Controls.Add(this.label1);
            this.Pest1_Grupo_DatosEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Grupo_DatosEncargado.Location = new System.Drawing.Point(35, 28);
            this.Pest1_Grupo_DatosEncargado.Name = "Pest1_Grupo_DatosEncargado";
            this.Pest1_Grupo_DatosEncargado.Size = new System.Drawing.Size(949, 354);
            this.Pest1_Grupo_DatosEncargado.TabIndex = 3;
            this.Pest1_Grupo_DatosEncargado.TabStop = false;
            this.Pest1_Grupo_DatosEncargado.Text = "Datos de los Encargados";
            // 
            // cmbParentesco
            // 
            this.cmbParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParentesco.FormattingEnabled = true;
            this.cmbParentesco.Items.AddRange(new object[] {
            "Padre",
            "Madre",
            "Otro"});
            this.cmbParentesco.Location = new System.Drawing.Point(198, 203);
            this.cmbParentesco.Name = "cmbParentesco";
            this.cmbParentesco.Size = new System.Drawing.Size(193, 26);
            this.cmbParentesco.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Parentesco";
            // 
            // txtCorrResp
            // 
            this.txtCorrResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrResp.Location = new System.Drawing.Point(198, 172);
            this.txtCorrResp.MaxLength = 45;
            this.txtCorrResp.Name = "txtCorrResp";
            this.txtCorrResp.Size = new System.Drawing.Size(193, 24);
            this.txtCorrResp.TabIndex = 30;
            this.txtCorrResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorrResp_KeyPress);
            // 
            // Pest1_Cmb_Trabaja
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(34, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Correo";
            // 
            // Pest1_Txt_Edad
            // 
            this.cmbEstResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstResp.FormattingEnabled = true;
            this.cmbEstResp.Items.AddRange(new object[] {
            "Responsable-Activo",
            "Responsable-Inactivo"});
            this.cmbEstResp.Location = new System.Drawing.Point(572, 82);
            this.cmbEstResp.Name = "cmbEstResp";
            this.cmbEstResp.Size = new System.Drawing.Size(212, 26);
            this.cmbEstResp.TabIndex = 28;
            // 
            // label13
            // 
            this.cmbTrabResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrabResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrabResp.FormattingEnabled = true;
            this.cmbTrabResp.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbTrabResp.Location = new System.Drawing.Point(572, 52);
            this.cmbTrabResp.Name = "cmbTrabResp";
            this.cmbTrabResp.Size = new System.Drawing.Size(101, 26);
            this.cmbTrabResp.TabIndex = 27;
            this.cmbTrabResp.SelectedIndexChanged += new System.EventHandler(this.cmbTrabResp_SelectedIndexChanged);
            // 
            // Pest1_Bttn_Limpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiar.Location = new System.Drawing.Point(433, 189);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 96);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Pest1_Bttn_Aceptar
            // 
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Location = new System.Drawing.Point(685, 189);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 96);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Estado";
            // 
            // Pest1_Txt_TelefonoTrabajo
            // 
            this.txtTelTrabResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelTrabResp.Location = new System.Drawing.Point(198, 292);
            this.txtTelTrabResp.MaxLength = 11;
            this.txtTelTrabResp.Name = "txtTelTrabResp";
            this.txtTelTrabResp.Size = new System.Drawing.Size(193, 24);
            this.txtTelTrabResp.TabIndex = 21;
            this.txtTelTrabResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelTrabResp_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Telefono del trabajo";
            // 
            // Pest1_Txt_Celular
            // 
            this.txtTelCelResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCelResp.Location = new System.Drawing.Point(198, 264);
            this.txtTelCelResp.MaxLength = 11;
            this.txtTelCelResp.Name = "txtTelCelResp";
            this.txtTelCelResp.Size = new System.Drawing.Size(193, 24);
            this.txtTelCelResp.TabIndex = 19;
            this.txtTelCelResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelCelResp_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefono celular";
            // 
            // Pest1_Txt_Domicilio
            // 
            this.txtDomResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomResp.Location = new System.Drawing.Point(198, 116);
            this.txtDomResp.MaxLength = 45;
            this.txtDomResp.Name = "txtDomResp";
            this.txtDomResp.Size = new System.Drawing.Size(193, 24);
            this.txtDomResp.TabIndex = 17;
            this.txtDomResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomResp_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Domicilio";
            // 
            // Pest1_Txt_Profesion
            // 
            this.txtProfResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfResp.Location = new System.Drawing.Point(198, 142);
            this.txtProfResp.MaxLength = 45;
            this.txtProfResp.Name = "txtProfResp";
            this.txtProfResp.Size = new System.Drawing.Size(193, 24);
            this.txtProfResp.TabIndex = 15;
            this.txtProfResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfResp_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Profesion u Oficio";
            // 
            // Pest1_Txt_TelefonoCasa
            // 
            this.txtTelCasResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCasResp.Location = new System.Drawing.Point(198, 236);
            this.txtTelCasResp.MaxLength = 11;
            this.txtTelCasResp.Name = "txtTelCasResp";
            this.txtTelCasResp.Size = new System.Drawing.Size(193, 24);
            this.txtTelCasResp.TabIndex = 11;
            this.txtTelCasResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelCasResp_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono su casa";
            // 
            // Pest1_Txt_LugarTrabajo
            // 
            this.txtLugResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugResp.Location = new System.Drawing.Point(572, 113);
            this.txtLugResp.MaxLength = 45;
            this.txtLugResp.Name = "txtLugResp";
            this.txtLugResp.Size = new System.Drawing.Size(212, 24);
            this.txtLugResp.TabIndex = 9;
            this.txtLugResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLugResp_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lugar de Trabajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "¿Trabaja?";
            // 
            // Pest1_Txt_Nombre
            // 
            this.txtNomResp.Enabled = false;
            this.txtNomResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomResp.Location = new System.Drawing.Point(198, 60);
            this.txtNomResp.MaxLength = 45;
            this.txtNomResp.Name = "txtNomResp";
            this.txtNomResp.Size = new System.Drawing.Size(193, 24);
            this.txtNomResp.TabIndex = 5;
            this.txtNomResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomResp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre completo";
            // 
            // Pest1_Txt_ID
            // 
            this.txtIdResp.Enabled = false;
            this.txtIdResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdResp.Location = new System.Drawing.Point(198, 88);
            this.txtIdResp.MaxLength = 13;
            this.txtIdResp.Name = "txtIdResp";
            this.txtIdResp.Size = new System.Drawing.Size(193, 24);
            this.txtIdResp.TabIndex = 3;
            this.txtIdResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdResp_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de ID";
            // 
            // Pest1_Txt_Cod
            // 
            this.txtCodResp.Enabled = false;
            this.txtCodResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodResp.Location = new System.Drawing.Point(198, 32);
            this.txtCodResp.MaxLength = 10;
            this.txtCodResp.Name = "txtCodResp";
            this.txtCodResp.Size = new System.Drawing.Size(98, 24);
            this.txtCodResp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 122);
            this.panel1.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(48, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Salir";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(457, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "Limpiar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(705, 288);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "Aceptar";
            // 
            // FormMantenimientoResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1037, 570);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMantenimientoResponsable";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mantenimiento de Responsables";
            this.Load += new System.EventHandler(this.FormMantenimientoResponsable_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowResponsables)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.Pest1_Grupo_DatosEncargado.ResumeLayout(false);
            this.Pest1_Grupo_DatosEncargado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Pest1_DGV_ShowResponsables;
        private System.Windows.Forms.TextBox Pest1_Txt_FiltroBusqueda;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox Pest1_Grupo_DatosEncargado;
        private System.Windows.Forms.ComboBox Pest1_Cmb_Estado;
        private System.Windows.Forms.ComboBox Pest1_Cmb_Trabaja;
        private System.Windows.Forms.TextBox Pest1_Txt_Edad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Pest1_Bttn_Limpiar;
        private System.Windows.Forms.Button Pest1_Bttn_Aceptar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Pest1_Txt_TelefonoTrabajo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Pest1_Txt_Celular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Pest1_Txt_Domicilio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Pest1_Txt_Profesion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Pest1_Txt_TelefonoCasa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pest1_Txt_LugarTrabajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pest1_Txt_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pest1_Txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pest1_Txt_Cod;
        private System.Windows.Forms.Label label1;
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
        public System.Windows.Forms.DataGridView DGV_ShowResponsables;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbParentesco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}