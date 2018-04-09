namespace APOAUTIS.Formas.Matricula
{
    partial class FormRangoMensualidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRangoMensualidad));
            this.Data_Rangos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bttn_SalarioMin_Aceptar = new System.Windows.Forms.Button();
            this.Txt_SalarioMinimoActual = new System.Windows.Forms.TextBox();
            this.Bttn_SalarioMin_Cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_Mensualidad = new System.Windows.Forms.TextBox();
            this.Txt_RangoInicial = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Bttn_Aceptar = new System.Windows.Forms.Button();
            this.Bttn_Ayuda = new System.Windows.Forms.Button();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Rangos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_Rangos
            // 
            this.Data_Rangos.AllowUserToAddRows = false;
            this.Data_Rangos.AllowUserToDeleteRows = false;
            this.Data_Rangos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_Rangos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.Data_Rangos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Rangos.Location = new System.Drawing.Point(16, 303);
            this.Data_Rangos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Data_Rangos.Name = "Data_Rangos";
            this.Data_Rangos.ReadOnly = true;
            this.Data_Rangos.Size = new System.Drawing.Size(587, 236);
            this.Data_Rangos.TabIndex = 0;
            this.Data_Rangos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Bttn_SalarioMin_Aceptar);
            this.groupBox1.Controls.Add(this.Txt_SalarioMinimoActual);
            this.groupBox1.Controls.Add(this.Bttn_SalarioMin_Cancelar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(497, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambio de valor de salario minimo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Salario minimo \r\nactual";
            // 
            // Bttn_SalarioMin_Aceptar
            // 
            this.Bttn_SalarioMin_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bttn_SalarioMin_Aceptar.BackgroundImage")));
            this.Bttn_SalarioMin_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bttn_SalarioMin_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bttn_SalarioMin_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_SalarioMin_Aceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.Bttn_SalarioMin_Aceptar.Location = new System.Drawing.Point(332, 25);
            this.Bttn_SalarioMin_Aceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bttn_SalarioMin_Aceptar.Name = "Bttn_SalarioMin_Aceptar";
            this.Bttn_SalarioMin_Aceptar.Size = new System.Drawing.Size(72, 68);
            this.Bttn_SalarioMin_Aceptar.TabIndex = 7;
            this.Bttn_SalarioMin_Aceptar.UseVisualStyleBackColor = true;
            this.Bttn_SalarioMin_Aceptar.Click += new System.EventHandler(this.Bttn_SalarioMin_Aceptar_Click);
            // 
            // Txt_SalarioMinimoActual
            // 
            this.Txt_SalarioMinimoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SalarioMinimoActual.Location = new System.Drawing.Point(162, 61);
            this.Txt_SalarioMinimoActual.Name = "Txt_SalarioMinimoActual";
            this.Txt_SalarioMinimoActual.Size = new System.Drawing.Size(142, 22);
            this.Txt_SalarioMinimoActual.TabIndex = 9;
            this.Txt_SalarioMinimoActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SalarioMinimoActual_KeyPress);
            // 
            // Bttn_SalarioMin_Cancelar
            // 
            this.Bttn_SalarioMin_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bttn_SalarioMin_Cancelar.BackgroundImage")));
            this.Bttn_SalarioMin_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bttn_SalarioMin_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bttn_SalarioMin_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_SalarioMin_Cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.Bttn_SalarioMin_Cancelar.Location = new System.Drawing.Point(407, 25);
            this.Bttn_SalarioMin_Cancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bttn_SalarioMin_Cancelar.Name = "Bttn_SalarioMin_Cancelar";
            this.Bttn_SalarioMin_Cancelar.Size = new System.Drawing.Size(72, 68);
            this.Bttn_SalarioMin_Cancelar.TabIndex = 8;
            this.Bttn_SalarioMin_Cancelar.UseVisualStyleBackColor = true;
            this.Bttn_SalarioMin_Cancelar.Click += new System.EventHandler(this.Bttn_SalarioMin_Cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Txt_Codigo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Text_Mensualidad);
            this.groupBox2.Controls.Add(this.Bttn_Aceptar);
            this.groupBox2.Controls.Add(this.Txt_RangoInicial);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar mensualidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Codigo";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Enabled = false;
            this.Txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Codigo.Location = new System.Drawing.Point(110, 79);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(104, 22);
            this.Txt_Codigo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rango Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mensualidad\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cod de \r\nCategoria\r\n";
            // 
            // Text_Mensualidad
            // 
            this.Text_Mensualidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Mensualidad.Location = new System.Drawing.Point(342, 80);
            this.Text_Mensualidad.Name = "Text_Mensualidad";
            this.Text_Mensualidad.Size = new System.Drawing.Size(137, 22);
            this.Text_Mensualidad.TabIndex = 15;
            this.Text_Mensualidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_Mensualidad_KeyPress);
            // 
            // Txt_RangoInicial
            // 
            this.Txt_RangoInicial.Enabled = false;
            this.Txt_RangoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RangoInicial.Location = new System.Drawing.Point(342, 47);
            this.Txt_RangoInicial.Name = "Txt_RangoInicial";
            this.Txt_RangoInicial.Size = new System.Drawing.Size(137, 22);
            this.Txt_RangoInicial.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Bttn_Aceptar
            // 
            this.Bttn_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bttn_Aceptar.BackgroundImage")));
            this.Bttn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bttn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bttn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Aceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.Bttn_Aceptar.Location = new System.Drawing.Point(497, 26);
            this.Bttn_Aceptar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bttn_Aceptar.Name = "Bttn_Aceptar";
            this.Bttn_Aceptar.Size = new System.Drawing.Size(72, 68);
            this.Bttn_Aceptar.TabIndex = 12;
            this.Bttn_Aceptar.UseVisualStyleBackColor = true;
            this.Bttn_Aceptar.Click += new System.EventHandler(this.button5_Click);
            // 
            // Bttn_Ayuda
            // 
            this.Bttn_Ayuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bttn_Ayuda.BackgroundImage")));
            this.Bttn_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bttn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bttn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Ayuda.ForeColor = System.Drawing.SystemColors.Control;
            this.Bttn_Ayuda.Location = new System.Drawing.Point(2, 545);
            this.Bttn_Ayuda.Name = "Bttn_Ayuda";
            this.Bttn_Ayuda.Size = new System.Drawing.Size(139, 110);
            this.Bttn_Ayuda.TabIndex = 4;
            this.Bttn_Ayuda.UseVisualStyleBackColor = true;
            this.Bttn_Ayuda.Click += new System.EventHandler(this.Bttn_Ayuda_Click);
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bttn_Salir.BackgroundImage")));
            this.Bttn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bttn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bttn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Salir.ForeColor = System.Drawing.SystemColors.Control;
            this.Bttn_Salir.Location = new System.Drawing.Point(148, 545);
            this.Bttn_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(139, 110);
            this.Bttn_Salir.TabIndex = 10;
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Aceptar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cancelar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(508, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Aceptar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 654);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ayuda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(198, 654);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Salir";
            // 
            // FormRangoMensualidad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(622, 672);
            this.ControlBox = false;
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Bttn_Ayuda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Data_Rangos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormRangoMensualidad";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rango de Mensualidad";
            this.Load += new System.EventHandler(this.FormRangoMensualidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Rangos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data_Rangos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_SalarioMinimoActual;
        private System.Windows.Forms.Button Bttn_SalarioMin_Cancelar;
        private System.Windows.Forms.Button Bttn_SalarioMin_Aceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bttn_Aceptar;
        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.Button Bttn_Ayuda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_Mensualidad;
        private System.Windows.Forms.TextBox Txt_RangoInicial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}