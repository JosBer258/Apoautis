namespace APOAUTIS.Formas.Matricula
{
    partial class FormHistorialMatriculas
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
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.Group_Opciones = new System.Windows.Forms.GroupBox();
            this.Bttn_Recargar = new System.Windows.Forms.Button();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.Radio_BusquedaEstudiante = new System.Windows.Forms.RadioButton();
            this.Txt_NombreEstudiante = new System.Windows.Forms.TextBox();
            this.Radio_BusquedaAnno = new System.Windows.Forms.RadioButton();
            this.Cmb_Anno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.Group_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Show
            // 
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Show.Location = new System.Drawing.Point(12, 133);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.Size = new System.Drawing.Size(615, 314);
            this.DGV_Show.TabIndex = 7;
            // 
            // Group_Opciones
            // 
            this.Group_Opciones.Controls.Add(this.Bttn_Recargar);
            this.Group_Opciones.Controls.Add(this.Bttn_Salir);
            this.Group_Opciones.Controls.Add(this.Radio_BusquedaEstudiante);
            this.Group_Opciones.Controls.Add(this.Txt_NombreEstudiante);
            this.Group_Opciones.Controls.Add(this.Radio_BusquedaAnno);
            this.Group_Opciones.Controls.Add(this.Cmb_Anno);
            this.Group_Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Opciones.Location = new System.Drawing.Point(12, 12);
            this.Group_Opciones.Name = "Group_Opciones";
            this.Group_Opciones.Size = new System.Drawing.Size(615, 100);
            this.Group_Opciones.TabIndex = 6;
            this.Group_Opciones.TabStop = false;
            this.Group_Opciones.Text = "Opciones de Busqueda";
            // 
            // Bttn_Recargar
            // 
            this.Bttn_Recargar.Location = new System.Drawing.Point(481, 56);
            this.Bttn_Recargar.Name = "Bttn_Recargar";
            this.Bttn_Recargar.Size = new System.Drawing.Size(128, 35);
            this.Bttn_Recargar.TabIndex = 6;
            this.Bttn_Recargar.Text = "Recargar";
            this.Bttn_Recargar.UseVisualStyleBackColor = true;
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Location = new System.Drawing.Point(481, 18);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(128, 32);
            this.Bttn_Salir.TabIndex = 5;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Radio_BusquedaEstudiante
            // 
            this.Radio_BusquedaEstudiante.AutoSize = true;
            this.Radio_BusquedaEstudiante.Location = new System.Drawing.Point(30, 30);
            this.Radio_BusquedaEstudiante.Name = "Radio_BusquedaEstudiante";
            this.Radio_BusquedaEstudiante.Size = new System.Drawing.Size(199, 20);
            this.Radio_BusquedaEstudiante.TabIndex = 3;
            this.Radio_BusquedaEstudiante.TabStop = true;
            this.Radio_BusquedaEstudiante.Text = "Busqueda por estudiante";
            this.Radio_BusquedaEstudiante.UseVisualStyleBackColor = true;
            // 
            // Txt_NombreEstudiante
            // 
            this.Txt_NombreEstudiante.Location = new System.Drawing.Point(276, 28);
            this.Txt_NombreEstudiante.Name = "Txt_NombreEstudiante";
            this.Txt_NombreEstudiante.Size = new System.Drawing.Size(149, 22);
            this.Txt_NombreEstudiante.TabIndex = 2;
            // 
            // Radio_BusquedaAnno
            // 
            this.Radio_BusquedaAnno.AutoSize = true;
            this.Radio_BusquedaAnno.Location = new System.Drawing.Point(30, 59);
            this.Radio_BusquedaAnno.Name = "Radio_BusquedaAnno";
            this.Radio_BusquedaAnno.Size = new System.Drawing.Size(242, 20);
            this.Radio_BusquedaAnno.TabIndex = 1;
            this.Radio_BusquedaAnno.TabStop = true;
            this.Radio_BusquedaAnno.Text = "Busqueda por año de matricula";
            this.Radio_BusquedaAnno.UseVisualStyleBackColor = true;
            // 
            // Cmb_Anno
            // 
            this.Cmb_Anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Anno.FormattingEnabled = true;
            this.Cmb_Anno.Location = new System.Drawing.Point(276, 59);
            this.Cmb_Anno.Name = "Cmb_Anno";
            this.Cmb_Anno.Size = new System.Drawing.Size(149, 24);
            this.Cmb_Anno.TabIndex = 0;
            // 
            // FormHistorialMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(642, 470);
            this.ControlBox = false;
            this.Controls.Add(this.DGV_Show);
            this.Controls.Add(this.Group_Opciones);
            this.Name = "FormHistorialMatriculas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Historial de Matriculas";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
            this.Group_Opciones.ResumeLayout(false);
            this.Group_Opciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Show;
        private System.Windows.Forms.GroupBox Group_Opciones;
        private System.Windows.Forms.Button Bttn_Recargar;
        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.RadioButton Radio_BusquedaEstudiante;
        private System.Windows.Forms.TextBox Txt_NombreEstudiante;
        private System.Windows.Forms.RadioButton Radio_BusquedaAnno;
        private System.Windows.Forms.ComboBox Cmb_Anno;
    }
}