using APOAUTIS.Clases;
using APOAUTIS.Formas.Matricula;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using APOAUTIS.Formas

namespace APOAUTIS
{
    public partial class VistaMatricula : Form
    {
        public VistaMatricula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabMatricula.SelectedTab = Pest_TiposAtencion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabMatricula.SelectedTab = Pest_DatosResponsable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabMatricula.SelectedTab = Pest_DatosAdicionales;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_BusqMatricula F_ShowAlum = new Form_BusqMatricula();
            AddOwnedForm(F_ShowAlum);
            F_ShowAlum.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Fun_ExtraerEscencial(int FV_CodMat, int FV_CodAlum, string FV_NomAlumno)
        {
           Pest_txtNumeroMatricula.Text = FV_CodMat.ToString();
           Pest1_Txt_NombreEstudiante.Text = FV_NomAlumno;

            C_BusqMatricula Cl_Busq = new C_BusqMatricula();
            Cl_Busq.Var_Alum_CodAlumno = (int)Convert.ToDouble(FV_CodAlum);
            Cl_Busq.Var_Mat_CodMatricula = (int)Convert.ToDouble(FV_CodMat);
            Cl_Busq.Fun_ExtraerDatos_Mat_Alumno();

            Pest1_Txt_LugarNacimiento.Text = Cl_Busq.Var_DG_TipoMatricula;
            textBox1.Text = Cl_Busq.Var_Alum_lugarnacimiento;
            Pest1_Txt_FechaNacimiento.Text = Cl_Busq.Var_Alum_fechanacimiento;
            Pest1_Txt_DireccionCompleta.Text = Cl_Busq.Var_Alum_direccioncompleta;
            Pest1_Txt_Celular.Text = Cl_Busq.Var_Alum_celular;
            Pest1_Txt_Instituto.Text = Cl_Busq.Var_Alum_instprocedencia;
            Pest1_Txt_AnoIngreso.Text = Cl_Busq.Var_DG_annioingreso;
            Pest1_Txt_RecibioEvaluacion.Text = Cl_Busq.Var_DG_recibioevaluacion;
            Pest1_Txt_TelefonoFijo.Text = Cl_Busq.Var_Alum_telefonofijo;
            Pest1_Txt_Jornada.Text = Cl_Busq.Var_DG_Jornada;
            Pest2_Pest_NombreInstituto.Text = Cl_Busq.Var_Alum_IntitutoIncl;
            Pest4_Txt_DireccionPorEmergencias.Text = Cl_Busq.Var_Alum_direcionemergencia;
            Pest4_Txt_TelefonoPorEmergencia.Text = Cl_Busq.Var_Alum_telefonoemergencia;
            Pest4_TxtBox_Observaciones.Text = Cl_Busq.Var_DG_Observaciones;
            Pest4_Txt_Fecha.Text = Cl_Busq.Var_DG_Fecha;
            Pest4_Txt_Entrevistador.Text = Cl_Busq.Var_DG_Entrevistador;


        }
        private void VistaMatricula_Load(object sender, EventArgs e)
        {
           
        }
    }
}
