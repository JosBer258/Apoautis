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


        public static List<C_DatosGenerales> Buscar( string nombreAlumno)
        {
            List<C_DatosGenerales> lista = new List<C_DatosGenerales>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT  IdAlum,nomAlumno, LugarNaciAlum, FechaNaciAlum, EdadAlum, SexoAlum FROM alumnos  where  NomAlumno = '{0}'",
            nombreAlumno), C_EstudioSocioMetodos.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                C_DatosGenerales Estudio = new C_DatosGenerales();
                Estudio.idAlumno = _reader.GetDouble(0);
                Estudio.nombreAlumno = _reader.GetString(1);
                Estudio.lugarNacAlumno = _reader.GetString(2);
                Estudio.fecha_NacAlumno = _reader.GetDateTime(3); 
                Estudio.edadAlumno = _reader.GetInt32(4);
                Estudio.sexoAlumno= _reader.GetString(5);

                


                lista.Add(Estudio);
            }
            
            return lista;
        }

        public static C_DatosGenerales ObtenerDatosGenerales(double cod)
        {
            C_DatosGenerales Estudio = new C_DatosGenerales();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  IdAlum, nomAlumno, LugarNaciAlum, FechaNaciAlum, EdadAlum, SexoAlum FROM alumnos  where CodAlumno= '{0}' ", cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Estudio.idAlumno = _reader.GetDouble(0);
                Estudio.nombreAlumno = _reader.GetString(1);
                Estudio.lugarNacAlumno = _reader.GetString(2);
                Estudio.fecha_NacAlumno = _reader.GetDateTime(3);
                Estudio.edadAlumno = _reader.GetInt32(4);
                Estudio.sexoAlumno = _reader.GetString(5);

            }

            conexion.Close();
            return Estudio;

        }





    }
}
