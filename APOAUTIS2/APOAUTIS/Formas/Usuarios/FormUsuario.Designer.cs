namespace APOAUTIS.Formas.Usuarios
{
    partial class FormUsuario
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
            this.Bttn_Out = new System.Windows.Forms.Button();
            this.DGV_Data = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rad_New = new System.Windows.Forms.RadioButton();
            this.Rad_Update = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bttn_OK = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Bttn_Clean = new System.Windows.Forms.Button();
            this.Txt_CodUser = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Txt_NameUser = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Txt_PasdUser = new System.Windows.Forms.TextBox();
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bttn_Out
            // 
            this.Bttn_Out.Location = new System.Drawing.Point(462, 372);
            this.Bttn_Out.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Bttn_Out.Name = "Bttn_Out";
            this.Bttn_Out.Size = new System.Drawing.Size(103, 33);
            this.Bttn_Out.TabIndex = 121;
            this.Bttn_Out.Text = "Salir";
            this.Bttn_Out.UseVisualStyleBackColor = true;
            this.Bttn_Out.Click += new System.EventHandler(this.Bttn_Out_Click);
            // 
            // DGV_Data
            // 
            this.DGV_Data.AllowUserToAddRows = false;
            this.DGV_Data.AllowUserToDeleteRows = false;
            this.DGV_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Data.Location = new System.Drawing.Point(14, 155);
            this.DGV_Data.Name = "DGV_Data";
            this.DGV_Data.ReadOnly = true;
            this.DGV_Data.Size = new System.Drawing.Size(551, 201);
            this.DGV_Data.TabIndex = 124;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rad_New);
            this.groupBox2.Controls.Add(this.Rad_Update);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(131, 138);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // Rad_New
            // 
            this.Rad_New.AutoSize = true;
            this.Rad_New.Location = new System.Drawing.Point(8, 74);
            this.Rad_New.Name = "Rad_New";
            this.Rad_New.Size = new System.Drawing.Size(91, 43);
            this.Rad_New.TabIndex = 1;
            this.Rad_New.TabStop = true;
            this.Rad_New.Text = "Agregar un \r\nNuevo\r\nUsuario\r\n";
            this.Rad_New.UseVisualStyleBackColor = true;
            // 
            // Rad_Update
            // 
            this.Rad_Update.AutoSize = true;
            this.Rad_Update.Location = new System.Drawing.Point(8, 27);
            this.Rad_Update.Name = "Rad_Update";
            this.Rad_Update.Size = new System.Drawing.Size(116, 30);
            this.Rad_Update.TabIndex = 0;
            this.Rad_Update.TabStop = true;
            this.Rad_Update.Text = "Actualizar datos\r\nde Usuario";
            this.Rad_Update.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cmb_Estado);
            this.groupBox1.Controls.Add(this.Bttn_OK);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Bttn_Clean);
            this.groupBox1.Controls.Add(this.Txt_CodUser);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.Txt_NameUser);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.Txt_PasdUser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(155, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(410, 138);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Bttn_OK
            // 
            this.Bttn_OK.Location = new System.Drawing.Point(298, 89);
            this.Bttn_OK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Bttn_OK.Name = "Bttn_OK";
            this.Bttn_OK.Size = new System.Drawing.Size(103, 32);
            this.Bttn_OK.TabIndex = 117;
            this.Bttn_OK.Text = "OK";
            this.Bttn_OK.UseVisualStyleBackColor = true;
            this.Bttn_OK.Click += new System.EventHandler(this.Bttn_OK_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 114;
            this.label9.Text = "Codigo de usuario";
            // 
            // Bttn_Clean
            // 
            this.Bttn_Clean.Location = new System.Drawing.Point(298, 37);
            this.Bttn_Clean.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Bttn_Clean.Name = "Bttn_Clean";
            this.Bttn_Clean.Size = new System.Drawing.Size(103, 32);
            this.Bttn_Clean.TabIndex = 116;
            this.Bttn_Clean.Text = "Limpiar";
            this.Bttn_Clean.UseVisualStyleBackColor = true;
            this.Bttn_Clean.Click += new System.EventHandler(this.Bttn_Clean_Click);
            // 
            // Txt_CodUser
            // 
            this.Txt_CodUser.Location = new System.Drawing.Point(130, 30);
            this.Txt_CodUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txt_CodUser.Name = "Txt_CodUser";
            this.Txt_CodUser.ReadOnly = true;
            this.Txt_CodUser.Size = new System.Drawing.Size(143, 20);
            this.Txt_CodUser.TabIndex = 115;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 58);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 13);
            this.label20.TabIndex = 110;
            this.label20.Text = "Nombre de usuario";
            // 
            // Txt_NameUser
            // 
            this.Txt_NameUser.Location = new System.Drawing.Point(130, 55);
            this.Txt_NameUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txt_NameUser.Name = "Txt_NameUser";
            this.Txt_NameUser.Size = new System.Drawing.Size(143, 20);
            this.Txt_NameUser.TabIndex = 111;
            this.Txt_NameUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NameUser_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 83);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 112;
            this.label19.Text = "Contraseña";
            // 
            // Txt_PasdUser
            // 
            this.Txt_PasdUser.Location = new System.Drawing.Point(130, 80);
            this.Txt_PasdUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txt_PasdUser.Name = "Txt_PasdUser";
            this.Txt_PasdUser.Size = new System.Drawing.Size(143, 20);
            this.Txt_PasdUser.TabIndex = 113;
            this.Txt_PasdUser.UseSystemPasswordChar = true;
            this.Txt_PasdUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PasdUser_KeyPress);
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Location = new System.Drawing.Point(130, 105);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(143, 21);
            this.Cmb_Estado.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 119;
            this.label1.Text = "Estado";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(579, 415);
            this.ControlBox = false;
            this.Controls.Add(this.Bttn_Out);
            this.Controls.Add(this.DGV_Data);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormUsuario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bttn_Out;
        private System.Windows.Forms.DataGridView DGV_Data;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rad_New;
        private System.Windows.Forms.RadioButton Rad_Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Bttn_OK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Bttn_Clean;
        private System.Windows.Forms.TextBox Txt_CodUser;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Txt_NameUser;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Txt_PasdUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Estado;
    }
}