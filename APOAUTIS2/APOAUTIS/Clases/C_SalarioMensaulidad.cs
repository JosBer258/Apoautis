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
    class C_SalarioMensaulidad: Conexion
    {
        private float var_salario_minimo;
        private float var_monto;
        private int var_categ;

        public float Var_salario_minimo
        {
            get
            {
                return var_salario_minimo;
            }

            set
            {
                var_salario_minimo = value;
            }
        }

        public float Var_monto
        {
            get
            {
                return var_monto;
            }

            set
            {
                var_monto = value;
            }
        }

        public int Var_categ
        {
            get
            {
                return var_categ;
            }

            set
            {
                var_categ = value;
            }
        }

        public void Fun_MostrarRangos(DataGridView Var_RangoMen)
        {
            cnx.Open();
            try
            {
                DataAdapter = new MySqlDataAdapter(@"select CodMens as 'Codigo', cargocat as 'Cod de categoria', cargnumsalar as 'Cantidad de salarios minimos', cargorangoinic as 'Rango inicial L.', cargvalmensul as 'Total de mensualidad L.' from cuota", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                Var_RangoMen.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public void Fun_Actual_Monto_Ct()
        {
            this.sql = string.Format(@" update cuota set cargvalmensul ='{0}' where CodMens ='{1}'",  Var_monto, Var_categ);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        public void Fun_Actualizar_SalarioLim()
        {
            this.sql = string.Format(@"update cuota set cargorangoinic = cargnumsalar * '{0}' where CodMens != 0", Var_salario_minimo);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }
    }
}
