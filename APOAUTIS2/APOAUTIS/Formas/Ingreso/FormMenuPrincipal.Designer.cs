namespace APOAUTIS.Formas.Ingreso
{
    partial class FormMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuIt = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montoMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrevistaDePadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudioSocioeconomicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionPsicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mydbDataSet = new APOAUTIS.mydbDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarPorRespnsableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.matriculaToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.responsablesToolStripMenuItem,
            this.entrevistaDePadresToolStripMenuItem,
            this.estudioSocioeconomicoToolStripMenuItem,
            this.evaluacionPsicoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuIt,
            this.vistaToolStripMenuItem2,
            this.historialToolStripMenuItem,
            this.ingresosGastosToolStripMenuItem,
            this.montoMatriculaToolStripMenuItem});
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // ingresoToolStripMenuIt
            // 
            this.ingresoToolStripMenuIt.Name = "ingresoToolStripMenuIt";
            this.ingresoToolStripMenuIt.Size = new System.Drawing.Size(169, 22);
            this.ingresoToolStripMenuIt.Text = "Ingreso";
            this.ingresoToolStripMenuIt.Click += new System.EventHandler(this.ingreoToolStripMenuItem_Click);
            // 
            // vistaToolStripMenuItem2
            // 
            this.vistaToolStripMenuItem2.Name = "vistaToolStripMenuItem2";
            this.vistaToolStripMenuItem2.Size = new System.Drawing.Size(169, 22);
            this.vistaToolStripMenuItem2.Text = "Vista";
            this.vistaToolStripMenuItem2.Click += new System.EventHandler(this.vistaToolStripMenuItem2_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // ingresosGastosToolStripMenuItem
            // 
            this.ingresosGastosToolStripMenuItem.Name = "ingresosGastosToolStripMenuItem";
            this.ingresosGastosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ingresosGastosToolStripMenuItem.Text = "Ingresos/Gastos";
            this.ingresosGastosToolStripMenuItem.Click += new System.EventHandler(this.ingresosGastosToolStripMenuItem_Click);
            // 
            // montoMatriculaToolStripMenuItem
            // 
            this.montoMatriculaToolStripMenuItem.Name = "montoMatriculaToolStripMenuItem";
            this.montoMatriculaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.montoMatriculaToolStripMenuItem.Text = "Monto Matricula";
            this.montoMatriculaToolStripMenuItem.Click += new System.EventHandler(this.montoMatriculaToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // responsablesToolStripMenuItem
            // 
            this.responsablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPorRespnsableToolStripMenuItem,
            this.buscarPorAlumnoToolStripMenuItem});
            this.responsablesToolStripMenuItem.Name = "responsablesToolStripMenuItem";
            this.responsablesToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.responsablesToolStripMenuItem.Text = "Responsables";
            this.responsablesToolStripMenuItem.Click += new System.EventHandler(this.responsablesToolStripMenuItem_Click);
            // 
            // entrevistaDePadresToolStripMenuItem
            // 
            this.entrevistaDePadresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem,
            this.vistaToolStripMenuItem});
            this.entrevistaDePadresToolStripMenuItem.Name = "entrevistaDePadresToolStripMenuItem";
            this.entrevistaDePadresToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.entrevistaDePadresToolStripMenuItem.Text = "Entrevista de Padres";
            this.entrevistaDePadresToolStripMenuItem.Click += new System.EventHandler(this.entrevistaDePadresToolStripMenuItem_Click);
            // 
            // ingresoToolStripMenuItem
            // 
            this.ingresoToolStripMenuItem.Name = "ingresoToolStripMenuItem";
            this.ingresoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ingresoToolStripMenuItem.Text = "Ingreso";
            this.ingresoToolStripMenuItem.Click += new System.EventHandler(this.ingresoToolStripMenuItem_Click);
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            this.vistaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.vistaToolStripMenuItem.Text = "Vista";
            this.vistaToolStripMenuItem.Click += new System.EventHandler(this.vistaToolStripMenuItem_Click);
            // 
            // estudioSocioeconomicoToolStripMenuItem
            // 
            this.estudioSocioeconomicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoToolStripMenuItem1,
            this.vistaToolStripMenuItem1});
            this.estudioSocioeconomicoToolStripMenuItem.Name = "estudioSocioeconomicoToolStripMenuItem";
            this.estudioSocioeconomicoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.estudioSocioeconomicoToolStripMenuItem.Text = "Estudio Socioeconomico";
            this.estudioSocioeconomicoToolStripMenuItem.Click += new System.EventHandler(this.estudioSocioeconomicoToolStripMenuItem_Click);
            // 
            // ingresoToolStripMenuItem1
            // 
            this.ingresoToolStripMenuItem1.Name = "ingresoToolStripMenuItem1";
            this.ingresoToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.ingresoToolStripMenuItem1.Text = "Ingreso";
            this.ingresoToolStripMenuItem1.Click += new System.EventHandler(this.ingresoToolStripMenuItem1_Click);
            // 
            // vistaToolStripMenuItem1
            // 
            this.vistaToolStripMenuItem1.Name = "vistaToolStripMenuItem1";
            this.vistaToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.vistaToolStripMenuItem1.Text = "Vista";
            this.vistaToolStripMenuItem1.Click += new System.EventHandler(this.vistaToolStripMenuItem1_Click);
            // 
            // evaluacionPsicoToolStripMenuItem
            // 
            this.evaluacionPsicoToolStripMenuItem.Name = "evaluacionPsicoToolStripMenuItem";
            this.evaluacionPsicoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.evaluacionPsicoToolStripMenuItem.Text = "Evaluacion Psicodiagnostica";
            this.evaluacionPsicoToolStripMenuItem.Click += new System.EventHandler(this.evaluacionPsicoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(45, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "alumnos";
            this.alumnosBindingSource.DataSource = this.mydbDataSet;
            // 
            // buscarPorRespnsableToolStripMenuItem
            // 
            this.buscarPorRespnsableToolStripMenuItem.Name = "buscarPorRespnsableToolStripMenuItem";
            this.buscarPorRespnsableToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.buscarPorRespnsableToolStripMenuItem.Text = "Buscar por Respnsable";
            this.buscarPorRespnsableToolStripMenuItem.Click += new System.EventHandler(this.buscarPorRespnsableToolStripMenuItem_Click);
            // 
            // buscarPorAlumnoToolStripMenuItem
            // 
            this.buscarPorAlumnoToolStripMenuItem.Name = "buscarPorAlumnoToolStripMenuItem";
            this.buscarPorAlumnoToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.buscarPorAlumnoToolStripMenuItem.Text = "Buscar por Alumno";
            this.buscarPorAlumnoToolStripMenuItem.Click += new System.EventHandler(this.buscarPorAlumnoToolStripMenuItem_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(937, 416);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrevistaDePadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudioSocioeconomicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionPsicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresoToolStripMenuIt;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem montoMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorRespnsableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorAlumnoToolStripMenuItem;
    }
}