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
    class C_EstudioSocioMetodos: Conexion
    {





        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=mydb; Uid=root; pwd=123456;");

            conectar.Open();
            return conectar;
        }


        public static int AgregarEstudioSo(C_EstudioSocioEc estudio)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO estudiosocioeconomico (Alumnos_CodAlumno, Lugar, Fecha, PersonaEntrevis, RevisaAproPor) values ('{0}','{1}','{2}', '{3}','{4}')",
                estudio.CodAlumno, estudio.LugarEntrevista, estudio.FechaEntrevista, estudio.PersonaEntrevis,estudio.EntrevistadoPor1), C_EstudioSocioMetodos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }




        public static List<C_DatosGenerales> Buscar( string nombreAlumno)
        {
            List<C_DatosGenerales> lista = new List<C_DatosGenerales>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT  CodAlumno,IdAlum,nomAlumno, LugarNaciAlum, FechaNaciAlum, EdadAlum, SexoAlum FROM alumnos  where  NomAlumno = '{0}'",
            nombreAlumno), C_EstudioSocioMetodos.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                C_DatosGenerales Estudio = new C_DatosGenerales();
                Estudio.CodAlumno = _reader.GetInt32(0);
                Estudio.IdAlumno = _reader.GetDouble(1);
                Estudio.NombreAlumno = _reader.GetString(2);
                Estudio.LugarNacAlumno = _reader.GetString(3);
                Estudio.Fecha_NacAlumno = _reader.GetDateTime(4);
                Estudio.EdadAlumno = _reader.GetInt32(5);
                Estudio.SexoAlumno = _reader.GetString(6);




                lista.Add(Estudio);
            }
            
            return lista;
        }


        public static C_DatosGenerales ObtenerDatosGenerales(double cod)
        {
            C_DatosGenerales Estudio = new C_DatosGenerales();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  CodAlumno,IdAlum, nomAlumno, LugarNaciAlum, FechaNaciAlum, EdadAlum, SexoAlum FROM alumnos  where CodAlumno= '{0}' ", cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Estudio.CodAlumno = _reader.GetInt32(0);
                Estudio.IdAlumno= _reader.GetDouble(1);
                Estudio.NombreAlumno = _reader.GetString(2);
                Estudio.LugarNacAlumno= _reader.GetString(3);
                Estudio.Fecha_NacAlumno= _reader.GetDateTime(4);
                Estudio.EdadAlumno = _reader.GetInt32(5);
                Estudio.SexoAlumno = _reader.GetString(6);

            }

            conexion.Close();
            return Estudio;

        }





    }
}
