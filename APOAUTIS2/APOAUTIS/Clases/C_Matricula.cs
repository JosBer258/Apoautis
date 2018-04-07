using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAUTIS.Clases
{
    class C_Matricula:Conexion
    {
        private int CodMatricula;
        private int Alumnos_CodAlumno;
        private string Jornada;
        private string AnioIngreso;
        private string RecibioEvalu;
        private string Observaciones;
        private string Entrevistador;
        private string CuotaPago;
        private string FechaIngreso;
        private string Tipo_Matricula;

        public int CodMatricula1
        {
            get
            {
                return CodMatricula;
            }

            set
            {
                CodMatricula = value;
            }
        }

        public int Alumnos_CodAlumno1
        {
            get
            {
                return Alumnos_CodAlumno;
            }

            set
            {
                Alumnos_CodAlumno = value;
            }
        }

        public string Jornada1
        {
            get
            {
                return Jornada;
            }

            set
            {
                Jornada = value;
            }
        }

        public string AnioIngreso1
        {
            get
            {
                return AnioIngreso;
            }

            set
            {
                AnioIngreso = value;
            }
        }

        public string RecibioEvalu1
        {
            get
            {
                return RecibioEvalu;
            }

            set
            {
                RecibioEvalu = value;
            }
        }

        public string Observaciones1
        {
            get
            {
                return Observaciones;
            }

            set
            {
                Observaciones = value;
            }
        }

        public string Entrevistador1
        {
            get
            {
                return Entrevistador;
            }

            set
            {
                Entrevistador = value;
            }
        }

        public string CuotaPago1
        {
            get
            {
                return CuotaPago;
            }

            set
            {
                CuotaPago = value;
            }
        }

       

        public string Tipo_Matricula1
        {
            get
            {
                return Tipo_Matricula;
            }

            set
            {
                Tipo_Matricula = value;
            }
        }

        public string FechaIngreso1
        {
            get
            {
                return FechaIngreso;
            }

            set
            {
                FechaIngreso = value;
            }
        }

        public void ingresoMatricula()
        {
            
            this.sql = string.Format(@"INSERT INTO matricula
                                        (Alumnos_CodAlumno, Jornada, AnioIngreso, RecibioEvalu,
                                        FechaIngreso)
                                        VALUES
                                        ('{0}','{1}', '{2}','{3}', '{4}');",
                                        Alumnos_CodAlumno1, Jornada1, AnioIngreso1, RecibioEvalu1, FechaIngreso1);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }

            public int obtenerUltimo()
            {
                int ultimo=0;

                this.sql = string.Format(@"select CodAlumno from alumnos order by CodAlumno desc limit 1;");

                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.cnx.Open();
                MySqlDataReader Reg = null;
                Reg = this.cmd.ExecuteReader();

                if(Reg.Read())
                {
                    ultimo = Convert.ToInt16(Reg["CodAlumno"].ToString());
                }
                this.cnx.Close();


                return (ultimo);
            }
        public int GenerarCod()
        {
            int ultimo = 0;

            this.sql = string.Format(@"select CodMatricula from matricula order by CodMatricula desc limit 1;");

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                ultimo = Convert.ToInt16(Reg["CodMatricula"].ToString()) + 1;
            }
            this.cnx.Close();


            return (ultimo);
        }
    }
}
