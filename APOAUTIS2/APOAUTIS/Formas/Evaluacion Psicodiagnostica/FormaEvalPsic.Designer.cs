namespace APOAUTIS
{
    partial class FormaEvalPsic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaEvalPsic));
            this.DGV_Evaluaciones = new System.Windows.Forms.DataGridView();
            this.radBusqFech = new System.Windows.Forms.RadioButton();
            this.radBusqNom = new System.Windows.Forms.RadioButton();
            this.txtBusqNom = new System.Windows.Forms.TextBox();
            this.dateBusqFech = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtCodEval = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtImpDiag = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grupo_IngresoResultado = new System.Windows.Forms.GroupBox();
            this.Date_FechaEvaluacion = new System.Windows.Forms.DateTimePicker();
            this.Grupo_Busqueda = new System.Windows.Forms.GroupBox();
            this.Radio_Busq_TodasPruebas = new System.Windows.Forms.RadioButton();
            this.Busq_Txt_Observaciones_Conjunto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Busq_Txt_Diagnosti_Conjunto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Radio_Busq_ImpresionYObservaciones = new System.Windows.Forms.RadioButton();
            this.Radio_Busq_Observaciones = new System.Windows.Forms.RadioButton();
            this.Busq_Txt_Observaciones = new System.Windows.Forms.TextBox();
            this.Radio_Busq_ImpresionDiagnos = new System.Windows.Forms.RadioButton();
            this.Busq_Txt_ImpresionDiagnostica = new System.Windows.Forms.TextBox();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Evaluaciones)).BeginInit();
            this.Grupo_IngresoResultado.SuspendLayout();
            this.Grupo_Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Show
            // 
            this.DGV_Evaluaciones.AllowUserToAddRows = false;
            this.DGV_Evaluaciones.AllowUserToDeleteRows = false;
            this.DGV_Evaluaciones.AllowUserToResizeColumns = false;
            this.DGV_Evaluaciones.AllowUserToResizeRows = false;
            this.DGV_Evaluaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Evaluaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Evaluaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Evaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Evaluaciones.Location = new System.Drawing.Point(6, 166);
            this.DGV_Evaluaciones.MultiSelect = false;
            this.DGV_Evaluaciones.Name = "DGV_Evaluaciones";
            this.DGV_Evaluaciones.ReadOnly = true;
            this.DGV_Evaluaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Evaluaciones.Size = new System.Drawing.Size(1118, 344);
            this.DGV_Evaluaciones.TabIndex = 6;
            // 
            // Radio_Busq_FechaIngreso
            // 
            this.radBusqFech.AutoSize = true;
            this.radBusqFech.Location = new System.Drawing.Point(33, 117);
            this.radBusqFech.Name = "radBusqFech";
            this.radBusqFech.Size = new System.Drawing.Size(129, 30);
            this.radBusqFech.TabIndex = 5;
            this.radBusqFech.Text = "Buscar por Fecha \r\nde Evaluacion";
            this.radBusqFech.UseVisualStyleBackColor = true;
            this.radBusqFech.CheckedChanged += new System.EventHandler(this.radBusqFech_CheckedChanged);
            // 
            // Radio_Busq_Nombre
            // 
            this.radBusqNom.AutoSize = true;
            this.radBusqNom.Location = new System.Drawing.Point(34, 93);
            this.radBusqNom.Name = "radBusqNom";
            this.radBusqNom.Size = new System.Drawing.Size(133, 17);
            this.radBusqNom.TabIndex = 4;
            this.radBusqNom.Text = "Buscar por Nombre";
            this.radBusqNom.UseVisualStyleBackColor = true;
            this.radBusqNom.CheckedChanged += new System.EventHandler(this.radBusqNom_CheckedChanged);
            // 
            // Busq_Txt_Nombre
            // 
            this.txtBusqNom.Enabled = false;
            this.txtBusqNom.Location = new System.Drawing.Point(185, 92);
            this.txtBusqNom.Name = "txtBusqNom";
            this.txtBusqNom.Size = new System.Drawing.Size(173, 20);
            this.txtBusqNom.TabIndex = 1;
            this.txtBusqNom.TextChanged += new System.EventHandler(this.txtBusqNom_TextChanged);
            this.txtBusqNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqNom_KeyPress);
            // 
            // Busq_Date_FechaRealizacion
            // 
            this.dateBusqFech.Enabled = false;
            this.dateBusqFech.Location = new System.Drawing.Point(185, 120);
            this.dateBusqFech.Name = "dateBusqFech";
            this.dateBusqFech.Size = new System.Drawing.Size(174, 20);
            this.dateBusqFech.TabIndex = 0;
            this.dateBusqFech.ValueChanged += new System.EventHandler(this.dateBusqFech_ValueChanged);
            // 
            // Bttn_Ok
            // 
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Location = new System.Drawing.Point(851, 39);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 85);
            this.btnAceptar.TabIndex = 90;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.Bttn_Ok_Click);
            // 
            // Bttn_Limpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(944, 39);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 85);
            this.btnLimpiar.TabIndex = 89;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Cmb_Sexo
            // 
            this.Cmb_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Sexo.FormattingEnabled = true;
            this.Cmb_Sexo.Location = new System.Drawing.Point(600, 33);
            this.Cmb_Sexo.Name = "Cmb_Sexo";
            this.Cmb_Sexo.Size = new System.Drawing.Size(116, 21);
            this.Cmb_Sexo.TabIndex = 67;
            // 
            // Txt_CodigoEvaluacion
            // 
            this.Txt_CodigoEvaluacion.Location = new System.Drawing.Point(178, 30);
            this.Txt_CodigoEvaluacion.Name = "Txt_CodigoEvaluacion";
            this.Txt_CodigoEvaluacion.Size = new System.Drawing.Size(109, 20);
            this.Txt_CodigoEvaluacion.TabIndex = 66;
            // 
            // Txt_Observaciones
            // 
            this.Txt_Observaciones.Location = new System.Drawing.Point(600, 137);
            this.Txt_Observaciones.Name = "Txt_Observaciones";
            this.Txt_Observaciones.Size = new System.Drawing.Size(235, 20);
            this.Txt_Observaciones.TabIndex = 64;
            // 
            // Txt_ImpresionDiagnostico
            // 
            this.Txt_ImpresionDiagnostico.Location = new System.Drawing.Point(600, 111);
            this.Txt_ImpresionDiagnostico.Name = "Txt_ImpresionDiagnostico";
            this.Txt_ImpresionDiagnostico.Size = new System.Drawing.Size(235, 20);
            this.Txt_ImpresionDiagnostico.TabIndex = 62;
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(600, 85);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(235, 20);
            this.Txt_Telefono.TabIndex = 60;
            // 
            // Txt_Responsable
            // 
            this.Txt_Responsable.Location = new System.Drawing.Point(600, 59);
            this.Txt_Responsable.Name = "Txt_Responsable";
            this.Txt_Responsable.Size = new System.Drawing.Size(235, 20);
            this.Txt_Responsable.TabIndex = 58;
            // 
            // Txt_Edad
            // 
            this.txtEdad.Location = new System.Drawing.Point(177, 134);
            this.txtEdad.MaxLength = 5;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(235, 20);
            this.txtEdad.TabIndex = 54;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // Txt_FechaNacimiento
            // 
            this.Txt_FechaNacimiento.Location = new System.Drawing.Point(178, 108);
            this.Txt_FechaNacimiento.Name = "Txt_FechaNacimiento";
            this.Txt_FechaNacimiento.Size = new System.Drawing.Size(235, 20);
            this.Txt_FechaNacimiento.TabIndex = 52;
            // 
            // Txt_NombreCompleto
            // 
            this.Txt_NombreCompleto.Location = new System.Drawing.Point(178, 56);
            this.Txt_NombreCompleto.Name = "Txt_NombreCompleto";
            this.Txt_NombreCompleto.Size = new System.Drawing.Size(235, 20);
            this.Txt_NombreCompleto.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "Codigo de evaluacion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(441, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 63;
            this.label13.Text = "Observaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Impresion Diagnostica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Responsable";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Fecha de evaluacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nombre completo";
            // 
            // Grupo_IngresoResultado
            // 
            this.Grupo_IngresoResultado.Controls.Add(this.label11);
            this.Grupo_IngresoResultado.Controls.Add(this.label15);
            this.Grupo_IngresoResultado.Controls.Add(this.Bttn_Salir);
            this.Grupo_IngresoResultado.Controls.Add(this.label14);
            this.Grupo_IngresoResultado.Controls.Add(this.dateFechNac);
            this.Grupo_IngresoResultado.Controls.Add(this.dateFechEval);
            this.Grupo_IngresoResultado.Controls.Add(this.btnAceptar);
            this.Grupo_IngresoResultado.Controls.Add(this.btnLimpiar);
            this.Grupo_IngresoResultado.Controls.Add(this.txtCodEval);
            this.Grupo_IngresoResultado.Controls.Add(this.label12);
            this.Grupo_IngresoResultado.Controls.Add(this.Txt_NombreCompleto);
            this.Grupo_IngresoResultado.Controls.Add(this.Cmb_Sexo);
            this.Grupo_IngresoResultado.Controls.Add(this.label1);
            this.Grupo_IngresoResultado.Controls.Add(this.Txt_FechaNacimiento);
            this.Grupo_IngresoResultado.Controls.Add(this.Txt_Observaciones);
            this.Grupo_IngresoResultado.Controls.Add(this.label4);
            this.Grupo_IngresoResultado.Controls.Add(this.Txt_ImpresionDiagnostico);
            this.Grupo_IngresoResultado.Controls.Add(this.label2);
            this.Grupo_IngresoResultado.Controls.Add(this.Txt_Edad);
            this.Grupo_IngresoResultado.Controls.Add(this.Txt_Telefono);
            this.Grupo_IngresoResultado.Controls.Add(this.label3);
            this.Grupo_IngresoResultado.Controls.Add(this.label5);
            this.Grupo_IngresoResultado.Controls.Add(this.Txt_Responsable);
            this.Grupo_IngresoResultado.Controls.Add(this.label6);
            this.Grupo_IngresoResultado.Controls.Add(this.label8);
            this.Grupo_IngresoResultado.Controls.Add(this.label13);
            this.Grupo_IngresoResultado.Controls.Add(this.label7);
            this.Grupo_IngresoResultado.Location = new System.Drawing.Point(12, 12);
            this.Grupo_IngresoResultado.Name = "Grupo_IngresoResultado";
            this.Grupo_IngresoResultado.Size = new System.Drawing.Size(1146, 172);
            this.Grupo_IngresoResultado.TabIndex = 91;
            this.Grupo_IngresoResultado.TabStop = false;
            this.Grupo_IngresoResultado.Text = "Ingresar Resultados de Prueba";
            // 
            // Date_FechaEvaluacion
            // 
            this.Date_FechaEvaluacion.Location = new System.Drawing.Point(177, 82);
            this.Date_FechaEvaluacion.Name = "Date_FechaEvaluacion";
            this.Date_FechaEvaluacion.Size = new System.Drawing.Size(236, 20);
            this.Date_FechaEvaluacion.TabIndex = 67;
            // 
            // Grupo_Busqueda
            // 
            this.Grupo_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grupo_Busqueda.Controls.Add(this.radTodas);
            this.Grupo_Busqueda.Controls.Add(this.txtBusqOB);
            this.Grupo_Busqueda.Controls.Add(this.label10);
            this.Grupo_Busqueda.Controls.Add(this.Busq_Txt_Diagnosti_Conjunto);
            this.Grupo_Busqueda.Controls.Add(this.label9);
            this.Grupo_Busqueda.Controls.Add(this.radBusqImpObs);
            this.Grupo_Busqueda.Controls.Add(this.radObs);
            this.Grupo_Busqueda.Controls.Add(this.txtBusqObs);
            this.Grupo_Busqueda.Controls.Add(this.radImpDiag);
            this.Grupo_Busqueda.Controls.Add(this.txtBusqImpDiag);
            this.Grupo_Busqueda.Controls.Add(this.DGV_Evaluaciones);
            this.Grupo_Busqueda.Controls.Add(this.radBusqNom);
            this.Grupo_Busqueda.Controls.Add(this.txtBusqNom);
            this.Grupo_Busqueda.Controls.Add(this.dateBusqFech);
            this.Grupo_Busqueda.Controls.Add(this.radBusqFech);
            this.Grupo_Busqueda.Location = new System.Drawing.Point(12, 202);
            this.Grupo_Busqueda.Name = "Grupo_Busqueda";
            this.Grupo_Busqueda.Size = new System.Drawing.Size(1146, 535);
            this.Grupo_Busqueda.TabIndex = 92;
            this.Grupo_Busqueda.TabStop = false;
            this.Grupo_Busqueda.Text = "Opciones de Busqueda";
            // 
            // Radio_Busq_TodasPruebas
            // 
            this.radTodas.AutoSize = true;
            this.radTodas.Checked = true;
            this.radTodas.Location = new System.Drawing.Point(472, 35);
            this.radTodas.Name = "radTodas";
            this.radTodas.Size = new System.Drawing.Size(159, 17);
            this.radTodas.TabIndex = 16;
            this.radTodas.TabStop = true;
            this.radTodas.Text = "Todas las evaluaciones";
            this.radTodas.UseVisualStyleBackColor = true;
            this.radTodas.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // Busq_Txt_Observaciones_Conjunto
            // 
            this.txtBusqOB.Enabled = false;
            this.txtBusqOB.Location = new System.Drawing.Point(628, 105);
            this.txtBusqOB.Name = "txtBusqOB";
            this.txtBusqOB.Size = new System.Drawing.Size(149, 20);
            this.txtBusqOB.TabIndex = 15;
            this.txtBusqOB.TextChanged += new System.EventHandler(this.txtBusqOB_TextChanged);
            this.txtBusqOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqOB_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "y Observaciones";
            // 
            // Busq_Txt_Diagnosti_Conjunto
            // 
            this.txtBusqID.Enabled = false;
            this.txtBusqID.Location = new System.Drawing.Point(628, 79);
            this.txtBusqID.Name = "txtBusqID";
            this.txtBusqID.Size = new System.Drawing.Size(149, 20);
            this.txtBusqID.TabIndex = 13;
            this.txtBusqID.TextChanged += new System.EventHandler(this.txtBusqID_TextChanged);
            this.txtBusqID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqID_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Impresion Diagnostica";
            // 
            // Radio_Busq_ImpresionYObservaciones
            // 
            this.radBusqImpObs.AutoSize = true;
            this.radBusqImpObs.Location = new System.Drawing.Point(471, 66);
            this.radBusqImpObs.Name = "radBusqImpObs";
            this.radBusqImpObs.Size = new System.Drawing.Size(103, 17);
            this.radBusqImpObs.TabIndex = 11;
            this.radBusqImpObs.Text = "Busqueda por";
            this.radBusqImpObs.UseVisualStyleBackColor = true;
            this.radBusqImpObs.CheckedChanged += new System.EventHandler(this.radBusqImpObs_CheckedChanged);
            // 
            // Radio_Busq_Observaciones
            // 
            this.radObs.AutoSize = true;
            this.radObs.Location = new System.Drawing.Point(34, 65);
            this.radObs.Name = "radObs";
            this.radObs.Size = new System.Drawing.Size(109, 17);
            this.radObs.TabIndex = 10;
            this.radObs.Text = "Observaciones";
            this.radObs.UseVisualStyleBackColor = true;
            this.radObs.CheckedChanged += new System.EventHandler(this.radObs_CheckedChanged);
            // 
            // Busq_Txt_Observaciones
            // 
            this.txtBusqObs.Enabled = false;
            this.txtBusqObs.Location = new System.Drawing.Point(185, 64);
            this.txtBusqObs.Name = "txtBusqObs";
            this.txtBusqObs.Size = new System.Drawing.Size(173, 20);
            this.txtBusqObs.TabIndex = 9;
            this.txtBusqObs.TextChanged += new System.EventHandler(this.txtBusqObs_TextChanged);
            this.txtBusqObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqObs_KeyPress);
            // 
            // Radio_Busq_ImpresionDiagnos
            // 
            this.radImpDiag.AutoSize = true;
            this.radImpDiag.Location = new System.Drawing.Point(33, 35);
            this.radImpDiag.Name = "radImpDiag";
            this.radImpDiag.Size = new System.Drawing.Size(150, 17);
            this.radImpDiag.TabIndex = 8;
            this.radImpDiag.Text = "Impresion Diagnostica";
            this.radImpDiag.UseVisualStyleBackColor = true;
            this.radImpDiag.CheckedChanged += new System.EventHandler(this.radImpDiag_CheckedChanged);
            // 
            // Busq_Txt_ImpresionDiagnostica
            // 
            this.txtBusqImpDiag.Enabled = false;
            this.txtBusqImpDiag.Location = new System.Drawing.Point(184, 34);
            this.txtBusqImpDiag.Name = "txtBusqImpDiag";
            this.txtBusqImpDiag.Size = new System.Drawing.Size(174, 20);
            this.txtBusqImpDiag.TabIndex = 7;
            this.txtBusqImpDiag.TextChanged += new System.EventHandler(this.txtBusqImpDiag_TextChanged);
            this.txtBusqImpDiag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqImpDiag_KeyPress);
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bttn_Salir.BackgroundImage")));
            this.Bttn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bttn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bttn_Salir.ForeColor = System.Drawing.SystemColors.Control;
            this.Bttn_Salir.Location = new System.Drawing.Point(1034, 36);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(87, 85);
            this.Bttn_Salir.TabIndex = 91;
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1065, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 93;
            this.label11.Text = "Salir";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(868, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "Aceptar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(967, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 93;
            this.label15.Text = "Limpiar";
            // 
            // FormaEvalPsic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 749);
            this.ControlBox = false;
            this.Controls.Add(this.Grupo_Busqueda);
            this.Controls.Add(this.Grupo_IngresoResultado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormaEvalPsic";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Evaluacion Psicodiagnostica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormaEvalPsic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Evaluaciones)).EndInit();
            this.Grupo_IngresoResultado.ResumeLayout(false);
            this.Grupo_IngresoResultado.PerformLayout();
            this.Grupo_Busqueda.ResumeLayout(false);
            this.Grupo_Busqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Show;
        private System.Windows.Forms.RadioButton Radio_Busq_FechaIngreso;
        private System.Windows.Forms.RadioButton Radio_Busq_Nombre;
        private System.Windows.Forms.TextBox Busq_Txt_Nombre;
        private System.Windows.Forms.DateTimePicker Busq_Date_FechaRealizacion;
        private System.Windows.Forms.Button Bttn_Ok;
        private System.Windows.Forms.Button Bttn_Limpiar;
        private System.Windows.Forms.ComboBox Cmb_Sexo;
        private System.Windows.Forms.TextBox Txt_CodigoEvaluacion;
        private System.Windows.Forms.TextBox Txt_Observaciones;
        private System.Windows.Forms.TextBox Txt_ImpresionDiagnostico;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.TextBox Txt_Responsable;
        private System.Windows.Forms.TextBox Txt_Edad;
        private System.Windows.Forms.TextBox Txt_FechaNacimiento;
        private System.Windows.Forms.TextBox Txt_NombreCompleto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Grupo_IngresoResultado;
        private System.Windows.Forms.DateTimePicker Date_FechaEvaluacion;
        private System.Windows.Forms.GroupBox Grupo_Busqueda;
        private System.Windows.Forms.RadioButton Radio_Busq_TodasPruebas;
        private System.Windows.Forms.TextBox Busq_Txt_Observaciones_Conjunto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Busq_Txt_Diagnosti_Conjunto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton Radio_Busq_ImpresionYObservaciones;
        private System.Windows.Forms.RadioButton Radio_Busq_Observaciones;
        private System.Windows.Forms.TextBox Busq_Txt_Observaciones;
        private System.Windows.Forms.RadioButton Radio_Busq_ImpresionDiagnos;
        private System.Windows.Forms.TextBox Busq_Txt_ImpresionDiagnostica;
        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.DateTimePicker dateFechNac;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
    }
}