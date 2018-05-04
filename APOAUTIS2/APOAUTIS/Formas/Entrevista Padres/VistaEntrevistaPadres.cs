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
        C_Validaciones C_Val = new C_Validaciones();
        C_EntrevistaIngreCambios C_Cambios = new C_EntrevistaIngreCambios();
        int Var_codig;
        string Var_Nombre;
        public int Cod_Usuario=0;

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
            try
            {

                Fun_Limpiar();

                if(C_Cambios.llenarDatosHistoriaMedico(FV_CodAlumno) == false)
                {
                    MessageBox.Show("No existe entrevista de padre registrada con este alumno","Mensaje de error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CL_Entrevista.Var_codigo_alumno = FV_CodAlumno;
                CL_Entrevista.Var_nombre_completo_alumno = FV_Nombre;

                Var_codig = FV_CodAlumno;
                PestDatosGen_Txt_NombreCompleto.Text = FV_Nombre;
                CL_Entrevista.Fun_ExtraerInformacion_Anamnesis();

                CL_Entrevista.Fun_ExtraerResponsables();
                PestDatosGen_Txt_Responsables.Text = CL_Entrevista.Var_general_resp;
                try
                {
                    CL_Entrevista.Fun_ExtraerInformacion_Genral_Leguaje_Social_Motriz();
                }
                catch (System.Exception e)
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
            }catch(System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Fun_ChekearCheckBox(CheckBox FV_CHK, string FV_Variable)
        {
            string Var_ValorBien = "si";
            string Var_Mal = "no";

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
            if (Cod_Usuario == 3)
            {
                panel2.Visible = true;
                Fun_Habilitar();
            }
            else
            {
                panel2.Visible = false;
            }

            ClicDerecho();
        }

        public void Fun_Habilitar()
        {
            PestDatosGen_Txt_Escolaridad.ReadOnly = false;
            PestDatosGen_Txt_Direccion.ReadOnly = false;
            PestDatosGen_Txt_Telefono.ReadOnly = false;
            PestDatosGen_Txt_RefiridoPor.ReadOnly = false;
            PestDatosGen_Txt_Lugar.ReadOnly = false;
            PestDatosGen_Txt_Fecha.ReadOnly = false;

            var boxes = groupBox2.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ReadOnly = false;
            }

            var boxes1 = groupBox7.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                box.ReadOnly = false;
            }

            var boxes2 = groupBox4.Controls.OfType<TextBox>();
            foreach (var box in boxes2)
            {
                box.ReadOnly = false;
            }


            var boxes3 = groupBox3.Controls.OfType<TextBox>();
            foreach (var box in boxes3)
            {
                box.ReadOnly = false;
            }

            var boxes4 = groupBox8.Controls.OfType<TextBox>();
            foreach (var box in boxes4)
            {
                box.ReadOnly = false;
            }

            var boxes5 = groupBox11.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                box.ReadOnly = false;
            }
            var boxes6 = groupBox9.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                box.ReadOnly = false;
            }
            var boxes7 = groupBox10.Controls.OfType<TextBox>();
            foreach (var box in boxes7)
            {
                box.ReadOnly = false;
            }

            var boxes8 = groupBox12.Controls.OfType<TextBox>();
            foreach (var box in boxes8)
            {
                box.ReadOnly = false;
            }
            var boxes9 = groupBox13.Controls.OfType<TextBox>();
            foreach (var box in boxes9)
            {
                box.ReadOnly = false;
            }
        }


        //VALIDACIONES DE VACIOS
        private bool GeneralVacios()
        {
            bool Resp = false;

            if (string.IsNullOrEmpty(PestDatosGen_Txt_Escolaridad.Text))
            {
                Resp = true;
            }
            if (string.IsNullOrEmpty(PestDatosGen_Txt_Direccion.Text))
            {
                Resp = true;
            }
            if (string.IsNullOrEmpty(PestDatosGen_Txt_Telefono.Text))
            {
                Resp = true;
            }


            if (string.IsNullOrEmpty(PestDatosGen_Txt_RefiridoPor.Text))
            {
                Resp = true;
            }
            if (string.IsNullOrEmpty(PestDatosGen_Txt_Lugar.Text))
            {
                Resp = true;
            }
            if (string.IsNullOrEmpty(PestDatosGen_Txt_Fecha.Text))
            {
                Resp = true;
            }



            var boxes = groupBox2.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    Resp = true;
                }
                
            }

            return Resp;
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
            dataGridView2.DataSource = null;
            dataGridView2.Refresh();

            PestDatosGen_Txt_Responsables.Text = string.Empty;

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

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label112_Click(object sender, EventArgs e)
        {

        }

        private void textBox105_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void label167_Click(object sender, EventArgs e)
        {

        }

        private void textBox158_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox159_TextChanged(object sender, EventArgs e)
        {

        }

        private void label165_Click(object sender, EventArgs e)
        {

        }

        private void label166_Click(object sender, EventArgs e)
        {

        }

        private void textBox156_TextChanged(object sender, EventArgs e)
        {

        }

        private void label168_Click(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void Pest_DatosGenerales_Click(object sender, EventArgs e)
        {

        }

        private void textBox131_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (GeneralVacios() == true)
            {
                MessageBox.Show("Debe Llenar todos los Campos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            LlenarVacios();
            try
            {
                IngresarCambios();
                Fun_Limpiar();
                MessageBox.Show("Los datos se guardaron correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en la actualización", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void IngresarCambios()
        {
            C_Cambios.ActualizarAlumno(Var_codig, PestDatosGen_Txt_Escolaridad.Text, PestDatosGen_Txt_Direccion.Text, PestDatosGen_Txt_Telefono.Text);
            C_Cambios.ActualizarEntrevistaPadres(Var_codig, PestDatosGen_Txt_RefiridoPor.Text, textBox158.Text, PestDatosGen_Txt_Lugar.Text, PestDatosGen_Txt_Fecha.Text);
            C_Cambios.ActualizaAnamnesis(Var_codig, PestAnam_Txt_TipoFamilia.Text, PestAnam_Txt_DuracionGestacion.Text, PestA_Txt_PesAlNacer.Text,
                PestAnam_Txt_DatosPrenatales.Text, PestAnam_Txt_DatosPerinatales.Text, PestAnam_Txt_DatosPostnatales.Text);
            C_Cambios.ActualizaRelacion(Var_codig, textBox154.Text, textBox152.Text, textBox148.Text, textBox150.Text);
            C_Cambios.ActualComoReacciona(Var_codig, textBox145.Text, textBox147.Text, textBox146.Text, textBox144.Text, textBox143.Text, textBox142.Text);
            C_Cambios.ActualizarMotors(Var_codig, textBox100.Text, textBox99.Text, textBox98.Text, textBox97.Text,
                textBox95.Text, PestDesar_Motriz.Text, PestDes_Txt_HanNotado.Text);

            C_Cambios.ActualizarComportamiento(Var_codig, textBox111.Text, textBox112.Text,
            textBox119.Text, textBox118.Text, textBox117.Text, textBox116.Text,
            textBox159.Text, textBox156.Text);


            C_Cambios.ActualizarLenguaje(textBox101.Text,
                textBox110.Text, textBox109.Text,
            textBox105.Text,
            textBox103.Text, textBox102.Text,
            textBox108.Text, textBox107.Text,
            textBox106.Text, Var_codig);

            C_Cambios.ActualizarVida(textBox3.Text, textBox130.Text, textBox129.Text, textBox128.Text,
            textBox131.Text, textBox133.Text, textBox132.Text, textBox127.Text,
            textBox126.Text, textBox125.Text, textBox124.Text, textBox123.Text,
            textBox122.Text, textBox121.Text, textBox120.Text, textBox113.Text, textBox141.Text,
            textBox140.Text, textBox139.Text, textBox138.Text, textBox137.Text,
            textBox135.Text, textBox134.Text, textBox1.Text, textBox2.Text, Var_codig);
        }

        private void ClicDerecho()
        {
            var blankContextMenu = new ContextMenuStrip();

            var boxes = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes1 = groupBox2.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

      

            var boxes2 = groupBox7.Controls.OfType<TextBox>();
            foreach (var box in boxes2)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes3 = groupBox4.Controls.OfType<TextBox>();
            foreach (var box in boxes3)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes4 = groupBox3.Controls.OfType<TextBox>();
            foreach (var box in boxes4)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes5 = groupBox8.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes6 = groupBox11.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

           
            var boxes8 = groupBox9.Controls.OfType<TextBox>();
            foreach (var box in boxes8)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
            var boxes7 = groupBox10.Controls.OfType<TextBox>();
            foreach (var box in boxes7)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxes11 = groupBox12.Controls.OfType<TextBox>();
            foreach (var box in boxes11)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
            var boxes9 = groupBox13.Controls.OfType<TextBox>();
            foreach (var box in boxes9)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


        }

        
        private void LlenarVacios()
        {
            if (string.IsNullOrEmpty(textBox158.Text))
            {
                textBox158.Text = "Ninguno";
            }

            if (string.IsNullOrEmpty(textBox156.Text))
            {
                textBox156.Text = "Normal";
            }

            
            if (string.IsNullOrEmpty(textBox159.Text))
            {
                textBox159.Text = "No";
            }


            if (string.IsNullOrEmpty(textBox154.Text))
            {
                textBox154.Text = "No";
            }

            if (string.IsNullOrEmpty(textBox152.Text))
            {
                textBox152.Text = "Normal";
            }

            if (string.IsNullOrEmpty(textBox148.Text))
            {
                textBox148.Text = "Normal";
            }

            if (string.IsNullOrEmpty(textBox150.Text))
            {
                textBox150.Text = "Normal";
            }


            var boxes = groupBox9.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "--";
                }

            }

            var boxes1 = groupBox10.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "--";
                }

            }

            var boxes2 = groupBox8.Controls.OfType<TextBox>();
            foreach (var box in boxes2)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "--";
                }

            }


            var boxes3 = groupBox11.Controls.OfType<TextBox>();
            foreach (var box in boxes3)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "--";
                }

            }

            var boxes4 = groupBox7.Controls.OfType<TextBox>();
            foreach (var box in boxes4)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "--";
                }

            }
    
            var boxes5 = groupBox4.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "--";
                }

            }

            var boxes6 = groupBox3.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "--";
                }

            }


        }

        private void PestAnam_Txt_DatosPostnatales_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender,e, PestAnam_Txt_DatosPostnatales);
        }

        private void PestAnam_Txt_DatosPerinatales_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, PestAnam_Txt_DatosPerinatales);
        }

        private void PestAnam_Txt_DatosPrenatales_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, PestAnam_Txt_DatosPrenatales);
        }

        private void PestAnam_Txt_DuracionGestacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, PestAnam_Txt_DuracionGestacion);
        }

        private void PestA_Txt_PesAlNacer_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, PestA_Txt_PesAlNacer);
        }

        private void PestAnam_Txt_TipoFamilia_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios(sender, e, PestAnam_Txt_TipoFamilia);
        }

        private void PestDatosGen_Txt_Escolaridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios(sender, e, PestDatosGen_Txt_Escolaridad);
        }

        private void PestDatosGen_Txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, PestDatosGen_Txt_Direccion);
        }

        private void PestDatosGen_Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValidarID(sender,e);
        }

        private void PestDatosGen_Txt_RefiridoPor_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios(sender, e, PestDatosGen_Txt_RefiridoPor);
        }

        private void PestDatosGen_Txt_Lugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, PestDatosGen_Txt_Lugar);
        }

        private void PestDatosGen_Txt_Fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.Fecha(sender, e, PestDatosGen_Txt_Fecha);
        }

        private void textBox158_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender,e, textBox158);
        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void textBox156_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox156);
        }

        private void textBox159_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox159);
        }

        private void textBox150_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox150);
        }

        private void textBox148_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox148);
        }

        private void textBox152_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox152);
        }

        private void textBox154_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender,e, textBox154);
        }

        private void textBox119_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox119);
        }

        private void textBox118_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox118);
        }

        private void textBox117_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox117);
        }

        private void textBox116_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox116);
        }

        private void textBox145_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox145);
        }

        private void textBox147_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox147);
        }

        private void textBox146_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox146);
        }

        private void textBox144_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox144);
        }

        private void textBox143_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox143);
        }

        private void textBox142_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox142);
        }

        private void textBox106_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox106);
        }

        private void textBox107_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox107);
        }

        private void textBox108_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox108);
        }

        private void textBox103_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox103);
        }

        private void textBox102_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox102);
        }

        private void textBox105_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox105);
        }

        private void textBox109_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox109);
        }

        private void textBox110_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox110);
        }

        private void textBox101_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox101);
        }

        private void textBox111_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox111);
        }

        private void textBox112_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox112);
        }

        private void PestDes_Txt_HanNotado_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, PestDes_Txt_HanNotado);
        }

        private void PestDesar_Motriz_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, PestDesar_Motriz);
        }

        private void textBox100_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox100);
        }

        private void textBox97_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox97);
        }

        private void textBox99_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox99);
        }

        private void textBox96_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox96);
        }

        private void textBox98_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox98);
        }

        private void textBox95_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox95);
        }

        private void textBox124_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox124);
        }

        private void textBox125_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox125);
        }

        private void textBox126_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox126);
        }

        private void textBox127_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox127);
        }

        private void textBox132_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox132);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox2);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox1);
        }

        private void textBox134_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox134);
        }

        private void textBox135_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox135);
        }

        private void textBox137_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox137);
        }

        private void textBox138_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox138);
        }

        private void textBox139_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox139);
        }

        private void textBox140_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox140);
        }

        private void textBox141_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox141);
        }

        private void textBox113_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox113);
        }

        private void textBox120_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox120);
        }

        private void textBox121_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox121);
        }

        private void textBox122_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox122);
        }

        private void textBox133_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox133);
        }

        private void textBox131_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox131);
        }

        private void textBox128_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox128);
        }

        private void textBox129_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox129);
        }

        private void textBox130_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox130);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Val.ValirLetrasYEspacios_Direccion(sender, e, textBox3);
        }
    }
}
