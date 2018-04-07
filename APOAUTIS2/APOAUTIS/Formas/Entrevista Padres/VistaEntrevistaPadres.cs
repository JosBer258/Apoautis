using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APOAUTIS.Formas.Entrevista_Padres;
using APOAUTIS.Formas.Alumnos;
using APOAUTIS.Clases;

namespace APOAUTIS
{
    public partial class VistaEntrevistaPadres : Form
    {
        C_VistaEntrevistaPadres CL_Entrevista = new C_VistaEntrevistaPadres();
        int Var_codig;
        string Var_Nombre;

        public VistaEntrevistaPadres()
        {
            InitializeComponent();
        }
        
        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PestDatosGen_Txt_Escolaridad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PestDatosGen_Txt_Lugar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void PestDatosGen_Txt_RefiridoPor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void PestDatosGen_Txt_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void PestDatosGen_Txt_Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void PestDatosGen_Txt_Fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void PestDatosGen_Bttn_BusquedaAlumno_Click(object sender, EventArgs e)
        {
            FormGlobalShowAlum F_ShowAlum = new FormGlobalShowAlum();
            AddOwnedForm(F_ShowAlum);
            F_ShowAlum.Accion = "Vista_Entrevista";
            F_ShowAlum.ShowDialog();
        }

        public void Fun_ExtraerDatos(int FV_CodAlumno, string FV_Nombre)
        {
            Fun_Limpiar();
            CL_Entrevista.Var_codigo_alumno = FV_CodAlumno;
            CL_Entrevista.Var_nombre_completo_alumno = FV_Nombre;
            PestDatosGen_Txt_NombreCompleto.Text = FV_Nombre;


            CL_Entrevista.Fun_ExtraerResponsables();
            PestDatosGen_Txt_Responsables.Text = CL_Entrevista.Var_general_resp;
            try
            {
                CL_Entrevista.Fun_ExtraerInformacion_Genral_Leguaje_Social_Motriz();
            } catch(System.Exception e)
            {
                MessageBox.Show(e.ToString());
            }
           
            //Generales
            PestDatosGen_Txt_FechaNacim.Text = CL_Entrevista.Var_general_fecha_nacimiento;
            PestDatosGen_Txt_EdadCron.Text = CL_Entrevista.Var_general_edad_cronologica;
            PestDatosGen_Txt_Escolaridad.Text = CL_Entrevista.Var_general_escolaridad;
            PestDatosGen_Txt_Direccion.Text = CL_Entrevista.Var_general_direccion;
            PestDatosGen_Txt_Telefono.Text = CL_Entrevista.Var_general_num;
            PestDatosGen_Txt_RefiridoPor.Text = CL_Entrevista.Var_general_referidopor;
            PestDatosGen_Txt_Lugar.Text = CL_Entrevista.Var_general_lugar;
            PestDatosGen_Txt_Fecha.Text = CL_Entrevista.Var_general_fecha;

            //Amnesis
            CL_Entrevista.Fun_ExtraerInformacion_Anamnesis();
            PestAnam_Txt_DuracionGestacion.Text = CL_Entrevista.Var_duracion_periodo_gestacion;
            PestAnam_Txt_TipoFamilia.Text = CL_Entrevista.Var_tipo_familia;
            PestAnam_Txt_DatosPrenatales.Text = CL_Entrevista.Var_datos_relevantes_prenatales;
            PestAnam_Txt_DatosPerinatales.Text = CL_Entrevista.Var_datos_relevantes_perinatales;
            PestAnam_Txt_DatosPostnatales.Text = CL_Entrevista.Var_datos_relevantes_postnatales;
            PestA_Txt_PesAlNacer.Text = CL_Entrevista.Var_peso_al_nacer;

            //Motriz
            textBox100.Text = CL_Entrevista.Var_desa_motriz_controCuello;
            textBox97.Text = CL_Entrevista.Var_desa_motriz_camino;
            textBox99.Text = CL_Entrevista.Var_desa_motriz_sesento;
            textBox96.Text = CL_Entrevista.Var_desa_motriz_corrio;
            textBox98.Text = CL_Entrevista.Var_desa_motriz_gateo;
            textBox95.Text = CL_Entrevista.Var_desa_motriz_saltar;
            PestDesar_Motriz.Text = CL_Entrevista.Var_desa_motriz_transnos_desar;
            PestDes_Txt_HanNotado.Text = CL_Entrevista.Var_desa_motriz_notado_tenga;

            //Desarrollo social
            textBox111.Text = CL_Entrevista.Var_DesSoc_Acept;
            textBox112.Text = CL_Entrevista.Var_DesSoc_PartAct;
            textBox119.Text = CL_Entrevista.Var_DesSoc_EncInt;
            textBox118.Text = CL_Entrevista.Var_DesSoc_DesCuando;
            textBox117.Text = CL_Entrevista.Var_DesSoc_ManiMaestr;
            textBox116.Text = CL_Entrevista.Var_DesSoc_Dsenvuelve;
            CL_Entrevista.Fun_MostrarAcotencimientosMedicos(dataGridView2);


            //Desarrollo Lenguaje
            textBox101.Text = CL_Entrevista.Var_Desle_EdadSonidos;
            textBox110.Text = CL_Entrevista.Var_Desle_SonidosVocales;
            textBox109.Text = CL_Entrevista.Var_Desle_SonidosSilabicos;
            textBox105.Text = CL_Entrevista.Var_Desle_DecirPalabras;
            textBox103.Text = CL_Entrevista.Var_Desle_ProConv;
            textBox102.Text = CL_Entrevista.Var_Desle_MuestraInter;
            textBox108.Text = CL_Entrevista.Var_Desle_HablaTercera;
            textBox107.Text = CL_Entrevista.Var_Desle_DiceOraciones;
            textBox106.Text = CL_Entrevista.Var_Desle_TiendeARepetir;
            textBox159.Text = CL_Entrevista.Var_rasgos_interesparticula;
            textBox156.Text = CL_Entrevista.Var_rasgos_normalconsuhijo;
            textBox158.Text = CL_Entrevista.Var_rasgos_quisieramencionarentrevista;
            textBox145.Text = CL_Entrevista.Var_reaciona_cortecabello;
            textBox147.Text = CL_Entrevista.Var_corteuñas;
            textBox146.Text = CL_Entrevista.Var_limpiezaoidos;
            textBox144.Text = CL_Entrevista.Var_cepilladientes;
            textBox143.Text = CL_Entrevista.Var_personaadulos_niños;
            textBox142.Text = CL_Entrevista.Var_reacion_antecambios;
            textBox154.Text = CL_Entrevista.Var_relacion_notadotengamasapego;
            textBox152.Text = CL_Entrevista.Var_relacion_con_padres;
            textBox148.Text = CL_Entrevista.Var_relacion_con_hermano;
            textBox150.Text = CL_Entrevista.Var_comprtamiento_general;


            textBox130.Text = CL_Entrevista.Var_vida_duermesolo;
            textBox129.Text = CL_Entrevista.Var_vida_aquehoraseacuenta;
            textBox128.Text = CL_Entrevista.Var_vida_aquehoraselevanta;
            textBox131.Text = CL_Entrevista.Var_vida_duermetodalanoceh;
            textBox133.Text = CL_Entrevista.Var_vida_duermeconunobjeto;
            textBox132.Text = CL_Entrevista.Var_vida_tienealgunacomidafav;
            textBox127.Text = CL_Entrevista.Var_vida_comidaquenolegusta;
            textBox126.Text = CL_Entrevista.Var_vida_comesolo;
            textBox125.Text = CL_Entrevista.Var_vida_utilizacubietos;
            textBox124.Text = CL_Entrevista.Var_vida_desdeedadcomesolo;
            textBox123.Text = CL_Entrevista.Var_vida_comecosasnocomesti;
            textBox122.Text = CL_Entrevista.Var_vida_agradabañarse;
            textBox121.Text = CL_Entrevista.Var_vida_coperaparaelbaño;
            textBox120.Text = CL_Entrevista.Var_vida_sebañasolo;
            textBox113.Text = CL_Entrevista.Var_vida_secambiasolo;
            textBox141.Text = CL_Entrevista.Var_vida_copeeraparacambiarse;
            textBox140.Text = CL_Entrevista.Var_vida_tienealgunarpa;
            textBox139.Text = CL_Entrevista.Var_vida_contrlaesfinter;
            textBox138.Text = CL_Entrevista.Var_vida_muestrasignosdefecando;
            textBox137.Text = CL_Entrevista.Var_vida_daaconocerqueandasucio;
            textBox135.Text = CL_Entrevista.Var_vida_desdequeedadconesfin;
            textBox134.Text = CL_Entrevista.Var_vida_usaelinodoro;
            textBox1.Text = CL_Entrevista.Var_vida_selimpiasolo;
            textBox2.Text = CL_Entrevista.Var_vida_sedejalimpiar;
            textBox3.Text = CL_Entrevista.Var_vida_ridmosueño;

            CL_Entrevista.Fun_ExtraerDatosIdenII();
            Fun_ChekearCheckBox(checkBox28, CL_Entrevista.Var_rasgos_muestramovimientos);

            Fun_ChekearCheckBox(checkBox27, CL_Entrevista.Var_rasgos_aineaobjetocs);
            Fun_ChekearCheckBox(checkBox12, CL_Entrevista.Var_rasgos_muestracambiosdetemperamento);
            Fun_ChekearCheckBox(checkBox11, CL_Entrevista.Var_rasgos_caminadepuntillas);
            Fun_ChekearCheckBox(checkBox26, CL_Entrevista.Var_rasgos_atiendecuandoselellama);
            Fun_ChekearCheckBox(checkBox25, CL_Entrevista.Var_rasgos_siguieinstrucciones);
            Fun_ChekearCheckBox(checkBox10, CL_Entrevista.Var_rasgos_muestraescolalia);
            Fun_ChekearCheckBox(checkBox9, CL_Entrevista.Var_rasgos_hablasolo);

            Fun_ChekearCheckBox(checkBox20, CL_Entrevista.Var_rasgos_muestrauntonodevozpeculiar);
            Fun_ChekearCheckBox(checkBox19, CL_Entrevista.Var_rasgos_hacesufacial);
            Fun_ChekearCheckBox(checkBox6, CL_Entrevista.Var_rasgos_legustagirarobjetos);
            Fun_ChekearCheckBox(checkBox5, CL_Entrevista.Var_rasgos_muestratemorsituaciones);
            Fun_ChekearCheckBox(checkBox8, CL_Entrevista.Var_rasgos_petronesmirada);
            Fun_ChekearCheckBox(checkBox7, CL_Entrevista.Var_rasgos_miradavacio);


        }

        private void Fun_ChekearCheckBox(CheckBox FV_CHK, string FV_Variable)
        {
            string Var_ValorBien = "1";
            string Var_Mal = "0";

            if(FV_Variable.Equals(Var_Mal) ==true || string.IsNullOrEmpty(FV_Variable))
            {
                FV_CHK.Checked = false;
            }else if(FV_Variable.Equals(Var_ValorBien) == true)
            {
                FV_CHK.Checked = true;
            }
        }

        private void VistaEntrevistaPadres_Load(object sender, EventArgs e)
        {
        }

        private void button24_Click(object sender, EventArgs e)
        {
    
        }

        private void textBox106_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pest_VidaDiaria_Click(object sender, EventArgs e)
        {

        }

        private void textBox120_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fun_Limpiar()
        {
            PestDatosGen_Txt_NombreCompleto.Text = string.Empty;
            //Generales
            PestDatosGen_Txt_FechaNacim.Text = string.Empty;
            PestDatosGen_Txt_EdadCron.Text = string.Empty;
            PestDatosGen_Txt_Escolaridad.Text = string.Empty;
            PestDatosGen_Txt_Direccion.Text = string.Empty;
            PestDatosGen_Txt_Telefono.Text = string.Empty;
            PestDatosGen_Txt_RefiridoPor.Text = string.Empty;
            PestDatosGen_Txt_Lugar.Text = string.Empty;
            PestDatosGen_Txt_Fecha.Text = string.Empty;
            PestAnam_Txt_DuracionGestacion.Text = string.Empty;
            PestAnam_Txt_TipoFamilia.Text = string.Empty;
            PestAnam_Txt_DatosPrenatales.Text = string.Empty;
            PestAnam_Txt_DatosPerinatales.Text = string.Empty;
            PestAnam_Txt_DatosPostnatales.Text = string.Empty;
            PestA_Txt_PesAlNacer.Text = string.Empty;
            textBox100.Text = string.Empty;
            textBox97.Text = string.Empty;
            textBox99.Text = string.Empty;
            textBox96.Text = string.Empty;
            textBox98.Text = string.Empty;
            textBox95.Text = string.Empty;
            PestDesar_Motriz.Text = string.Empty;
            PestDes_Txt_HanNotado.Text = string.Empty;
            textBox111.Text = string.Empty;
            textBox112.Text = string.Empty;
            textBox119.Text = string.Empty;
            textBox118.Text = string.Empty;
            textBox117.Text = string.Empty;
            textBox116.Text = string.Empty;


            textBox101.Text = string.Empty;
            textBox110.Text = string.Empty;
            textBox109.Text = string.Empty;
            textBox105.Text = string.Empty;
            textBox103.Text = string.Empty;
            textBox102.Text = string.Empty;
            textBox108.Text = string.Empty;
            textBox107.Text = string.Empty;
            textBox106.Text = string.Empty;
            textBox159.Text = string.Empty;
            textBox156.Text = string.Empty;
            textBox158.Text = string.Empty;
            textBox145.Text = string.Empty;
            textBox147.Text = string.Empty;
            textBox146.Text = string.Empty;
            textBox144.Text = string.Empty;
            textBox143.Text = string.Empty;
            textBox142.Text = string.Empty;
            textBox154.Text = string.Empty;
            textBox152.Text = string.Empty;
            textBox148.Text = string.Empty;
            textBox150.Text = string.Empty;


            textBox130.Text = string.Empty;
            textBox129.Text = string.Empty;
            textBox128.Text = string.Empty;
            textBox131.Text = string.Empty;
            textBox133.Text = string.Empty;
            textBox132.Text = string.Empty;
            textBox127.Text = string.Empty;
            textBox126.Text = string.Empty;
            textBox125.Text = string.Empty;
            textBox124.Text = string.Empty;
            textBox123.Text = string.Empty;
            textBox122.Text = string.Empty;
            textBox121.Text = string.Empty;
            textBox120.Text = string.Empty;
            textBox113.Text = string.Empty;
            textBox141.Text = string.Empty;
            textBox140.Text = string.Empty;
            textBox139.Text = string.Empty;
            textBox138.Text = string.Empty;
            textBox137.Text = string.Empty;
            textBox135.Text = string.Empty;
            textBox134.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
