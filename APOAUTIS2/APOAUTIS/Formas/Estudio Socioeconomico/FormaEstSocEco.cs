using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APOAUTIS.Formas.Estudio_Socioeconomico;

namespace APOAUTIS
{
    public partial class FormaEstSocEco : Form
    {



        Clases.C_Validaciones Validaciones = new Clases.C_Validaciones();
        FromBusquedaAlumno F_ShowAlum = new FromBusquedaAlumno();

      //  FormGlobalShowAlum F_ShowAlum = new FormGlobalShowAlum();
        Clases.C_DatosGenerales C_datos = new Clases.C_DatosGenerales();

        int Var_codigoAlumno = 0;

        public FormaEstSocEco()
        {
            InitializeComponent();
        }

        private void DatosGenerales_Click(object sender, EventArgs e)
        {

        }

        private void AtencionSalud_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabEstSocioEco.SelectedTab = InformacionFamilia;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabEstSocioEco.SelectedTab = SaludRecreacion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabEstSocioEco.SelectedTab = InformacionVivienda;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             Formas.Matricula.FormMontoMatricula Monto = new Formas.Matricula.FormMontoMatricula();
            Monto.ShowDialog();
        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_lugar_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformacionFamilia_Click(object sender, EventArgs e)
        {

        }

        private void btm_EsSo_BuscarAlumno_DatosGe_Click_1(object sender, EventArgs e)
        {
          /*FromBusquedaAlumno   frmBusqEstSoc = new FromBusquedaAlumno();
            frmBusqEstSoc.ShowDialog();*/
            /*
            AddOwnedForm(F_ShowAlum);
            F_ShowAlum.Accion = "Gastos";
            F_ShowAlum.ShowDialog();
            */



        }

        private void txt_EsSo_SexoAlum_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btm_EsSo_BuscarAlumno_DatosGe_Click(object sender, EventArgs e)
        {
            FromBusquedaAlumno frmBusqEstSoc = new FromBusquedaAlumno();
            frmBusqEstSoc.ShowDialog();

            if(FromBusquedaAlumno.AlumnoSeleccionado != null)
            {
                C_datos.CodAlumno = Var_codigoAlumno;


               // txt_EsSo_NombreEst_DatosGe.Text = Var_Nombre;
                txt_EsSo_IdentiEst_DatosGe.Text = Convert.ToString(FromBusquedaAlumno.AlumnoSeleccionado.IdAlumno);
                txt_EsSo_NombreEst_DatosGe.Text = FromBusquedaAlumno.AlumnoSeleccionado.NombreAlumno;
                txt_EsSo_LugarNaci_DatosGe.Text = FromBusquedaAlumno.AlumnoSeleccionado.LugarNacAlumno;
                txt_EsSo_FechaNa_DatosGe.Text = Convert.ToString( FromBusquedaAlumno.AlumnoSeleccionado.Fecha_NacAlumno.Date);
                txt_EsSo_EdadEst_DatosGe.Text = Convert.ToString(FromBusquedaAlumno.AlumnoSeleccionado.EdadAlumno);
                txt_EsSo_SexoAlum_DatosGe.Text = Convert.ToString(FromBusquedaAlumno.AlumnoSeleccionado.SexoAlumno);

            }

        }
    }
}
