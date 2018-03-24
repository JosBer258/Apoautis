using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Windows.Forms;


namespace APOAUTIS.Clases
{
    class C_MuestraHistorialMatricu: Conexion
    {
        private int var_anio_primario;
        private int var_anio_final;
        private int var_anio_busqueda;
        private int var_nom_filtro;

        public int Var_anio_primario
        {
            get
            {
                return var_anio_primario;
            }

            set
            {
                var_anio_primario = value;
            }
        }

        public int Var_anio_final
        {
            get
            {
                return var_anio_final;
            }

            set
            {
                var_anio_final = value;
            }
        }

        public int Var_anio_busqueda
        {
            get
            {
                return var_anio_busqueda;
            }

            set
            {
                var_anio_busqueda = value;
            }
        }

        public int Var_nom_filtro
        {
            get
            {
                return var_nom_filtro;
            }

            set
            {
                var_nom_filtro = value;
            }
        }

        public void Fun_ExtraerAñoMaximo()
        {
            sql = string.Format("select AnioIngreso from matricula order by AnioIngreso desc limit 1;");
            cnx.Open();
            cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = cmd.ExecuteReader();
            if (Reg.Read())
            {
                Var_anio_final = (int) Convert.ToDouble(Reg["AnioIngreso"].ToString());
            }
            cnx.Close();
        }

        public void Fun_ExtraerAñoMinimo()
        {
            sql = string.Format("select AnioIngreso from matricula order by AnioIngreso limit 1;");
            cnx.Open();
            cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = cmd.ExecuteReader();
            if (Reg.Read())
            {
                Var_anio_primario = (int)Convert.ToDouble(Reg["AnioIngreso"].ToString());
            }
            cnx.Close();
        }

        public void Fun_MostrarAños(ComboBox Var_ExFecha)
        {
            Fun_ExtraerAñoMaximo();
            Fun_ExtraerAñoMinimo();
            for (int i= Var_anio_final; i>= Var_anio_primario; i--)
            {
                Var_ExFecha.Items.Add(i);
            }
        }

        public void Fun_MostrarTodos(System.Windows.Forms.DataGridView Var_MuestraDatos)
        {

        }
    }
}
