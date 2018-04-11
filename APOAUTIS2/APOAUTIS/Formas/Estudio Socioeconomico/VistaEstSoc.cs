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


        //FromBusquedaAlumno F_ShowAlum = new FromBusquedaAlumno();
        Clases.C_responsablePadre padrep = new Clases.C_responsablePadre();
        Clases.C_responsablesMadre madrep = new Clases.C_responsablesMadre();
        Clases.C_ResponsablesOtro otroresp = new Clases.C_ResponsablesOtro();
        Clases.C_InformacionFamilia infofamilia = new Clases.C_InformacionFamilia();
        int var_respM = 0;
        int var_respP = 0;
        int var_respO = 0;


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

        private void button3_Click(object sender, EventArgs e)
        {
            tabEstSocioEco.SelectedTab = InformacionVivienda;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormBusquedaResponsables frmBusqEstSoc = new FormBusquedaResponsables();
            frmBusqEstSoc.ShowDialog();


            if (FormBusquedaResponsables.AlumnoSeleccionado != null)
            {
                C_datos.CodAlumno = FormBusquedaResponsables.AlumnoSeleccionado.CodAlumno;
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
                    txt_EsSo_LugarTrabMadre_forma.Text = FormBusquedaResponsables.madreSeleccionado.DomicilioResp;
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
                    txt_EsSo_LugarTrabPadre_forma.Text = FormBusquedaResponsables.padreSeleccionado.DomicilioResp;
                    txt_EsSo_TelCAsaPadre_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.padreSeleccionado.TelefonoCasaResp);
                    txt_EsSo_TelTrabPadre_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.padreSeleccionado.TrabajoResp);
                }


                if (FormBusquedaResponsables.otrorespSeleccionado != null)
                {
                    otroresp.CodAlumno = FormBusquedaResponsables.otrorespSeleccionado.CodAlumno;


                    txt_EsSo_NomEncarg_DatosGe.Text = FormBusquedaResponsables.otrorespSeleccionado.NomRespOtro;
                    txt_EsSo_OficioEncarg_DatosGe.Text = FormBusquedaResponsables.otrorespSeleccionado.Oficio + FormBusquedaResponsables.otrorespSeleccionado.Profesion;
                    txt_EsSo_EdadEncarg_DatosGe.Text = Convert.ToString(FormBusquedaResponsables.otrorespSeleccionado.Edad);
                    txt_EsSo_TelEncarg_DatosGe.Text = FormBusquedaResponsables.otrorespSeleccionado.Telefono;
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
    }
}
