namespace APOAUTIS.Formas.Manuales
{
    partial class FormManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual));
            this.PDF_Local = new AxAcroPDFLib.AxAcroPDF();
            this.Bttn_Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PDF_Local)).BeginInit();
            this.SuspendLayout();
            // 
            // PDF_Local
            // 
            this.PDF_Local.Enabled = true;
            this.PDF_Local.Location = new System.Drawing.Point(12, 12);
            this.PDF_Local.Name = "PDF_Local";
            this.PDF_Local.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDF_Local.OcxState")));
            this.PDF_Local.Size = new System.Drawing.Size(846, 498);
            this.PDF_Local.TabIndex = 0;
<<<<<<< HEAD
=======
            this.PDF_Local.OnError += new System.EventHandler(this.PDF_Local_OnError);
>>>>>>> master
            // 
            // Bttn_Aceptar
            // 
            this.Bttn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Aceptar.Location = new System.Drawing.Point(601, 516);
            this.Bttn_Aceptar.Name = "Bttn_Aceptar";
            this.Bttn_Aceptar.Size = new System.Drawing.Size(257, 72);
            this.Bttn_Aceptar.TabIndex = 1;
            this.Bttn_Aceptar.Text = "Aceptar";
            this.Bttn_Aceptar.UseVisualStyleBackColor = true;
            this.Bttn_Aceptar.Click += new System.EventHandler(this.Bttn_Aceptar_Click);
            // 
            // FormManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(870, 600);
            this.ControlBox = false;
            this.Controls.Add(this.Bttn_Aceptar);
            this.Controls.Add(this.PDF_Local);
            this.Name = "FormManual";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual de usuario";
            this.Load += new System.EventHandler(this.FormManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PDF_Local)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF PDF_Local;
        private System.Windows.Forms.Button Bttn_Aceptar;
    }
}