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
                CL_Entrevista.Fun_ExtraerInformacion_Anamnesis();
                Fun_MostrarDatosAnamnesis();
          

        }


        public void Fun_MostrarDatosAnamnesis()
        {

            PestA_Txt_PesAlNacer.Text = CL_Entrevista.Var_peso_al_nacer;
            PestAnam_Txt_DuracionGestacion.Text = CL_Entrevista.Var_duracion_periodo_gestacion;
            PestAnam_Txt_TipoFamilia.Text = CL_Entrevista.Var_tipo_familia;
            PestAnam_Txt_DatosPrenatales.Text = CL_Entrevista.Var_datos_relevantes_prenatales;
            PestAnam_Txt_DatosPerinatales.Text = CL_Entrevista.Var_datos_relevantes_perinatales;
            PestAnam_Txt_DatosPostnatales.Text = CL_Entrevista.Var_datos_relevantes_postnatales;
        }

        private void VistaEntrevistaPadres_Load(object sender, EventArgs e)
        {
            
        }
    }
}
