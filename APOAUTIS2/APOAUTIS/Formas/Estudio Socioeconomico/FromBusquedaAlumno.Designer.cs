namespace APOAUTIS.Formas.Estudio_Socioeconomico
{
    partial class FromBusquedaAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromBusquedaAlumno));
            this.Bttn_Cancelar = new System.Windows.Forms.Button();
            this.Txt_FiltroAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.btm_buscar = new System.Windows.Forms.Button();
            this.btm_Aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bttn_Cancelar
            // 
            this.Bttn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bttn_Cancelar.BackgroundImage")));
            this.Bttn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bttn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bttn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.Bttn_Cancelar.Location = new System.Drawing.Point(139, 6);
            this.Bttn_Cancelar.Name = "Bttn_Cancelar";
            this.Bttn_Cancelar.Size = new System.Drawing.Size(106, 99);
            this.Bttn_Cancelar.TabIndex = 11;
            this.Bttn_Cancelar.UseVisualStyleBackColor = true;
            this.Bttn_Cancelar.Click += new System.EventHandler(this.Bttn_Cancelar_Click);
            // 
            // Txt_FiltroAlumno
            // 
            this.Txt_FiltroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FiltroAlumno.Location = new System.Drawing.Point(189, 36);
            this.Txt_FiltroAlumno.MaxLength = 40;
            this.Txt_FiltroAlumno.Name = "Txt_FiltroAlumno";
            this.Txt_FiltroAlumno.Size = new System.Drawing.Size(431, 24);
            this.Txt_FiltroAlumno.TabIndex = 10;
            this.Txt_FiltroAlumno.TextChanged += new System.EventHandler(this.Txt_FiltroAlumno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del Alumno: \r\n";
            // 
            // DGV_Show
            // 
            this.DGV_Show.AllowUserToAddRows = false;
            this.DGV_Show.AllowUserToDeleteRows = false;
            this.DGV_Show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Show.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Show.Location = new System.Drawing.Point(14, 95);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.ReadOnly = true;
            this.DGV_Show.Size = new System.Drawing.Size(758, 287);
            this.DGV_Show.TabIndex = 8;
            this.DGV_Show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Show_CellContentClick);
            // 
            // btm_buscar
            // 
            this.btm_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btm_buscar.BackgroundImage")));
            this.btm_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btm_buscar.Location = new System.Drawing.Point(683, 1);
            this.btm_buscar.Name = "btm_buscar";
            this.btm_buscar.Size = new System.Drawing.Size(72, 71);
            this.btm_buscar.TabIndex = 12;
            this.btm_buscar.UseVisualStyleBackColor = true;
            this.btm_buscar.Click += new System.EventHandler(this.btm_buscar_Click);
            // 
            // btm_Aceptar
            // 
            this.btm_Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btm_Aceptar.BackgroundImage")));
            this.btm_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btm_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_Aceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btm_Aceptar.Location = new System.Drawing.Point(12, 3);
            this.btm_Aceptar.Name = "btm_Aceptar";
            this.btm_Aceptar.Size = new System.Drawing.Size(106, 102);
            this.btm_Aceptar.TabIndex = 13;
            this.btm_Aceptar.UseVisualStyleBackColor = true;
            this.btm_Aceptar.Click += new System.EventHandler(this.btm_Aceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Buscar Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Aceptar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cancelar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btm_Aceptar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Bttn_Cancelar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 125);
            this.panel1.TabIndex = 17;
            // 
            // FromBusquedaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(789, 527);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btm_buscar);
            this.Controls.Add(this.Txt_FiltroAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Show);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FromBusquedaAlumno";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Busqueda del Alumno";
            this.Load += new System.EventHandler(this.FromBusquedaAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bttn_Cancelar;
        private System.Windows.Forms.TextBox Txt_FiltroAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Show;
        private System.Windows.Forms.Button btm_buscar;
        private System.Windows.Forms.Button btm_Aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}