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
        C_Validaciones val = new C_Validaciones();
        C_Usuarios Usuarios = new C_Usuarios();

        public Login()
        {
            InitializeComponent();
        }
        int cont = 5;
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bttn_Entrar_Click(object sender, EventArgs e)
        {

            string pssword = val.EncriptarContraseña(Txt_Contrasenna.Text);
            string user = Txt_NombreUsuario.Text;

            /*if (Txt_NombreUsuario.Text == "root" && Txt_Contrasenna.Text == "123")
             {
                 FormMenuPrincipal menu = new FormMenuPrincipal();
                 menu.ShowDialog();
             }
             */
            Usuarios.Var_nom_user = user;
            Usuarios.Var_cont_user = pssword;
            if( Usuarios.checkLogin() == true)
            {
                if (Usuarios.Var_codigo_estado == 1)
                {
                    Usuarios.RestablecerIntentos();
                    FormMenuPrincipal menu = new FormMenuPrincipal();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario: " + Usuarios.Var_nom_user + 
                        " Ha sido bloqueado, favor acudir al Supervisor",
                        "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
               
            }else if( Usuarios.buscarExistencia() == true)
            {

                Txt_Contrasenna.Text = "";
                Txt_Contrasenna.Focus();

                if (Usuarios.Var_oportunidades > 0)
                {
                    MessageBox.Show("Quedan: " + Usuarios.Var_oportunidades + " intentos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    MessageBox.Show("Usuario: " + Usuarios.Var_nom_user + " Ha sido bloqueado, favor acudir al Supervisor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                }
            }else if (Usuarios.checkLogin() == false)
            {
                cont--;
                if (cont > 0)
                {
                    MessageBox.Show("Verifique Usuario o Contraseña incorrectos. \nTiene " + cont + " intentos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ingreso Incorrecto de datos. \nLa Aplicacion se cerrara", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
          

            
        }

        private void Login_Load(object sender, EventArgs e)
        {
 

        }

        private void Txt_NombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Txt_Contrasenna_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarPassword(sender,e);
        }
    }
}
