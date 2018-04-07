using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace APOAUTIS.Clases
{
    class C_EvalPsico : Conexion
    {
        private int codEval;
        private string fechEval;
        private string fechNac;
        private string nomEval;
        private int edad;
        private string impDiag;
        private string sexo;
        private string respEval;
        private string telEval;
        private string obsEval;

        public int CodEval
        {
            get
            {
                return codEval;
            }

            set
            {
                codEval = value;
            }
        }

        public string FechEval
        {
            get
            {
                return fechEval;
            }

            set
            {
                fechEval = value;
            }
        }

        public string FechNac
        {
            get
            {
                return fechNac;
            }

            set
            {
                fechNac = value;
            }
        }

        public string NomEval
        {
            get
            {
                return nomEval;
            }

            set
            {
                nomEval = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public string ImpDiag
        {
            get
            {
                return impDiag;
            }

            set
            {
                impDiag = value;
            }
        }

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string RespEval
        {
            get
            {
                return respEval;
            }

            set
            {
                respEval = value;
            }
        }

        public string TelEval
        {
            get
            {
                return telEval;
            }

            set
            {
                telEval = value;
            }
        }

        public string ObsEval
        {
            get
            {
                return obsEval;
            }

            set
            {
                obsEval = value;
            }
        }

        public void ingresoEval()
        {
            this.sql = string.Format(@"INSERT INTO evaluacion
                                        (CodEvaluacion, FechaEvaluacion, ImpresionDiagnos, NombreEvaluado,
                                        FechaNaci, Edad, Sexo, Responsable, Telefono, Observaciones)
                                        VALUES
                                        ('{0}','{1}', '{2}','{3}', '{4}',
                                        '{5}', '{6}','{7}', '{8}','{9}');",
                                        0, fechEval, impDiag, nomEval, fechNac, edad,
                                        sexo, respEval, telEval, obsEval);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        public void Fill_DGV_Eval(DataGridView dgv)
        {

            cnx.Open();
            try
            {
                DataAdapter = new MySqlDataAdapter(@"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                                    NombreEvaluado as 'Nombre del Evaluado',
                                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                                    FechaNaci as 'Fecha de Nacimiento',
                                                    Edad,
                                                    Sexo,
                                                    Responsable,
                                                    Telefono,
                                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                                    Observaciones
                                                    FROM evaluacion;", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public void busquedaNombre(DataGridView dgv, string nombre)
        {

            string searchQuery = @"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                    NombreEvaluado as 'Nombre del Evaluado',
                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                    FechaNaci as 'Fecha de Nacimiento',
                                    Edad,
                                    Sexo,
                                    Responsable,
                                    Telefono,
                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                    Observaciones
                                    FROM evaluacion WHERE NombreEvaluado LIKE '%" + nombre + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, cnx);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public void busquedaImpDiag(DataGridView dgv, string impresion)
        {

            string searchQuery = @"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                    NombreEvaluado as 'Nombre del Evaluado',
                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                    FechaNaci as 'Fecha de Nacimiento',
                                    Edad,
                                    Sexo,
                                    Responsable,
                                    Telefono,
                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                    Observaciones
                                    FROM evaluacion WHERE ImpresionDiagnos LIKE '%" + impresion + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, cnx);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public void busquedaObs(DataGridView dgv, string observacion)
        {

            string searchQuery = @"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                    NombreEvaluado as 'Nombre del Evaluado',
                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                    FechaNaci as 'Fecha de Nacimiento',
                                    Edad,
                                    Sexo,
                                    Responsable,
                                    Telefono,
                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                    Observaciones
                                    FROM evaluacion WHERE Observaciones LIKE '%" + observacion + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, cnx);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public void busquedaIDOB(DataGridView dgv, string impresion, string observacion)
        {

            string searchQuery = @"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                    NombreEvaluado as 'Nombre del Evaluado',
                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                    FechaNaci as 'Fecha de Nacimiento',
                                    Edad,
                                    Sexo,
                                    Responsable,
                                    Telefono,
                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                    Observaciones
                                    FROM evaluacion WHERE ImpresionDiagnos LIKE '%" + impresion + "%' AND Observaciones LIKE '%" + observacion + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, cnx);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;

        }


        public void busquedaFecha(DataGridView dgv, string fecha)
        {

            string searchQuery = @"SELECT CodEvaluacion as 'Codigo de Evaluacion',
                                    NombreEvaluado as 'Nombre del Evaluado',
                                    DATE_FORMAT(FechaEvaluacion, '%Y-%m-%d') as 'Fecha de Evaluacion',
                                    FechaNaci as 'Fecha de Nacimiento',
                                    Edad,
                                    Sexo,
                                    Responsable,
                                    Telefono,
                                    ImpresionDiagnos as 'Impresion Diagnostica',
                                    Observaciones
                                    FROM evaluacion WHERE FechaEvaluacion = '" + fecha + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, cnx);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;

        }

        public string mostrarCodigo()
        {
            string cdg = "0";
            cnx.Open();

            string query = "SELECT (MAX( CodEvaluacion ) + 1) as CodEvaluacion FROM evaluacion";
            MySqlCommand comando = new MySqlCommand(query, cnx);

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read() == true)
            {
                cdg = reader[0].ToString();

            }

            reader.Close();
            cnx.Close();
            return cdg;
        }

        public void validarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



    }
}
