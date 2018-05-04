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
    public partial class VistaEstSoc : Form
    {
        public int Cod_Otros, Cod_Padre, Cod_Madre, Cod_Socioeconomico;

        //FromBusquedaAlumno F_ShowAlum = new FromBusquedaAlumno();
        Clases.C_Validaciones vali = new Clases.C_Validaciones();
        Clases.C_responsablePadre padrep = new Clases.C_responsablePadre();
        Clases.C_responsablesMadre madrep = new Clases.C_responsablesMadre();
        Clases.C_ResponsablesOtro otroresp = new Clases.C_ResponsablesOtro();
        Clases.C_InformacionFamilia infofamilia = new Clases.C_InformacionFamilia();
        Clases.C_CambiosSocio cambios = new Clases.C_CambiosSocio();

        int var_respM = 0;
        int var_respP = 0;
        int var_respO = 0;

        public int Cod_Usuario=0;


        Clases.C_DatosGenerales C_datos = new Clases.C_DatosGenerales();
        Clases.C_EstudioSocioEc C_estudio = new Clases.C_EstudioSocioEc();
        int Var_codigoAlumno = 0;
        int var_CodEstudioSE = 0;

        double total_ingresos;
        double total_gastos;


        public VistaEstSoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabEstSocioEco.SelectedTab = InformacionFamilia;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabEstSocioEco.SelectedTab = SaludRecreacion;
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            Limpiar();
            FormBusquedaResponsables frmBusqEstSoc = new FormBusquedaResponsables();
            frmBusqEstSoc.ShowDialog();


            if (FormBusquedaResponsables.socio != null)
            {
                txt_fechaEntrevista.Text = Convert.ToString(FormBusquedaResponsables.socio.FechaEntrevista);
                txt_EsSo_lugar_DatosGe.Text = FormBusquedaResponsables.socio.LugarEntrevista;
                txt_EsSo_PersonaEntre_DatosGe.Text = FormBusquedaResponsables.socio.PersonaEntrevis;
                txt_EsSo_Aporbado_SaludRecre.Text = FormBusquedaResponsables.socio.EntrevistadoPor1;
            }
            else
            {
                MessageBox.Show("No existe Estudio Socioeconomico de este Alumno","Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (FormBusquedaResponsables.AlumnoSeleccionado != null)
            {
                C_datos.CodAlumno = FormBusquedaResponsables.AlumnoSeleccionado.CodAlumno;
                Var_codigoAlumno= FormBusquedaResponsables.AlumnoSeleccionado.CodAlumno;
                txt_EsSo_IdentiEst_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.AlumnoSeleccionado.IdAlumno);
                txt_EsSo_NombreEst_DatosGe.Text = FormBusquedaResponsables.AlumnoSeleccionado.NombreAlumno;
                txt_EsSo_LugarNaci_DatosGe.Text = FormBusquedaResponsables.AlumnoSeleccionado.LugarNacAlumno;
                txt_EsSo_FechaNa_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.AlumnoSeleccionado.Fecha_NacAlumno.Date);
                txt_EsSo_EdadEst_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.AlumnoSeleccionado.EdadAlumno);
                txt_EsSo_SexoAlum_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.AlumnoSeleccionado.SexoAlumno);
                txt_EsSo_lugar_DatosGe.Text = FormBusquedaResponsables.AlumnoSeleccionado.LugarNacAlumno;
                txt_EsSo_PersonaEntre_DatosGe.Text = FormBusquedaResponsables.AlumnoSeleccionado.PersonaEntrevistada;


                if (FormBusquedaResponsables.madreSeleccionado != null)
                {
                    madrep.CodAlumno = FormBusquedaResponsables.madreSeleccionado.CodAlumno;


                    txt_EsSo_NomMadre_DatosGe.Text = FormBusquedaResponsables.madreSeleccionado.NombResp;
                    txt_EsSo_OficioMadre_forma.Text = FormBusquedaResponsables.madreSeleccionado.ProfesionResp1 + FormBusquedaResponsables.madreSeleccionado.OficioREsp;
                    txt_EsSo_LugarTrabMadre_forma.Text = FormBusquedaResponsables.madreSeleccionado.LugarTrabRes;
                    txt_EsSo_CelMadre_DatosGe.Text = FormBusquedaResponsables.madreSeleccionado.TelefonoCasaResp;
                    txt_EsSo_IdentMadre_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.madreSeleccionado.IdResp);
                    txt_EsSo_DomiciMadre_DatosGe.Text =FormBusquedaResponsables.madreSeleccionado.DomicilioResp;
                    txt_EsSo_LugarTrabMadre_forma.Text = FormBusquedaResponsables.madreSeleccionado.LugarTrabRes;
                    txt_EsSo_TelCasaMadre_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.madreSeleccionado.TelefonoCasaResp);
                    txt_EsSo_TelTrabMadre_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.madreSeleccionado.TrabajoResp);

                }

                if (FormBusquedaResponsables.padreSeleccionado != null)
                {
                    padrep.CodAlumno = FormBusquedaResponsables.padreSeleccionado.CodAlumno;


                    txt_EsSo_NomPadre_DatosGe.Text = FormBusquedaResponsables.padreSeleccionado.NombResp;
                    txt_EsSo_OficioPadre_forma.Text = FormBusquedaResponsables.padreSeleccionado.ProfesionResp1 + FormBusquedaResponsables.padreSeleccionado.OficioREsp;
                    txt_EsSo_LugarTrabPadre_forma.Text = FormBusquedaResponsables.padreSeleccionado.LugarTrabRes;
                    txt_EsSo_CelPadre_DatosGe.Text = FormBusquedaResponsables.padreSeleccionado.TelefonoCasaResp;
                    txt_EsSo_IdentPadre_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.padreSeleccionado.IdResp);
                    txt_EsSo_DomiciPadre_DatosGe.Text = FormBusquedaResponsables.padreSeleccionado.DomicilioResp;
                    txt_EsSo_LugarTrabPadre_forma.Text = FormBusquedaResponsables.padreSeleccionado.LugarTrabRes;
                    txt_EsSo_TelCAsaPadre_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.padreSeleccionado.TelefonoCasaResp);
                    txt_EsSo_TelTrabPadre_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.padreSeleccionado.TrabajoResp);
                }


                if (FormBusquedaResponsables.otrorespSeleccionado != null)
                {
                    otroresp.CodAlumno = FormBusquedaResponsables.otrorespSeleccionado.CodAlumno;


                    txt_EsSo_NomEncarg_DatosGe.Text = FormBusquedaResponsables.otrorespSeleccionado.NomRespOtro;
                    txt_EsSo_OficioEncarg_DatosGe.Text = FormBusquedaResponsables.otrorespSeleccionado.Oficio + FormBusquedaResponsables.otrorespSeleccionado.Profesion;
                    txt_EsSo_EdadEncarg_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.otrorespSeleccionado.Edad);
                    txt_EsSo_TelEncarg_DatosGe.Text = FormBusquedaResponsables.otrorespSeleccionado.Cel;
                    txt_EsSo_ParentescoEncar_DatosGe.Text = FormBusquedaResponsables.otrorespSeleccionado.Parentesco;

                }

                if (FormBusquedaResponsables.Infofamilia != null)
                {
                    infofamilia.CodAlumno1 = FormBusquedaResponsables.Infofamilia.CodAlumno1;

                    txt_EsSo_HabitantesCasa_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.PersonasHabitan1);
                    txt_EsSo_MasHijos_InfoFami.Text = FormBusquedaResponsables.Infofamilia.TieneMasHijos1;
                    txt_EsSo_CuantosHijos_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.Cuantoshijosmas);
                    txt_EsSo_CuantosFami_InfoFami.Text = FormBusquedaResponsables.Infofamilia.HabitanOtrosFamiliares1;
                    txt_EsSo_TotalMiemb_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.MienEnTotal1);
                    txt_EsSo_TotalTraba_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.CuantosMiembrosTrabajan1);
                    txt_EsSo_IngreAbue_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.IngresoAbuela1);
                    txt_EsSo_IngrePadre_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.IngresoPadre1);
                    txt_EsSo_IngreMadre_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.IngresoMadre1);
                    txt_EsSo_IngreHijo_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.IngresoHijo1);
                    txt_EsSo_IngrePencion_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.Pension1);
                    txt_EsSo_IngreOtros_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.OtrosIngresos1);
                    txt_EsSo_IngreTotales_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.TotalIngresos1);
                    txt_EsSo_Energia_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.GastosEnergia1);
                    txt_EsSo_TotalMiemb_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.MienEnTotal1);
                    txt_EsSo_Agua_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.GastoAgua1);
                    txt_EsSo_Telefono_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.GastoTel1);
                    txt_EsSo_Alimentos_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.GastoComida1);
                    txt_EsSo_Transp_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.GastoTransp1);
                    txt_EsSo_Salud_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.GastoSalub1);
                    txt_EsSo_Educa_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.GastoEduca1);
                    txt_EsSo_Combus_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.GastoGaso1);
                    txt_EsSo_Vestime_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.GastoRpa1);
                    txt_EsSo_Alquiler_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.GastoVivienda1);
                    txt_EsSo_Otros_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.OtrosGastos1);
                    txt_EsSo_TotalGastos_InfoFami.Text = Convert.ToString(FormBusquedaResponsables.Infofamilia.TotalGastos1);


                }

                if (FormBusquedaResponsables.Recreacion != null)
                {


                    txt_EsSo_Parques_SaludRecre.Text = FormBusquedaResponsables.Recreacion.Parques;
                    txt_EsSo_CentrosCom_SaludRecre.Text = FormBusquedaResponsables.Recreacion.CentrosComerciales;
                    txt_EsSo_Museos_SaludRecre.Text = Convert.ToString(FormBusquedaResponsables.Recreacion.Museos);
                    txt_EsSo_cine_SaludRecre.Text = FormBusquedaResponsables.Recreacion.Museos;
                    txt_EsSo_Balnearios_SaludRecre.Text = FormBusquedaResponsables.Recreacion.Balnearios;
                    txt_EsSo_Playa_SaludRecre.Text = FormBusquedaResponsables.Recreacion.Playa;
                    txt_EsSo_OtrosLugares_SaludRecre.Text = FormBusquedaResponsables.Recreacion.Otros;

                }



                if (FormBusquedaResponsables.Medico != null)
                {


                    txt_lugares_recibe_atencionMe.Text = FormBusquedaResponsables.Medico.LugaresRecibeAtencion1;
                    txt_enfermedaPaFa.Text = FormBusquedaResponsables.Medico.EnfermedadesPadeceFamilia1;
                    txt_EsSo_GastoMedi_SaludRecre.Text = Convert.ToString(FormBusquedaResponsables.Medico.CuantoGastaMedi1);
                }

                if (FormBusquedaResponsables.vivienda != null)
                {
                    txt_tenencia.Text = FormBusquedaResponsables.vivienda.Tenencia;
                    txt_consturccion.Text = FormBusquedaResponsables.vivienda.MaterialConst;
                    txt_piso.Text = FormBusquedaResponsables.vivienda.MaterialPiso;
                    txt_servicios_clq_cuenta.Text = FormBusquedaResponsables.vivienda.ServicioBasicos;
                    txt_disponeDe.Text = FormBusquedaResponsables.vivienda.DisponeDe;
                }

                if (FormBusquedaResponsables.socio != null)
                {
                    Cod_Socioeconomico = FormBusquedaResponsables.socio.CodEstudioSocio;
                    txt_fechaEntrevista.Text= Convert.ToString(FormBusquedaResponsables.socio.FechaEntrevista);
                    txt_EsSo_lugar_DatosGe.Text = FormBusquedaResponsables.socio.LugarEntrevista;
                    txt_EsSo_PersonaEntre_DatosGe.Text = FormBusquedaResponsables.socio.PersonaEntrevis;
                    txt_EsSo_Aporbado_SaludRecre.Text = FormBusquedaResponsables.socio.EntrevistadoPor1;
                }







            }
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatosGenerales_Click(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_NomMadre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_IdentMadre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_NomPadre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_IdentPadre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_DomiciPadre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_NomEncarg_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_ParentescoEncar_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_TelEncarg_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_EdadEncarg_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_OficioEncarg_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_TelTrabPadre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_CelPadre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_TelCAsaPadre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_OficioPadre_forma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_LugarTrabPadre_forma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_OficioMadre_forma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_PersonaEntre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_fechaEntrevista_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_TelCasaMadre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_CelMadre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_LugarTrabMadre_forma_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_TelTrabMadre_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_EdadEst_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_FechaNa_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_LugarNaci_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_NombreEst_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformacionFamilia_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void VistaEstSoc_Load(object sender, EventArgs e)
        {
            if (Cod_Usuario == 3)
            {
                button6.Visible = true;
                label79.Visible = true;
                HabilitarGrupos();

            }
            else
            {
                button6.Visible = false;
                label79.Visible = false;
            }

            CliciDerecho();
        }

        public void HabilitarGrupos()
        {

            var boxes7 = groupBox12.Controls.OfType<TextBox>();
            foreach (var box in boxes7)
            {
                box.ReadOnly = false;

            }

            var boxes8 = groupBox9.Controls.OfType<TextBox>();
            foreach (var box in boxes8)
            {
                box.ReadOnly = false;

            }

            var boxes = groupBox13.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ReadOnly = false;

            }
           

            txt_EsSo_IdentiEst_DatosGe.ReadOnly = false;

            

            /////////////////////////////
            txt_disponeDe.ReadOnly = false;
txt_servicios_clq_cuenta.ReadOnly = false;
            txt_EsSo_Aporbado_SaludRecre.ReadOnly = false;
            txt_EsSo_GastoMedi_SaludRecre.ReadOnly = false;
            txt_enfermedaPaFa.ReadOnly = false;
            txt_lugares_recibe_atencionMe.ReadOnly = false;
            txt_fechaEntrevista.ReadOnly = true;

            txt_EsSo_HabitantesCasa_InfoFami.ReadOnly = false;
            txt_EsSo_CuantosFami_InfoFami.ReadOnly = false;
            txt_EsSo_TotalMiemb_InfoFami.ReadOnly = false;
            txt_EsSo_TotalTraba_InfoFami.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_EsSo_NombreEst_DatosGe.Text))
            {
                MessageBox.Show("Debe elegir a un estudiante", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (Fun_ValidarVacios() == true)
            {
                MessageBox.Show("Existen campos requeridos vacios", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            /*
            if (ValidarVaciosPadres() == true)
            {
                MessageBox.Show("Existen campos en los datos del padre que son requeridos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidarVaciosMadre() == true)
            {
                MessageBox.Show("Existen campos en los datos de la madre que son requeridos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidarVaciosOtros() == true)
            {
                MessageBox.Show("Existen campos en los datos del otro responsable que son requeridos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

    */
            Fun_LlenarVacios1();

            //cambios----Var_codigoAlumno
            try
            {
                cambios.Fun_IngresarRecreacion(txt_EsSo_Parques_SaludRecre.Text, txt_EsSo_CentrosCom_SaludRecre.Text, txt_EsSo_Museos_SaludRecre.Text,
                    txt_EsSo_cine_SaludRecre.Text, txt_EsSo_Balnearios_SaludRecre.Text, txt_EsSo_Playa_SaludRecre.Text, txt_EsSo_OtrosLugares_SaludRecre.Text, Var_codigoAlumno);


                cambios.Fun_IngresarInformacionVivienda(txt_tenencia.Text, txt_consturccion.Text,
                    txt_piso.Text, txt_servicios_clq_cuenta.Text, txt_disponeDe.Text, Var_codigoAlumno);



                cambios.Fun_IngresarHistorial(txt_lugares_recibe_atencionMe.Text, txt_enfermedaPaFa.Text, Convert.ToDouble(txt_EsSo_GastoMedi_SaludRecre.Text), Var_codigoAlumno);

                cambios.Fun_InformacionFamilia(Convert.ToInt32(txt_EsSo_HabitantesCasa_InfoFami.Text), txt_EsSo_CuantosFami_InfoFami.Text,
                    Convert.ToInt32(txt_EsSo_TotalMiemb_InfoFami.Text), Convert.ToInt32(txt_EsSo_TotalTraba_InfoFami.Text), Var_codigoAlumno);


                cambios.Fun_Estudio(txt_EsSo_lugar_DatosGe.Text, txt_EsSo_PersonaEntre_DatosGe.Text, txt_EsSo_Aporbado_SaludRecre.Text, Var_codigoAlumno);


                cambios.ActualizarID(txt_EsSo_IdentiEst_DatosGe.Text, Var_codigoAlumno);
                MessageBox.Show("Los datos se guardaron correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en la actualización", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            /* if (string.IsNullOrEmpty(txt_EsSo_NomMadre_DatosGe.Text) ==false && string.IsNullOrEmpty(txt_EsSo_IdentMadre_DatosGe.Text) == false)
            {
                //Madre
            }

            if (string.IsNullOrEmpty(txt_EsSo_NomPadre_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_IdentPadre_DatosGe.Text) == false)
            {
                //Padre
            }

            if (string.IsNullOrEmpty(txt_EsSo_NomEncarg_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_ParentescoEncar_DatosGe.Text) == false)
            {
                //Otros
            }
            */
            Limpiar();
        }

        private void Limpiar()
        {
            txt_disponeDe.Text = string.Empty;
            txt_servicios_clq_cuenta.Text = string.Empty;
            txt_EsSo_GastoMedi_SaludRecre.Text = string.Empty;
            txt_EsSo_Aporbado_SaludRecre.Text = string.Empty;
            txt_enfermedaPaFa.Text = string.Empty;
            txt_lugares_recibe_atencionMe.Text = string.Empty;

            txt_EsSo_HabitantesCasa_InfoFami.Text = string.Empty;
            txt_EsSo_MasHijos_InfoFami.Text = string.Empty;
            txt_EsSo_CuantosHijos_InfoFami.Text = string.Empty;
            txt_EsSo_CuantosFami_InfoFami.Text = string.Empty;
            txt_EsSo_TotalMiemb_InfoFami.Text = string.Empty;
            txt_EsSo_TotalTraba_InfoFami.Text = string.Empty;

            var boxes = groupBox3.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.Text = string.Empty;

            }
            var boxes1 = groupBox2.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                box.Text = string.Empty;

            }
            var boxes2 = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxes2)
            {
                box.Text = string.Empty;

            }

            var boxes3 = groupBox13.Controls.OfType<TextBox>();
            foreach (var box in boxes3)
            {
                box.Text = string.Empty;

            }

            var boxes4 = groupBox4.Controls.OfType<TextBox>();
            foreach (var box in boxes4)
            {
                box.Text = string.Empty;

            }

            var boxes5 = groupBox6.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                box.Text = string.Empty;

            }

            var boxes6 = groupBox5.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                box.Text = string.Empty;

            }

            var boxes7 = groupBox12.Controls.OfType<TextBox>();
            foreach (var box in boxes7)
            {
                box.Text = string.Empty;

            }

            var boxes8 = groupBox9.Controls.OfType<TextBox>();
            foreach (var box in boxes8)
            {
                box.Text = string.Empty;

            }

        }



        private void CliciDerecho()
        {
            var blankContextMenu = new ContextMenuStrip();

            txt_disponeDe.ContextMenuStrip = blankContextMenu;
            txt_servicios_clq_cuenta.ContextMenuStrip = blankContextMenu;
            txt_EsSo_GastoMedi_SaludRecre.ContextMenuStrip = blankContextMenu;
            txt_EsSo_Aporbado_SaludRecre.ContextMenuStrip = blankContextMenu;
            txt_enfermedaPaFa.ContextMenuStrip = blankContextMenu;
            txt_lugares_recibe_atencionMe.ContextMenuStrip = blankContextMenu;

            txt_EsSo_HabitantesCasa_InfoFami.ContextMenuStrip = blankContextMenu;
            txt_EsSo_MasHijos_InfoFami.ContextMenuStrip = blankContextMenu;
            txt_EsSo_CuantosHijos_InfoFami.ContextMenuStrip = blankContextMenu;
            txt_EsSo_CuantosFami_InfoFami.ContextMenuStrip = blankContextMenu;
            txt_EsSo_TotalMiemb_InfoFami.ContextMenuStrip = blankContextMenu;
            txt_EsSo_TotalTraba_InfoFami.ContextMenuStrip = blankContextMenu;

            var boxes = groupBox3.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
            var boxes1 = groupBox2.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
            var boxes2 = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxes2)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes3 = groupBox13.Controls.OfType<TextBox>();
            foreach (var box in boxes3)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes4 = groupBox4.Controls.OfType<TextBox>();
            foreach (var box in boxes4)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes5 = groupBox6.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes6 = groupBox5.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes7 = groupBox12.Controls.OfType<TextBox>();
            foreach (var box in boxes7)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes8 = groupBox9.Controls.OfType<TextBox>();
            foreach (var box in boxes8)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

        }

        private void txt_lugares_recibe_atencionMe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_lugares_recibe_atencionMe);
        }

        private void txt_enfermedaPaFa_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_enfermedaPaFa);
        }

        private void txt_EsSo_GastoMedi_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.NumerosDecimales(sender,e, txt_EsSo_GastoMedi_SaludRecre);
        }

        private void txt_EsSo_Aporbado_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender,e, txt_EsSo_Aporbado_SaludRecre);
        }

        private void txt_disponeDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_disponeDe);
        }

        private void txt_servicios_clq_cuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_servicios_clq_cuenta);
        }

        private void txt_tenencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_tenencia);
        }

        private void txt_consturccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_consturccion);
        }

        private void txt_piso_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_piso);
        }

        private void txt_EsSo_OtrosLugares_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_OtrosLugares_SaludRecre);
        }

        private void txt_EsSo_Playa_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_Playa_SaludRecre);
        }

        private void txt_EsSo_Balnearios_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_Balnearios_SaludRecre);
        }

        private void txt_EsSo_cine_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_cine_SaludRecre);
        }

        private void txt_EsSo_Parques_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_Parques_SaludRecre);
        }

        private void txt_EsSo_CentrosCom_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_CentrosCom_SaludRecre);
        }

        private void txt_EsSo_Museos_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_Museos_SaludRecre);
        }

        private void txt_EsSo_TotalMiemb_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_TotalTraba_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_CuantosFami_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios(sender,e, txt_EsSo_CuantosFami_InfoFami);
        }

        private void txt_EsSo_HabitantesCasa_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_IdentiEst_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_lugar_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {

            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_lugar_DatosGe);

        }

        private void txt_EsSo_PersonaEntre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {

            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_PersonaEntre_DatosGe);

        }

        private void txt_EsSo_TelEncarg_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_EdadEncarg_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_TelCAsaPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_CelPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_TelTrabPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_TelTrabMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_CelMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_TelCasaMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_IdentPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_IdentMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValidarID(sender, e);
        }

        private void txt_EsSo_OficioEncarg_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_OficioEncarg_DatosGe);
        }

        private void txt_EsSo_NomEncarg_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_NomEncarg_DatosGe);
        }

        private void txt_EsSo_ParentescoEncar_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_ParentescoEncar_DatosGe);
        }

        private void txt_EsSo_NomPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_NomPadre_DatosGe);
        }

        private void txt_EsSo_OficioPadre_forma_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_OficioPadre_forma);
        }

        private void txt_EsSo_DomiciPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_DomiciPadre_DatosGe);
        }

        private void txt_EsSo_LugarTrabPadre_forma_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_LugarTrabPadre_forma);
        }

        private void txt_EsSo_LugarTrabMadre_forma_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_LugarTrabMadre_forma);
        }

        private void txt_EsSo_OficioMadre_forma_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_OficioMadre_forma);
        }

        private void txt_EsSo_DomiciMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_DomiciMadre_DatosGe);
        }

        private void txt_EsSo_NomMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.ValirLetrasYEspacios_Direccion(sender, e, txt_EsSo_NomMadre_DatosGe);
        }


        public void Fun_LlenarVacios1()
        {
            if (string.IsNullOrEmpty(txt_EsSo_HabitantesCasa_InfoFami.Text))
            {
                txt_EsSo_HabitantesCasa_InfoFami.Text = "0";
            }

            if (string.IsNullOrEmpty(txt_EsSo_CuantosFami_InfoFami.Text))
            {
                txt_EsSo_CuantosFami_InfoFami.Text = "No";
            }

            if (string.IsNullOrEmpty(txt_EsSo_TotalMiemb_InfoFami.Text))
            {
                txt_EsSo_TotalMiemb_InfoFami.Text = "0";
            }

            if (string.IsNullOrEmpty(txt_EsSo_TotalTraba_InfoFami.Text))
            {
                txt_EsSo_TotalTraba_InfoFami.Text = "0";
            }


            if (string.IsNullOrEmpty(txt_disponeDe.Text))
            {
                txt_disponeDe.Text = "Ninguno";
            }

            if (string.IsNullOrEmpty(txt_servicios_clq_cuenta.Text))
            {
                txt_servicios_clq_cuenta.Text = "Ninguno";
            }

            if (string.IsNullOrEmpty(txt_EsSo_GastoMedi_SaludRecre.Text))
            {
                txt_EsSo_GastoMedi_SaludRecre.Text = "0";
            }

            if (string.IsNullOrEmpty(txt_enfermedaPaFa.Text))
            {
                txt_enfermedaPaFa.Text = "Ninguno";
            }

            if (string.IsNullOrEmpty(txt_lugares_recibe_atencionMe.Text))
            {
                txt_lugares_recibe_atencionMe.Text = "Ninguno";
            }



            var boxes6 = groupBox9.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "No";
                }
            }


                var boxes7 = groupBox12.Controls.OfType<TextBox>();
                foreach (var box in boxes7)
                {
                    if (string.IsNullOrEmpty(box.Text))
                    {
                        box.Text = "Desconocido";
                    }
                }

        }


        private bool Fun_ValidarVacios()
        {
            bool ExistenVacios = false;

            if (string.IsNullOrEmpty(txt_EsSo_Aporbado_SaludRecre.Text))
            {
                errorProvider1.SetError(txt_EsSo_Aporbado_SaludRecre, "Debe llenar este campo");
                ExistenVacios = true;
            }else
            {
                errorProvider1.SetError(txt_EsSo_Aporbado_SaludRecre, "");
            }
            //***************************************************************************************************




            if (string.IsNullOrEmpty(txt_EsSo_lugar_DatosGe.Text))
            {
                errorProvider1.SetError(txt_EsSo_lugar_DatosGe, "Debe llenar este campo");
                ExistenVacios = true;
            }
            else
            {
                errorProvider1.SetError(txt_EsSo_lugar_DatosGe, "");
            }




            if (string.IsNullOrEmpty(txt_EsSo_PersonaEntre_DatosGe.Text))
            {
                errorProvider1.SetError(txt_EsSo_PersonaEntre_DatosGe, "Debe llenar este campo");
                ExistenVacios = true;
            }
            else
            {
                errorProvider1.SetError(txt_EsSo_PersonaEntre_DatosGe, "");
            }



            if (string.IsNullOrEmpty(txt_EsSo_IdentiEst_DatosGe.Text))
            {
                errorProvider1.SetError(txt_EsSo_IdentiEst_DatosGe, "Debe llenar este campo");
                ExistenVacios = true;
            }
            else
            {
                errorProvider1.SetError(txt_EsSo_IdentiEst_DatosGe, "");
            }
            
            return ExistenVacios;
        }


        private bool ValidarVaciosPadres()
        {
            bool ExisteIncosistencia = true;

           
            if (string.IsNullOrEmpty(txt_EsSo_NomPadre_DatosGe.Text) == true && string.IsNullOrEmpty(txt_EsSo_IdentPadre_DatosGe.Text) == true
                  && string.IsNullOrEmpty(txt_EsSo_OficioPadre_forma.Text) == true && string.IsNullOrEmpty(txt_EsSo_DomiciPadre_DatosGe.Text) == true
                  && string.IsNullOrEmpty(txt_EsSo_TelCAsaPadre_DatosGe.Text) == true && string.IsNullOrEmpty(txt_EsSo_CelPadre_DatosGe.Text) == true
                  && string.IsNullOrEmpty(txt_EsSo_LugarTrabPadre_forma.Text) == true && string.IsNullOrEmpty(txt_EsSo_TelTrabPadre_DatosGe.Text) == true)
            {
                ExisteIncosistencia = false;
            }


            if (string.IsNullOrEmpty(txt_EsSo_NomPadre_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_IdentPadre_DatosGe.Text) == false
                  && string.IsNullOrEmpty(txt_EsSo_OficioPadre_forma.Text) == false && string.IsNullOrEmpty(txt_EsSo_DomiciPadre_DatosGe.Text) == false
                  && string.IsNullOrEmpty(txt_EsSo_TelCAsaPadre_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_CelPadre_DatosGe.Text) == false
                  && string.IsNullOrEmpty(txt_EsSo_LugarTrabPadre_forma.Text) == false && string.IsNullOrEmpty(txt_EsSo_TelTrabPadre_DatosGe.Text) == false)
            {
                ExisteIncosistencia = false;
            }
            return ExisteIncosistencia;
        }


        private bool ValidarVaciosMadre()
        {
            bool ExisteIncosistencia = true;

            if (string.IsNullOrEmpty(txt_EsSo_NomMadre_DatosGe.Text) == true && string.IsNullOrEmpty(txt_EsSo_IdentMadre_DatosGe.Text) == true
                && string.IsNullOrEmpty(txt_EsSo_OficioMadre_forma.Text) == true && string.IsNullOrEmpty(txt_EsSo_DomiciMadre_DatosGe.Text) == true
                && string.IsNullOrEmpty(txt_EsSo_TelCasaMadre_DatosGe.Text) == true && string.IsNullOrEmpty(txt_EsSo_CelMadre_DatosGe.Text) == true
                && string.IsNullOrEmpty(txt_EsSo_LugarTrabMadre_forma.Text) == true && string.IsNullOrEmpty(txt_EsSo_TelTrabMadre_DatosGe.Text) == true)
            {
                ExisteIncosistencia = false;
            }

            if (string.IsNullOrEmpty(txt_EsSo_NomMadre_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_IdentMadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_OficioMadre_forma.Text) == false && string.IsNullOrEmpty(txt_EsSo_DomiciMadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_TelCasaMadre_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_CelMadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_LugarTrabMadre_forma.Text) == false && string.IsNullOrEmpty(txt_EsSo_TelTrabMadre_DatosGe.Text) == false)
            {
                ExisteIncosistencia = false;
            }

            return ExisteIncosistencia;
        }


        private bool ValidarVaciosOtros()
        {
            bool ExisteIncosistencia = true;

            if (string.IsNullOrEmpty(txt_EsSo_NomEncarg_DatosGe.Text) == true && string.IsNullOrEmpty(txt_EsSo_ParentescoEncar_DatosGe.Text) == true 
                && string.IsNullOrEmpty(txt_EsSo_EdadEncarg_DatosGe.Text) == true && string.IsNullOrEmpty(txt_EsSo_TelEncarg_DatosGe.Text) == true
                && string.IsNullOrEmpty(txt_EsSo_OficioEncarg_DatosGe.Text) == true)
            {
                ExisteIncosistencia = false;
            }


            if (string.IsNullOrEmpty(txt_EsSo_NomEncarg_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_ParentescoEncar_DatosGe.Text) == false
                && string.IsNullOrEmpty(txt_EsSo_EdadEncarg_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_TelEncarg_DatosGe.Text) == false 
                && string.IsNullOrEmpty(txt_EsSo_OficioEncarg_DatosGe.Text) == false)
            {
                ExisteIncosistencia = false;
            }


            return ExisteIncosistencia;
        }
    }
}
