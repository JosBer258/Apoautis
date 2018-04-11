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

        private void DGV_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cmb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Rad_Update_CheckedChanged(object sender, EventArgs e)
        {
           /* if (Rad_Update.Checked == true)
            {
                Txt_CodUser.Clear();
                Txt_NameUser.Clear();
                Txt_NameUser.Enabled = false;
            }
            else
            {
                Txt_CodUser.Text = Convert.ToString(User.ObtenerUltimoCodigoUsuario());
                Txt_NameUser.Clear();
                Txt_NameUser.Enabled = true;
            }*/
        }

        private void Rad_New_CheckedChanged(object sender, EventArgs e)
        {
            if (Rad_New.Checked == true)
            {
                Txt_CodUser.Text = Convert.ToString(User.ObtenerUltimoCodigoUsuario());
                Txt_NameUser.Clear();
                Txt_PasdUser.Clear();
                Txt_NameUser.Enabled = true;
                Cmb_Estado.Enabled = false;
                Vacios(sender, e);



            }
            else
            {
                Txt_CodUser.Clear();
                Txt_NameUser.Clear();
                Txt_PasdUser.Clear();
                Txt_NameUser.Enabled = false;
                Cmb_Estado.Enabled = true;
                Vacios(sender, e);


            }
        }

        private void DGV_Data_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
           

      
        public void ExtraerDatosCodigo(int Coduser)
        {
            Conexion cn = new Conexion();
            cn.sql = string.Format(@"select A.CodUsuario as Codigo_Usuario, A.NomUsuario, A.ClaveUsuaio
,A.CodigoEstado, B.DescripcionEstado, C.Intentos from ingreso as C inner join 
usuarios as A on A.CodUsuario = C.CodUsuario inner join Estados as B on A.CodigoEstado = B.CodEstado
where A.CodUsuario = '{0}' ", Coduser);
            cn.cmd = new MySqlCommand(cn.sql, cn.cnx);
            cn.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = cn.cmd.ExecuteReader();

            if (Reg.Read())
            {

                Txt_NameUser.Text = (Reg["NomUsuario"].ToString());
                //Txt_PasdUser.Text = (Reg["ClaveUsuaio"].ToString());
                cn.cnx.Close();
              

            }
            else
            {
               
            }

            cn.cnx.Close();
            
        }
        public void ExtraerDatosNombre(string Nomuser)
        {
            Conexion cn = new Conexion();
            cn.sql = string.Format(@"select A.CodUsuario, A.NomUsuario, A.ClaveUsuaio
,A.CodigoEstado, B.DescripcionEstado, C.Intentos from ingreso as C inner join 
usuarios as A on A.CodUsuario = C.CodUsuario inner join Estados as B on A.CodigoEstado = B.CodEstado
where A.NomUsuario = '{0}' ", Nomuser);
            cn.cmd = new MySqlCommand(cn.sql, cn.cnx);
            cn.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Txt_CodUser.Text = (Reg["CodUsuario"].ToString());
                //Txt_PasdUser.Text = (Reg["ClaveUsuaio"].ToString());

                cn.cnx.Close();


            }
            else
            {

            }

            cn.cnx.Close();

        }

        private void DGV_Data_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void Txt_NameUser_TextChanged(object sender, EventArgs e)
        {
            Vacios(sender, e);
        }

        private void Txt_PasdUser_TextChanged(object sender, EventArgs e)
        {
            Vacios(sender, e);
        }

        private void DGV_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string a;
            a = DGV_Data.CurrentCell.ColumnIndex.ToString();

            if (Rad_New.Checked == false)
            {
                if (Convert.ToInt16(a) == 1 || Convert.ToInt16(a) == 0)
                {

                    if (Convert.ToInt16(a) == 0)
                    {

                        Txt_CodUser.Text = DGV_Data.CurrentCell.Value.ToString();
                        ExtraerDatosCodigo(Convert.ToInt16(Txt_CodUser.Text));
                        Txt_PasdUser.Clear();

                    }
                    else
                     if (Convert.ToInt16(a) == 1)
                    {

                        Txt_NameUser.Text = DGV_Data.CurrentCell.Value.ToString();
                        Txt_PasdUser.Clear();
                        ExtraerDatosNombre((Txt_NameUser.Text));
                    }

                    MessageBox.Show("Listo");
                    Vacios(sender, e);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
