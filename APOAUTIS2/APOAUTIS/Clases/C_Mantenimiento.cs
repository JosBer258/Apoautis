using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Clases
{
    class C_Mantenimiento : Conexion
    {
        public void Fun_ExtraerJornadas(DataGridView dgv)
        {
            cnx.Open();
            try
            {
                this.sql = string.Format
               (@"select cod_jornada as 'Codigo de la Jornada', descripcion as 'Descripcion' from jornada;");
                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.DataAdapter = new MySqlDataAdapter(this.cmd);
                this.dt = new DataTable();
                this.DataAdapter.Fill(this.dt);
                dgv.DataSource = this.dt;

            }
            catch
            {

            }
            cnx.Close();
        }
        public void Fun_ExtraerTiposMat(DataGridView dgv)
        {
            cnx.Open();
            try
            {
                this.sql = string.Format
               (@"select Cod_Tipo as 'Codigo de Tipo', Descripcion as 'Descripcion' from tipo_matricula;;");
                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.DataAdapter = new MySqlDataAdapter(this.cmd);
                this.dt = new DataTable();
                this.DataAdapter.Fill(this.dt);
                dgv.DataSource = this.dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public int Fun_ExtraerCodigoAlumno_Jormada()
        {
            int ultimo = 0;

            this.sql = string.Format(@"select cod_jornada  from jornada order by cod_jornada desc limit 1;");

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                ultimo = Convert.ToInt16(Reg["cod_jornada"].ToString()) + 1;
            }
            this.cnx.Close();


            return (ultimo);
        }
        public int Fun_ExtraerCodigoAlumno_TipoMat()
        {
            int ultimo = 0;

            this.sql = string.Format(@"select Cod_Tipo from tipo_matricula order by Cod_Tipo desc limit 1;");

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                ultimo = Convert.ToInt16(Reg["Cod_Tipo"].ToString()) + 1;
            }
            this.cnx.Close();


            return (ultimo);
        }



        public void Fun_ingresarJornada(string FV_Desc)
        {
            this.sql = string.Format(@"insert into jornada values(0,'{0}');", FV_Desc);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();
            if (Reg > 0)
            {
                MessageBox.Show("Los datos se ingresaron correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Ocurrio un error en el ingreso\nPor favor contacte con su supervisor", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.cnx.Close();
        }
        public void Fun_ingresarTipoM(string FV_Desc)
        {
            this.sql = string.Format(@"insert into tipo_matricula values(0,'{0}');", FV_Desc);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();
            if (Reg > 0)
            {
                MessageBox.Show("Los datos se ingresaron correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Ocurrio un error en el ingreso\nPor favor contacte con su supervisor", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.cnx.Close();
        }


        public void Fun_PdateJornada(int FV_Cod, string FV_Desc)
        {
            this.sql = string.Format(@"update jornada set descripcion='{0}' where cod_jornada='{1}';", FV_Desc, FV_Cod);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();
            if (Reg > 0)
            {
                MessageBox.Show("Los datos se actualizaron correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Ocurrio un error en la actualizacion\nPor favor contacte con su supervisor", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.cnx.Close();
        }
        public void Fun_PdateTipo(int FV_Cod, string FV_Desc)
        {
            this.sql = string.Format(@"update tipo_matricula set Descripcion='{0}' where Cod_Tipo='{1}';", FV_Desc, FV_Cod);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();
            if (Reg > 0)
            {
                MessageBox.Show("Los datos se actualizaron correctamente", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("Ocurrio un error en la actualizacion\nPor favor contacte con su supervisor", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.cnx.Close();
        }


        public bool Fun_Validar_Jormada(string desc)
        {
            bool ultimo = false;

            this.sql = string.Format(@"select * from jornada where descripcion ='{0}';", desc);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                ultimo = true;
            }
            this.cnx.Close();


            return (ultimo);
        }


        public bool Fun_Validar_Tipo(string desc)
        {
            bool ultimo = false;

            this.sql = string.Format(@"select * from tipo_matricula where Descripcion='{0}';", desc);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                ultimo = true;
            }
            this.cnx.Close();


            return (ultimo);
        }

    }
}
