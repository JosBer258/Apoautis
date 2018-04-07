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
    }
}
