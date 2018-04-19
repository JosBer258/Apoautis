using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAUTIS.Clases
{
    class C_Tipos_Atencion:Conexion
    {

        private string var_Combo_AtencionGrupal;
        private string var_Combo_AtencionPreVocacional;
        private string var_Combo_AtencionVocacional;
        private string var_Combo_AtensionFisica;
        private string var_Combo_Distancia;
        private string var_Combo_Escolar;
        private string var_Combo_Individual;
        private string var_Combo_TerapiaDomicilio;

        public string Var_Combo_AtencionGrupal
        {
            get
            {
                return var_Combo_AtencionGrupal;
            }

            set
            {
                var_Combo_AtencionGrupal = value;
            }
        }

        public string Var_Combo_AtencionPreVocacional
        {
            get
            {
                return var_Combo_AtencionPreVocacional;
            }

            set
            {
                var_Combo_AtencionPreVocacional = value;
            }
        }

        public string Var_Combo_AtencionVocacional
        {
            get
            {
                return var_Combo_AtencionVocacional;
            }

            set
            {
                var_Combo_AtencionVocacional = value;
            }
        }

        public string Var_Combo_AtensionFisica
        {
            get
            {
                return var_Combo_AtensionFisica;
            }

            set
            {
                var_Combo_AtensionFisica = value;
            }
        }

        public string Var_Combo_Distancia
        {
            get
            {
                return var_Combo_Distancia;
            }

            set
            {
                var_Combo_Distancia = value;
            }
        }

        public string Var_Combo_Escolar
        {
            get
            {
                return var_Combo_Escolar;
            }

            set
            {
                var_Combo_Escolar = value;
            }
        }

        public string Var_Combo_Individual
        {
            get
            {
                return var_Combo_Individual;
            }

            set
            {
                var_Combo_Individual = value;
            }
        }

        public string Var_Combo_TerapiaDomicilio
        {
            get
            {
                return var_Combo_TerapiaDomicilio;
            }

            set
            {
                var_Combo_TerapiaDomicilio = value;
            }
        }


        public void Fun_IngresarTiposAtencion(int FV_CodAlumno)
        {
            this.sql = string.Format(@"insert into tiposatencion values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');",
                FV_CodAlumno, Var_Combo_AtencionGrupal, Var_Combo_AtencionPreVocacional, Var_Combo_AtencionVocacional, Var_Combo_Escolar, Var_Combo_Individual, Var_Combo_Distancia, Var_Combo_TerapiaDomicilio, Var_Combo_AtensionFisica);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            int Reg = this.cmd.ExecuteNonQuery();
            if (Reg > 0)
            {
                 }
            else
            {
                
            }
            this.cnx.Close();

        }

        public void Fun_BuscarTipos(int FV_Codigo)
        {
            this.sql = string.Format(@"select * from tiposatencion where Alumnos_CodAlumno='{0}';", FV_Codigo);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Var_Combo_AtencionGrupal = Reg["Aten_grupal"].ToString();
                Var_Combo_AtencionPreVocacional = Reg["Aten_pre_vocacional"].ToString();
                Var_Combo_AtencionVocacional = Reg["Aten_vocacional"].ToString();
                Var_Combo_Escolar = Reg["Aten_Escolar"].ToString();
                Var_Combo_Individual = Reg["Aten_Individual"].ToString();
                Var_Combo_Distancia = Reg["Aten_distancia"].ToString();
                Var_Combo_TerapiaDomicilio = Reg["Teraia_domicilio"].ToString();
                Var_Combo_AtensionFisica = Reg["Atencion_fisica"].ToString();
            }
            this.cnx.Close();

        }
    }
}
