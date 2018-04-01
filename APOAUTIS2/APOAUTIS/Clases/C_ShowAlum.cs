using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Clases
{
    class C_ShowAlum: Conexion
    {
        private int var_cod_alumno;
        private string var_nom_cliente;

        public int Var_cod_alumno
        {
            get
            {
                return var_cod_alumno;
            }

            set
            {
                var_cod_alumno = value;
            }
        }

        public string Var_nom_cliente
        {
            get
            {
                return var_nom_cliente;
            }

            set
            {
                var_nom_cliente = value;
            }
        }

        public void Fun_MuestraDatosGen(DataGridView Dvg_MuestraDatos)
        {
            cnx.Open();
            sql = String.Format("select CodAlumno as 'Codigo', IdAlum as 'ID', NomAlumno as 'Nombre del Alumno',EdadAlum as 'Edad' from alumnos");
            cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);
            DataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            DataAdapter.Fill(dt);
            Dvg_MuestraDatos.DataSource = dt;
            cnx.Close();
        }

        public void Fun_MuestraDatosPorAlum(DataGridView Var_Show)
        {
            cnx.Open();
            sql = String.Format("select CodAlumno as 'Codigo', IdAlum as 'ID', NomAlumno as 'Nombre del Alumno',EdadAlum as 'Edad' from alumnos where NomAlumno like '%{0}%'", Var_nom_cliente);
            cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);
            DataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            DataAdapter.Fill(dt);
            Var_Show.DataSource = dt;
            cnx.Close();
        }

       
   
    }
}
