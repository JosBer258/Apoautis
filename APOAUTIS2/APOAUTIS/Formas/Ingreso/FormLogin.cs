using APOAUTIS.Clases;
using APOAUTIS.Formas.Ingreso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS
{
    public partial class Login : Form
    {
        C_Login Log = new C_Login();

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bttn_Entrar_Click(object sender, EventArgs e)
        {
            if(Txt_NombreUsuario.Text == "root" && Txt_Contrasenna.Text == "123")
            {
                FormMenuPrincipal menu = new FormMenuPrincipal();
                menu.ShowDialog();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
 

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
