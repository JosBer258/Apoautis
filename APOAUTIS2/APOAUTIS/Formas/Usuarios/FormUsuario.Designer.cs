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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.Bttn_Out = new System.Windows.Forms.Button();
            this.DGV_Data = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rad_New = new System.Windows.Forms.RadioButton();
            this.Rad_Update = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Estado = new System.Windows.Forms.ComboBox();
            this.Bttn_OK = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Bttn_Clean = new System.Windows.Forms.Button();
            this.Txt_CodUser = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Txt_NameUser = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Txt_PasdUser = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Data)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bttn_Out
            // 
            this.Bttn_Out.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Bttn_Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bttn_Out.BackgroundImage")));
            this.Bttn_Out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bttn_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bttn_Out.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Bttn_Out.Location = new System.Drawing.Point(14, -4);
            this.Bttn_Out.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Bttn_Out.Name = "Bttn_Out";
            this.Bttn_Out.Size = new System.Drawing.Size(98, 94);
            this.Bttn_Out.TabIndex = 121;
            this.Bttn_Out.UseVisualStyleBackColor = false;
            this.Bttn_Out.Click += new System.EventHandler(this.Bttn_Out_Click);
            // 
            // DGV_Data
            // 
            this.DGV_Data.AllowUserToAddRows = false;
            this.DGV_Data.AllowUserToDeleteRows = false;
            this.DGV_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Data.EnableHeadersVisualStyles = false;
            this.DGV_Data.Location = new System.Drawing.Point(14, 18);
            this.DGV_Data.Name = "DGV_Data";
            this.DGV_Data.ReadOnly = true;
            this.DGV_Data.Size = new System.Drawing.Size(1017, 277);
            this.DGV_Data.TabIndex = 124;
            this.DGV_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Data_CellContentClick);
            this.DGV_Data.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Data_CellContentDoubleClick);
            this.DGV_Data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Data_CellDoubleClick);
            this.DGV_Data.SelectionChanged += new System.EventHandler(this.DGV_Data_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rad_New);
            this.groupBox2.Controls.Add(this.Rad_Update);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(170, 163);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // Rad_New
            // 
            this.Rad_New.AutoSize = true;
            this.Rad_New.Location = new System.Drawing.Point(22, 83);
            this.Rad_New.Name = "Rad_New";
            this.Rad_New.Size = new System.Drawing.Size(106, 52);
            this.Rad_New.TabIndex = 1;
            this.Rad_New.TabStop = true;
            this.Rad_New.Text = "Agregar un \r\nNuevo\r\nUsuario\r\n";
            this.Rad_New.UseVisualStyleBackColor = true;
            this.Rad_New.CheckedChanged += new System.EventHandler(this.Rad_New_CheckedChanged);
            // 
            // Rad_Update
            // 
            this.Rad_Update.AutoSize = true;
            this.Rad_Update.Location = new System.Drawing.Point(22, 32);
            this.Rad_Update.Name = "Rad_Update";
            this.Rad_Update.Size = new System.Drawing.Size(137, 36);
            this.Rad_Update.TabIndex = 0;
            this.Rad_Update.TabStop = true;
            this.Rad_Update.Text = "Actualizar datos\r\nde Usuario";
            this.Rad_Update.UseVisualStyleBackColor = true;
            this.Rad_Update.CheckedChanged += new System.EventHandler(this.Rad_Update_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(194, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(635, 163);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 119;
            this.label1.Text = "Estado";
            // 
            // Cmb_Estado
            // 
            this.Cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Estado.FormattingEnabled = true;
            this.Cmb_Estado.Location = new System.Drawing.Point(156, 119);
            this.Cmb_Estado.Name = "Cmb_Estado";
            this.Cmb_Estado.Size = new System.Drawing.Size(248, 23);
            this.Cmb_Estado.TabIndex = 118;
            this.Cmb_Estado.SelectedIndexChanged += new System.EventHandler(this.Cmb_Estado_SelectedIndexChanged);
            // 
            // Bttn_OK
            // 
            this.Bttn_OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bttn_OK.BackgroundImage")));
            this.Bttn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bttn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bttn_OK.ForeColor = System.Drawing.SystemColors.Control;
            this.Bttn_OK.Location = new System.Drawing.Point(532, 36);
            this.Bttn_OK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Bttn_OK.Name = "Bttn_OK";
            this.Bttn_OK.Size = new System.Drawing.Size(98, 94);
            this.Bttn_OK.TabIndex = 117;
            this.Bttn_OK.UseVisualStyleBackColor = true;
            this.Bttn_OK.Click += new System.EventHandler(this.Bttn_OK_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 15);
            this.label9.TabIndex = 114;
            this.label9.Text = "Codigo de usuario";
            // 
            // Bttn_Clean
            // 
            this.Bttn_Clean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bttn_Clean.BackgroundImage")));
            this.Bttn_Clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bttn_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bttn_Clean.ForeColor = System.Drawing.SystemColors.Control;
            this.Bttn_Clean.Location = new System.Drawing.Point(429, 36);
            this.Bttn_Clean.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Bttn_Clean.Name = "Bttn_Clean";
            this.Bttn_Clean.Size = new System.Drawing.Size(98, 94);
            this.Bttn_Clean.TabIndex = 116;
            this.Bttn_Clean.UseVisualStyleBackColor = true;
            this.Bttn_Clean.Click += new System.EventHandler(this.Bttn_Clean_Click);
            // 
            // Txt_CodUser
            // 
            this.Txt_CodUser.Enabled = false;
            this.Txt_CodUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodUser.Location = new System.Drawing.Point(156, 39);
            this.Txt_CodUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txt_CodUser.Name = "Txt_CodUser";
            this.Txt_CodUser.ReadOnly = true;
            this.Txt_CodUser.Size = new System.Drawing.Size(248, 21);
            this.Txt_CodUser.TabIndex = 115;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(11, 69);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 15);
            this.label20.TabIndex = 110;
            this.label20.Text = "Nombre de usuario";
            // 
            // Txt_NameUser
            // 
            this.Txt_NameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NameUser.Location = new System.Drawing.Point(156, 66);
            this.Txt_NameUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txt_NameUser.MaxLength = 45;
            this.Txt_NameUser.Name = "Txt_NameUser";
            this.Txt_NameUser.Size = new System.Drawing.Size(248, 21);
            this.Txt_NameUser.TabIndex = 111;
            this.Txt_NameUser.TextChanged += new System.EventHandler(this.Txt_NameUser_TextChanged);
            this.Txt_NameUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NameUser_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(11, 95);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 15);
            this.label19.TabIndex = 112;
            this.label19.Text = "Contraseña";
            // 
            // Txt_PasdUser
            // 
            this.Txt_PasdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PasdUser.Location = new System.Drawing.Point(156, 92);
            this.Txt_PasdUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txt_PasdUser.MaxLength = 20;
            this.Txt_PasdUser.Name = "Txt_PasdUser";
            this.Txt_PasdUser.Size = new System.Drawing.Size(248, 21);
            this.Txt_PasdUser.TabIndex = 113;
            this.Txt_PasdUser.UseSystemPasswordChar = true;
            this.Txt_PasdUser.TextChanged += new System.EventHandler(this.Txt_PasdUser_TextChanged);
            this.Txt_PasdUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PasdUser_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.DGV_Data);
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 298);
            this.panel2.TabIndex = 126;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Bttn_Out);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 113);
            this.panel1.TabIndex = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 120;
            this.label2.Text = "Limpiar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 121;
            this.label3.Text = "Aceptar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 122;
            this.label4.Text = "Salir";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1042, 597);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}