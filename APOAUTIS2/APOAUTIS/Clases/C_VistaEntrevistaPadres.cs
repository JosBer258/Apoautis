using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Clases
{
    class C_VistaEntrevistaPadres: Conexion
    {
        //variables de busqueda
        private int var_codigo_alumno;
        private string var_nombre_completo_alumno;

        //Datos Generales


        //Anamnesis
        private string var_tipo_familia;
        private string var_peso_al_nacer;
        private string var_duracion_periodo_gestacion;
        private string var_datos_relevantes_prenatales;
        private string var_datos_relevantes_perinatales;
        private string var_datos_relevantes_postnatales;


        public int Var_codigo_alumno
        {
            get
            {
                return var_codigo_alumno;
            }

            set
            {
                var_codigo_alumno = value;
            }
        }

        public string Var_nombre_completo_alumno
        {
            get
            {
                return var_nombre_completo_alumno;
            }

            set
            {
                var_nombre_completo_alumno = value;
            }
        }

        public string Var_tipo_familia
        {
            get
            {
                return var_tipo_familia;
            }

            set
            {
                var_tipo_familia = value;
            }
        }

        public string Var_peso_al_nacer
        {
            get
            {
                return var_peso_al_nacer;
            }

            set
            {
                var_peso_al_nacer = value;
            }
        }

        public string Var_duracion_periodo_gestacion
        {
            get
            {
                return var_duracion_periodo_gestacion;
            }

            set
            {
                var_duracion_periodo_gestacion = value;
            }
        }

        public string Var_datos_relevantes_prenatales
        {
            get
            {
                return var_datos_relevantes_prenatales;
            }

            set
            {
                var_datos_relevantes_prenatales = value;
            }
        }

        public string Var_datos_relevantes_perinatales
        {
            get
            {
                return var_datos_relevantes_perinatales;
            }

            set
            {
                var_datos_relevantes_perinatales = value;
            }
        }

        public string Var_datos_relevantes_postnatales
        {
            get
            {
                return var_datos_relevantes_postnatales;
            }

            set
            {
                var_datos_relevantes_postnatales = value;
            }
        }

        public void Fun_ExtraerInformacion_Anamnesis()
        {
            this.sql = string.Format("select * from anamnesis where Alumnos_CodAlumno = '{0}'", Var_codigo_alumno);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Var_duracion_periodo_gestacion = Reg["DuracionGestacion"].ToString();
                Var_tipo_familia = Reg["TipoFamilia"].ToString();
                Var_peso_al_nacer = Reg["PesoAlNacer"].ToString();
                Var_datos_relevantes_prenatales = Reg["DatosPrenatales"].ToString();
                Var_datos_relevantes_perinatales = Reg["DatosPerinatales"].ToString();
                Var_datos_relevantes_postnatales = Reg["DatosPostnatales"].ToString();
            }
            this.cnx.Close();
   
        }
    }
}
