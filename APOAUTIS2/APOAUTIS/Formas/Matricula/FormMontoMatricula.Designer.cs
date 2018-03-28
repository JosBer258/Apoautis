namespace APOAUTIS.Formas.Matricula
{
    partial class FormMontoMatricula
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
            this.Bttn_Salir = new System.Windows.Forms.Button();
            this.Gruop_MuestraDatos = new System.Windows.Forms.GroupBox();
            this.Bttn_BusquedaDeAlumno = new System.Windows.Forms.Button();
            this.Bttn_Limpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bttn_Calcular = new System.Windows.Forms.Button();
            this.Bttn_Aceptar = new System.Windows.Forms.Button();
            this.Txt_Mensualidad = new System.Windows.Forms.TextBox();
            this.Txt_Responsable = new System.Windows.Forms.TextBox();
            this.Txt_TotalIngreso = new System.Windows.Forms.TextBox();
            this.Txt_NombreAlumno = new System.Windows.Forms.TextBox();
            this.Gruop_Busqueda = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DGV_Show = new System.Windows.Forms.DataGridView();
            this.Txt_Filtro_Matricula = new System.Windows.Forms.TextBox();
            this.Gruop_Opciones = new System.Windows.Forms.GroupBox();
            this.Radio_Agregar = new System.Windows.Forms.RadioButton();
            this.Radio_Actualizar = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Gruop_MuestraDatos.SuspendLayout();
            this.Gruop_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).BeginInit();
            this.Gruop_Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Salir.Location = new System.Drawing.Point(663, 452);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(99, 41);
            this.Bttn_Salir.TabIndex = 17;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // Gruop_MuestraDatos
            // 
            this.Gruop_MuestraDatos.Controls.Add(this.Bttn_BusquedaDeAlumno);
            this.Gruop_MuestraDatos.Controls.Add(this.Bttn_Limpiar);
            this.Gruop_MuestraDatos.Controls.Add(this.label5);
            this.Gruop_MuestraDatos.Controls.Add(this.label4);
            this.Gruop_MuestraDatos.Controls.Add(this.label3);
            this.Gruop_MuestraDatos.Controls.Add(this.label2);
            this.Gruop_MuestraDatos.Controls.Add(this.label1);
            this.Gruop_MuestraDatos.Controls.Add(this.Bttn_Calcular);
            this.Gruop_MuestraDatos.Controls.Add(this.Bttn_Aceptar);
            this.Gruop_MuestraDatos.Controls.Add(this.Txt_Mensualidad);
            this.Gruop_MuestraDatos.Controls.Add(this.Txt_Responsable);
            this.Gruop_MuestraDatos.Controls.Add(this.Txt_TotalIngreso);
            this.Gruop_MuestraDatos.Controls.Add(this.Txt_NombreAlumno);
            this.Gruop_MuestraDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gruop_MuestraDatos.Location = new System.Drawing.Point(161, 12);
            this.Gruop_MuestraDatos.Name = "Gruop_MuestraDatos";
            this.Gruop_MuestraDatos.Size = new System.Drawing.Size(601, 165);
            this.Gruop_MuestraDatos.TabIndex = 15;
            this.Gruop_MuestraDatos.TabStop = false;
            this.Gruop_MuestraDatos.Text = "Muestra de los datos";
            // 
            // Bttn_BusquedaDeAlumno
            // 
            this.Bttn_BusquedaDeAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_BusquedaDeAlumno.Location = new System.Drawing.Point(147, 12);
            this.Bttn_BusquedaDeAlumno.Name = "Bttn_BusquedaDeAlumno";
            this.Bttn_BusquedaDeAlumno.Size = new System.Drawing.Size(99, 41);
            this.Bttn_BusquedaDeAlumno.TabIndex = 13;
            this.Bttn_BusquedaDeAlumno.Text = "Busqueda de Alumno";
            this.Bttn_BusquedaDeAlumno.UseVisualStyleBackColor = true;
            this.Bttn_BusquedaDeAlumno.Click += new System.EventHandler(this.Bttn_BusquedaDeAlumno_Click);
            // 
            // Bttn_Limpiar
            // 
            this.Bttn_Limpiar.Location = new System.Drawing.Point(252, 114);
            this.Bttn_Limpiar.Name = "Bttn_Limpiar";
            this.Bttn_Limpiar.Size = new System.Drawing.Size(99, 41);
            this.Bttn_Limpiar.TabIndex = 12;
            this.Bttn_Limpiar.Text = "Limpiar";
            this.Bttn_Limpiar.UseVisualStyleBackColor = true;
            this.Bttn_Limpiar.Click += new System.EventHandler(this.Bttn_Limpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mensualidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total de Ingresos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Responsables";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre del Estudiante\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // Bttn_Calcular
            // 
            this.Bttn_Calcular.Location = new System.Drawing.Point(478, 116);
            this.Bttn_Calcular.Name = "Bttn_Calcular";
            this.Bttn_Calcular.Size = new System.Drawing.Size(100, 39);
            this.Bttn_Calcular.TabIndex = 6;
            this.Bttn_Calcular.Text = "Calcular";
            this.Bttn_Calcular.UseVisualStyleBackColor = true;
            this.Bttn_Calcular.Click += new System.EventHandler(this.Bttn_Calcular_Click);
            // 
            // Bttn_Aceptar
            // 
            this.Bttn_Aceptar.Location = new System.Drawing.Point(147, 114);
            this.Bttn_Aceptar.Name = "Bttn_Aceptar";
            this.Bttn_Aceptar.Size = new System.Drawing.Size(99, 41);
            this.Bttn_Aceptar.TabIndex = 5;
            this.Bttn_Aceptar.Text = "Aceptar";
            this.Bttn_Aceptar.UseVisualStyleBackColor = true;
            this.Bttn_Aceptar.Click += new System.EventHandler(this.Bttn_Aceptar_Click);
            // 
            // Txt_Mensualidad
            // 
            this.Txt_Mensualidad.Enabled = false;
            this.Txt_Mensualidad.Location = new System.Drawing.Point(478, 90);
            this.Txt_Mensualidad.Name = "Txt_Mensualidad";
            this.Txt_Mensualidad.Size = new System.Drawing.Size(100, 20);
            this.Txt_Mensualidad.TabIndex = 4;
            // 
            // Txt_Responsable
            // 
            this.Txt_Responsable.Enabled = false;
            this.Txt_Responsable.Location = new System.Drawing.Point(147, 88);
            this.Txt_Responsable.Name = "Txt_Responsable";
            this.Txt_Responsable.Size = new System.Drawing.Size(201, 20);
            this.Txt_Responsable.TabIndex = 3;
            // 
            // Txt_TotalIngreso
            // 
            this.Txt_TotalIngreso.Enabled = false;
            this.Txt_TotalIngreso.Location = new System.Drawing.Point(478, 65);
            this.Txt_TotalIngreso.Name = "Txt_TotalIngreso";
            this.Txt_TotalIngreso.Size = new System.Drawing.Size(100, 20);
            this.Txt_TotalIngreso.TabIndex = 1;
            // 
            // Txt_NombreAlumno
            // 
            this.Txt_NombreAlumno.Enabled = false;
            this.Txt_NombreAlumno.Location = new System.Drawing.Point(147, 64);
            this.Txt_NombreAlumno.Name = "Txt_NombreAlumno";
            this.Txt_NombreAlumno.Size = new System.Drawing.Size(201, 20);
            this.Txt_NombreAlumno.TabIndex = 0;
            // 
            // Gruop_Busqueda
            // 
            this.Gruop_Busqueda.Controls.Add(this.label6);
            this.Gruop_Busqueda.Controls.Add(this.DGV_Show);
            this.Gruop_Busqueda.Controls.Add(this.Txt_Filtro_Matricula);
            this.Gruop_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gruop_Busqueda.Location = new System.Drawing.Point(12, 183);
            this.Gruop_Busqueda.Name = "Gruop_Busqueda";
            this.Gruop_Busqueda.Size = new System.Drawing.Size(750, 263);
            this.Gruop_Busqueda.TabIndex = 16;
            this.Gruop_Busqueda.TabStop = false;
            this.Gruop_Busqueda.Text = "Busqueda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filtro de Busqueda";
            // 
            // DGV_Show
            // 
            this.DGV_Show.AllowUserToAddRows = false;
            this.DGV_Show.AllowUserToDeleteRows = false;
            this.DGV_Show.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Show.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.DGV_Show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Show.Location = new System.Drawing.Point(6, 63);
            this.DGV_Show.Name = "DGV_Show";
            this.DGV_Show.ReadOnly = true;
            this.DGV_Show.Size = new System.Drawing.Size(738, 194);
            this.DGV_Show.TabIndex = 0;
            this.DGV_Show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Show_CellContentClick);
            this.DGV_Show.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Show_CellContentDoubleClick);
            this.DGV_Show.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Show_CellDoubleClick);
            // 
            // Txt_Filtro_Matricula
            // 
            this.Txt_Filtro_Matricula.Location = new System.Drawing.Point(135, 28);
            this.Txt_Filtro_Matricula.MaxLength = 25;
            this.Txt_Filtro_Matricula.Name = "Txt_Filtro_Matricula";
            this.Txt_Filtro_Matricula.Size = new System.Drawing.Size(155, 20);
            this.Txt_Filtro_Matricula.TabIndex = 13;
            this.Txt_Filtro_Matricula.TextChanged += new System.EventHandler(this.Txt_Filtro_Matricula_TextChanged);
            this.Txt_Filtro_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Filtro_Matricula_KeyPress);
            // 
            // Gruop_Opciones
            // 
            this.Gruop_Opciones.Controls.Add(this.Radio_Agregar);
            this.Gruop_Opciones.Controls.Add(this.Radio_Actualizar);
            this.Gruop_Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gruop_Opciones.Location = new System.Drawing.Point(12, 12);
            this.Gruop_Opciones.Name = "Gruop_Opciones";
            this.Gruop_Opciones.Size = new System.Drawing.Size(143, 150);
            this.Gruop_Opciones.TabIndex = 14;
            this.Gruop_Opciones.TabStop = false;
            this.Gruop_Opciones.Text = "Opciones";
            // 
            // Radio_Agregar
            // 
            this.Radio_Agregar.AutoSize = true;
            this.Radio_Agregar.Location = new System.Drawing.Point(34, 95);
            this.Radio_Agregar.Name = "Radio_Agregar";
            this.Radio_Agregar.Size = new System.Drawing.Size(69, 17);
            this.Radio_Agregar.TabIndex = 1;
            this.Radio_Agregar.TabStop = true;
            this.Radio_Agregar.Text = "Agregar";
            this.Radio_Agregar.UseVisualStyleBackColor = true;
            this.Radio_Agregar.CheckedChanged += new System.EventHandler(this.Radio_Agregar_CheckedChanged);
            // 
            // Radio_Actualizar
            // 
            this.Radio_Actualizar.AutoSize = true;
            this.Radio_Actualizar.Location = new System.Drawing.Point(34, 41);
            this.Radio_Actualizar.Name = "Radio_Actualizar";
            this.Radio_Actualizar.Size = new System.Drawing.Size(81, 17);
            this.Radio_Actualizar.TabIndex = 0;
            this.Radio_Actualizar.TabStop = true;
            this.Radio_Actualizar.Text = "Actualizar";
            this.Radio_Actualizar.UseVisualStyleBackColor = true;
            this.Radio_Actualizar.CheckedChanged += new System.EventHandler(this.Radio_Actualizar_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMontoMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(774, 499);
            this.ControlBox = false;
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.Gruop_MuestraDatos);
            this.Controls.Add(this.Gruop_Busqueda);
            this.Controls.Add(this.Gruop_Opciones);
            this.Name = "FormMontoMatricula";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = " Monto de Matricula";
            this.Load += new System.EventHandler(this.FormMontoMatricula_Load);
            this.Gruop_MuestraDatos.ResumeLayout(false);
            this.Gruop_MuestraDatos.PerformLayout();
            this.Gruop_Busqueda.ResumeLayout(false);
            this.Gruop_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Show)).EndInit();
            this.Gruop_Opciones.ResumeLayout(false);
            this.Gruop_Opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bttn_Salir;
        private System.Windows.Forms.GroupBox Gruop_MuestraDatos;
        private System.Windows.Forms.Button Bttn_Limpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bttn_Calcular;
        private System.Windows.Forms.Button Bttn_Aceptar;
        private System.Windows.Forms.TextBox Txt_Mensualidad;
        private System.Windows.Forms.TextBox Txt_Responsable;
        private System.Windows.Forms.TextBox Txt_TotalIngreso;
        private System.Windows.Forms.TextBox Txt_NombreAlumno;
        private System.Windows.Forms.GroupBox Gruop_Busqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGV_Show;
        private System.Windows.Forms.TextBox Txt_Filtro_Matricula;
        private System.Windows.Forms.GroupBox Gruop_Opciones;
        private System.Windows.Forms.RadioButton Radio_Agregar;
        private System.Windows.Forms.RadioButton Radio_Actualizar;
        private System.Windows.Forms.Button Bttn_BusquedaDeAlumno;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}