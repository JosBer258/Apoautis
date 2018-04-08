using APOAUTIS.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Usuarios
{
    public partial class FormUsuario : Form
    {
        C_Validaciones Val = new C_Validaciones();
        C_Usuarios User = new C_Usuarios();

        public FormUsuario()
        {
            InitializeComponent();
        }

        private void Bttn_Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bttn_Clean_Click(object sender, EventArgs e)
        {

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            User.Fun_Show(DGV_Data);
            Rad_Update.Checked = true;
        }

        private void Txt_NameUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Txt_NameUser);
        }

        private void Txt_PasdUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarPassword(sender, e);
        }

        private void Bttn_OK_Click(object sender, EventArgs e)
        {
            User.Var_cont_user = Val.EncriptarContraseña(Txt_PasdUser.Text);
            User.Var_nom_user = Txt_NameUser.Text;

            User.Fun_New();
            User.Fun_Show(DGV_Data);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
