using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAUTIS.Clases
{
    class C_CambiosSocio : Conexion
    {
        public void Fun_IngresarRecreacion(string parques, string centroscomerciales, string museso, string cine, string balnearo, string playa, string otros, int cod)
        {
            this.sql = string.Format(@"update lugaresrecreacion set Parques='{0}', CentrosComerciales='{1}', 
            Museos='{2}', Cine='{3}', Balnearios='{4}',Playa='{5}', Otros='{6}'
            where Alumnos_CodAlumno='{7}'; ", parques, centroscomerciales, museso, cine, balnearo, playa, otros,cod);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public void Fun_IngresarInformacionVivienda(string Tenencia, string MaterialConst, string MaterialPiso, string Servicios, string Dispone, int Cod)
        {
            this.sql = string.Format(@"update informacionvivienda
            set Tenencia='{0}', MaterialConst='{1}', MaterialPiso='{2}', ServiciosBacicos='{3}', DisponeDe='{4}'
            where Alumnos_CodAlumno='{5}';", Tenencia,  MaterialConst,  MaterialPiso, Servicios,Dispone, Cod);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public void Fun_IngresarHistorial(string Lugares, string Enfermedades, double Gasto, int Cod)
        {
            this.sql = string.Format(@"update historialmedico
            set LugaresRecibeAtencionMedica='{0}', EnfermePadecenFamili='{1}', CuantoGastaEnMed='{2}'
            where Alumnos_CodAlumno='{3}';", Lugares, Enfermedades,  Gasto, Cod);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public void Fun_InformacionFamilia(int personas, string otrosfamiliares, int miembrostotao, int cuantostrabajan, int cod)
        {
            this.sql = string.Format(@"update informacionfamilia
set PersonasHabitan='{0}', HabitanOtrosFami='{1}', MiemEnTotal='{2}', CuantMiembrTrab='{3}'
where Alumnos_CodAlumno='{4}';", personas, otrosfamiliares,miembrostotao, cuantostrabajan, cod);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public void Fun_Estudio(string lugar, string personaentre, string estudio, int cod)
        {
            this.sql = string.Format(@"update estudiosocioeconomico
set Lugar='{0}', PersonaEntrevis='{1}', RevisaAproPor='{2}'
where CodEstudioSE='{3}';", lugar, personaentre, estudio, cod);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public  void ActualizarID(string ID, int cod)
        {
            this.sql = string.Format(@"update alumnos set IdAlum='{0}' where CodAlumno='{1}';", ID, cod);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }
    }

}
