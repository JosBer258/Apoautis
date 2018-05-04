namespace APOAUTIS.Formas.Entrevista_Padres
{
    partial class FrmBusquedaEntPadres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaEntPadres));
            this.Bttn_Cancelar = new System.Windows.Forms.Button();
            this.Txt_FiltroAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Bttn_Cancelar.Location = new System.Drawing.Point(12, 6);
            this.Bttn_Cancelar.Name = "Bttn_Cancelar";
            this.Bttn_Cancelar.Size = new System.Drawing.Size(76, 69);
            this.Bttn_Cancelar.TabIndex = 15;
            this.Bttn_Cancelar.UseVisualStyleBackColor = true;
            this.Bttn_Cancelar.Click += new System.EventHandler(this.Bttn_Cancelar_Click);
            // 
            // Txt_FiltroAlumno
            // 
            this.Txt_FiltroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FiltroAlumno.Location = new System.Drawing.Point(209, 14);
            this.Txt_FiltroAlumno.MaxLength = 44;
            this.Txt_FiltroAlumno.Name = "Txt_FiltroAlumno";
            this.Txt_FiltroAlumno.Size = new System.Drawing.Size(370, 24);
            this.Txt_FiltroAlumno.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre del Alumno: \r\n";
            // 
            // DGV_Show
            // 
            this.DGV_Show.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Show.Location = new System.Drawing.Point(27, 56);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.Size = new System.Drawing.Size(552, 332);
            this.DGV_Show.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Bttn_Cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 100);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cancelar";
            // 
            // FrmBusquedaEntPadres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(610, 488);
            this.ControlBox = false;
            this.Controls.Add(this.Txt_FiltroAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Show);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBusquedaEntPadres";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FrmBusquedaEntPadres";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}