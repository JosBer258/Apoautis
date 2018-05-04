using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOAUTIS.Clases
{
    class C_EntrevistaIngreCambios : Conexion
    {
        public void ActualizarAlumno(int cod, string escol, string direcion, string telefono)
        {

            this.sql = string.Format(@"update alumnos set DireccionAlum='{0}', TelFijoAlum='{1}', EscolaridadAlum='{2}' where CodAlumno='{3}'; ",
                direcion, telefono, escol, cod);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public void ActualizarEntrevistaPadres(int cod, string referidoPor, string DetallesFuera, string Lugar, string Fecha)
        {

            this.sql = string.Format(@"update entrevistapadres set ReferidoPor='{0}', DetalleFueraEntre='{1}', Lugar='{2}', Fecha='{3}' where Alumnos_CodAlumno='{4}';"
                                            , referidoPor, DetallesFuera, Lugar, Fecha, cod);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public void ActualizaAnamnesis(int cod, string tipofamilia, string duraciongestacion, string pesoalnacer, string datosprenatales, string perinatales, string postnatales)
        {

            this.sql = string.Format(@"update anamnesis set TipoFamilia = '{0}', DuracionGestacion = '{1}', PesoAlNacer = '{2}', 
                                        DatosPrenatales = '{3}', DatosPerinatales = '{4}', DatosPostnatales = '{5}' where Alumnos_CodAlumno = '{6}';"
                                            , tipofamilia, duraciongestacion, pesoalnacer, datosprenatales, perinatales, postnatales, cod);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }




        public void ActualizaRelacion(int cod, string apegumienbro, string relacionconpadres, string comporgeneral, string relacionhermanos)
        {

            this.sql = string.Format(@"update relacionfamiliar set ApegoUnMiemFami = '{0}', RelacionesConPadres = '{1}',
ComporEnGeneral = '{2}', RelacionConHermanos = '{3}' where Alumnos_CodAlumno = '{4}';", apegumienbro, relacionconpadres, comporgeneral, relacionhermanos, cod);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }



        public void ActualComoReacciona(int cod, string CorteCabello, string CorteUnnas, string Limpieza, string Cepill, string ConAdultos, string Cambios)
        {

            this.sql = string.Format(@"update reaccionaante
            set CorteCabello='{0}', CorteUnas='{1}', LimpiezaOidos='{2}', Cepillado='{3}', ConAdultosNinos='{4}', 
            ComoReacAnteCambios='{5}' where Alumnos_CodAlumno='{6}';", CorteCabello, CorteUnnas, Limpieza, Cepill, ConAdultos, Cambios, cod);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public void ActualizarMotors(int cod, string Control, string sesento, string gateo, string camino, string saltar, string antecendentes, string movpeculia)
        {
            this.sql = string.Format(@"update desarrollomotriz
set ControlCuello='{0}', SeSento='{1}', Gateo='{2}', Camino='{3}', 
Salta='{4}', AntecedentesTransFami='{5}', MovPeculiManoCuerp='{6}'
where Alumnos_CodAlumno='{7}';", Control, sesento, gateo, camino, saltar, antecendentes, movpeculia, cod);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }

        public void ActualizarComportamiento(int cod, string AceptaBusca, string participa,
            string IntegradoKinder, string Desdecuando, string QueManifiesta, string ComoSeDesenvuelve,
            string InteresParticular, string DescribaDiaNormal)
        {
            this.sql = string.Format(@"update `desarrollosocial/comportamiento` set
                                        AceptaBuscaInteraccion='{0}', ParticipaEnActividades='{1}', 
                                        IntegradoEnKinder='{2}', DesdeCuanIntegrado='{3}', QueManifiesSuMaestra='{4}', ComoSeDesenvuelve='{5}', InteresPArticularJuguete='{6}', DescribaDiaNormal='{7}'
                                           where Alumnos_CodAlumno='{8}';", AceptaBusca, participa, IntegradoKinder, Desdecuando, QueManifiesta,ComoSeDesenvuelve, InteresParticular, DescribaDiaNormal, cod);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }

        

        public void ActualizarLenguaje(string EdadComSonGut, string EdadComSonVocales, string EdadSonSil, 
            string EdadComSonPal, string ProporConversacion, string MuestraInt, string Hablaentercera, string DirecOraciones,
            string Repite, int cod_Alumno)
        {
            this.sql = string.Format(@"update desarrollolenguaje set EdadComSonGut='{0}', EdadComSonVoc='{1}', 
EdadComSonSil='{2}', EdadComSonPal='{3}', PropiciaConver='{4}', 
MuestraIntTema='{5}', HablaEnTerPers='{6}', DiceOracCompl='{7}', 
RepitePalaEsc='{8}'where Alumnos_CodAlumno='{9}';", EdadComSonGut, EdadComSonVocales, EdadSonSil, EdadComSonPal, ProporConversacion, MuestraInt, Hablaentercera, DirecOraciones, Repite, cod_Alumno
                );
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public void ActualizarVida(string RitmoSueño, string DuermeSolo, string AqueHoraSeAcuesta, string AqueHoraSeLevanta, 
            string DuermeSinInterrupc, string DuermeConObjetosEspecial, string ComidaFavor, string ComidaquNoLegusta,
            string ComeSolo, string UtilizaCubiertos, string DesdequeEdadComeSolo, string Comecosasquenoseancomest,
            string LeAgradaBanarse, string CooperaParaElBano,string SeBanaSolo,string SeCambiaSolo,string CooperaParaCambiarse,
            string TieneRopaFavorita, string ControlaEsfinter, string  MuestraSignosDefecado, string DaConoserPanalSucio,
string DesdeQueEdadControlaEsfienter, string DesdeQueEdadUsaInodoro, string SeLimpiaSolo, string SeDejaLimpiar, int Cod)
        {
            this.sql = string.Format(@"update vidadiaria
            set ComoEsSuRitmoDeSueño='{0}', DuermeSolo='{1}', AqueHoraSeAcuesta='{2}', AqueHoraSeLevanta='{3}',
            DuermeSinInterruccion='{4}', DuermeConObjetoEspecial='{5}', ComidaFavorita='{6}', ComidaQueNoLeGusta='{7}',
            ComeSolo='{8}', UtilizaCubierto='{9}', DesdeQueEdadComeSolo='{10}', ComeCosasQueNoSeanComestibles='{11}',
            LeAgradaBanarse='{12}', CooperaParaElBano='{13}', SeBanaSolo='{14}', SeCambiaSolo='{15}', CooperaParaCambiarse='{16}',
            TieneRopaFavorita='{17}', ControlaEsfinter='{18}', MuestraSignosDefecado='{19}', DaConoserPanalSucio='{20}',
            DesdeQueEdadControlaEsfienter='{21}', DesdeQueEdadUsaInodoro='{22}', SeLimpiaSolo='{23}', SeDejaLimpiar='{24}'
            where Alumnos_CodAlumno='{25}';", RitmoSueño,  DuermeSolo,  AqueHoraSeAcuesta, AqueHoraSeLevanta,
             DuermeSinInterrupc,DuermeConObjetosEspecial, ComidaFavor, ComidaquNoLegusta,
            ComeSolo, UtilizaCubiertos, DesdequeEdadComeSolo, Comecosasquenoseancomest,
            LeAgradaBanarse, CooperaParaElBano, SeBanaSolo, SeCambiaSolo, CooperaParaCambiarse,
            TieneRopaFavorita, ControlaEsfinter,  MuestraSignosDefecado, DaConoserPanalSucio,
             DesdeQueEdadControlaEsfienter, DesdeQueEdadUsaInodoro, SeLimpiaSolo, SeDejaLimpiar, Cod);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }


        public bool llenarDatosHistoriaMedico(int CodAlumno11)
        {
            bool Resp = false;

            this.sql = string.Format(@"select * from entrevistapadres where  Alumnos_CodAlumno='{0}';", CodAlumno11);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Resp = true;
                this.cnx.Close();


            }
            else
            {

            }
            this.cnx.Close();

            return Resp;
        }

    }
}
