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


        public static int AgregarOtroResp(C_ResponsablesOtro otroresp)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO encargadootrofamiliar (Responsables_CodResp, ParentescoEncarg, Edad) VALUES ('{0}', '{1}', '{2}');",
            otroresp.CodRespOtro, otroresp.Parentesco,otroresp.Edad), C_EstudioSocioMetodos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }

        
        public static int AgregarOtroTipo(C_ResponsablesOtro tipo)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `alumnos/responsables` (CodAlumno, CodResp, Cod_TipoResp) VALUES ('{0}', '{1}', '3');",
            tipo.CodAlumno,tipo.CodRespOtro), C_EstudioSocioMetodos.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }
        public static int AgregarOtro(C_ResponsablesOtro otro)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO responsables (NomComRes, ProfecionRes, TelCelRes) VALUES ('{0}', '{1}', '{2}')", otro.NomRespOtro, otro.Profesion,otro.Telefono), C_EstudioSocioMetodos.ObtenerConexion());
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
           "SELECT b.CodAlumno,a.CodResp, a.NomComRes, a.NumIdRes, a.DomicilioRes, a.ProfecionRes, a.OficioRes, a.LugarTrabajoRes, a.TelCasaRes, a.TelCelRes, a.TelTrabajoRes, a.CorreoRes, b.Cod_TipoResp  FROM responsables as a INNER JOIN  `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON b.CodAlumno= c.CodAlumno where b.Cod_TipoResp='2' and  c.CodAlumno= '{0}'",
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
           "SELECT b.CodAlumno,a.CodResp, a.NomComRes, a.NumIdRes, a.DomicilioRes, a.ProfecionRes, a.OficioRes, a.LugarTrabajoRes, a.TelCasaRes, a.TelCelRes, a.TelTrabajoRes, a.CorreoRes, b.Cod_TipoResp  FROM responsables as a INNER JOIN  `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON b.CodAlumno= c.CodAlumno where b.Cod_TipoResp='1' and  c.CodAlumno= '{0}'",
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
           "SELECT b.CodAlumno,a.CodResp,d.Edad,d.ParentescoEncarg, a.NomComRes, a.ProfecionRes, a.OficioRes, a.TelCelRes,  b.Cod_TipoResp FROM encargadootrofamiliar as d INNER JOIN responsables as a on d.Responsables_CodResp  = a.CodResp  INNER JOIN   `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON  b.CodAlumno = c.CodAlumno  where a.CodResp='3' and  c.CodAlumno='{0}' ",
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

        

        public static C_EstudioSocioEc ObtenerEstudioSE(double cod)
        {
            C_EstudioSocioEc Estudio = new C_EstudioSocioEc();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Alumnos_CodAlumno, Lugar, Fecha, PersonaEntrevis, RevisaAproPor FROM estudiosocioeconomico where Alumnos_CodAlumno = '{0}'", cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Estudio.CodAlumno = _reader.GetInt32(0);
                Estudio.LugarEntrevista= _reader.GetString(1);
                Estudio.FechaEntrevista = _reader.GetString(2);
                Estudio.PersonaEntrevis = _reader.GetString(3);
                Estudio.EntrevistadoPor1 = _reader.GetString(4);


            }

            conexion.Close();
            return Estudio;

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

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT b.CodAlumno,a.CodResp, a.NomComRes, a.NumIdRes, a.DomicilioRes, a.ProfecionRes, a.OficioRes, a.LugarTrabajoRes, a.TelCasaRes, a.TelCelRes, a.TelTrabajoRes, a.CorreoRes, b.Cod_TipoResp FROM responsables as a INNER JOIN  `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON b.CodAlumno= c.CodAlumno where b.Cod_TipoResp='2' and  c.CodAlumno= '{0}'", cod), conexion);
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

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT b.CodAlumno,a.CodResp, a.NomComRes, a.NumIdRes, a.DomicilioRes, a.ProfecionRes, a.OficioRes, a.LugarTrabajoRes, a.TelCasaRes, a.TelCelRes, a.TelTrabajoRes, a.CorreoRes, b.Cod_TipoResp FROM responsables as a INNER JOIN  `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON b.CodAlumno= c.CodAlumno where b.Cod_TipoResp='1' and  c.CodAlumno= '{0}'", cod), conexion);
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

        public static C_ResponsablesOtro ObtenerOtro()
        {
            C_ResponsablesOtro otro = new C_ResponsablesOtro();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT t.CodResp FROM `alumnos/responsables` t WHERE t.CodResp = ( SELECT MAX(CodResp)  FROM `alumnos/responsables`)"), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                otro.CodRespOtro = _reader.GetInt32(0);

            }

            conexion.Close();
            return otro;

        }

        

            public static C_HistorialMedico ObtenerHistorialMedico(double cod)
        {
            C_HistorialMedico medico= new C_HistorialMedico();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Alumnos_CodAlumno, LugaresRecibeAtencionMedica, EnfermePadecenFamili, CuantoGastaEnMed from historialmedico where Alumnos_CodAlumno = '{0}'", cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                medico.CodigoAlum= _reader.GetInt32(0);
                medico.LugaresRecibeAtencion1= _reader.GetString(1);
                medico.EnfermedadesPadeceFamilia1= _reader.GetString(2);
                medico.CuantoGastaMedi1= _reader.GetDouble(3);

            }

            conexion.Close();
            return medico;

        }

        public static C_LugaresRecreacion ObtenerRecreacion(double cod)
        {
            C_LugaresRecreacion recre = new C_LugaresRecreacion();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format(" SELECT Alumnos_CodAlumno, Parques, CentrosComerciales, Museos, Cine, Balnearios, Playa, Otros from lugaresrecreacion where Alumnos_CodAlumno = '{0}'", cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                recre.CodAlumno = _reader.GetInt32(0);
                recre.Parques = _reader.GetString(1);
                recre.CentrosComerciales = _reader.GetString(2);
                recre.Museos = _reader.GetString(3);
                recre.Cine = _reader.GetString(4);
                recre.Balnearios = _reader.GetString(5);
                recre.Playa = _reader.GetString(6);
                recre.Otros = _reader.GetString(7);

            }

            conexion.Close();
            return recre;

        }

        public static C_ResponsablesOtro ObtenerOtroResp(double cod)
        {
            C_ResponsablesOtro otro = new C_ResponsablesOtro();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT b.CodAlumno,a.CodResp,d.ParentescoEncarg, d.Edad, a.NomComRes,a.ProfecionRes,a.TelCelRes, b.Cod_TipoResp FROM   encargadootrofamiliar as d INNER JOIN  responsables as a   on d.Responsables_CodResp  = a.CodResp  INNER JOIN  `alumnos/responsables`  as b ON a.CodResp = b.CodResp  INNER JOIN alumnos as c ON b.CodAlumno= c.CodAlumno where b.Cod_TipoResp='3' and  c.CodAlumno= '{0}'",cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                otro.CodAlumno = _reader.GetInt32(0);
                otro.CodRespOtro = _reader.GetInt32(1);
                otro.Parentesco = _reader.GetString(2);
                otro.Edad= _reader.GetInt32(3);
                otro.NomRespOtro = _reader.GetString(4);
                otro.Profesion = _reader.GetString(5);
                otro.Cel= _reader.GetString(6);
                otro.TipoResp = _reader.GetInt32(7);

            }

            conexion.Close();
            return otro;

        }


        public static C_InformacionVivienda ObtenerInfoVivienda(double cod)
        {
            C_InformacionVivienda vivienda = new C_InformacionVivienda();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Alumnos_CodAlumno, Tenencia, MaterialConst, MaterialPiso, ServiciosBacicos, DisponeDe from informacionvivienda where Alumnos_CodAlumno ='{0}'", cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                vivienda.CodAlumno = _reader.GetInt32(0);
                vivienda.Tenencia = _reader.GetString(1);
                vivienda.MaterialConst = _reader.GetString(2);
                vivienda.MaterialPiso= _reader.GetString(3);
                vivienda.ServicioBasicos = _reader.GetString(4);
                vivienda.DisponeDe = _reader.GetString(5);
            }

            conexion.Close();
            return vivienda;

        }

        public static C_InformacionFamilia ObtenerInfofamilia(double cod)
        {
            C_InformacionFamilia familia = new C_InformacionFamilia();
            MySqlConnection conexion = C_EstudioSocioMetodos.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT Alumnos_CodAlumno, PersonasHabitan, TienenMasHijos, HabitanOtrosFami, MiemEnTotal, CuantMiembrTrab, IngresoAbuela, IngresoMadre, IngresoPadre, IngresoHijo, Pension, OtrosIngresos, TotalMensLemp,GastoEnergiaElec, GastoAgua, GastoTel, GastoComida, GastoTransp, GastoSalub, GastoEduca, GastoGaso, GastoRopa, GastoVivienda, OtrosGastos, TotalGastos from informacionfamilia where Alumnos_CodAlumno = '{0}'", cod), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                familia.CodAlumno1 = _reader.GetInt32(0);
                familia.PersonasHabitan1 = _reader.GetInt32(1);
                familia.TieneMasHijos1 = _reader.GetString(2);
                familia.HabitanOtrosFamiliares1= _reader.GetString(3);
                familia.CuantosMiembrosTrabajan1 = _reader.GetInt32(4);
                familia.IngresoAbuela1 = _reader.GetDouble(5);
                familia.IngresoMadre1 = _reader.GetDouble(6);
                familia.IngresoPadre1 = _reader.GetDouble(7);
                familia.IngresoHijo1 = _reader.GetDouble(8);
                familia.Pension1 = _reader.GetDouble(9);
                familia.OtrosIngresos1 = _reader.GetDouble(10);
                familia.TotalIngresos1 = _reader.GetDouble(11);
                familia.GastosEnergia1 = _reader.GetDouble(12);
                familia.GastoAgua1 = _reader.GetDouble(13);
                familia.GastoTel1 = _reader.GetDouble(14);
                familia.GastoComida1 = _reader.GetDouble(15);
                familia.GastoTransp1 = _reader.GetDouble(16);
                familia.GastoSalub1 = _reader.GetDouble(17);
                familia.GastoEduca1 = _reader.GetDouble(18);
                familia.GastoGaso1 = _reader.GetDouble(19);
                familia.GastoRpa1 = _reader.GetDouble(20);
                familia.GastoVivienda1 = _reader.GetDouble(21);
                familia.OtrosGastos1 = _reader.GetDouble(22);
                familia.TotalGastos1 = _reader.GetDouble(23);

            }

            conexion.Close();
            return familia;

        }










    }
}
