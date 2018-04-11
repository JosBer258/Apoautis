namespace APOAUTIS.Formas.Estudio_Socioeconomico
{
    partial class FormBusquedaResponsables
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
            this.btm_Aceptar_responsables = new System.Windows.Forms.Button();
            this.btm_buscar_responsable = new System.Windows.Forms.Button();
            this.Bttn_Cancelar_responsables = new System.Windows.Forms.Button();
            this.Txt_FiltroResponsable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_responsables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_responsables)).BeginInit();
            this.SuspendLayout();
            // 
            // btm_Aceptar_responsables
            // 
            this.btm_Aceptar_responsables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_Aceptar_responsables.Location = new System.Drawing.Point(416, 396);
            this.btm_Aceptar_responsables.Name = "btm_Aceptar_responsables";
            this.btm_Aceptar_responsables.Size = new System.Drawing.Size(104, 36);
            this.btm_Aceptar_responsables.TabIndex = 19;
            this.btm_Aceptar_responsables.Text = "Aceptar";
            this.btm_Aceptar_responsables.UseVisualStyleBackColor = true;
            this.btm_Aceptar_responsables.Click += new System.EventHandler(this.btm_Aceptar_responsables_Click);
            // 
            // btm_buscar_responsable
            // 
            this.btm_buscar_responsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_buscar_responsable.Location = new System.Drawing.Point(555, 12);
            this.btm_buscar_responsable.Name = "btm_buscar_responsable";
            this.btm_buscar_responsable.Size = new System.Drawing.Size(108, 36);
            this.btm_buscar_responsable.TabIndex = 18;
            this.btm_buscar_responsable.Text = "Buscar";
            this.btm_buscar_responsable.UseVisualStyleBackColor = true;
            this.btm_buscar_responsable.Click += new System.EventHandler(this.btm_buscar_responsable_Click);
            // 
            // Bttn_Cancelar_responsables
            // 
            this.Bttn_Cancelar_responsables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Cancelar_responsables.Location = new System.Drawing.Point(535, 398);
            this.Bttn_Cancelar_responsables.Name = "Bttn_Cancelar_responsables";
            this.Bttn_Cancelar_responsables.Size = new System.Drawing.Size(108, 33);
            this.Bttn_Cancelar_responsables.TabIndex = 17;
            this.Bttn_Cancelar_responsables.Text = "Cancelar";
            this.Bttn_Cancelar_responsables.UseVisualStyleBackColor = true;
            this.Bttn_Cancelar_responsables.Click += new System.EventHandler(this.Bttn_Cancelar_responsables_Click);
            // 
            // Txt_FiltroResponsable
            // 
            this.Txt_FiltroResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FiltroResponsable.Location = new System.Drawing.Point(179, 18);
            this.Txt_FiltroResponsable.Name = "Txt_FiltroResponsable";
            this.Txt_FiltroResponsable.Size = new System.Drawing.Size(370, 24);
            this.Txt_FiltroResponsable.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre del Alumno: \r\n";
            // 
            // DGV_responsables
            // 
            this.DGV_responsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_responsables.Location = new System.Drawing.Point(-3, 60);
            this.DGV_responsables.Name = "DGV_responsables";
            this.DGV_responsables.Size = new System.Drawing.Size(662, 332);
            this.DGV_responsables.TabIndex = 14;
            // 
            // FormBusquedaResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 436);
            this.Controls.Add(this.btm_Aceptar_responsables);
            this.Controls.Add(this.btm_buscar_responsable);
            this.Controls.Add(this.Bttn_Cancelar_responsables);
            this.Controls.Add(this.Txt_FiltroResponsable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_responsables);
            this.Name = "FormBusquedaResponsables";
            this.Text = "FormBusquedaResponsables";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_responsables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btm_Aceptar_responsables;
        private System.Windows.Forms.Button btm_buscar_responsable;
        private System.Windows.Forms.Button Bttn_Cancelar_responsables;
        private System.Windows.Forms.TextBox Txt_FiltroResponsable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_responsables;
    }
}