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
    class C_Usuarios : Conexion
    {
        C_Validaciones val = new C_Validaciones();
        private string var_nom_user;
        private string var_cont_user;
        private int var_cod_user;
        private int var_codigo_estado;
        private int var_oportunidades;
        private string AddNomUsuario;
        private string AddPassword;
        private int AddEstado;
        private int AddCodUser;
      





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
        public int Var_codigo_estado
        {
            get
            {
                return var_codigo_estado;
            }

            set
            {
                var_codigo_estado = value;
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

        public int Var_oportunidades {

            get
            {
                return var_oportunidades;
            }

            set
            {
                var_oportunidades = value;
            }



        }

        public string AddNomUsuario1 {
            get { return AddNomUsuario; }
            set { AddNomUsuario = value; } }

        public string AddPassword1 { get
            {
                return AddPassword;
            }
            set { AddPassword = value; }
        }
        public int AddEstado1 { get
            {
                return AddEstado;
            }
            set { AddEstado = value; }
        }
        public int AddCodUser1 { get { return AddCodUser; }
        set { AddCodUser = value; }
}

public void Fun_Show(DataGridView dgv)
        {

            cnx.Open();
            try
            {
                DataAdapter = new MySqlDataAdapter(@"select A.CodUsuario as 'Codigo de Usuario', 
A.NomUsuario as 'Nombre de Usuario', B.DescripcionEstado as 'Descripcion de Estado' from ingreso as C inner join 
usuarios as A on A.CodUsuario = C.CodUsuario inner join Estados as B on 
A.CodigoEstado = B.CodEstado ", ccnx);
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
            this.sql = string.Format(@"insert into usuarios values (0,'{0}', '{1}',1)",
                AddNomUsuario1, val.EncriptarContraseña(AddPassword1));

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
            IngresoUsuariotablaIngreso();
        }
        public void IngresoUsuariotablaIngreso()
        {
            this.sql = string.Format(@"insert into ingreso values (0,6,'{0}')",
                 AddCodUser1);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }
        public void updateUsuario()
        {

            this.sql = string.Format(@"UPDATE  usuarios 
 Set ClaveUsuaio = '{0}', CodigoEstado ='{1}'
WHERE CodUsuario = '{2}'", val.EncriptarContraseña(AddPassword1), AddEstado1, AddCodUser1);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg3 = null;
            Reg3 = this.cmd.ExecuteReader();
            this.cnx.Close();
        }
        public bool RevisionDeExistencia()
        {
            this.sql = string.Format(@"select * from usuarios where NomUsuario='{0}' ",
                AddNomUsuario1);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                this.cnx.Close();
                return true;

            }
            else
            {
                this.cnx.Close();

                return false;
            }

        }
    
        public int ObtenerUltimoCodigoUsuario()
        {
            int Codigo = 0;
            this.sql = string.Format(@"select CodUsuario as CodigoFinal from usuarios order by
CodUsuario desc limit 1");
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = Convert.ToInt16((Reg["CodigoFinal"].ToString()));

            }
            else
            {

            }

            this.cnx.Close();
            return (Codigo + 1);

        }

        public bool checkLogin()
        {

            bool resultado = false;
            this.sql = string.Format(@"select A.CodUsuario, A.NomUsuario, A.ClaveUsuaio
,A.CodigoEstado, B.DescripcionEstado, C.Intentos from ingreso as C inner join 
usuarios as A on A.CodUsuario = C.CodUsuario inner join Estados as B on A.CodigoEstado = B.CodEstado
where A.NomUsuario = '{0}' AND A.ClaveUsuaio = '{1}'", this.var_nom_user, this.var_cont_user);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Var_codigo_estado = Convert.ToInt16((Reg["CodigoEstado"].ToString()));
                Var_cod_user = Convert.ToInt16((Reg["CodUsuario"].ToString()));
                Formas.Ingreso.FormMenuPrincipal menu = new Formas.Ingreso.FormMenuPrincipal();
                menu.State = Var_codigo_estado;
                
                
                if (Var_nom_user == Reg["NomUsuario"].ToString())
                {
                    resultado = true;
                    this.cnx.Close();
                }
                else
                {
                    resultado = false;
                    this.cnx.Close();
                }
                

            }
            else
            {
                resultado = false;
            }

            this.cnx.Close();
            return resultado;
        }





        public bool buscarExistencia()
        {

            bool resultado = false;
            this.sql = string.Format(@"select A.CodUsuario, A.NomUsuario, A.ClaveUsuaio
,A.CodigoEstado, B.DescripcionEstado, C.Intentos from ingreso as C inner join 
usuarios as A on A.CodUsuario = C.CodUsuario inner join Estados as B on A.CodigoEstado = B.CodEstado
where A.NomUsuario = '{0}'", this.var_nom_user);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                var_oportunidades = Convert.ToInt16((Reg["Intentos"].ToString()))-1;
                var_cod_user = Convert.ToInt16((Reg["CodUsuario"].ToString()));

                this.cnx.Close();
                ReducirIntentos();
                resultado = true;

            }
            else
            {
                resultado = false;
            }

            this.cnx.Close();
            return resultado;
        }


        public void RestablecerIntentos()
        {

            this.sql = string.Format(@"UPDATE  ingreso as A INNER JOIN usuarios 
as B  ON A.CodUsuario = B.CodUsuario 
 Set A.Intentos = 6
WHERE B.CodUsuario = '{0}'
AND B.CodigoEstado = '{1}'", this.Var_cod_user, this.Var_codigo_estado);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg3 = null;
            Reg3 = this.cmd.ExecuteReader();
            this.cnx.Close();
        }
        public void RestablecerIntentos2()
        {

            this.sql = string.Format(@"UPDATE  ingreso as A INNER JOIN usuarios 
as B  ON A.CodUsuario = B.CodUsuario 
 Set A.Intentos = 6
WHERE B.CodUsuario = '{0}'
AND B.CodigoEstado = '{1}'", AddCodUser1, AddEstado1);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg3 = null;
            Reg3 = this.cmd.ExecuteReader();
            this.cnx.Close();
        }



        public void BloquearUsuario()
        {
            if (Var_oportunidades == 0)
            {
                this.sql = string.Format(@"UPDATE usuarios Set CodigoEstado = 2 WHERE CodUsuario = '{0}'", 
this.Var_cod_user);
                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.cnx.Open();
                MySqlDataReader Reg2 = null;
                Reg2 = this.cmd.ExecuteReader();
                if (Reg2.Read())
                {
                    var_codigo_estado = Convert.ToInt16((Reg2["CodigoEstado"].ToString()));
                }
                this.cnx.Close();
            }
        }

        public void ReducirIntentos()
        {

            if (Var_oportunidades >= 0)
            {
                this.sql = string.Format(@"UPDATE  ingreso as A INNER JOIN usuarios 
as B  ON A.CodUsuario = B.CodUsuario 
 Set A.Intentos = '{0}'
WHERE B.CodUsuario = '{1}'",
this.Var_oportunidades, this.Var_cod_user);
                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.cnx.Open();
                MySqlDataReader Reg1 = null;
                Reg1 = this.cmd.ExecuteReader();
                this.cnx.Close();
            }

            BloquearUsuario();
        }

        public void GenerarEstado(ComboBox Com_Roles)
        {
            cnx.Open();
            sql = string.Format(@"select CodEstado, DescripcionEstado from estados where CodTipoEstado = '1' ");
            cmd = new MySqlCommand(sql, cnx);
            DataAdapter = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            Com_Roles.ValueMember = "CodEstado";
            Com_Roles.DisplayMember = "DescripcionEstado";
            Com_Roles.DataSource = dt;
        }

    }



}
