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

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
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
            Fun_Limpiar();
            Pest_txtNumeroMatricula.Text = FV_CodMat.ToString();
            Pest1_Txt_NombreEstudiante.Text = FV_NomAlumno;

            C_BusqMatricula Cl_Busq = new C_BusqMatricula();
            C_Tipos_Atencion Cl_Tipo = new C_Tipos_Atencion();

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

            Pest1_Txt_Jornada.Text = Cl_Busq.Fun_Conseguir_jorm();
            Pest1_Txt_LugarNacimiento.Text = Cl_Busq.Var_DG_TipoMatricula;

            Cl_Busq.Fun_UsaMedicamento();
            Pest4_Txt_UsaMedicamentos.Text = Cl_Busq.Var_Usa_medicamentos;


            Cl_Tipo.Fun_BuscarTipos(Cl_Busq.Var_Alum_CodAlumno);


            Fun_Comb(comboBox_atencion_fisica, Cl_Tipo.Var_Combo_AtensionFisica);


            Fun_Comb(comboBox_atencion_grupal, Cl_Tipo.Var_Combo_AtencionGrupal);

            Fun_Comb(comboBox_atencion_prevocacional, Cl_Tipo.Var_Combo_AtencionPreVocacional);

            Fun_Comb(comboBox_atencion_terapia_domicilio, Cl_Tipo.Var_Combo_TerapiaDomicilio);

            Fun_Comb(comboBox_atencion_vocacional, Cl_Tipo.Var_Combo_AtencionVocacional);

            Fun_Comb(comboBox_atension_distancia, Cl_Tipo.Var_Combo_Distancia);
            Fun_Comb(comboBox_atension_escolar, Cl_Tipo.Var_Combo_Escolar);
            Fun_Comb(comboBox_atension_individual, Cl_Tipo.Var_Combo_Individual);

            if (Cl_Busq.Fun_ExtraerResponsables(Cl_Busq.Var_Alum_CodAlumno, 1))
            {
                Pest3_Txt_NombrePadre.Text= Cl_Busq.Var_nombre;
                Pest3_Txt_ProfesionPadre.Text = Cl_Busq.Var_profesion;
                Pest3_Txt_LugarPadre.Text = Cl_Busq.Var_lugar;
                Pest3_Txt_TelefonoPadre.Text = Cl_Busq.Var_telefono;
            }

            if (Cl_Busq.Fun_ExtraerResponsables(Cl_Busq.Var_Alum_CodAlumno, 2))
            {
                Pest3_Txt_NombreMadre.Text = Cl_Busq.Var_nombre;
                Pest3_Txt_ProfesionMadre.Text = Cl_Busq.Var_profesion;
                Pest3_Txt_LugarMadre.Text = Cl_Busq.Var_lugar;
                Pest3_Txt_TelefonoMadre.Text = Cl_Busq.Var_telefono;
            }

        }
        
        private void Fun_Limpiar()
        {

            Pest3_Txt_NombrePadre.Text = string.Empty;
            Pest3_Txt_ProfesionPadre.Text = string.Empty;
            Pest3_Txt_LugarPadre.Text = string.Empty;
            Pest3_Txt_TelefonoPadre.Text = string.Empty;
            Pest3_Txt_NombreMadre.Text = string.Empty;
            Pest3_Txt_ProfesionMadre.Text = string.Empty;
            Pest3_Txt_LugarMadre.Text = string.Empty;
            Pest3_Txt_TelefonoMadre.Text = string.Empty;
            Pest1_Txt_LugarNacimiento.Text = string.Empty;
            textBox1.Text = string.Empty;
            Pest1_Txt_FechaNacimiento.Text = string.Empty;
            Pest1_Txt_DireccionCompleta.Text = string.Empty;
            Pest1_Txt_Celular.Text = string.Empty;
            Pest1_Txt_Instituto.Text = string.Empty;
            Pest1_Txt_AnoIngreso.Text = string.Empty;
            Pest1_Txt_RecibioEvaluacion.Text = string.Empty;
            Pest1_Txt_TelefonoFijo.Text = string.Empty;
            Pest1_Txt_Jornada.Text = string.Empty;
            Pest2_Pest_NombreInstituto.Text = string.Empty;
            Pest4_Txt_DireccionPorEmergencias.Text = string.Empty;
            Pest4_Txt_TelefonoPorEmergencia.Text = string.Empty;
            Pest4_TxtBox_Observaciones.Text = string.Empty;
            Pest4_Txt_Fecha.Text = string.Empty;
            Pest4_Txt_Entrevistador.Text = string.Empty;
            Pest1_Txt_Jornada.Text = string.Empty;
            Pest1_Txt_LugarNacimiento.Text = string.Empty;

        }


        private void Fun_Comb(ComboBox FV_C, string FV_Var_Aten)
        {
            if (FV_Var_Aten == "Si")
            {
                FV_C.SelectedIndex = 0;
            }
            else
            {
                FV_C.SelectedIndex = 1;
            }
        }
        
        private void VistaMatricula_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pest_TiposAtencion_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void Pest3_Txt_NombrePadre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
