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

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO estudiosocioeconomico (CodEstudioSE,Alumnos_CodAlumno, Lugar, Fecha, PersonaEntrevis, RevisaAproPor) values ('{0}','{1}','{2}', '{3}','{4}','{5}')",
                estudio.CodEstudioSocio,estudio.CodAlumno, estudio.LugarEntrevista, estudio.FechaEntrevista, estudio.PersonaEntrevis,estudio.EntrevistadoPor1), C_EstudioSocioMetodos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int AgregarEInformacionFamilia(C_InformacionFamilia infoFamilia)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO informacionfamilia (Alumnos_CodAlumno, PersonasHabitan, TienenMasHijos, HabitanOtrosFami, MiemEnTotal, CuantMiembrTrab, IngresoAbuela,IngresoMadre,IngresoPadre, IngresoHijo, Pension, OtrosIngresos, TotalMensLemp, GastoEnergiaElec, GastoAgua, GastoTel, GastoComida, GastoTransp, GastoSalub, GastoEduca, GastoGaso,GastoRopa, GastoVivienda, OtrosGastos,TotalGastos) VALUES ('{0}','{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}')",
            infoFamilia.CodAlumno1,infoFamilia.PersonasHabitan1,infoFamilia.TieneMasHijos1, infoFamilia.HabitanOtrosFamiliares1, infoFamilia.MienEnTotal1,infoFamilia.CuantosMiembrosTrabajan1,infoFamilia.IngresoAbuela1,infoFamilia.IngresoMadre1,infoFamilia.IngresoPadre1,infoFamilia.IngresoHijo1,infoFamilia.Pension1,infoFamilia.OtrosIngresos1,infoFamilia.TotalIngresos1,infoFamilia.GastosEnergia1,infoFamilia.GastoAgua1,infoFamilia.GastoTel1,infoFamilia.GastoComida1,infoFamilia.GastoTransp1,infoFamilia.GastoSalub1,infoFamilia.GastoEduca1,infoFamilia.GastoGaso1,infoFamilia.GastoRpa1,infoFamilia.GastoVivienda1,infoFamilia.OtrosGastos1,infoFamilia.TotalGastos1), C_EstudioSocioMetodos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int AgregarAtencionMedica(C_HistorialMedico Medico)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE historialmedico SET LugaresRecibeAtencionMedica='{0}', EnfermePadecenFamili='{1}', CuantoGastaEnMed='{2}' WHERE Alumnos_CodAlumno='{3}'",Medico.LugaresRecibeAtencion1 ,Medico.EnfermedadesPadeceFamilia1 , Medico.CuantoGastaMedi1, Medico.CodigoAlum), C_EstudioSocioMetodos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }

        public static int AgregarLugaresRecreacion(C_LugaresRecreacion recreacion)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO lugaresrecreacion (Alumnos_CodAlumno, Parques, CentrosComerciales, Museos, Cine, Balnearios, Playa, Otros) VALUES ('{0}', '{1} ', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
            recreacion.CodAlumno, recreacion.Parques, recreacion.CentrosComerciales, recreacion.Museos,recreacion.Cine,recreacion.Balnearios,recreacion.Playa,recreacion.Otros), C_EstudioSocioMetodos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }

        public static int AgregarInfovivienda(C_InformacionVivienda vivienda)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO informacionvivienda (Alumnos_CodAlumno, Tenencia, MaterialConst, MaterialPiso, ServiciosBacicos, DisponeDe) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",
            vivienda.CodAlumno, vivienda.Tenencia, vivienda.MaterialConst, vivienda.MaterialPiso,vivienda.ServicioBasicos, vivienda.DisponeDe), C_EstudioSocioMetodos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }

        
        public static int AgregarMadre(C_responsablesMadre madre)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE responsables SET NumIdRes='{0}', DomicilioRes='{1}', LugarTrabajoRes='{2}', TelCasaRes='{3}',TelTrabajoRes='{4}' WHERE CodResp='{5}'", madre.IdResp, madre.DomicilioResp, madre.LugarTrabRes, madre.TelefonoCasaResp, madre.TrabajoResp,madre.CodResp), C_EstudioSocioMetodos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }

        public static int AgregarPadre(C_responsablePadre padre)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE responsables SET NumIdRes='{0}', DomicilioRes='{1}', LugarTrabajoRes='{2}', TelCasaRes='{3}',TelTrabajoRes='{4}' WHERE CodResp='{5}'", padre.IdResp, padre.DomicilioResp, padre.LugarTrabRes, padre.TelefonoCasaResp, padre.TrabajoResp,padre.CodResp), C_EstudioSocioMetodos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }

        public static int AgregarOtro(C_ResponsablesOtro otro)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE responsables as a inner  join encargadootrofamiliar as b  on a.CodResp = b.CodEncargadoOtrofam SET a.NomComRes='{0}', b.ParentescoEncarg='{1}', a.TelCelRes='{2}', a.ProfecionRes='{3}' , b.Edad='{4}' WHERE CodResp='{5}'", otro.NomRespOtro, otro.Parentesco, otro.Telefono,otro.Profesion ,otro.Edad, otro.CodRespOtro), C_EstudioSocioMetodos.ObtenerConexion());
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
        public static List<C_responsablesMadre> BuscarMadre(string nombreAlumno)
        {
            List<C_responsablesMadre> lista = new List<C_responsablesMadre>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT b.CodAlumno,a.CodResp, a.NomComRes, a.NumIdRes, a.DomicilioRes, a.ProfecionRes, a.OficioRes, a.LugarTrabajoRes, a.TelCasaRes, a.TelCelRes, a.TelTrabajoRes, a.CorreoRes, a.tiporesponsable_cod  FROM responsables as a INNER JOIN  `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON b.CodAlumno= c.CodAlumno where a.tiporesponsable_cod='1' and  c.CodAlumno= '{0}'",
            nombreAlumno), C_EstudioSocioMetodos.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                C_responsablesMadre madre= new C_responsablesMadre();
                madre.CodAlumno = _reader.GetInt32(0);
                madre.CodResp= _reader.GetInt32(1);
                madre.NombResp = _reader.GetString(2);
                madre.IdResp = _reader.GetInt32(3);
                madre.DomicilioResp = _reader.GetString(4);
                madre.ProfesionResp1 = _reader.GetString(5);
                madre.OficioREsp = _reader.GetString(6);
                madre.LugarTrabRes = _reader.GetString(7);
                madre.TelefonoCasaResp = _reader.GetString(8);
                madre.CelResp = _reader.GetString(9);
                madre.TrabajoResp = _reader.GetString(10);
                madre.CorreoResp= _reader.GetString(11);
                madre.TipoRes = _reader.GetInt32(12);


                lista.Add(madre);
            }

            return lista;
        }

        public static List<C_responsablePadre> BuscarPadre(string nombreAlumno)
        {
            List<C_responsablePadre> lista = new List<C_responsablePadre>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT b.CodAlumno,a.CodResp, a.NomComRes, a.NumIdRes, a.DomicilioRes, a.ProfecionRes, a.OficioRes, a.LugarTrabajoRes, a.TelCasaRes, a.TelCelRes, a.TelTrabajoRes, a.CorreoRes, a.tiporesponsable_cod  FROM responsables as a INNER JOIN  `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON b.CodAlumno= c.CodAlumno where a.tiporesponsable_cod='2' and  c.CodAlumno= '{0}'",
            nombreAlumno), C_EstudioSocioMetodos.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                C_responsablePadre padre = new C_responsablePadre();
                padre.CodAlumno = _reader.GetInt32(0);
                padre.CodResp = _reader.GetInt32(1);
                padre.NombResp = _reader.GetString(2);
                padre.IdResp = _reader.GetInt32(3);
                padre.DomicilioResp = _reader.GetString(4);
                padre.ProfesionResp1 = _reader.GetString(5);
                padre.OficioREsp = _reader.GetString(6);
                padre.LugarTrabRes = _reader.GetString(7);
                padre.TelefonoCasaResp = _reader.GetString(8);
                padre.CelResp = _reader.GetString(9);
                padre.TrabajoResp = _reader.GetString(10);
                padre.CorreoResp = _reader.GetString(11);
                padre.TipoRes = _reader.GetInt32(12);


                lista.Add(padre);
            }

            return lista;
        }

        public static List<C_ResponsablesOtro> BuscarOtros(string nombreAlumno)
        {
            List<C_ResponsablesOtro> lista = new List<C_ResponsablesOtro>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT b.CodAlumno,a.CodResp,d.Edad,d.ParentescoEncarg, a.NomComRes, a.ProfecionRes, a.OficioRes, a.TelCelRes, a.tiporesponsable_cod  FROM encargadootrofamiliar as d INNER JOIN responsables as a on d.Responsables_CodResp  = a.CodResp  INNER JOIN   `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON  b.CodAlumno = c.CodAlumno  where a.CodResp='3' and  c.CodAlumno='{0}' ",
            nombreAlumno), C_EstudioSocioMetodos.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                C_ResponsablesOtro otro = new C_ResponsablesOtro();
                otro.CodAlumno = _reader.GetInt32(0);
                otro.CodRespOtro = _reader.GetInt32(1);
                otro.Edad = _reader.GetInt32(2);
                otro.Parentesco = _reader.GetString(3);
                otro.NomRespOtro = _reader.GetString(4);
                otro.Profesion = _reader.GetString(5);
                otro.Oficio = _reader.GetString(6);
                otro.Telefono = _reader.GetString(7);
                otro.TipoResp = _reader.GetInt32(8);


                lista.Add(otro);
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

        
        public static C_responsablesMadre ObtenerMadre(double cod)
        {
            C_responsablesMadre madre = new C_responsablesMadre();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT b.CodAlumno,a.CodResp, a.NomComRes, a.NumIdRes, a.DomicilioRes, a.ProfecionRes, a.OficioRes, a.LugarTrabajoRes, a.TelCasaRes, a.TelCelRes, a.TelTrabajoRes, a.CorreoRes, a.tiporesponsable_cod  FROM responsables as a INNER JOIN  `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON b.CodAlumno= c.CodAlumno where a.tiporesponsable_cod='1' and  c.CodAlumno= '{0}'", cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                madre.CodAlumno = _reader.GetInt32(0);
                madre.CodResp = _reader.GetInt32(1);
                madre.NombResp = _reader.GetString(2);
                madre.IdResp = _reader.GetInt32(3);
                madre.DomicilioResp = _reader.GetString(4);
                madre.ProfesionResp1 = _reader.GetString(5);
                madre.OficioREsp = _reader.GetString(6);
                madre.LugarTrabRes = _reader.GetString(7);
                madre.TelefonoCasaResp = _reader.GetString(8);
                madre.CelResp = _reader.GetString(9);
                madre.TrabajoResp = _reader.GetString(10);
                madre.CorreoResp = _reader.GetString(11);
                madre.TipoRes = _reader.GetInt32(12);


            }

            conexion.Close();
            return madre;

        }

        public static C_responsablePadre ObtenerPadre(double cod)
        {
            C_responsablePadre padre = new C_responsablePadre();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT b.CodAlumno,a.CodResp, a.NomComRes, a.NumIdRes, a.DomicilioRes, a.ProfecionRes, a.OficioRes, a.LugarTrabajoRes, a.TelCasaRes, a.TelCelRes, a.TelTrabajoRes, a.CorreoRes, a.tiporesponsable_cod  FROM responsables as a INNER JOIN  `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON b.CodAlumno= c.CodAlumno where a.tiporesponsable_cod='2' and  c.CodAlumno= '{0}'", cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                padre.CodAlumno = _reader.GetInt32(0);
                padre.CodResp = _reader.GetInt32(1);
                padre.NombResp = _reader.GetString(2);
                padre.IdResp = _reader.GetInt32(3);
                padre.DomicilioResp = _reader.GetString(4);
                padre.ProfesionResp1 = _reader.GetString(5);
                padre.OficioREsp = _reader.GetString(6);
                padre.LugarTrabRes = _reader.GetString(7);
                padre.TelefonoCasaResp = _reader.GetString(8);
                padre.CelResp = _reader.GetString(9);
                padre.TrabajoResp = _reader.GetString(10);
                padre.CorreoResp = _reader.GetString(11);
                padre.TipoRes = _reader.GetInt32(12);


            }

            conexion.Close();
            return padre;

        }

        public static C_ResponsablesOtro ObtenerOtro(double cod)
        {
            C_ResponsablesOtro otro = new C_ResponsablesOtro();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT b.CodAlumno,a.CodResp,d.Edad,d.ParentescoEncarg, a.NomComRes, a.ProfecionRes, a.OficioRes, a.TelCelRes, a.tiporesponsable_cod  FROM encargadootrofamiliar as d INNER JOIN responsables as a on d.Responsables_CodResp  = a.CodResp  INNER JOIN   `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON  b.CodAlumno = c.CodAlumno  where a.CodResp='3' and  c.CodAlumno='{0}' ", cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                otro.CodAlumno = _reader.GetInt32(0);
                otro.CodRespOtro = _reader.GetInt32(1);
                otro.Edad = _reader.GetInt32(2);
                otro.Parentesco = _reader.GetString(3);
                otro.NomRespOtro = _reader.GetString(4);
                otro.Profesion = _reader.GetString(5);
                otro.Oficio = _reader.GetString(6);
                otro.Telefono = _reader.GetString(7);
                otro.TipoResp = _reader.GetInt32(8);


            }

            conexion.Close();
            return otro;

        }










    }
}
