namespace APOAUTIS.Formas.Alumnos
{
    partial class FormGlobalShowAlum
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
            this.DataGrid_Show = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Show)).BeginInit();
            this.SuspendLayout();
            // 
            // Bttn_Cancelar
            // 
            this.Bttn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Cancelar.Location = new System.Drawing.Point(426, 402);
            this.Bttn_Cancelar.Name = "Bttn_Cancelar";
            this.Bttn_Cancelar.Size = new System.Drawing.Size(187, 44);
            this.Bttn_Cancelar.TabIndex = 7;
            this.Bttn_Cancelar.Text = "Cancelar";
            this.Bttn_Cancelar.UseVisualStyleBackColor = true;
            this.Bttn_Cancelar.Click += new System.EventHandler(this.Bttn_Cancelar_Click);
            // 
            // Txt_FiltroAlumno
            // 
            this.Txt_FiltroAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FiltroAlumno.Location = new System.Drawing.Point(226, 22);
            this.Txt_FiltroAlumno.MaxLength = 25;
            this.Txt_FiltroAlumno.Name = "Txt_FiltroAlumno";
            this.Txt_FiltroAlumno.Size = new System.Drawing.Size(385, 24);
            this.Txt_FiltroAlumno.TabIndex = 6;
            this.Txt_FiltroAlumno.TextChanged += new System.EventHandler(this.Txt_FiltroAlumno_TextChanged);
            this.Txt_FiltroAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_FiltroAlumno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Alumno: \r\n";
            // 
            // DataGrid_Show
            // 
            this.DataGrid_Show.AllowUserToAddRows = false;
            this.DataGrid_Show.AllowUserToDeleteRows = false;
            this.DataGrid_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_Show.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DataGrid_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Show.Location = new System.Drawing.Point(14, 67);
            this.DataGrid_Show.Name = "DataGrid_Show";
            this.DataGrid_Show.ReadOnly = true;
            this.DataGrid_Show.Size = new System.Drawing.Size(598, 329);
            this.DataGrid_Show.TabIndex = 8;
            this.DataGrid_Show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Show_CellContentClick);
            this.DataGrid_Show.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Show_CellContentDoubleClick);
            this.DataGrid_Show.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Show_CellDoubleClick);
            // 
            // FormGlobalShowAlum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(625, 455);
            this.ControlBox = false;
            this.Controls.Add(this.DataGrid_Show);
            this.Controls.Add(this.Bttn_Cancelar);
            this.Controls.Add(this.Txt_FiltroAlumno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormGlobalShowAlum";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Busqueda de todos los Alumnos";
            this.Load += new System.EventHandler(this.FormGlobalShowAlum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bttn_Cancelar;
        private System.Windows.Forms.TextBox Txt_FiltroAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGrid_Show;
    }
}