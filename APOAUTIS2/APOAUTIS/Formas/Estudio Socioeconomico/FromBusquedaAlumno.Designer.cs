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
            this.Bttn_Cancelar = new System.Windows.Forms.Button();
            this.Txt_FiltroAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.btm_buscar = new System.Windows.Forms.Button();
            this.btm_Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // Bttn_Cancelar
            // 
            this.Bttn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Cancelar.Location = new System.Drawing.Point(550, 388);
            this.Bttn_Cancelar.Name = "Bttn_Cancelar";
            this.Bttn_Cancelar.Size = new System.Drawing.Size(108, 33);
            this.Bttn_Cancelar.TabIndex = 11;
            this.Bttn_Cancelar.Text = "Cancelar";
            this.Bttn_Cancelar.UseVisualStyleBackColor = true;
            this.Bttn_Cancelar.Click += new System.EventHandler(this.Bttn_Cancelar_Click);
            // 
            // Txt_FiltroAlumno
            // 
            this.Txt_FiltroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FiltroAlumno.Location = new System.Drawing.Point(194, 8);
            this.Txt_FiltroAlumno.Name = "Txt_FiltroAlumno";
            this.Txt_FiltroAlumno.Size = new System.Drawing.Size(370, 24);
            this.Txt_FiltroAlumno.TabIndex = 10;
            this.Txt_FiltroAlumno.TextChanged += new System.EventHandler(this.Txt_FiltroAlumno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del Alumno: \r\n";
            // 
            // DGV_Show
            // 
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Show.Location = new System.Drawing.Point(12, 50);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.Size = new System.Drawing.Size(662, 332);
            this.DGV_Show.TabIndex = 8;
            this.DGV_Show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Show_CellContentClick);
            // 
            // btm_buscar
            // 
            this.btm_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_buscar.Location = new System.Drawing.Point(570, 2);
            this.btm_buscar.Name = "btm_buscar";
            this.btm_buscar.Size = new System.Drawing.Size(108, 36);
            this.btm_buscar.TabIndex = 12;
            this.btm_buscar.Text = "Buscar";
            this.btm_buscar.UseVisualStyleBackColor = true;
            this.btm_buscar.Click += new System.EventHandler(this.btm_buscar_Click);
            // 
            // btm_Aceptar
            // 
            this.btm_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_Aceptar.Location = new System.Drawing.Point(431, 386);
            this.btm_Aceptar.Name = "btm_Aceptar";
            this.btm_Aceptar.Size = new System.Drawing.Size(104, 36);
            this.btm_Aceptar.TabIndex = 13;
            this.btm_Aceptar.Text = "Aceptar";
            this.btm_Aceptar.UseVisualStyleBackColor = true;
            this.btm_Aceptar.Click += new System.EventHandler(this.btm_Aceptar_Click);
            // 
            // FromBusquedaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(689, 426);
            this.ControlBox = false;
            this.Controls.Add(this.btm_Aceptar);
            this.Controls.Add(this.btm_buscar);
            this.Controls.Add(this.Bttn_Cancelar);
            this.Controls.Add(this.Txt_FiltroAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Show);
            this.Name = "FromBusquedaAlumno";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FromBusquedaAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
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
    }
}