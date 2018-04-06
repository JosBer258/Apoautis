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
        private string nombre_Alumno;
        private string lugar_Nacimiento;
        private string fecha_Nacimiento;
        private string direccion_Alumno;
        private string telefono_Alumno;
        private string celular_Alumno;
        private string instituo_Procedencia;

        public string Nombre_Alumno
        {
            get
            {
                return nombre_Alumno;
            }

            set
            {
                nombre_Alumno = value;
            }
        }

        public string Lugar_Nacimiento
        {
            get
            {
                return lugar_Nacimiento;
            }

            set
            {
                lugar_Nacimiento = value;
            }
        }

        public string Fecha_Nacimiento
        {
            get
            {
                return fecha_Nacimiento;
            }

            set
            {
                fecha_Nacimiento = value;
            }
        }

        public string Direccion_Alumno
        {
            get
            {
                return direccion_Alumno;
            }

            set
            {
                direccion_Alumno = value;
            }
        }

        public string Telefono_Alumno
        {
            get
            {
                return telefono_Alumno;
            }

            set
            {
                telefono_Alumno = value;
            }
        }

        public string Celular_Alumno
        {
            get
            {
                return celular_Alumno;
            }

            set
            {
                celular_Alumno = value;
            }
        }

        public string Instituo_Procedencia
        {
            get
            {
                return instituo_Procedencia;
            }

            set
            {
                instituo_Procedencia = value;
            }
        }

        public void ingresoAlumno()
        {
            this.sql = string.Format(@"INSERT INTO alumnos
                                        (NomAlumno, LugarNaciAlum, FechaNaciAlum, DireccionAlum,
                                        TelFijoAlum, CelAlumno, InsProceAlumno)
                                        VALUES
                                        ('{0}','{1}', '{2}','{3}', '{4}',
                                        '{5}', '{6}');",
                                        Nombre_Alumno, Lugar_Nacimiento, Fecha_Nacimiento, Direccion_Alumno,
                                        Telefono_Alumno,Celular_Alumno,Instituo_Procedencia);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }

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
