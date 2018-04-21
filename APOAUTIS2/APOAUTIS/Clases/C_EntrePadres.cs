using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace APOAUTIS.Clases
{
    class C_EntrePadres : Conexion
    {

        //formulario de datos generales
        private string fecha_nacimiento;
        private string edad_cronograma;
        private string responsables;
        private string escolaridad;
        private string direccion;
        private string telefono;
        private string referido_por;
        private string lugar;
        private string fecha;
        public void fun_datosgenerales(string FV_Entr)
        {
            this.sql = string.Format(@"insert into entrevistapadres (`Alumnos_CodAlumno`,ReferidoPor,lugar,fecha, DetalleFueraEntre) values ('{0}','{1}','{2}','{3}','{4}')",
           CodAlumno, referido_por, lugar, fecha, FV_Entr);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

        }
        public void Fun_buscar_alumno(DataGridView dgv, string a)
        {
            cnx.Open();
            try
            {
                string busq;
                busq = a;
                this.sql = string.Format
                (@"select CodAlumno as 'Codigo de Alumno', NomAlumno as 'Nombre de Alumno',FechaNaciAlum as 'fecha de nacimiento',EdadCronologica as 'edad cronologica',EscolaridadAlum as 'escolaridad del alumno',DireccionAlum as 'direccion del alumno',TelFijoAlum as 'telefono fijo' from alumnos where NomAlumno like '%{0}%'", busq);
                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.DataAdapter = new MySqlDataAdapter(this.cmd);
                this.dt = new DataTable();
                this.DataAdapter.Fill(this.dt);
                dgv.DataSource = this.dt;

            }
            catch
            {

            }
            cnx.Close();

        }

        public void Fun_mostrar_alumno(DataGridView dgv)
        {
            cnx.Open();
            try
            {
                //string busq;

                this.sql = string.Format
                (@"select CodAlumno as 'Codigo de Alumno', NomAlumno as 'Nombre de Alumno',FechaNaciAlum as 'fecha de nacimiento',EdadCronologica as 'edad cronologica',EscolaridadAlum as 'escolaridad del alumno',DireccionAlum as 'direccion del alumno',TelFijoAlum as 'telefono fijo' from alumnos");
                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.DataAdapter = new MySqlDataAdapter(this.cmd);
                this.dt = new DataTable();
                this.DataAdapter.Fill(this.dt);
                dgv.DataSource = this.dt;

            }
            catch
            {

            }
            cnx.Close();

        }

        //formulario de anamnesis

        private int codAlumno;
        private string nomAlumno;
        private string tipo_fam;
        private string peso_nacer;
        private string dura_gestion;
        private string datos_rele_prenatales;
        private string datos_rele_perinatales;
        private string datos_rele_posnatales;

        public string Tipo_fam
        {
            get
            {
                return tipo_fam;
            }

            set
            {
                tipo_fam = value;
            }
        }

        public string Peso_nacer
        {
            get
            {
                return peso_nacer;
            }

            set
            {
                peso_nacer = value;
            }
        }

        public string Dura_gestion
        {
            get
            {
                return dura_gestion;
            }

            set
            {
                dura_gestion = value;
            }
        }

        public string Datos_rele_prenatales
        {
            get
            {
                return datos_rele_prenatales;
            }

            set
            {
                datos_rele_prenatales = value;
            }
        }

        public string Datos_rele_perinatales
        {
            get
            {
                return datos_rele_perinatales;
            }

            set
            {
                datos_rele_perinatales = value;
            }
        }

        public string Datos_rele_posnatales
        {
            get
            {
                return datos_rele_posnatales;
            }

            set
            {
                datos_rele_posnatales = value;
            }
        }



        public void fun_anamnesis()
        {
            this.sql = string.Format(@"insert into anamnesis values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
           CodAlumno, tipo_fam, dura_gestion, peso_nacer, datos_rele_prenatales, datos_rele_perinatales, datos_rele_posnatales);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

        }
        //formulario de desarrollo de motriz
        private string control_cuello;
        private string se_sento;
        private string gateo;
        private string camino;
        private string corrio;
        private string salta;
        private string antece_trans_fami;
        private string mov_pecul_cuerpo;

        public string Control_cuello
        {
            get
            {
                return control_cuello;
            }

            set
            {
                control_cuello = value;
            }
        }

        public string Se_sento
        {
            get
            {
                return se_sento;
            }

            set
            {
                se_sento = value;
            }
        }

        public string Gateo
        {
            get
            {
                return gateo;
            }

            set
            {
                gateo = value;
            }
        }

        public string Camino
        {
            get
            {
                return camino;
            }

            set
            {
                camino = value;
            }
        }

        public string Corrio
        {
            get
            {
                return corrio;
            }

            set
            {
                corrio = value;
            }
        }

        public string Salta
        {
            get
            {
                return salta;
            }

            set
            {
                salta = value;
            }
        }

        public string Antece_trans_fami
        {
            get
            {
                return antece_trans_fami;
            }

            set
            {
                antece_trans_fami = value;
            }
        }

        public string Mov_pecul_cuerpo
        {
            get
            {
                return mov_pecul_cuerpo;
            }

            set
            {
                mov_pecul_cuerpo = value;
            }
        }


        public void fun_desa_motris()
        {
            this.sql = string.Format(@"insert into desarrollomotriz values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
            CodAlumno, control_cuello, se_sento, gateo, camino, corrio, salta, antece_trans_fami, mov_pecul_cuerpo);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }
        //desarrollo social y de lenguaje
        private string acepta_busca_interac;
        private string parti_actividades;
        private string edad_son_gut;
        private string edad_son_voc;
        private string edad_son_sila;
        private string edad_son_pal;
        private string propicia_conver;
        private string muestra_inter_tema;
        private string habla_tercera_pers;
        private string dice_oracion_comple;
        private string repite_palabra_escu;
        public string Acepta_busca_interac
        {
            get
            {
                return acepta_busca_interac;
            }

            set
            {
                acepta_busca_interac = value;
            }
        }

        public string Parti_actividades
        {
            get
            {
                return parti_actividades;
            }

            set
            {
                parti_actividades = value;
            }
        }

        public string Edad_son_gut
        {
            get
            {
                return edad_son_gut;
            }

            set
            {
                edad_son_gut = value;
            }
        }

        public string Edad_son_voc
        {
            get
            {
                return edad_son_voc;
            }

            set
            {
                edad_son_voc = value;
            }
        }

        public string Edad_son_sila
        {
            get
            {
                return edad_son_sila;
            }

            set
            {
                edad_son_sila = value;
            }
        }

        public string Edad_son_pal
        {
            get
            {
                return edad_son_pal;
            }

            set
            {
                edad_son_pal = value;
            }
        }
        public string Propicia_conver
        {
            get
            {
                return propicia_conver;
            }

            set
            {
                propicia_conver = value;
            }
        }

        public string Muestra_inter_tema
        {
            get
            {
                return muestra_inter_tema;
            }

            set
            {
                muestra_inter_tema = value;
            }
        }

        public string Habla_tercera_pers
        {
            get
            {
                return habla_tercera_pers;
            }

            set
            {
                habla_tercera_pers = value;
            }
        }

        public string Dice_oracion_comple
        {
            get
            {
                return dice_oracion_comple;
            }

            set
            {
                dice_oracion_comple = value;
            }
        }

        public string Repite_palabra_escu
        {
            get
            {
                return repite_palabra_escu;
            }

            set
            {
                repite_palabra_escu = value;
            }
        }
        public void fun_desalenguaje()
        {
            this.sql = string.Format(@"insert into desarrollolenguaje values (0,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
            CodAlumno, edad_son_gut, edad_son_voc, edad_son_sila, edad_son_pal, propicia_conver, muestra_inter_tema, habla_tercera_pers,
            dice_oracion_comple, repite_palabra_escu);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }
        //acontecimiento medicos
        private string cuando;
        private string donde;
        private string diag_tratamiento;
        private string integrado_kinder;
        private string desde_cuando;
        private string manifiesta_comportamiento_escuela;
        private string deseenvuelve_escuela;
        public string Cuando
        {
            get
            {
                return cuando;
            }

            set
            {
                cuando = value;
            }
        }

        public string Donde
        {
            get
            {
                return donde;
            }

            set
            {
                donde = value;
            }
        }

        public string Diag_tratamiento
        {
            get
            {
                return diag_tratamiento;
            }

            set
            {
                diag_tratamiento = value;
            }
        }

        public string Integrado_kinder
        {
            get
            {
                return integrado_kinder;
            }

            set
            {
                integrado_kinder = value;
            }
        }

        public string Desde_cuando
        {
            get
            {
                return desde_cuando;
            }

            set
            {
                desde_cuando = value;
            }
        }

        public string Manifiesta_comportamiento_escuela
        {
            get
            {
                return manifiesta_comportamiento_escuela;
            }

            set
            {
                manifiesta_comportamiento_escuela = value;
            }
        }
        public string Deseenvuelve_escuela
        {
            get
            {
                return deseenvuelve_escuela;
            }

            set
            {
                deseenvuelve_escuela = value;
            }
        }
        public void fun_aconte_academicos(string Int, string Dia)
        {
            this.sql = string.Format(@"insert into `desarrollosocial/comportamiento`(Alumnos_CodAlumno,AceptaBuscaInteraccion, ParticipaEnActividades,IntegradoEnKinder,DesdeCuanIntegrado,QueManifiesSuMaestra,ComoSeDesenvuelve,InteresPArticularJuguete,DescribaDiaNormal) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
            CodAlumno, acepta_busca_interac, parti_actividades, integrado_kinder, desde_cuando, manifiesta_comportamiento_escuela, deseenvuelve_escuela, Int, Dia);

            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }
        public void fun_aconte_medicos()
        {
            this.sql = string.Format(@"insert into acontecimientomedco values (0,'{0}','{1}','{2}','{3}')",
            CodAlumno, cuando, donde, diag_tratamiento);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        public void Fun_Show(DataGridView dgv, int Cod_Alumno)
        {
            if (string.IsNullOrEmpty(Cod_Alumno.ToString()))
            {
                Cod_Alumno = 0;
            }
            cnx.Open();
            try
            {
                sql = string.Format(@"select cuando,donde,DiagnosticoTratamiento from acontecimientomedco where Alumnos_CodAlumno ='{0}'", Cod_Alumno);
                DataAdapter = new MySqlDataAdapter(sql, ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch(Exception)
            {

            }
            cnx.Close();
        }

        //vida diara
        private string duerme_solo;
        private string hora_acuesta;
        private string hora_levanta;
        private string duerme_sin_interruncion;
        private string duerme_objeto_especial;
        private string comida_favorita;
        private string comida_no_guste;
        private string come_solo;
        private string utiliza_cubierto;
        private string edad_come_solo;
        private string come_no_comestible;
        private string agrada_banarse;
        private string coopera_banarse;
        private string bana;
        private string cambia_solo;
        private string coopera_cambiarse;
        private string ropa_preferida;
        private string controla_sfinter;
        private string muestra_signos_defecando;
        private string conocer_panal_sucio;
        private string edad_controla_esfinter;
        private string uso_inodoro;
        private string limpia_solo;
        private string coopera_limpiarse;
        public string Duerme_solo
        {
            get
            {
                return duerme_solo;
            }

            set
            {
                duerme_solo = value;
            }
        }

        public string Hora_acuesta
        {
            get
            {
                return hora_acuesta;
            }

            set
            {
                hora_acuesta = value;
            }
        }

        public string Hora_levanta
        {
            get
            {
                return hora_levanta;
            }

            set
            {
                hora_levanta = value;
            }
        }

        public string Duerme_objeto_especial
        {
            get
            {
                return duerme_objeto_especial;
            }

            set
            {
                duerme_objeto_especial = value;
            }
        }

        public string Comida_favorita
        {
            get
            {
                return comida_favorita;
            }

            set
            {
                comida_favorita = value;
            }
        }

        public string Comida_no_guste
        {
            get
            {
                return comida_no_guste;
            }

            set
            {
                comida_no_guste = value;
            }
        }

        public string Come_solo
        {
            get
            {
                return come_solo;
            }

            set
            {
                come_solo = value;
            }
        }

        public string Utiliza_cubierto
        {
            get
            {
                return utiliza_cubierto;
            }

            set
            {
                utiliza_cubierto = value;
            }
        }

        public string Edad_come_solo
        {
            get
            {
                return edad_come_solo;
            }

            set
            {
                edad_come_solo = value;
            }
        }

        public string Come_no_comestible
        {
            get
            {
                return come_no_comestible;
            }

            set
            {
                come_no_comestible = value;
            }
        }

        public string Agrada_banarse
        {
            get
            {
                return agrada_banarse;
            }

            set
            {
                agrada_banarse = value;
            }
        }

        public string Coopera_banarse
        {
            get
            {
                return coopera_banarse;
            }

            set
            {
                coopera_banarse = value;
            }
        }

        public string Bana
        {
            get
            {
                return bana;
            }

            set
            {
                bana = value;
            }
        }

        public string Duerme_sin_interruncion
        {
            get
            {
                return duerme_sin_interruncion;
            }

            set
            {
                duerme_sin_interruncion = value;
            }
        }
        public string Cambia_solo
        {
            get
            {
                return cambia_solo;
            }

            set
            {
                cambia_solo = value;
            }
        }

        public string Coopera_cambiarse
        {
            get
            {
                return coopera_cambiarse;
            }

            set
            {
                coopera_cambiarse = value;
            }
        }

        public string Ropa_preferida
        {
            get
            {
                return ropa_preferida;
            }

            set
            {
                ropa_preferida = value;
            }
        }

        public string Controla_sfinter
        {
            get
            {
                return controla_sfinter;
            }

            set
            {
                controla_sfinter = value;
            }
        }

        public string Muestra_signos_defecando
        {
            get
            {
                return muestra_signos_defecando;
            }

            set
            {
                muestra_signos_defecando = value;
            }
        }

        public string Conocer_panal_sucio
        {
            get
            {
                return conocer_panal_sucio;
            }

            set
            {
                conocer_panal_sucio = value;
            }
        }

        public string Edad_controla_esfinter
        {
            get
            {
                return edad_controla_esfinter;
            }

            set
            {
                edad_controla_esfinter = value;
            }
        }

        public string Uso_inodoro
        {
            get
            {
                return uso_inodoro;
            }

            set
            {
                uso_inodoro = value;
            }
        }

        public string Limpia_solo
        {
            get
            {
                return limpia_solo;
            }

            set
            {
                limpia_solo = value;
            }
        }

        public string Coopera_limpiarse
        {
            get
            {
                return coopera_limpiarse;
            }

            set
            {
                coopera_limpiarse = value;
            }
        }



        public void fun_vida(string r)
        {
            this.sql = string.Format(@"insert into vidadiaria (`Alumnos_CodAlumno`,DuermeSolo, AqueHoraSeAcuesta, AqueHoraSeLevanta,DuermeSinInterruccion,DuermeConObjetoEspecial,ComidaFavorita,ComidaQueNoLeGusta
,ComeSolo,UtilizaCubierto,DesdeQueEdadComeSolo,ComeCosasQueNoSeanComestibles,LeAgradaBanarse,CooperaParaElBano,SeBanaSolo,SeCambiaSolo, CooperaParaCambiarse, TieneRopaFavorita,ControlaEsfinter,MuestraSignosDefecado,
DaConoserPanalSucio,DesdeQueEdadControlaEsfienter,DesdeQueEdadUsaInodoro,SeLimpiaSolo,SeDejaLimpiar, ComoEsSuRitmoDeSueño) 
values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}')",
            CodAlumno, duerme_solo, hora_acuesta, hora_levanta, duerme_sin_interruncion, duerme_objeto_especial, comida_favorita, comida_no_guste, come_solo, utiliza_cubierto,
            edad_come_solo, come_no_comestible, agrada_banarse, coopera_banarse, bana, cambia_solo, coopera_cambiarse, ropa_preferida, controla_sfinter, muestra_signos_defecando, conocer_panal_sucio, edad_controla_esfinter, uso_inodoro, limpia_solo,
            coopera_limpiarse, r);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }
        //relacion con la familia 
        private string apego_faniliar;
        private string relacion_padres;
        private string relacion_hermanos;
        private string comportamiento;
        public string Apego_faniliar
        {
            get
            {
                return apego_faniliar;
            }

            set
            {
                apego_faniliar = value;
            }
        }

        public string Relacion_padres
        {
            get
            {
                return relacion_padres;
            }

            set
            {
                relacion_padres = value;
            }
        }

        public string Relacion_hermanos
        {
            get
            {
                return relacion_hermanos;
            }

            set
            {
                relacion_hermanos = value;
            }
        }

        public string Comportamiento
        {
            get
            {
                return comportamiento;
            }

            set
            {
                comportamiento = value;
            }
        }


        public void fun_relacion_familiar()
        {
            this.sql = string.Format(@"insert into relacionfamiliar values ('{0}','{1}','{2}','{3}','{4}')",
            CodAlumno, apego_faniliar, relacion_padres, relacion_hermanos, comportamiento);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }

        //como reacciona ante las siguientes preguntas
        private string corte_pelo;
        private string corte_unas;
        private string limpieza_oidos;
        private string cepilla_dientes;
        private string personas_adultas;
        private string cambios_hogar;
        public string Corte_pelo
        {
            get
            {
                return corte_pelo;
            }

            set
            {
                corte_pelo = value;
            }
        }

        public string Corte_unas
        {
            get
            {
                return corte_unas;
            }

            set
            {
                corte_unas = value;
            }
        }

        public string Limpieza_oidos
        {
            get
            {
                return limpieza_oidos;
            }

            set
            {
                limpieza_oidos = value;
            }
        }

        public string Cepilla_dientes
        {
            get
            {
                return cepilla_dientes;
            }

            set
            {
                cepilla_dientes = value;
            }
        }

        public string Personas_adultas
        {
            get
            {
                return personas_adultas;
            }

            set
            {
                personas_adultas = value;
            }
        }

        public string Cambios_hogar
        {
            get
            {
                return cambios_hogar;
            }

            set
            {
                cambios_hogar = value;
            }
        }



        public void fun_reaccion()
        {
            this.sql = string.Format(@"insert into reaccionaante values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
            CodAlumno, corte_pelo, corte_unas, limpieza_oidos, cepilla_dientes, personas_adultas, cambios_hogar);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }
        //rasgos identificables
        private string interes_particular_juguete;
        private string describadia_normal;
        private string algo_mencionar;
        public string Interes_particular_juguete
        {
            get
            {
                return interes_particular_juguete;
            }

            set
            {
                interes_particular_juguete = value;
            }
        }

        public string Describadia_normal
        {
            get
            {
                return describadia_normal;
            }

            set
            {
                describadia_normal = value;
            }
        }
        public string Algo_mencionar
        {
            get
            {
                return algo_mencionar;
            }

            set
            {
                algo_mencionar = value;
            }
        }
        public void fun_rasgos()
        {
            this.sql = string.Format(@"insert into `desarrollosocial/comportamiento`(`Alumnos_CodAlumno`,InteresPArticularJuguete,QuiereMenciFueEntrevista) values ('{0}','{1}','{2}','{3}')",
            CodAlumno, interes_particular_juguete, describadia_normal, algo_mencionar);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        //ragos indentificables 2
        private string movimientos_estereotipados;
        private string alinea_objetos;
        private string cambio_temperamento;
        private string camina_puntilla;
        private string atiende_cuando_llama;
        private string instrucciones_verbales;
        private string muestra_esvolalia;
        private string habla_solo;
        private string voz_peculear;
        private string funcional_lenguaje;
        private string gusta_girar_objetos;
        private string temor_situaciones;
        private string miradas_extranas;
        private string mirada_al_vacio;
        public string Movimientos_estereotipados
        {
            get
            {
                return movimientos_estereotipados;
            }

            set
            {
                movimientos_estereotipados = value;
            }
        }

        public string Alinea_objetos
        {
            get
            {
                return alinea_objetos;
            }

            set
            {
                alinea_objetos = value;
            }
        }

        public string Cambio_temperamento
        {
            get
            {
                return cambio_temperamento;
            }

            set
            {
                cambio_temperamento = value;
            }
        }

        public string Atiende_cuando_llama
        {
            get
            {
                return atiende_cuando_llama;
            }

            set
            {
                atiende_cuando_llama = value;
            }
        }

        public string Instrucciones_verbales
        {
            get
            {
                return instrucciones_verbales;
            }

            set
            {
                instrucciones_verbales = value;
            }
        }

        public string Muestra_esvolalia
        {
            get
            {
                return muestra_esvolalia;
            }

            set
            {
                muestra_esvolalia = value;
            }
        }

        public string Habla_solo
        {
            get
            {
                return habla_solo;
            }

            set
            {
                habla_solo = value;
            }
        }

        public string Voz_peculear
        {
            get
            {
                return voz_peculear;
            }

            set
            {
                voz_peculear = value;
            }
        }

        public string Funcional_lenguaje
        {
            get
            {
                return funcional_lenguaje;
            }

            set
            {
                funcional_lenguaje = value;
            }
        }

        public string Gusta_girar_objetos
        {
            get
            {
                return gusta_girar_objetos;
            }

            set
            {
                gusta_girar_objetos = value;
            }
        }

        public string Temor_situaciones
        {
            get
            {
                return temor_situaciones;
            }

            set
            {
                temor_situaciones = value;
            }
        }

        public string Miradas_extranas
        {
            get
            {
                return miradas_extranas;
            }

            set
            {
                miradas_extranas = value;
            }
        }

        public string Mirada_al_vacio
        {
            get
            {
                return mirada_al_vacio;
            }

            set
            {
                mirada_al_vacio = value;
            }
        }

        public string Camina_puntilla
        {
            get
            {
                return camina_puntilla;
            }

            set
            {
                camina_puntilla = value;
            }
        }

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

        public string NomAlumno
        {
            get
            {
                return nomAlumno;
            }

            set
            {
                nomAlumno = value;
            }
        }

        public string Fecha_nacimiento
        {
            get
            {
                return fecha_nacimiento;
            }

            set
            {
                fecha_nacimiento = value;
            }
        }

        public string Edad_cronograma
        {
            get
            {
                return edad_cronograma;
            }

            set
            {
                edad_cronograma = value;
            }
        }

        public string Responsables
        {
            get
            {
                return responsables;
            }

            set
            {
                responsables = value;
            }
        }

        public string Escolaridad
        {
            get
            {
                return escolaridad;
            }

            set
            {
                escolaridad = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Referido_por
        {
            get
            {
                return referido_por;
            }

            set
            {
                referido_por = value;
            }
        }

        public string Lugar
        {
            get
            {
                return lugar;
            }

            set
            {
                lugar = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public void fun_rasgos_identificables_2()
        {
            try
            {
                this.sql = string.Format(@"insert into rasgosidentificables values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                CodAlumno, movimientos_estereotipados, alinea_objetos, cambio_temperamento, camina_puntilla,
                atiende_cuando_llama, instrucciones_verbales, muestra_esvolalia, habla_solo, voz_peculear,
                funcional_lenguaje, gusta_girar_objetos, temor_situaciones, miradas_extranas, mirada_al_vacio);
                this.cmd = new MySqlCommand(this.sql, this.cnx);
                this.cnx.Open();
                MySqlDataReader Reg = null;
                Reg = this.cmd.ExecuteReader();
                this.cnx.Close();
            } catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string Fun_ExtraerResponsables(int Cod_Alumno)
        {
            string Var_resp_nombres = "";
            int ContadorFil = 1;

            this.sql = string.Format("select C.NomComRes as 'Responsable' from alumnos as A inner join `alumnos/responsables` as B on A.CodAlumno = B.CodAlumno inner join responsables as C on B.CodResp = C.CodResp where A.CodAlumno = '{0}'", Cod_Alumno);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            while (Reg.Read())
            {
                if (ContadorFil > 1)
                {
                    Var_resp_nombres = Var_resp_nombres + " y " + Reg["Responsable"].ToString();
                }
                else
                {
                    Var_resp_nombres = Reg["Responsable"].ToString();
                }

                ContadorFil++;
            }

            cnx.Close();
            return Var_resp_nombres;
        }


        public bool Fun_ValidarSIYaExisteEntrevista(int Cod_Alumno)
        {
            bool Resp = false;

            this.sql = string.Format("select * from entrevistapadres where Alumnos_CodAlumno = '{0}'", Cod_Alumno);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Resp = true;
            }

            cnx.Close();
            return Resp;
        }

        public int V_EdadAlumno;
        public string V_EdadCronologica;

        public DateTime ne;
        public string w;

        public void Fun_VerificarYear(int FV_Cod)
        {
            int F_Edad;
            string EdadCronoloGica;

            this.sql = string.Format(@"select FechaNaciAlum from alumnos where CodAlumno='{0}'", FV_Cod);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                ne = DateTime.Parse(Reg["FechaNaciAlum"].ToString());
                DateTime nacimiento = new DateTime(ne.Year, ne.Month, ne.Day); //Fecha de nacimiento
                int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                F_Edad = edad;
                TimeSpan ts = DateTime.Now.Date - ne.Date;

                double Años = ts.Days / 365;
                double Meses = Convert.ToInt32((ts.Days - (Años * 365)) / 30.4167);
                double Dias = Convert.ToInt32((ts.Days - (Años * 365)) - (Meses * 30.4167));
                string str = "Año:" + Años.ToString() + " Mes:" + Meses.ToString() + " Dia:" + Dias.ToString();
                EdadCronoloGica = str;
                this.cnx.Close();
                V_EdadCronologica = EdadCronoloGica;
                updateEdades(F_Edad, EdadCronoloGica, FV_Cod);

            }
            else
            {

            }
            this.cnx.Close();

        }
        public void updateEdades(int FV_Edad, string FV_EdadCro, int FV_CodAlu)
        {
            this.sql = string.Format(@"update alumnos set EdadAlum ='{0}', EdadCronologica='{1}'
            where CodAlumno='{2}'", FV_Edad, FV_EdadCro, FV_CodAlu);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();

            V_EdadAlumno = FV_Edad;
            V_EdadCronologica = FV_EdadCro;
        }

        public void UpdateAlumnoOtros(string Escolaridad, string Direccion, string TelFijo, int CodAlumo)
        {
            this.sql = string.Format(@"update alumnos set EscolaridadAlum = '{0}', DireccionAlum = '{1}', TelFijoAlum = '{2}'  
                                        where CodAlumno = '{3}'", Escolaridad, Direccion, TelFijo, CodAlumo);
            this.cmd = new MySqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }

    }
}
