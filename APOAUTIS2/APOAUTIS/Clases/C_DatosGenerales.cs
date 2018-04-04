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
    public class C_DatosGenerales
    {



        private int codAlumno;
        private double idAlumno;
        private string nombreAlumno;
        private int edadAlumno;
        private DateTime fecha_NacAlumno;
        private string lugarNacAlumno;
        private string sexoAlumno;

        public int CodAlumno
        {
            get
            {
                return codAlumno;
            }

            set
            {
                codAlumno = value;
            }
        }

        public double IdAlumno
        {
            get
            {
                return idAlumno;
            }

            set
            {
                idAlumno = value;
            }
        }

        public string NombreAlumno
        {
            get
            {
                return nombreAlumno;
            }

            set
            {
                nombreAlumno = value;
            }
        }

        public int EdadAlumno
        {
            get
            {
                return edadAlumno;
            }

            set
            {
                edadAlumno = value;
            }
        }

        public DateTime Fecha_NacAlumno
        {
            get
            {
                return fecha_NacAlumno;
            }

            set
            {
                fecha_NacAlumno = value;
            }
        }

        public string LugarNacAlumno
        {
            get
            {
                return lugarNacAlumno;
            }

            set
            {
                lugarNacAlumno = value;
            }
        }

        public string SexoAlumno
        {
            get
            {
                return sexoAlumno;
            }

            set
            {
                sexoAlumno = value;
            }
        }





        public C_DatosGenerales()
        {
        }

        public C_DatosGenerales(int codAlumno, double idAlumno, string nombreAlumno, int edadAlumno, DateTime fecha_NacAlumno, string lugarNacAlumno, string sexoAlumno)
        {
            CodAlumno = codAlumno;
            IdAlumno = idAlumno;
            NombreAlumno = nombreAlumno;
            EdadAlumno = edadAlumno;
            Fecha_NacAlumno = fecha_NacAlumno;
            LugarNacAlumno = lugarNacAlumno;
            SexoAlumno = sexoAlumno;
        }
    }
}

