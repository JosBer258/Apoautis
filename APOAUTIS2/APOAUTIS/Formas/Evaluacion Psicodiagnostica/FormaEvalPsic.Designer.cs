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
            this.dateFechNac = new System.Windows.Forms.DateTimePicker();
            this.dateFechEval = new System.Windows.Forms.DateTimePicker();
            this.Grupo_Busqueda = new System.Windows.Forms.GroupBox();
            this.radTodas = new System.Windows.Forms.RadioButton();
            this.txtBusqOB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBusqID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radBusqImpObs = new System.Windows.Forms.RadioButton();
            this.radObs = new System.Windows.Forms.RadioButton();
            this.txtBusqObs = new System.Windows.Forms.TextBox();
            this.radImpDiag = new System.Windows.Forms.RadioButton();
            this.txtBusqImpDiag = new System.Windows.Forms.TextBox();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Evaluaciones)).BeginInit();
            this.Grupo_IngresoResultado.SuspendLayout();
            this.Grupo_Busqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Evaluaciones
            // 
            this.DGV_Evaluaciones.AllowUserToAddRows = false;
            this.DGV_Evaluaciones.AllowUserToDeleteRows = false;
            this.DGV_Evaluaciones.AllowUserToResizeColumns = false;
            this.DGV_Evaluaciones.AllowUserToResizeRows = false;
            this.DGV_Evaluaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV_Evaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Evaluaciones.Location = new System.Drawing.Point(6, 131);
            this.DGV_Evaluaciones.MultiSelect = false;
            this.DGV_Evaluaciones.Name = "DGV_Evaluaciones";
            this.DGV_Evaluaciones.ReadOnly = true;
            this.DGV_Evaluaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Evaluaciones.Size = new System.Drawing.Size(829, 197);
            this.DGV_Evaluaciones.TabIndex = 6;
            // 
            // radBusqFech
            // 
            this.radBusqFech.AutoSize = true;
            this.radBusqFech.Location = new System.Drawing.Point(17, 56);
            this.radBusqFech.Name = "radBusqFech";
            this.radBusqFech.Size = new System.Drawing.Size(129, 30);
            this.radBusqFech.TabIndex = 5;
            this.radBusqFech.Text = "Buscar por Fecha \r\nde Evaluacion";
            this.radBusqFech.UseVisualStyleBackColor = true;
            this.radBusqFech.CheckedChanged += new System.EventHandler(this.radBusqFech_CheckedChanged);
            // 
            // radBusqNom
            // 
            this.radBusqNom.AutoSize = true;
            this.radBusqNom.Location = new System.Drawing.Point(16, 34);
            this.radBusqNom.Name = "radBusqNom";
            this.radBusqNom.Size = new System.Drawing.Size(133, 17);
            this.radBusqNom.TabIndex = 4;
            this.radBusqNom.Text = "Buscar por Nombre";
            this.radBusqNom.UseVisualStyleBackColor = true;
            this.radBusqNom.CheckedChanged += new System.EventHandler(this.radBusqNom_CheckedChanged);
            // 
            // txtBusqNom
            // 
            this.txtBusqNom.Enabled = false;
            this.txtBusqNom.Location = new System.Drawing.Point(152, 33);
            this.txtBusqNom.Name = "txtBusqNom";
            this.txtBusqNom.Size = new System.Drawing.Size(169, 20);
            this.txtBusqNom.TabIndex = 1;
            this.txtBusqNom.TextChanged += new System.EventHandler(this.txtBusqNom_TextChanged);
            this.txtBusqNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqNom_KeyPress);
            // 
            // dateBusqFech
            // 
            this.dateBusqFech.Enabled = false;
            this.dateBusqFech.Location = new System.Drawing.Point(152, 59);
            this.dateBusqFech.Name = "dateBusqFech";
            this.dateBusqFech.Size = new System.Drawing.Size(170, 20);
            this.dateBusqFech.TabIndex = 0;
            this.dateBusqFech.ValueChanged += new System.EventHandler(this.dateBusqFech_ValueChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(717, 176);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 40);
            this.btnAceptar.TabIndex = 90;
            this.btnAceptar.Text = "Ingresar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.Bttn_Ok_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(573, 176);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 40);
            this.btnLimpiar.TabIndex = 89;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(600, 33);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(116, 21);
            this.cmbSexo.TabIndex = 67;
            // 
            // txtCodEval
            // 
            this.txtCodEval.Enabled = false;
            this.txtCodEval.Location = new System.Drawing.Point(178, 30);
            this.txtCodEval.MaxLength = 10;
            this.txtCodEval.Name = "txtCodEval";
            this.txtCodEval.Size = new System.Drawing.Size(109, 20);
            this.txtCodEval.TabIndex = 66;
            this.txtCodEval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodEval_KeyPress);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(600, 137);
            this.txtObs.MaxLength = 45;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(235, 20);
            this.txtObs.TabIndex = 64;
            this.txtObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObs_KeyPress);
            // 
            // txtImpDiag
            // 
            this.txtImpDiag.Location = new System.Drawing.Point(600, 111);
            this.txtImpDiag.MaxLength = 45;
            this.txtImpDiag.Name = "txtImpDiag";
            this.txtImpDiag.Size = new System.Drawing.Size(235, 20);
            this.txtImpDiag.TabIndex = 62;
            this.txtImpDiag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImpDiag_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(600, 85);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(235, 20);
            this.txtTel.TabIndex = 60;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtResp
            // 
            this.txtResp.Location = new System.Drawing.Point(600, 59);
            this.txtResp.MaxLength = 45;
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(235, 20);
            this.txtResp.TabIndex = 58;
            this.txtResp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResp_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(177, 134);
            this.txtEdad.MaxLength = 5;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(235, 20);
            this.txtEdad.TabIndex = 54;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(178, 56);
            this.txtNombre.MaxLength = 45;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 20);
            this.txtNombre.TabIndex = 48;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
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
            this.Grupo_IngresoResultado.Controls.Add(this.dateFechNac);
            this.Grupo_IngresoResultado.Controls.Add(this.dateFechEval);
            this.Grupo_IngresoResultado.Controls.Add(this.btnAceptar);
            this.Grupo_IngresoResultado.Controls.Add(this.btnLimpiar);
            this.Grupo_IngresoResultado.Controls.Add(this.txtCodEval);
            this.Grupo_IngresoResultado.Controls.Add(this.label12);
            this.Grupo_IngresoResultado.Controls.Add(this.txtNombre);
            this.Grupo_IngresoResultado.Controls.Add(this.cmbSexo);
            this.Grupo_IngresoResultado.Controls.Add(this.label1);
            this.Grupo_IngresoResultado.Controls.Add(this.txtObs);
            this.Grupo_IngresoResultado.Controls.Add(this.label4);
            this.Grupo_IngresoResultado.Controls.Add(this.txtImpDiag);
            this.Grupo_IngresoResultado.Controls.Add(this.label2);
            this.Grupo_IngresoResultado.Controls.Add(this.txtEdad);
            this.Grupo_IngresoResultado.Controls.Add(this.txtTel);
            this.Grupo_IngresoResultado.Controls.Add(this.label3);
            this.Grupo_IngresoResultado.Controls.Add(this.label5);
            this.Grupo_IngresoResultado.Controls.Add(this.txtResp);
            this.Grupo_IngresoResultado.Controls.Add(this.label6);
            this.Grupo_IngresoResultado.Controls.Add(this.label8);
            this.Grupo_IngresoResultado.Controls.Add(this.label13);
            this.Grupo_IngresoResultado.Controls.Add(this.label7);
            this.Grupo_IngresoResultado.Location = new System.Drawing.Point(12, 12);
            this.Grupo_IngresoResultado.Name = "Grupo_IngresoResultado";
            this.Grupo_IngresoResultado.Size = new System.Drawing.Size(841, 222);
            this.Grupo_IngresoResultado.TabIndex = 91;
            this.Grupo_IngresoResultado.TabStop = false;
            this.Grupo_IngresoResultado.Text = "Ingresar Resultados de Evaluacion";
            // 
            // dateFechNac
            // 
            this.dateFechNac.Location = new System.Drawing.Point(177, 108);
            this.dateFechNac.Name = "dateFechNac";
            this.dateFechNac.Size = new System.Drawing.Size(236, 20);
            this.dateFechNac.TabIndex = 91;
            // 
            // dateFechEval
            // 
            this.dateFechEval.CustomFormat = "yyyy-MM-dd";
            this.dateFechEval.Location = new System.Drawing.Point(177, 82);
            this.dateFechEval.Name = "dateFechEval";
            this.dateFechEval.Size = new System.Drawing.Size(236, 20);
            this.dateFechEval.TabIndex = 67;
            // 
            // Grupo_Busqueda
            // 
            this.Grupo_Busqueda.Controls.Add(this.radTodas);
            this.Grupo_Busqueda.Controls.Add(this.txtBusqOB);
            this.Grupo_Busqueda.Controls.Add(this.label10);
            this.Grupo_Busqueda.Controls.Add(this.txtBusqID);
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
            this.Grupo_Busqueda.Location = new System.Drawing.Point(12, 252);
            this.Grupo_Busqueda.Name = "Grupo_Busqueda";
            this.Grupo_Busqueda.Size = new System.Drawing.Size(841, 334);
            this.Grupo_Busqueda.TabIndex = 92;
            this.Grupo_Busqueda.TabStop = false;
            this.Grupo_Busqueda.Text = "Opciones de Busqueda";
            // 
            // radTodas
            // 
            this.radTodas.AutoSize = true;
            this.radTodas.Checked = true;
            this.radTodas.Location = new System.Drawing.Point(648, 34);
            this.radTodas.Name = "radTodas";
            this.radTodas.Size = new System.Drawing.Size(159, 17);
            this.radTodas.TabIndex = 16;
            this.radTodas.TabStop = true;
            this.radTodas.Text = "Todas las evaluaciones";
            this.radTodas.UseVisualStyleBackColor = true;
            this.radTodas.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // txtBusqOB
            // 
            this.txtBusqOB.Enabled = false;
            this.txtBusqOB.Location = new System.Drawing.Point(468, 94);
            this.txtBusqOB.Name = "txtBusqOB";
            this.txtBusqOB.Size = new System.Drawing.Size(162, 20);
            this.txtBusqOB.TabIndex = 15;
            this.txtBusqOB.TextChanged += new System.EventHandler(this.txtBusqOB_TextChanged);
            this.txtBusqOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqOB_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "y Observaciones";
            // 
            // txtBusqID
            // 
            this.txtBusqID.Enabled = false;
            this.txtBusqID.Location = new System.Drawing.Point(250, 93);
            this.txtBusqID.Name = "txtBusqID";
            this.txtBusqID.Size = new System.Drawing.Size(105, 20);
            this.txtBusqID.TabIndex = 13;
            this.txtBusqID.TextChanged += new System.EventHandler(this.txtBusqID_TextChanged);
            this.txtBusqID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqID_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(112, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Impresion Diagnostica";
            // 
            // radBusqImpObs
            // 
            this.radBusqImpObs.AutoSize = true;
            this.radBusqImpObs.Location = new System.Drawing.Point(12, 94);
            this.radBusqImpObs.Name = "radBusqImpObs";
            this.radBusqImpObs.Size = new System.Drawing.Size(103, 17);
            this.radBusqImpObs.TabIndex = 11;
            this.radBusqImpObs.Text = "Busqueda por";
            this.radBusqImpObs.UseVisualStyleBackColor = true;
            this.radBusqImpObs.CheckedChanged += new System.EventHandler(this.radBusqImpObs_CheckedChanged);
            // 
            // radObs
            // 
            this.radObs.AutoSize = true;
            this.radObs.Location = new System.Drawing.Point(340, 60);
            this.radObs.Name = "radObs";
            this.radObs.Size = new System.Drawing.Size(109, 17);
            this.radObs.TabIndex = 10;
            this.radObs.Text = "Observaciones";
            this.radObs.UseVisualStyleBackColor = true;
            this.radObs.CheckedChanged += new System.EventHandler(this.radObs_CheckedChanged);
            // 
            // txtBusqObs
            // 
            this.txtBusqObs.Enabled = false;
            this.txtBusqObs.Location = new System.Drawing.Point(491, 59);
            this.txtBusqObs.Name = "txtBusqObs";
            this.txtBusqObs.Size = new System.Drawing.Size(139, 20);
            this.txtBusqObs.TabIndex = 9;
            this.txtBusqObs.TextChanged += new System.EventHandler(this.txtBusqObs_TextChanged);
            this.txtBusqObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqObs_KeyPress);
            // 
            // radImpDiag
            // 
            this.radImpDiag.AutoSize = true;
            this.radImpDiag.Location = new System.Drawing.Point(339, 32);
            this.radImpDiag.Name = "radImpDiag";
            this.radImpDiag.Size = new System.Drawing.Size(150, 17);
            this.radImpDiag.TabIndex = 8;
            this.radImpDiag.Text = "Impresion Diagnostica";
            this.radImpDiag.UseVisualStyleBackColor = true;
            this.radImpDiag.CheckedChanged += new System.EventHandler(this.radImpDiag_CheckedChanged);
            // 
            // txtBusqImpDiag
            // 
            this.txtBusqImpDiag.Enabled = false;
            this.txtBusqImpDiag.Location = new System.Drawing.Point(490, 31);
            this.txtBusqImpDiag.Name = "txtBusqImpDiag";
            this.txtBusqImpDiag.Size = new System.Drawing.Size(140, 20);
            this.txtBusqImpDiag.TabIndex = 7;
            this.txtBusqImpDiag.TextChanged += new System.EventHandler(this.txtBusqImpDiag_TextChanged);
            this.txtBusqImpDiag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqImpDiag_KeyPress);
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Location = new System.Drawing.Point(729, 592);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(118, 40);
            this.Bttn_Salir.TabIndex = 91;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormaEvalPsic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 644);
            this.ControlBox = false;
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.Grupo_Busqueda);
            this.Controls.Add(this.Grupo_IngresoResultado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormaEvalPsic";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Evaluacion Psicodiagnostica";
            this.Load += new System.EventHandler(this.FormaEvalPsic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Evaluaciones)).EndInit();
            this.Grupo_IngresoResultado.ResumeLayout(false);
            this.Grupo_IngresoResultado.PerformLayout();
            this.Grupo_Busqueda.ResumeLayout(false);
            this.Grupo_Busqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Evaluaciones;
        private System.Windows.Forms.RadioButton radBusqFech;
        private System.Windows.Forms.RadioButton radBusqNom;
        private System.Windows.Forms.TextBox txtBusqNom;
        private System.Windows.Forms.DateTimePicker dateBusqFech;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtCodEval;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtImpDiag;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
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
        private System.Windows.Forms.DateTimePicker dateFechEval;
        private System.Windows.Forms.GroupBox Grupo_Busqueda;
        private System.Windows.Forms.RadioButton radTodas;
        private System.Windows.Forms.TextBox txtBusqOB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBusqID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radBusqImpObs;
        private System.Windows.Forms.RadioButton radObs;
        private System.Windows.Forms.TextBox txtBusqObs;
        private System.Windows.Forms.RadioButton radImpDiag;
        private System.Windows.Forms.TextBox txtBusqImpDiag;
        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.DateTimePicker dateFechNac;
    }
}