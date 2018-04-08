using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Clases
{
    class C_Usuarios: Conexion
    {
        private string var_nom_user;
        private string var_cont_user;
        private int var_cod_user;

        public string Var_nom_user
        {
            get
            {
                return var_nom_user;
            }

            set
            {
                var_nom_user = value;
            }
        }

        public string Var_cont_user
        {
            get
            {
                return var_cont_user;
            }

            set
            {
                var_cont_user = value;
            }
        }

        public int Var_cod_user
        {
            get
            {
                return var_cod_user;
            }

            set
            {
                var_cod_user = value;
            }
        }

        public void Fun_Show(DataGridView dgv)
        {
            
            cnx.Open();
            try
            {
                DataAdapter = new MySqlDataAdapter(@"select CodUsuario as 'Codigo', NomUsuario as 'Nombre', ClaveUsuaio as 'Contraseña' from usuarios", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public void Fun_New()
        {
            this.sql = string.Format(@"insert into usuarios values (0,'{0}', '{1}')", Var_nom_user, Var_cont_user);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }

    
    }
}
