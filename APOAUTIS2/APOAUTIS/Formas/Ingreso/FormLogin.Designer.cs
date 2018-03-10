namespace APOAUTIS
{
    partial class Login
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
            this.button2 = new System.Windows.Forms.Button();
            this.Bttn_Entrar = new System.Windows.Forms.Button();
            this.Txt_Contrasenna = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(238, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 63);
            this.button2.TabIndex = 125;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bttn_Entrar
            // 
            this.Bttn_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Entrar.Location = new System.Drawing.Point(20, 153);
            this.Bttn_Entrar.Name = "Bttn_Entrar";
            this.Bttn_Entrar.Size = new System.Drawing.Size(151, 63);
            this.Bttn_Entrar.TabIndex = 124;
            this.Bttn_Entrar.Text = "Entrar";
            this.Bttn_Entrar.UseVisualStyleBackColor = true;
            this.Bttn_Entrar.Click += new System.EventHandler(this.Bttn_Entrar_Click);
            // 
            // Txt_Contrasenna
            // 
            this.Txt_Contrasenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Contrasenna.Location = new System.Drawing.Point(181, 74);
            this.Txt_Contrasenna.Name = "Txt_Contrasenna";
            this.Txt_Contrasenna.Size = new System.Drawing.Size(208, 31);
            this.Txt_Contrasenna.TabIndex = 121;
            this.Txt_Contrasenna.Text = "123";
            this.Txt_Contrasenna.UseSystemPasswordChar = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(17, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 18);
            this.label19.TabIndex = 120;
            this.label19.Text = "Contraseña";
            // 
            // Txt_NombreUsuario
            // 
            this.Txt_NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreUsuario.Location = new System.Drawing.Point(181, 26);
            this.Txt_NombreUsuario.Name = "Txt_NombreUsuario";
            this.Txt_NombreUsuario.Size = new System.Drawing.Size(208, 31);
            this.Txt_NombreUsuario.TabIndex = 119;
            this.Txt_NombreUsuario.Text = "root";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(17, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 18);
            this.label20.TabIndex = 118;
            this.label20.Text = "Nombre de usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 232);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Bttn_Entrar);
            this.Controls.Add(this.Txt_Contrasenna);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Txt_NombreUsuario);
            this.Controls.Add(this.label20);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Bttn_Entrar;
        private System.Windows.Forms.TextBox Txt_Contrasenna;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Txt_NombreUsuario;
        private System.Windows.Forms.Label label20;
    }
}