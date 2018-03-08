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
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mydbDataSet = new APOAUTIS.mydbDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entrevistaDePadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudioSocioeconomicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionPsicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.usuariosToolStripMenuItem1,
            this.pruebasToolStripMenuItem,
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
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // pruebasToolStripMenuItem
            // 
            this.pruebasToolStripMenuItem.Name = "pruebasToolStripMenuItem";
            this.pruebasToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.pruebasToolStripMenuItem.Text = "Pruebas";
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
            // entrevistaDePadresToolStripMenuItem
            // 
            this.entrevistaDePadresToolStripMenuItem.Name = "entrevistaDePadresToolStripMenuItem";
            this.entrevistaDePadresToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.entrevistaDePadresToolStripMenuItem.Text = "Entrevista de Padres";
            this.entrevistaDePadresToolStripMenuItem.Click += new System.EventHandler(this.entrevistaDePadresToolStripMenuItem_Click);
            // 
            // estudioSocioeconomicoToolStripMenuItem
            // 
            this.estudioSocioeconomicoToolStripMenuItem.Name = "estudioSocioeconomicoToolStripMenuItem";
            this.estudioSocioeconomicoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.estudioSocioeconomicoToolStripMenuItem.Text = "Estudio Socioeconomico";
            this.estudioSocioeconomicoToolStripMenuItem.Click += new System.EventHandler(this.estudioSocioeconomicoToolStripMenuItem_Click);
            // 
            // evaluacionPsicoToolStripMenuItem
            // 
            this.evaluacionPsicoToolStripMenuItem.Name = "evaluacionPsicoToolStripMenuItem";
            this.evaluacionPsicoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.evaluacionPsicoToolStripMenuItem.Text = "Evaluacion Psico";
            this.evaluacionPsicoToolStripMenuItem.Click += new System.EventHandler(this.evaluacionPsicoToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pruebasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrevistaDePadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudioSocioeconomicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionPsicoToolStripMenuItem;
    }
}