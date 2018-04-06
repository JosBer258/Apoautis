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
           private int CodAlumno1;
        private string NomAlumno1;
            private string LugarNaciAlum1;
            private string FechaNaciAlum1;
        private int EdadAlum1;
        private string EdadCronologica1;
            private string SexoAlum1;
            private string IdAlum1;
        private string DireccionAlum1;
        private string TelFijoAlum1;
        private string CelAlumno1;
        private string EscolaridadAlum1;
        private string LugarOrigAlum1;
        private string InstProceAlumno1;
        private string InstDondeEstaIncluido1;
        private string ExistenciaAlergias;
        private string UsoMedicamentos;
        private string EnfermedadesPadeciFamilia;
        private string LugaresAtencionMedica;
        private double GastosMEdicos;

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
