using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Clases
{
    class C_VistaEntrevistaPadres : Conexion
    {
        //variables de busqueda
        private int var_codigo_alumno;
        private string var_nombre_completo_alumno;

        //Datos Generales
        private string var_general_fecha_nacimiento = "";
        private string var_general_edad_cronologica = "";
        private string var_general_escolaridad = "";
        private string var_general_direccion = "";
        private string var_general_referidopor = "";
        private string var_general_lugar = "";
        private string var_general_fecha = "";
        private string var_general_num = "";



        private string var_general_resp = "";

        //Anamnesis
        private string var_tipo_familia = "";
        private string var_peso_al_nacer = "";
        private string var_duracion_periodo_gestacion = "";
        private string var_datos_relevantes_prenatales = "";
        private string var_datos_relevantes_perinatales = "";
        private string var_datos_relevantes_postnatales = "";


        //DesrrolloMotriz
        private string var_desa_motriz_controCuello = "";
        private string var_desa_motriz_camino = "";
        private string var_desa_motriz_sesento = "";
        private string var_desa_motriz_corrio = "";
        private string var_desa_motriz_gateo = "";
        private string var_desa_motriz_saltar = "";
        private string var_desa_motriz_transnos_desar = "";
        private string var_desa_motriz_notado_tenga = "";

        //Desarrollo Social
        private string var_DesSoc_Acept = "";
        private string var_DesSoc_PartAct = "";
        private string var_DesSoc_EncInt = "";
        private string var_DesSoc_DesCuando = "";
        private string var_DesSoc_ManiMaestr = "";
        private string var_DesSoc_Dsenvuelve = "";

        //Desarrollo del lenguaje
        private string var_Desle_EdadSonidos;
        private string var_Desle_SonidosVocales;
        private string var_Desle_SonidosSilabicos;
        private string var_Desle_DecirPalabras;
        private string var_Desle_CualesPalabras;
        private string var_Desle_ProConv;
        private string var_Desle_MuestraInter;
        private string var_Desle_HablaTercera;
        private string var_Desle_DiceOraciones;
        private string var_Desle_TiendeARepetir;

        private string var_rasgos_interesparticula;
        private string var_rasgos_normalconsuhijo;
        private string var_rasgos_quisieramencionarentrevista;


        //Vida Diaria
        private string var_vida_duermesolo;
        private string var_vida_aquehoraseacuenta;
        private string var_vida_aquehoraselevanta;
        private string var_vida_duermetodalanoceh;
        private string var_vida_duermeconunobjeto;
        private string var_vida_tienealgunacomidafav;
        private string var_vida_comidaquenolegusta;
        private string var_vida_comesolo;
        private string var_vida_utilizacubietos;
        private string var_vida_desdeedadcomesolo;
        private string var_vida_comecosasnocomesti;
        private string var_vida_agradabañarse;
        private string var_vida_coperaparaelbaño;
        private string var_vida_sebañasolo;

        private string var_vida_secambiasolo;
        private string var_vida_copeeraparacambiarse;
        private string var_vida_tienealgunarpa;
        private string var_vida_contrlaesfinter;
        private string var_vida_muestrasignosdefecando;
        private string var_vida_daaconocerqueandasucio;
        private string var_vida_desdequeedadconesfin;
        private string var_vida_usaelinodoro;

        private string var_vida_selimpiasolo;
        private string var_vida_sedejalimpiar;
        private string var_vida_ridmosueño;

        //Como reaciona ante
        private string var_reaciona_cortecabello;
        private string var_corteuñas;
        private string var_limpiezaoidos;
        private string var_cepilladientes;
        private string var_personaadulos_niños;
        private string var_reacion_antecambios;

        //relacion con la familia
        private string var_relacion_notadotengamasapego = "";
        private string var_relacion_con_padres = "";
        private string var_relacion_con_hermano = "";
        private string var_comprtamiento_general = "";

        //RASGOS
        private string var_rasgos_muestramovimientos = "";
        private string var_rasgos_aineaobjetocs = "";
        private string var_rasgos_muestracambiosdetemperamento = "";
        private string var_rasgos_caminadepuntillas = "";
        private string var_rasgos_atiendecuandoselellama = "";
        private string var_rasgos_siguieinstrucciones = "";
        private string var_rasgos_muestraescolalia = "";
        private string var_rasgos_hablasolo = "";
        private string var_rasgos_muestrauntonodevozpeculiar = "";
        private string var_rasgos_hacesufacial = "";
        private string var_rasgos_legustagirarobjetos = "";
        private string var_rasgos_muestratemorsituaciones = "";
        private string var_rasgos_petronesmirada = "";
        private string var_rasgos_miradavacio = "";

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

        public string Get_peso_al_nacer()
        {
            return var_peso_al_nacer;
        }

        public void Set_peso_al_nacer(string o)
        {
            var_peso_al_nacer = o;
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

        public string Var_general_resp
        {
            get
            {
                return var_general_resp;
            }

            set
            {
                var_general_resp = value;
            }
        }

        public string Var_general_fecha_nacimiento
        {
            get
            {
                return var_general_fecha_nacimiento;
            }

            set
            {
                var_general_fecha_nacimiento = value;
            }
        }

        public string Var_general_edad_cronologica
        {
            get
            {
                return var_general_edad_cronologica;
            }

            set
            {
                var_general_edad_cronologica = value;
            }
        }

        public string Var_general_escolaridad
        {
            get
            {
                return var_general_escolaridad;
            }

            set
            {
                var_general_escolaridad = value;
            }
        }

        public string Var_general_direccion
        {
            get
            {
                return var_general_direccion;
            }

            set
            {
                var_general_direccion = value;
            }
        }

        public string Var_general_referidopor
        {
            get
            {
                return var_general_referidopor;
            }

            set
            {
                var_general_referidopor = value;
            }
        }

        public string Var_general_lugar
        {
            get
            {
                return var_general_lugar;
            }

            set
            {
                var_general_lugar = value;
            }
        }

        public string Var_general_fecha
        {
            get
            {
                return var_general_fecha;
            }

            set
            {
                var_general_fecha = value;
            }
        }

        public string Var_general_num
        {
            get
            {
                return var_general_num;
            }

            set
            {
                var_general_num = value;
            }
        }

        public string Var_desa_motriz_controCuello
        {
            get
            {
                return var_desa_motriz_controCuello;
            }

            set
            {
                var_desa_motriz_controCuello = value;
            }
        }

        public string Var_desa_motriz_camino
        {
            get
            {
                return var_desa_motriz_camino;
            }

            set
            {
                var_desa_motriz_camino = value;
            }
        }

        public string Var_desa_motriz_sesento
        {
            get
            {
                return var_desa_motriz_sesento;
            }

            set
            {
                var_desa_motriz_sesento = value;
            }
        }

        public string Var_desa_motriz_corrio
        {
            get
            {
                return var_desa_motriz_corrio;
            }

            set
            {
                var_desa_motriz_corrio = value;
            }
        }

        public string Var_desa_motriz_gateo
        {
            get
            {
                return var_desa_motriz_gateo;
            }

            set
            {
                var_desa_motriz_gateo = value;
            }
        }

        public string Var_desa_motriz_saltar
        {
            get
            {
                return var_desa_motriz_saltar;
            }

            set
            {
                var_desa_motriz_saltar = value;
            }
        }

        public string Var_desa_motriz_transnos_desar
        {
            get
            {
                return var_desa_motriz_transnos_desar;
            }

            set
            {
                var_desa_motriz_transnos_desar = value;
            }
        }

        public string Var_desa_motriz_notado_tenga
        {
            get
            {
                return var_desa_motriz_notado_tenga;
            }

            set
            {
                var_desa_motriz_notado_tenga = value;
            }
        }

        public string Var_DesSoc_Acept
        {
            get
            {
                return var_DesSoc_Acept;
            }

            set
            {
                var_DesSoc_Acept = value;
            }
        }

        public string Var_DesSoc_PartAct
        {
            get
            {
                return var_DesSoc_PartAct;
            }

            set
            {
                var_DesSoc_PartAct = value;
            }
        }

        public string Var_DesSoc_EncInt
        {
            get
            {
                return var_DesSoc_EncInt;
            }

            set
            {
                var_DesSoc_EncInt = value;
            }
        }

        public string Var_DesSoc_DesCuando
        {
            get
            {
                return var_DesSoc_DesCuando;
            }

            set
            {
                var_DesSoc_DesCuando = value;
            }
        }

        public string Var_DesSoc_ManiMaestr
        {
            get
            {
                return var_DesSoc_ManiMaestr;
            }

            set
            {
                var_DesSoc_ManiMaestr = value;
            }
        }

        public string Var_DesSoc_Dsenvuelve
        {
            get
            {
                return var_DesSoc_Dsenvuelve;
            }

            set
            {
                var_DesSoc_Dsenvuelve = value;
            }
        }

        public string Var_Desle_EdadSonidos
        {
            get
            {
                return var_Desle_EdadSonidos;
            }

            set
            {
                var_Desle_EdadSonidos = value;
            }
        }

        public string Var_Desle_SonidosVocales
        {
            get
            {
                return var_Desle_SonidosVocales;
            }

            set
            {
                var_Desle_SonidosVocales = value;
            }
        }

        public string Var_Desle_SonidosSilabicos
        {
            get
            {
                return var_Desle_SonidosSilabicos;
            }

            set
            {
                var_Desle_SonidosSilabicos = value;
            }
        }

        public string Var_Desle_DecirPalabras
        {
            get
            {
                return var_Desle_DecirPalabras;
            }

            set
            {
                var_Desle_DecirPalabras = value;
            }
        }

        public string Var_Desle_CualesPalabras
        {
            get
            {
                return var_Desle_CualesPalabras;
            }

            set
            {
                var_Desle_CualesPalabras = value;
            }
        }

        public string Var_Desle_ProConv
        {
            get
            {
                return var_Desle_ProConv;
            }

            set
            {
                var_Desle_ProConv = value;
            }
        }

        public string Var_Desle_MuestraInter
        {
            get
            {
                return var_Desle_MuestraInter;
            }

            set
            {
                var_Desle_MuestraInter = value;
            }
        }

        public string Var_Desle_HablaTercera
        {
            get
            {
                return var_Desle_HablaTercera;
            }

            set
            {
                var_Desle_HablaTercera = value;
            }
        }

        public string Var_Desle_DiceOraciones
        {
            get
            {
                return var_Desle_DiceOraciones;
            }

            set
            {
                var_Desle_DiceOraciones = value;
            }
        }

        public string Var_Desle_TiendeARepetir
        {
            get
            {
                return var_Desle_TiendeARepetir;
            }

            set
            {
                var_Desle_TiendeARepetir = value;
            }
        }

        public string Var_rasgos_interesparticula
        {
            get
            {
                return var_rasgos_interesparticula;
            }

            set
            {
                var_rasgos_interesparticula = value;
            }
        }

        public string Var_rasgos_normalconsuhijo
        {
            get
            {
                return var_rasgos_normalconsuhijo;
            }

            set
            {
                var_rasgos_normalconsuhijo = value;
            }
        }

        public string Var_rasgos_quisieramencionarentrevista
        {
            get
            {
                return var_rasgos_quisieramencionarentrevista;
            }

            set
            {
                var_rasgos_quisieramencionarentrevista = value;
            }
        }

        public string Var_comprtamiento_general
        {
            get
            {
                return var_comprtamiento_general;
            }

            set
            {
                var_comprtamiento_general = value;
            }
        }

        public string Var_relacion_con_hermano
        {
            get
            {
                return var_relacion_con_hermano;
            }

            set
            {
                var_relacion_con_hermano = value;
            }
        }

        public string Var_relacion_con_padres
        {
            get
            {
                return var_relacion_con_padres;
            }

            set
            {
                var_relacion_con_padres = value;
            }
        }

        public string Var_relacion_notadotengamasapego
        {
            get
            {
                return var_relacion_notadotengamasapego;
            }

            set
            {
                var_relacion_notadotengamasapego = value;
            }
        }

        public string Var_reacion_antecambios
        {
            get
            {
                return var_reacion_antecambios;
            }

            set
            {
                var_reacion_antecambios = value;
            }
        }

        public string Var_personaadulos_niños
        {
            get
            {
                return var_personaadulos_niños;
            }

            set
            {
                var_personaadulos_niños = value;
            }
        }

        public string Var_cepilladientes
        {
            get
            {
                return var_cepilladientes;
            }

            set
            {
                var_cepilladientes = value;
            }
        }

        public string Var_limpiezaoidos
        {
            get
            {
                return var_limpiezaoidos;
            }

            set
            {
                var_limpiezaoidos = value;
            }
        }

        public string Var_corteuñas
        {
            get
            {
                return var_corteuñas;
            }

            set
            {
                var_corteuñas = value;
            }
        }

        public string Var_reaciona_cortecabello
        {
            get
            {
                return var_reaciona_cortecabello;
            }

            set
            {
                var_reaciona_cortecabello = value;
            }
        }

        public string Var_vida_usaelinodoro
        {
            get
            {
                return var_vida_usaelinodoro;
            }

            set
            {
                var_vida_usaelinodoro = value;
            }
        }

        public string Var_vida_desdequeedadconesfin
        {
            get
            {
                return var_vida_desdequeedadconesfin;
            }

            set
            {
                var_vida_desdequeedadconesfin = value;
            }
        }

        public string Var_vida_daaconocerqueandasucio
        {
            get
            {
                return var_vida_daaconocerqueandasucio;
            }

            set
            {
                var_vida_daaconocerqueandasucio = value;
            }
        }

        public string Var_vida_muestrasignosdefecando
        {
            get
            {
                return var_vida_muestrasignosdefecando;
            }

            set
            {
                var_vida_muestrasignosdefecando = value;
            }
        }

        public string Var_vida_contrlaesfinter
        {
            get
            {
                return var_vida_contrlaesfinter;
            }

            set
            {
                var_vida_contrlaesfinter = value;
            }
        }

        public string Var_vida_tienealgunarpa
        {
            get
            {
                return var_vida_tienealgunarpa;
            }

            set
            {
                var_vida_tienealgunarpa = value;
            }
        }

        public string Var_vida_copeeraparacambiarse
        {
            get
            {
                return var_vida_copeeraparacambiarse;
            }

            set
            {
                var_vida_copeeraparacambiarse = value;
            }
        }

        public string Var_vida_secambiasolo
        {
            get
            {
                return var_vida_secambiasolo;
            }

            set
            {
                var_vida_secambiasolo = value;
            }
        }

        public string Var_vida_sebañasolo
        {
            get
            {
                return var_vida_sebañasolo;
            }

            set
            {
                var_vida_sebañasolo = value;
            }
        }

        public string Var_vida_coperaparaelbaño
        {
            get
            {
                return var_vida_coperaparaelbaño;
            }

            set
            {
                var_vida_coperaparaelbaño = value;
            }
        }

        public string Var_vida_agradabañarse
        {
            get
            {
                return var_vida_agradabañarse;
            }

            set
            {
                var_vida_agradabañarse = value;
            }
        }

        public string Var_vida_comecosasnocomesti
        {
            get
            {
                return var_vida_comecosasnocomesti;
            }

            set
            {
                var_vida_comecosasnocomesti = value;
            }
        }

        public string Var_vida_desdeedadcomesolo
        {
            get
            {
                return var_vida_desdeedadcomesolo;
            }

            set
            {
                var_vida_desdeedadcomesolo = value;
            }
        }

        public string Var_vida_utilizacubietos
        {
            get
            {
                return var_vida_utilizacubietos;
            }

            set
            {
                var_vida_utilizacubietos = value;
            }
        }

        public string Var_vida_comesolo
        {
            get
            {
                return var_vida_comesolo;
            }

            set
            {
                var_vida_comesolo = value;
            }
        }

        public string Var_vida_comidaquenolegusta
        {
            get
            {
                return var_vida_comidaquenolegusta;
            }

            set
            {
                var_vida_comidaquenolegusta = value;
            }
        }

        public string Var_vida_tienealgunacomidafav
        {
            get
            {
                return var_vida_tienealgunacomidafav;
            }

            set
            {
                var_vida_tienealgunacomidafav = value;
            }
        }

        public string Var_vida_duermeconunobjeto
        {
            get
            {
                return var_vida_duermeconunobjeto;
            }

            set
            {
                var_vida_duermeconunobjeto = value;
            }
        }

        public string Var_vida_duermetodalanoceh
        {
            get
            {
                return var_vida_duermetodalanoceh;
            }

            set
            {
                var_vida_duermetodalanoceh = value;
            }
        }

        public string Var_vida_aquehoraselevanta
        {
            get
            {
                return var_vida_aquehoraselevanta;
            }

            set
            {
                var_vida_aquehoraselevanta = value;
            }
        }

        public string Var_vida_aquehoraseacuenta
        {
            get
            {
                return var_vida_aquehoraseacuenta;
            }

            set
            {
                var_vida_aquehoraseacuenta = value;
            }
        }

        public string Var_vida_duermesolo
        {
            get
            {
                return var_vida_duermesolo;
            }

            set
            {
                var_vida_duermesolo = value;
            }
        }

        public string Var_vida_selimpiasolo
        {
            get
            {
                return var_vida_selimpiasolo;
            }

            set
            {
                var_vida_selimpiasolo = value;
            }
        }

        public string Var_vida_sedejalimpiar
        {
            get
            {
                return var_vida_sedejalimpiar;
            }

            set
            {
                var_vida_sedejalimpiar = value;
            }
        }

        public string Var_vida_ridmosueño
        {
            get
            {
                return var_vida_ridmosueño;
            }

            set
            {
                var_vida_ridmosueño = value;
            }
        }

        public string Var_rasgos_miradavacio
        {
            get
            {
                return var_rasgos_miradavacio;
            }

            set
            {
                var_rasgos_miradavacio = value;
            }
        }

        public string Var_rasgos_petronesmirada
        {
            get
            {
                return var_rasgos_petronesmirada;
            }

            set
            {
                var_rasgos_petronesmirada = value;
            }
        }

        public string Var_rasgos_muestratemorsituaciones
        {
            get
            {
                return var_rasgos_muestratemorsituaciones;
            }

            set
            {
                var_rasgos_muestratemorsituaciones = value;
            }
        }

        public string Var_rasgos_legustagirarobjetos
        {
            get
            {
                return var_rasgos_legustagirarobjetos;
            }

            set
            {
                var_rasgos_legustagirarobjetos = value;
            }
        }

        public string Var_rasgos_hacesufacial
        {
            get
            {
                return var_rasgos_hacesufacial;
            }

            set
            {
                var_rasgos_hacesufacial = value;
            }
        }

        public string Var_rasgos_muestrauntonodevozpeculiar
        {
            get
            {
                return var_rasgos_muestrauntonodevozpeculiar;
            }

            set
            {
                var_rasgos_muestrauntonodevozpeculiar = value;
            }
        }

        public string Var_rasgos_hablasolo
        {
            get
            {
                return var_rasgos_hablasolo;
            }

            set
            {
                var_rasgos_hablasolo = value;
            }
        }

        public string Var_rasgos_muestraescolalia
        {
            get
            {
                return var_rasgos_muestraescolalia;
            }

            set
            {
                var_rasgos_muestraescolalia = value;
            }
        }

        public string Var_rasgos_siguieinstrucciones
        {
            get
            {
                return var_rasgos_siguieinstrucciones;
            }

            set
            {
                var_rasgos_siguieinstrucciones = value;
            }
        }

        public string Var_rasgos_atiendecuandoselellama
        {
            get
            {
                return var_rasgos_atiendecuandoselellama;
            }

            set
            {
                var_rasgos_atiendecuandoselellama = value;
            }
        }

        public string Var_rasgos_caminadepuntillas
        {
            get
            {
                return var_rasgos_caminadepuntillas;
            }

            set
            {
                var_rasgos_caminadepuntillas = value;
            }
        }

        public string Var_rasgos_muestracambiosdetemperamento
        {
            get
            {
                return var_rasgos_muestracambiosdetemperamento;
            }

            set
            {
                var_rasgos_muestracambiosdetemperamento = value;
            }
        }

        public string Var_rasgos_aineaobjetocs
        {
            get
            {
                return var_rasgos_aineaobjetocs;
            }

            set
            {
                var_rasgos_aineaobjetocs = value;
            }
        }

        public string Var_rasgos_muestramovimientos
        {
            get
            {
                return var_rasgos_muestramovimientos;
            }

            set
            {
                var_rasgos_muestramovimientos = value;
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
                Set_peso_al_nacer(Reg["PesoAlNacer"].ToString());
            }
            else
            {

                Var_duracion_periodo_gestacion = "";
                Var_tipo_familia = "";
                Var_peso_al_nacer = "";
                Var_datos_relevantes_prenatales = "";
                Var_datos_relevantes_perinatales = "";
                Var_datos_relevantes_postnatales = "";
                Set_peso_al_nacer("");
            }
            this.cnx.Close();
   
        }


        public void Fun_ExtraerInformacion_Genral_Leguaje_Social_Motriz()
        {
            this.sql = string.Format(@"select *    from alumnos as A left join entrevistapadres as B on 
            A.CodAlumno = B.Alumnos_CodAlumno left join desarrollomotriz as C on
            C.Alumnos_CodAlumno = A.CodAlumno left join `desarrollosocial/comportamiento` as D 
            on A.CodAlumno = D.Alumnos_CodAlumno left join desarrollolenguaje as E 
            on A.CodAlumno = E.Alumnos_CodAlumno
            left join reaccionaante as F on A.CodAlumno=F.Alumnos_CodAlumno left join 
            relacionfamiliar as G on A.CodAlumno = G.Alumnos_CodAlumno left join
            vidadiaria as H on A.CodAlumno = H.Alumnos_CodAlumno
where A.CodAlumno   = '{0}'", Var_codigo_alumno);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                Var_general_fecha_nacimiento = Reg["FechaNaciAlum"].ToString();
                Var_general_edad_cronologica = Reg["EdadCronologica"].ToString();
                Var_general_escolaridad = Reg["EscolaridadAlum"].ToString();
                Var_general_direccion = Reg["DireccionAlum"].ToString();
                Var_general_referidopor = Reg["ReferidoPor"].ToString();
                Var_general_lugar = Reg["Lugar"].ToString();
                Var_general_fecha = Reg["Fecha"].ToString();
                Var_general_num = Reg["TelFijoAlum"].ToString();


                Var_desa_motriz_controCuello = Reg["ControlCuello"].ToString();
                Var_desa_motriz_camino = Reg["Camino"].ToString();
                Var_desa_motriz_sesento = Reg["SeSento"].ToString();
                Var_desa_motriz_corrio = Reg["Corrio"].ToString();
                Var_desa_motriz_gateo = Reg["Gateo"].ToString();
                Var_desa_motriz_saltar = Reg["Salta"].ToString();
                Var_desa_motriz_transnos_desar = Reg["AntecedentesTransFami"].ToString();
                Var_desa_motriz_notado_tenga = Reg["MovPeculiManoCuerp"].ToString();


                Var_DesSoc_Acept = Reg["AceptaBuscaInteraccion"].ToString();
                Var_DesSoc_PartAct = Reg["ParticipaEnActividades"].ToString();
                Var_DesSoc_EncInt = Reg["IntegradoEnKinder"].ToString();
                Var_DesSoc_DesCuando = Reg["DesdeCuanIntegrado"].ToString();
                Var_DesSoc_ManiMaestr = Reg["QueManifiesSuMaestra"].ToString();
                Var_DesSoc_Dsenvuelve = Reg["ComoSeDesenvuelve"].ToString();


                Var_Desle_EdadSonidos = Reg["EdadComSonGut"].ToString();
                Var_Desle_SonidosVocales = Reg["EdadComSonVoc"].ToString();
                Var_Desle_SonidosSilabicos = Reg["EdadComSonSil"].ToString();
                Var_Desle_DecirPalabras = Reg["EdadComSonPal"].ToString();
                Var_Desle_ProConv = Reg["PropiciaConver"].ToString();
                Var_Desle_MuestraInter = Reg["MuestraIntTema"].ToString();
                Var_Desle_HablaTercera = Reg["HablaEnTerPers"].ToString();
                Var_Desle_DiceOraciones = Reg["DiceOracCompl"].ToString();
                Var_Desle_TiendeARepetir = Reg["RepitePalaEsc"].ToString();

                Var_rasgos_interesparticula = Reg["InteresPArticularJuguete"].ToString();
                Var_rasgos_normalconsuhijo = Reg["DescribaDiaNormal"].ToString();
                Var_rasgos_quisieramencionarentrevista = Reg["DetalleFueraEntre"].ToString();

                

                Var_reaciona_cortecabello = Reg["CorteCabello"].ToString();
                Var_corteuñas = Reg["CorteUnas"].ToString();
                Var_limpiezaoidos = Reg["LimpiezaOidos"].ToString();
                Var_cepilladientes = Reg["Cepillado"].ToString();
                Var_personaadulos_niños = Reg["ConAdultosNinos"].ToString();
                Var_reacion_antecambios = Reg["ComoReacAnteCambios"].ToString();
                Var_relacion_notadotengamasapego = Reg["ApegoUnMiemFami"].ToString();
                Var_relacion_con_padres = Reg["RelacionesConPadres"].ToString();
                Var_relacion_con_hermano = Reg["RelacionConHermanos"].ToString();
                Var_comprtamiento_general = Reg["ComporEnGeneral"].ToString();

                Var_vida_duermesolo = Reg["DuermeSolo"].ToString();
                Var_vida_aquehoraseacuenta = Reg["AqueHoraSeAcuesta"].ToString();
                Var_vida_aquehoraselevanta = Reg["AqueHoraSeLevanta"].ToString();
                Var_vida_duermetodalanoceh = Reg["DuermeSinInterruccion"].ToString();
                Var_vida_duermeconunobjeto = Reg["DuermeConObjetoEspecial"].ToString();
                Var_vida_tienealgunacomidafav = Reg["ComidaFavorita"].ToString();
                Var_vida_comidaquenolegusta = Reg["ComidaQueNoLeGusta"].ToString();
                Var_vida_comesolo = Reg["ComeSolo"].ToString();
                Var_vida_utilizacubietos = Reg["UtilizaCubierto"].ToString();
                Var_vida_desdeedadcomesolo = Reg["DesdeQueEdadComeSolo"].ToString();
                Var_vida_comecosasnocomesti = Reg["ComeCosasQueNoSeanComestibles"].ToString();
                Var_vida_agradabañarse = Reg["LeAgradaBanarse"].ToString();
                Var_vida_coperaparaelbaño = Reg["CooperaParaElBano"].ToString();
                Var_vida_sebañasolo = Reg["SeBanaSolo"].ToString();
                Var_vida_secambiasolo = Reg["SeCambiaSolo"].ToString();
                Var_vida_copeeraparacambiarse = Reg["CooperaParaCambiarse"].ToString();
                Var_vida_tienealgunarpa = Reg["TieneRopaFavorita"].ToString();
                Var_vida_contrlaesfinter = Reg["ControlaEsfinter"].ToString();
                Var_vida_muestrasignosdefecando = Reg["MuestraSignosDefecado"].ToString();
                Var_vida_daaconocerqueandasucio = Reg["DaConoserPanalSucio"].ToString();
                Var_vida_desdequeedadconesfin = Reg["DesdeQueEdadControlaEsfienter"].ToString();
                Var_vida_usaelinodoro = Reg["DesdeQueEdadUsaInodoro"].ToString();

                Var_vida_selimpiasolo = Reg["SeLimpiaSolo"].ToString();
                Var_vida_sedejalimpiar = Reg["SeDejaLimpiar"].ToString();
                Var_vida_ridmosueño = Reg["ComoEsSuRitmoDeSueño"].ToString();

            }
            this.cnx.Close();

        }


        public void Fun_ExtraerResponsables()
        {
            Var_general_resp = "";
            int ContadorFil = 1;

            this.sql = string.Format("select C.NomComRes as 'Responsable' from alumnos as A inner join `alumnos/responsables` as B on A.CodAlumno = B.CodAlumno inner join responsables as C on B.CodResp = C.CodResp where A.CodAlumno = '{0}'", Var_codigo_alumno);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            while (Reg.Read())
            {
                if (ContadorFil > 1)
                {
                    Var_general_resp = Var_general_resp + "\n y " + Reg["Responsable"].ToString();
                }
                else
                {
                    Var_general_resp = Reg["Responsable"].ToString();
                }

                ContadorFil++;
            }

            cnx.Close();
        }

        public void Fun_MostrarAcotencimientosMedicos(DataGridView Dvg_MuestraDatos)
        {
            cnx.Open();
            sql = string.Format(@"select Cuando, Donde, DiagnosticoTratamiento as 'Diagnostico y Tratamiento' from acontecimientomedco where Alumnos_CodAlumno = '{0}'", Var_codigo_alumno);
            cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, cnx);
            DataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            DataAdapter.Fill(dt);
            Dvg_MuestraDatos.DataSource = dt;
            cnx.Close();
        }

        public void Fun_ExtraerDatosIdenII()
        {
            this.sql = string.Format(@"select * from rasgosidentificables where Alumnos_CodAlumno='{0}'", Var_codigo_alumno);
            this.cnx.Open();
            this.cmd = new MySql.Data.MySqlClient.MySqlCommand(this.sql, this.cnx);
            MySql.Data.MySqlClient.MySqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Var_rasgos_muestramovimientos = Reg["MuestroMovEstereOti"].ToString();
                Var_rasgos_aineaobjetocs = Reg["AlineaObjetos"].ToString();
                Var_rasgos_muestracambiosdetemperamento = Reg["MuestraCambTemp"].ToString();
                Var_rasgos_caminadepuntillas = Reg["CamiPuntillas"].ToString();
                Var_rasgos_atiendecuandoselellama = Reg["EntiPorSuNombre"].ToString();
                Var_rasgos_siguieinstrucciones = Reg["SigueInstrVerba"].ToString();
                Var_rasgos_muestraescolalia = Reg["MuestraEcolalia"].ToString();
                Var_rasgos_hablasolo = Reg["HablaSolo"].ToString();
                Var_rasgos_muestrauntonodevozpeculiar = Reg["TonoVozPeculiar"].ToString();
                Var_rasgos_hacesufacial = Reg["LenguajeFuncional"].ToString();
                Var_rasgos_legustagirarobjetos = Reg["GustaVerGirar"].ToString();
                Var_rasgos_muestratemorsituaciones = Reg["MuesTermorAnte"].ToString();
                Var_rasgos_petronesmirada = Reg["PatroMiraExtranos"].ToString();
                Var_rasgos_miradavacio = Reg["MiradaAlVacio"].ToString();
            }
            this.cnx.Close();
            }
    }
}
