using APOAUTIS.Clases;
using APOAUTIS.Formas.Alumnos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Ingreso
{
    public partial class Prueba : Form
    {
        string mario;
        C_VistaEntrevistaPadres CL_Entrevista = new C_VistaEntrevistaPadres();

        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            
        }

        public void Fun_ExtraerDatos(int FV_CodAlumno, string FV_Nombre)
        {


            CL_Entrevista.Var_codigo_alumno = FV_CodAlumno;
            CL_Entrevista.Var_nombre_completo_alumno = FV_Nombre;
            CL_Entrevista.Fun_ExtraerInformacion_Anamnesis();
            mario = CL_Entrevista.Var_peso_al_nacer;
            Fun_MostrarDatosAnamnesis();


        }


        public void Fun_MostrarDatosAnamnesis()
        {

            MessageBox.Show(CL_Entrevista.Var_peso_al_nacer);
            textBox1.Text = mario;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGlobalShowAlum F_ShowAlum = new FormGlobalShowAlum();
            AddOwnedForm(F_ShowAlum);
            F_ShowAlum.Accion = "PP";
            F_ShowAlum.ShowDialog();
        }
    }
}
