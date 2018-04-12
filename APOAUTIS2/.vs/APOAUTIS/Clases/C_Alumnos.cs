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
    class C_Alumnos: Conexion
    {
        public void Fun_Show(DataGridView dgv)
        {
            cnx.Open();
            try
            {
                DataAdapter = new MySqlDataAdapter(@"select * from alumnos", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }


        

        
    }
}
