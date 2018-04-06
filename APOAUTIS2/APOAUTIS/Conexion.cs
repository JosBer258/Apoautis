using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using APOAUTIS.Properties;
//using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace APOAUTIS
{
    class Conexion
    {
        public string ccnx;
        public string sql;
        public string mensaje;
        public MySqlConnection cnx;
        public MySqlCommand cmd;
        public MySqlDataAdapter DataAdapter;
        public DataTable dt;
        public DataRow Dr;
        public MySqlDataReader DtR;
        public DataSet Dataset;
        public DataView DataView;



        public Conexion()
        {
            try
            {
                this.ccnx = Settings.Default.mydbConnectionString;
                this.cnx = new MySqlConnection(this.ccnx);
            }
            catch (Exception)
            {

            }

        }

        public void Abrir()
        {
            try
            {
                cnx.Open();
              

            }
            catch (Exception)
            {
         
            }
        }
    }
}
