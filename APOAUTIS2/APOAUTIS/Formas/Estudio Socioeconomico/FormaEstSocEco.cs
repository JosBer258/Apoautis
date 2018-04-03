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

        public void txt_EsSo_lugar_TextChanged(object sender, EventArgs e)
        {

        }

        public void txt_EsSo_IdentiEst_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformacionFamilia_Click(object sender, EventArgs e)
        {

        }

        private void btm_EsSo_BuscarAlumno_DatosGe_Click_1(object sender, EventArgs e)
        {
          FromBusquedaAlumno   frmBusqEstSoc = new FromBusquedaAlumno();
            frmBusqEstSoc.ShowDialog();



            

          
        }

        public void txt_EsSo_SexoAlum_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btm_EsSo_BuscarAlumno_DatosGe_Click(object sender, EventArgs e)
        {









            /*
            FromBusquedaAlumno frmBusqEstSoc = new FromBusquedaAlumno();
            frmBusqEstSoc.ShowDialog();

            if(FromBusquedaAlumno.AlumnoSeleccionado != null)
            {
                txt_EsSo_IdentiEst_DatosGe.Text = Convert.ToString(FromBusquedaAlumno.AlumnoSeleccionado.idAlumno);
                txt_EsSo_NombreEst_DatosGe.Text = FromBusquedaAlumno.AlumnoSeleccionado.nombreAlumno;
                txt_EsSo_LugarNaci_DatosGe.Text = FromBusquedaAlumno.AlumnoSeleccionado.lugarNacAlumno;
                txt_EsSo_FechaNa_DatosGe.Text = Convert.ToString(FromBusquedaAlumno.AlumnoSeleccionado.fecha_NacAlumno);
                txt_EsSo_EdadEst_DatosGe.Text = Convert.ToString(FromBusquedaAlumno.AlumnoSeleccionado.edadAlumno);
                txt_EsSo_SexoAlum_DatosGe.Text = Convert.ToString(FromBusquedaAlumno.AlumnoSeleccionado.sexoAlumno);

            }
            */
        }

        public void txt_EsSo_NombreEst_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        public void txt_EsSo_LugarNaci_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        public void txt_EsSo_FechaNa_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        public void txt_EsSo_EdadEst_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
