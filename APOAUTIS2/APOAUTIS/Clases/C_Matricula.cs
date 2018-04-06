using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAUTIS.Clases
{
    class C_Matricula: Conexion
    {
        private int codigo_Matricula;
        private int codigo_Alumno;
        private string jornada;
        private string recibio_evaluacion;
        private string anio_Ingreso;
        private string tipo_Matricula;

        public int Codigo_Matricula
        {
            get
            {
                return codigo_Matricula;
            }

            set
            {
                codigo_Matricula = value;
            }
        }

        public int Codigo_Alumno
        {
            get
            {
                return codigo_Alumno;
            }

            set
            {
                codigo_Alumno = value;
            }
        }

        public string Jornada
        {
            get
            {
                return jornada;
            }

            set
            {
                jornada = value;
            }
        }

        public string Recibio_evaluacion
        {
            get
            {
                return recibio_evaluacion;
            }

            set
            {
                recibio_evaluacion = value;
            }
        }

        public string Anio_Ingreso
        {
            get
            {
                return anio_Ingreso;
            }

            set
            {
                anio_Ingreso = value;
            }
        }

        public string Tipo_Matricula
        {
            get
            {
                return tipo_Matricula;
            }

            set
            {
                tipo_Matricula = value;
            }
        }

        public void ingresoMatricula()
        {
            this.sql = string.Format(@"INSERT INTO matricula
                                        (Alumnos_CodAlumno, Jornada, AnioIngreso, RecibioEvalu,
                                        Tipo_Matricula)
                                        VALUES
                                        ('{0}','{1}', '{2}','{3}', '{4}');",
                                        Codigo_Alumno, Jornada, Anio_Ingreso, Recibio_evaluacion,
                                        Tipo_Matricula);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }
    }
}
