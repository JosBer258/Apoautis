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
using APOAUTIS.Clases;

namespace APOAUTIS
{
    public partial class FormaEstSocEco : Form
    {



        Clases.C_Validaciones Validaciones = new Clases.C_Validaciones();
        //FromBusquedaAlumno F_ShowAlum = new FromBusquedaAlumno();
        Clases.C_responsablePadre padrep = new Clases.C_responsablePadre();
        Clases.C_responsablesMadre madrep = new Clases.C_responsablesMadre();
        Clases.C_ResponsablesOtro otroresp = new Clases.C_ResponsablesOtro();
        C_Alumnos alum = new C_Alumnos();
        C_Responsables cResp = new C_Responsables();
        int var_respM = 0;
        int var_respP = 0;
        int var_respO = 0;


        Clases.C_DatosGenerales C_datos = new Clases.C_DatosGenerales();
        Clases.C_EstudioSocioEc C_estudio = new Clases.C_EstudioSocioEc();
        int Var_codigoAlumno = 0;
        int var_CodEstudioSE = 0;

        double total_ingresos;
        double total_gastos;
        int Cod_Resp;

        string ihss = " ";
        string hospitalEscu = " ";
        string hospitalSanf = " ";
        string centroSa = " ";
        string clinicaPar = " ";
        string otroSalud = " ";
        string Diabetes = " ";
        string hiperten = " ";
        string enferRespi = " ";
        string ninguna = " ";
        string otra = " ";

        string rb_propia = " ";
        string rb_alquilada = " ";
        string rb_otraTenencia = " ";
        string const_ladrillo = " ";
        string cont_bloque = " ";
        string cont_madera = " ";
        string cont_otro = " ";
        string piso_tierra = " ";
        string piso_cemento = " ";
        string piso_ladrillo = " ";
        string piso_ceramica = " ";
        string piso_madera = " ";
        string piso_otro = " ";

        string energia = " ";
        string agua = " ";
        string telefono = " ";
        string alcantarillado = " ";
        string otroServicio = " ";

        string television = " ";
        string equipoSonido = " ";
        string refrigerador = " ";
        string Estufa = " ";
        string ducha = " ";
        string lavadora = " ";
        string auto = " ";
        string micro = " ";
        string compu = " ";
        string ventilador = " ";
        string aire= " ";




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

            if (Var_codigoAlumno == 0)
            {
                MessageBox.Show("Debe buscar un alumno para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabEstSocioEco.SelectedTab = SaludRecreacion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabEstSocioEco.SelectedTab = InformacionVivienda;
        }

        public void ValidarTrabajo()
        {
            if (Combox_EsSo_TrabajaMadre_forma.SelectedIndex == -1)
            {
                Combox_EsSo_TrabajaMadre_forma.SelectedIndex = 1;
                txt_EsSo_LugarTrabMadre_forma.Text = "no";
            }

            if (Combox_EsSo_TrabajaMadre_forma.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txt_EsSo_LugarTrabMadre_forma.Text)){
                    txt_EsSo_LugarTrabMadre_forma.Text = "Desconocido";
                }
            }

            if (Combox_EsSo_TrabajaMadre_forma.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txt_EsSo_LugarTrabMadre_forma.Text)){
                    txt_EsSo_LugarTrabMadre_forma.Text = "no";
                }
            }




            if (combox_EsSo_TrabajaPadre_forma.SelectedIndex == -1)
            {
                combox_EsSo_TrabajaPadre_forma.SelectedIndex = 1;
                txt_EsSo_LugarTrabPadre_forma.Text = "no";
            }

            if (combox_EsSo_TrabajaPadre_forma.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txt_EsSo_LugarTrabPadre_forma.Text))
                {
                    txt_EsSo_LugarTrabPadre_forma.Text = "Desconocido";
                }
            }

            if (combox_EsSo_TrabajaPadre_forma.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txt_EsSo_LugarTrabPadre_forma.Text))
                {
                    txt_EsSo_LugarTrabPadre_forma.Text = "no";
                }
            }
        }

        public void Fun_ValidarVacios()
        {
            if (string.IsNullOrEmpty(txt_EsSo_GastoMedi_SaludRecre.Text))
            {
                txt_EsSo_GastoMedi_SaludRecre.Text = "0";
            }


            if (string.IsNullOrEmpty(txt_EsSo_HabitantesCasa_InfoFami.Text))
            {
                txt_EsSo_HabitantesCasa_InfoFami.Text = "0";
            }

            if (string.IsNullOrEmpty(txt_EsSo_CuantosHijos_InfoFami.Text))
            {
                txt_EsSo_CuantosHijos_InfoFami.Text = "0";
            }

            if (string.IsNullOrEmpty(txt_EsSo_TotalMiemb_InfoFami.Text))
            {
                txt_EsSo_TotalMiemb_InfoFami.Text = "0";
            }
            if (string.IsNullOrEmpty(txt_EsSo_CuantosFamil_InfoFami.Text))
            {
                txt_EsSo_CuantosFamil_InfoFami.Text = "0";
            }
            if (string.IsNullOrEmpty(txt_EsSo_TotalTraba_InfoFami.Text))
            {
                txt_EsSo_TotalTraba_InfoFami.Text = "0";
            }

            if (string.IsNullOrEmpty(txt_EsSo_GastoMedi_SaludRecre.Text))
            {
                txt_EsSo_GastoMedi_SaludRecre.Text = "0";
            }


            int Val1 = 0;
            int Val2 = 0;
            int Val3 = 0;
            int Val4 = 0;

            var boxa = groupBox7.Controls.OfType<CheckBox>();
            foreach (var box in boxa)
            {

                if(box.Checked == false)
                {
                    Val1++;
                }
            }

            if (Val1 == 6)
            {
                chekbox_EsSo_OtroSalud_SaludRecre.Checked = true;
            }



            var boxb = groupBox8.Controls.OfType<CheckBox>();
            foreach (var box in boxb)
            {
                if (box.Checked == false)
                {
                    Val2++;
                }
            }

            if (Val2 == 5)
            {
                chekbox_EsSo_NingunaEnfer_SaludRecre.Checked = true;
            }



            var box100 = groupBox11.Controls.OfType<CheckBox>();
            foreach (var box in box100)
            {

                if (box.Checked == false)
                {
                    Val3++;
                }
            }

            if (Val3 == 5)
            {
                chekbox_EsSo_Energia_InfoVivien.Checked = true;
            }




            var box101 = groupBox10.Controls.OfType<CheckBox>();
            foreach (var box in box101)
            {

                if (box.Checked == false)
                {
                    Val4++;
                }
            }

            if (Val4 == 11)
            {
                chekbox_EsSo_Tele_InfoVivien.Checked = true;
            }




        }
        private void button4_Click(object sender, EventArgs e)
        {
            C_Alumnos C_Al = new C_Alumnos();
            Var_codigoAlumno = C_datos.CodAlumno;

            if (string.IsNullOrEmpty(txt_EsSo_NombreEst_DatosGe.Text) == true)
            {
                MessageBox.Show("Debe selecionar un alumno", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabEstSocioEco.SelectedTab = DatosGenerales;
                return;
            }



            if ( C_Al.ValidarEstudio(Var_codigoAlumno) ==true)
            {
                MessageBox.Show("Ya existe un estudio de este alumno", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabEstSocioEco.SelectedTab = DatosGenerales;
                Fun_Limpiar();
                return;
            }

            if (string.IsNullOrEmpty(txt_EsSo_Aporbado_SaludRecre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la persona que aprobo este ingreso", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if(string.IsNullOrEmpty(txt_EsSo_lugar_DatosGe.Text) || string.IsNullOrEmpty(txt_EsSo_PersonaEntre_DatosGe.Text))
            {

                MessageBox.Show("Debe llenar todos los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabEstSocioEco.SelectedTab = DatosGenerales;
                txt_EsSo_lugar_DatosGe.Focus();
                return;
            }
            //this.Hide();
            // string strDate = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            // DateTime varFeInicio = Convert.toDatetime(dtpFeInicio.Text);

           

            Fun_ValidarVacios();
            ValidarIngresosVacios();
            Fun_VerificarLugaresVacios();

            if (Fun_ValidarExistenciaOtros() == false)
            {
                MessageBox.Show("Debe llenar todos los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_EsSo_NomEncarg_DatosGe.Focus();
                tabEstSocioEco.SelectedTab = DatosGenerales;
                return;
            }

            ValidarTrabajo();

            if (Fun_ValidarExistenciaMadre() == false)
            {
                MessageBox.Show("Debe llenar todos los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabEstSocioEco.SelectedTab = DatosGenerales;
                txt_EsSo_NomMadre_DatosGe.Focus();
                return;
            }

            if (Fun_ValidarExistenciaPadre() == false)
            {
                MessageBox.Show("Debe llenar todos los datos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabEstSocioEco.SelectedTab = DatosGenerales;
                txt_EsSo_NomPadre_DatosGe.Focus();
                return;
            }

            //Actualizar Alumno

            if (string.IsNullOrEmpty(txt_EsSo_IdentiEst_DatosGe.Text))
            {

            }else
            {
                alum.Fun_ActualizarID(Var_codigoAlumno, txt_EsSo_IdentiEst_DatosGe.Text);
            }

            

            Clases.C_EstudioSocioEc estudioSocio = new Clases.C_EstudioSocioEc();
            estudioSocio.CodEstudioSocio = Var_codigoAlumno;
            estudioSocio.CodAlumno= Var_codigoAlumno;
            estudioSocio.LugarEntrevista = txt_EsSo_lugar_DatosGe.Text.Trim();
            estudioSocio.FechaEntrevista = Convert.ToString(dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day); //Convert.ToDateTime(dateTimePicker1.Text);
            estudioSocio.PersonaEntrevis =  txt_EsSo_PersonaEntre_DatosGe.Text;
            estudioSocio.EntrevistadoPor1 = txt_EsSo_Aporbado_SaludRecre.Text.Trim();


            int resultado = Clases.C_EstudioSocioMetodos.AgregarEstudioSo(estudioSocio);
            if (resultado > 0)
            {
                MessageBox.Show("Estudio SocioEconomico Ingresado Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
            //total_ingresos = (Convert.ToDouble(txt_EsSo_IngreAbue_InfoFami.Text) + Convert.ToDouble(txt_EsSo_IngreMadre_InfoFami.Text) + Convert.ToDouble(txt_EsSo_IngrePadre_InfoFami.Text)
              //  + Convert.ToDouble(txt_EsSo_IngreHijo_InfoFami.Text) + Convert.ToDouble(txt_EsSo_IngrePencion_InfoFami.Text) + Convert.ToDouble(txt_EsSo_IngreOtros_InfoFami.Text));
            
            Clases.C_InformacionFamilia infoFamilia = new Clases.C_InformacionFamilia();
            infoFamilia.CodAlumno1 = Var_codigoAlumno;
            infoFamilia.PersonasHabitan1 = Convert.ToInt32(txt_EsSo_HabitantesCasa_InfoFami.Text.Trim());
            infoFamilia.TieneMasHijos1 = comboBox1.SelectedItem.ToString();
            infoFamilia.HabitanOtrosFamiliares1 = Convert.ToString(combox_EsSo_CuantosFami_InfoFami.Text);
            infoFamilia.MienEnTotal1 = Convert.ToInt32(txt_EsSo_TotalMiemb_InfoFami.Text.Trim());
            infoFamilia.CuantosMiembrosTrabajan1 = Convert.ToInt32(txt_EsSo_TotalMiemb_InfoFami.Text.Trim());
            infoFamilia.IngresoAbuela1 = Convert.ToDouble(txt_EsSo_IngreAbue_InfoFami.Text.Trim());
            infoFamilia.IngresoMadre1 = Convert.ToDouble(txt_EsSo_IngreMadre_InfoFami.Text.Trim());
            infoFamilia.IngresoPadre1 = Convert.ToDouble(txt_EsSo_IngrePadre_InfoFami.Text.Trim());
            infoFamilia.IngresoHijo1 = Convert.ToDouble(txt_EsSo_IngreHijo_InfoFami.Text.Trim());
            infoFamilia.Pension1 = Convert.ToDouble(txt_EsSo_IngrePencion_InfoFami.Text.Trim());
            infoFamilia.OtrosIngresos1= Convert.ToDouble(txt_EsSo_IngreOtros_InfoFami.Text.Trim());
            //infoFamilia.TotalIngresos1 = Convert.ToDouble(total_ingresos);
            infoFamilia.TotalIngresos1 = Convert.ToDouble(txt_EsSo_IngreTotales_InfoFami.Text.Trim());
            infoFamilia.GastosEnergia1 = Convert.ToDouble(txt_EsSo_Energia_InfoFami.Text.Trim());
            infoFamilia.GastoAgua1 = Convert.ToDouble(txt_EsSo_Telefono_InfoFami.Text.Trim());
            infoFamilia.GastoComida1 = Convert.ToDouble(txt_EsSo_Alimentos_InfoFami.Text.Trim());
            infoFamilia.GastoTel1 = Convert.ToDouble(txt_EsSo_Telefono_InfoFami.Text.Trim());
            infoFamilia.GastoSalub1 = Convert.ToDouble(txt_EsSo_Salud_InfoFami.Text.Trim());
            infoFamilia.GastoTransp1= Convert.ToDouble(txt_EsSo_Transp_InfoFami.Text.Trim());
            infoFamilia.GastoEduca1= Convert.ToDouble(txt_EsSo_Educa_InfoFami.Text.Trim());
            infoFamilia.GastoGaso1= Convert.ToDouble(txt_EsSo_Combus_InfoFami.Text.Trim());
            infoFamilia.GastoRpa1= Convert.ToDouble(txt_EsSo_Vestime_InfoFami.Text.Trim());
            infoFamilia.GastoVivienda1= Convert.ToDouble(txt_EsSo_Alquiler_InfoFami.Text.Trim());
            infoFamilia.OtrosGastos1 = Convert.ToDouble(txt_EsSo_Otros_InfoFami.Text.Trim());
            infoFamilia.TotalGastos1 = Convert.ToDouble(txt_EsSo_TotalGastos_InfoFami.Text.Trim());

            int resultado2 = Clases.C_EstudioSocioMetodos.AgregarEInformacionFamilia(infoFamilia);



            try
            {

                Clases.C_HistorialMedico hisMedico = new Clases.C_HistorialMedico();
                hisMedico.CodigoAlum = Var_codigoAlumno;
                hisMedico.LugaresRecibeAtencion1 = Convert.ToString(ihss + " " + hospitalEscu + " " + hospitalSanf + " " + centroSa + " " + clinicaPar + " " + otroSalud + " ");
                hisMedico.EnfermedadesPadeceFamilia1 = Convert.ToString(Diabetes + " " + hiperten + " " + enferRespi + " " + ninguna + " " + otra + " ");
                hisMedico.CuantoGastaMedi1 = Convert.ToDouble(txt_EsSo_GastoMedi_SaludRecre.Text);

                int resultado3 = Clases.C_EstudioSocioMetodos.AgregarAtencionMedica(hisMedico);

                if (resultado3 > 0)
                {
                    //MessageBox.Show("Estudio SocioEconomico Ingresado Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   // MessageBox.Show("No se pudo guardar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }catch(System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            if (string.IsNullOrEmpty(txt_EsSo_NomMadre_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_IdentMadre_DatosGe.Text) == false)
            {


                Clases.C_responsablesMadre madreresp = new Clases.C_responsablesMadre();
                madreresp.CodResp = var_respM;


                madreresp.IdResp = txt_EsSo_IdentMadre_DatosGe.Text;
                madreresp.DomicilioResp = Convert.ToString(txt_EsSo_DomiciMadre_DatosGe);
                madreresp.LugarTrabRes = Convert.ToString(Combox_EsSo_TrabajaMadre_forma.Text);
                madreresp.TelefonoCasaResp = Convert.ToString(txt_EsSo_TelCasaMadre_DatosGe.Text);
                madreresp.TelefonoCasaResp = Convert.ToString(txt_EsSo_TelTrabMadre_DatosGe.Text);

                int resultado6 = Clases.C_EstudioSocioMetodos.AgregarMadre(madreresp);
                cResp.Fun_ActualizarResponsables(madreresp.CodResp, txt_EsSo_CelMadre_DatosGe.Text);

            }

            if (string.IsNullOrEmpty(txt_EsSo_NomPadre_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_IdentPadre_DatosGe.Text) == false)
            {
                //var_respP = padrep.CodResp;

                Clases.C_responsablePadre padreresp = new Clases.C_responsablePadre();
                padreresp.CodResp = var_respP;
                padreresp.IdResp = txt_EsSo_IdentPadre_DatosGe.Text;
                padreresp.DomicilioResp = Convert.ToString(txt_EsSo_DomiciPadre_DatosGe.Text);
                padreresp.LugarTrabRes = Convert.ToString(combox_EsSo_TrabajaPadre_forma.Text);
                padreresp.TelefonoCasaResp = Convert.ToString(txt_EsSo_TelCAsaPadre_DatosGe.Text);
                padreresp.TelefonoCasaResp = Convert.ToString(txt_EsSo_TelTrabPadre_DatosGe.Text);

                int resultado7 = Clases.C_EstudioSocioMetodos.AgregarPadre(padreresp);
                cResp.Fun_ActualizarResponsables(padreresp.CodResp, txt_EsSo_CelPadre_DatosGe.Text);

            }


            if (string.IsNullOrEmpty(txt_EsSo_NomEncarg_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_ParentescoEncar_DatosGe.Text) == false)
            {
                //Ingreso Repsonsable
                cResp.insertResponsableOtros(txt_EsSo_TelEncarg_DatosGe.Text, txt_EsSo_NomEncarg_DatosGe.Text, txt_EsSo_OficioEncarg_DatosGe.Text);
                Cod_Resp = cResp.ObtenerUltimoCodigoResponsable() - 1;
                cResp.insertResponsableAlumno(Var_codigoAlumno, Cod_Resp, 3);
                cResp.Fun_IngresatrOtro(Cod_Resp, txt_EsSo_ParentescoEncar_DatosGe.Text, Convert.ToUInt16(txt_EsSo_EdadEncarg_DatosGe.Text));

            }


           

            Clases.C_LugaresRecreacion recreacion = new Clases.C_LugaresRecreacion();
            recreacion.CodAlumno = Var_codigoAlumno;
            recreacion.Parques= Convert.ToString(combox_EsSo_Parques_SaludRecre.Text + "" + txt_EsSo_Parques_SaludRecre.Text );
            recreacion.CentrosComerciales = Convert.ToString(combox_EsSo_CentrosCom_SaludRecre.Text + "" + txt_EsSo_CentrosCom_SaludRecre.Text);
            recreacion.Museos = Convert.ToString(combox_EsSo_Museos_SaludRecre.Text + "" + txt_EsSo_Museos_SaludRecre.Text);
            recreacion.Cine = Convert.ToString(combox_EsSo_Cine_SaludRecre.Text + "" + txt_EsSo_cine_SaludRecre.Text);
            recreacion.Balnearios = Convert.ToString(combox_EsSo_Balnearios_SaludRecre.Text + "" + txt_EsSo_Balnearios_SaludRecre.Text);
            recreacion.Playa = Convert.ToString(combox_EsSo_Playa_SaludRecre.Text + "" + txt_EsSo_Playa_SaludRecre.Text);
            recreacion.Otros = Convert.ToString(txt_EsSo_OtrosLugares_SaludRecre.Text + "" + combox_EsSo_OtrosLugares_SaludRecre.Text);

            int resultado4 = Clases.C_EstudioSocioMetodos.AgregarLugaresRecreacion(recreacion);



             Clases.C_InformacionVivienda vivienda = new Clases.C_InformacionVivienda();
             vivienda.CodAlumno = Var_codigoAlumno;
             vivienda.Tenencia= Convert.ToString(rb_propia + "" + rb_alquilada + "" +rb_otraTenencia +"" + txt_EsSo_OtraTenencia_InfoVivien.Text);
             vivienda.MaterialConst = Convert.ToString(const_ladrillo+ ""+ cont_bloque+ "" + cont_madera+""+ cont_otro+ "" + txt_EsSo_OtroMaterial_InfoVivien.Text);
             vivienda.MaterialPiso = Convert.ToString(piso_tierra + "" + piso_cemento+""+piso_ladrillo+ ""+piso_ceramica+ ""+piso_madera+ "" + piso_otro +"" + txt_EsSo_OtroMaterPiso_InfoVivien.Text);
             vivienda.ServicioBasicos = Convert.ToString(energia + "" +agua + "" +telefono + "" +alcantarillado + "" +otroServicio + "" + txt_EsSo_OtroServicio_InfoVivien.Text);
             vivienda.DisponeDe = Convert.ToString(television + "" +telefono + "" +refrigerador + "" +Estufa + "" +ducha + "" +lavadora + "" +auto + "" +micro + "" +compu + "" +ventilador + "" +aire );


             int resultado5 = Clases.C_EstudioSocioMetodos.AgregarInfovivienda(vivienda);

            Fun_Limpiar();


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







        }

        public void txt_EsSo_SexoAlum_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btm_EsSo_BuscarAlumno_DatosGe_Click(object sender, EventArgs e)
        {
            Fun_Limpiar();
            FromBusquedaAlumno frmBusqEstSoc = new FromBusquedaAlumno();
            frmBusqEstSoc.ShowDialog();

            try
            {
                if (FromBusquedaAlumno.AlumnoSeleccionado != null)
                {
                    

                    C_datos.CodAlumno = FromBusquedaAlumno.AlumnoSeleccionado.CodAlumno;
                    txt_EsSo_IdentiEst_DatosGe.Text = Convert.ToString(FromBusquedaAlumno.AlumnoSeleccionado.IdAlumno);
                    txt_EsSo_NombreEst_DatosGe.Text = FromBusquedaAlumno.AlumnoSeleccionado.NombreAlumno;
                    txt_EsSo_LugarNaci_DatosGe.Text = FromBusquedaAlumno.AlumnoSeleccionado.LugarNacAlumno;
                    txt_EsSo_FechaNa_DatosGe.Text = Convert.ToString(FromBusquedaAlumno.AlumnoSeleccionado.Fecha_NacAlumno.Date);
                    txt_EsSo_EdadEst_DatosGe.Text = Convert.ToString(FromBusquedaAlumno.AlumnoSeleccionado.EdadAlumno);
                    txt_EsSo_SexoAlum_DatosGe.Text = Convert.ToString(FromBusquedaAlumno.AlumnoSeleccionado.SexoAlumno);
                }
            }
            catch
            {

            }


            try
            {

                if (FromBusquedaAlumno.madreSeleccionado != null)
            {
                madrep.CodAlumno = FromBusquedaAlumno.madreSeleccionado.CodAlumno;
                madrep.CodResp = FromBusquedaAlumno.madreSeleccionado.CodResp;
                    var_respM = madrep.CodResp;
                   
  

                    txt_EsSo_NomMadre_DatosGe.Text = FromBusquedaAlumno.madreSeleccionado.NombResp;
                txt_EsSo_OficioMadre_forma.Text = FromBusquedaAlumno.madreSeleccionado.ProfesionResp1 + FromBusquedaAlumno.madreSeleccionado.OficioREsp;
                txt_EsSo_LugarTrabMadre_forma.Text = FromBusquedaAlumno.madreSeleccionado.LugarTrabRes;
                txt_EsSo_CelMadre_DatosGe.Text = FromBusquedaAlumno.madreSeleccionado.TelefonoCasaResp;
            }
            }
            catch
            {

            }


            try { 
            if (FromBusquedaAlumno.padreSeleccionado != null)
            {
                padrep.CodAlumno = FromBusquedaAlumno.padreSeleccionado.CodAlumno;
                    padrep.CodResp = FromBusquedaAlumno.padreSeleccionado.CodResp;
                    var_respP = padrep.CodResp;

                    
                    txt_EsSo_NomPadre_DatosGe.Text = FromBusquedaAlumno.padreSeleccionado.NombResp;
                txt_EsSo_OficioPadre_forma.Text = FromBusquedaAlumno.padreSeleccionado.ProfesionResp1 + FromBusquedaAlumno.padreSeleccionado.OficioREsp;
                txt_EsSo_LugarTrabPadre_forma.Text = FromBusquedaAlumno.padreSeleccionado.LugarTrabRes;
                txt_EsSo_CelPadre_DatosGe.Text = FromBusquedaAlumno.padreSeleccionado.TelefonoCasaResp;
            }
        }
            catch
            {

            }
          
         
          

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

        private void txt_EsSo_IngreAbue_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoIngresos();
        }

        private void chekbox_EsSo_ihss_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_ihss_SaludRecre.Checked)
            {
                ihss = "IHSS";
            }
            else
            {
                ihss = "";
            }
        }

        private void chekbox_EsSo_HospEscu_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_HospEscu_SaludRecre.Checked)
            {
                hospitalEscu = "Hospital Escuela";
            }
            else
            {
                hospitalEscu = "";
            }
        }

        private void chekbox_EsSo_HospiSanfe_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_HospiSanfe_SaludRecre.Checked)
            {
                hospitalSanf = "Hospital San Felipe";
            }
            else
            {
                hospitalSanf = "";
            }
        }

        private void chekbox_EsSo_CentroSalud_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_CentroSalud_SaludRecre.Checked)
            {
                centroSa = "Centro de Salud";
            }
            else
            {
                centroSa = "";
            }
        }

        private void chekbox_EsSo_ClinicaPart_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_ClinicaPart_SaludRecre.Checked)
            {
                clinicaPar = "Clinica Particular";
            }
            else
            {
                clinicaPar = "";
            }
        }

        private void chekbox_EsSo_OtroSalud_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_OtroSalud_SaludRecre.Checked)
            {
                otroSalud = "Otro";
            }
            else
            {
                otroSalud = "";
            }
        }

        private void chekbox_EsSo_Diabetes_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Diabetes_SaludRecre.Checked)
            {
                Diabetes = "Diabetes";
            }
            else
            {
                Diabetes = "";
            }
        }

        private void chekbox_EsSo_HiperTensi_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_HiperTensi_SaludRecre.Checked)
            {
                hiperten = "Hipertencion";
            }
            else
            {
                hiperten = "";
            }
        }

        private void chekbox_EsSo_InfecRespi_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_InfecRespi_SaludRecre.Checked)
            {
                enferRespi = "Enfermedades Respiratorias";
            }
            else
            {
                enferRespi = "";
            }
        }

        private void chekbox_EsSo_NingunaEnfer_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_NingunaEnfer_SaludRecre.Checked)
            {
                ninguna = "Ninguna";
            }
            else
            {
                ninguna = "";
            }
        }

        private void chekbox_EsSo_OtraEnfer_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_OtroSalud_SaludRecre.Checked)
            {
                otra = "Otra";
            }
            else
            {
                otra = "";
            }
        }

        private void txt_EsSo_GastoMedi_SaludRecre_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtm_EsSo_Propia_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_Propia_InfoVivien.Checked)
            {
                rb_propia = "Casa Propia";
            }
            else
            {
                rb_propia = "";
            }
        }

        private void rbtm_EsSo_Alquilada_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_Alquilada_InfoVivien.Checked)
            {
                rb_alquilada = "Casa alquilada";
            }
            else
            {
                rb_alquilada = "";
            }
        }

        private void rbtm_EsSo_OtroCaracte_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_OtroCaracte_InfoVivien.Checked)
            {
                rb_otraTenencia = "Otro tipo de tenencia";
                txt_EsSo_OtraTenencia_InfoVivien.Enabled = true;
            }
            else
            {
                rb_otraTenencia = "";
                txt_EsSo_OtraTenencia_InfoVivien.Enabled = false;
            }


        }

        private void rbtm_EsSo_Ladrillo_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_Ladrillo_InfoVivien.Checked)
            {
                const_ladrillo = "Construccion de ladrillo";
            }
            else
            {
                const_ladrillo = "";
            }
        }

        private void rbtm_EsSo_Bloque_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_Bloque_InfoVivien.Checked)
            {
                cont_bloque = "construccion de bloque";
            }
            else
            {
                cont_bloque = "";
            }
        }

        private void rbtm_EsSo_Madera_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_MaderaPiso_InfoVivien.Checked)
            {
                cont_madera = "construccion de madera";
            }
            else
            {
                cont_madera = "";
            }
        }

        private void rbtm_EsSo_OtroMaterial_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_OtroMaterial_InfoVivien.Checked)
            {
                cont_otro = "Otro tipo material de construccion, ";
                txt_EsSo_OtroMaterial_InfoVivien.Enabled = true;
            }
            else
            {
                cont_otro = "";
                txt_EsSo_OtroMaterial_InfoVivien.Enabled = false;
            }
        }

        private void rbtm_EsSo_Tierra_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_Tierra_InfoVivien.Checked)
            {
                piso_tierra = "Piso de tierra";
            }
            else
            {
                piso_tierra = "";
            }
        }

        private void rbtm_EsSo_cementoPiso_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_cementoPiso_InfoVivien.Checked)
            {
                piso_cemento = "piso de cemento";
            }
            else
            {
                piso_cemento = "";
            }
        }

        private void rbtm_EsSo_LabrilloPiso_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_Ladrillo_InfoVivien.Checked)
            {
                piso_ladrillo = "Otro tipo piso de ladrillo";
            }
            else
            {
                piso_ladrillo = "";
            }


        }

        private void rbtm_EsSo_CEramica_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_CEramica_InfoVivien.Checked)
            {
                piso_ceramica = "Piso de ceramica";
            }
            else
            {
                cont_otro = "";
            }
        }

        private void rbtm_EsSo_MaderaPiso_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_MaderaPiso_InfoVivien.Checked)
            {
                piso_madera = "Piso de  madera";
            }
            else
            {
                piso_madera = "";
            }
        }

        private void rbtm_EsSo_OtroMaterPiso_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtm_EsSo_OtroMaterPiso_InfoVivien.Checked)
            {
                piso_otro = "Otro tipo material de piso";
                txt_EsSo_OtroMaterPiso_InfoVivien.Enabled = true;
            }
            else
            {
                piso_otro = "";
                txt_EsSo_OtroMaterPiso_InfoVivien.Enabled = false;

            }
        }

        private void chekbox_EsSo_Energia_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Energia_InfoVivien.Checked)
            {
                energia = "Energia Electrica";
            }
            else
            {
                energia = "";
            }
        }

        private void chekbox_EsSo_Agua_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Agua_InfoVivien.Checked)
            {
                agua = "Agua Potable";
            }
            else
            {
                agua = "";
            }
        }

        private void chekbox_EsSo_Telefono_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Telefono_InfoVivien.Checked)
            {
                telefono = "Telefono";
            }
            else
            {
                telefono = "";
            }
        }

        private void chekbox_EsSo_Alcantari_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Alcantari_InfoVivien.Checked)
            {
                alcantarillado = "Alcantarillado";
            }
            else
            {
                alcantarillado = "";
            }
        }

        private void chekbox_EsSo_OtrosServ_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_OtrosServ_InfoVivien.Checked)
            {
                otroServicio = "Otros servicios";
                txt_EsSo_OtroServicio_InfoVivien.Enabled = true;
            }
            else
            {
                otroServicio = "";
                txt_EsSo_OtroServicio_InfoVivien.Enabled = false;

            }
        }

        private void chekbox_EsSo_Tele_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Tele_InfoVivien.Checked)
            {
                television = "Television";
            }
            else
            {
                television = "";
            }
        }

        private void chekbox_EsSo_EquipoSoni_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_EquipoSoni_InfoVivien.Checked)
            {
                equipoSonido = "Equipo de sonido";
            }
            else
            {
                equipoSonido = "";
            }
        }

        private void chekbox_EsSo_Refri_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Refri_InfoVivien.Checked)
            {
                refrigerador = "Refriferador";
            }
            else
            {
                refrigerador = "";
            }
        }

        private void chekbox_EsSo_Estufa_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Estufa_InfoVivien.Checked)
            {
                Estufa = "Estufa";
            }
            else
            {
                Estufa = "";
            }
        }

        private void chekbox_EsSo_Ducha_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Ducha_InfoVivien.Checked)
            {
                ducha = "Calentador (Ducha) ";
            }
            else
            {
                ducha = "";
            }
        }

        private void chekbox_EsSo_Lavadora_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Lavadora_InfoVivien.Checked)
            {
                lavadora = "Lavadora";
            }
            else
            {
                lavadora = "";
            }
        }

        private void chekbox_EsSo_Automovil_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Automovil_InfoVivien.Checked)
            {
                auto = "Automovil";
            }
            else
            {
                auto = "";
            }
        }

        private void chekbox_EsSo_Microondas_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Microondas_InfoVivien.Checked)
            {
                micro = "Microondas";
            }
            else
            {
                micro = "";
            }
        }

        private void chekbox_EsSo_Compu_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Compu_InfoVivien.Checked)
            {
                compu = "Computadora";
            }
            else
            {
                compu = "";
            }
        }

        private void chekbox_EsSo_Ventila_nfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_Ventila_nfoVivien.Checked)
            {
                ventilador = "Ventilador";
            }
            else
            {
                ventilador = "";
            }
        }

        private void chekbox_EsSo_AireAcon_InfoVivien_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_EsSo_AireAcon_InfoVivien.Checked)
            {
                aire = "Aire Acondicionado";
            }
            else
            {
                aire = "";
            }
        }

        private void e(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarNombres_SoloLetras(sender, e);
        }

        private void txt_EsSo_OtroMaterial_InfoVivien_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_EsSo_OtroMaterial_InfoVivien_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarNombres_SoloLetras(sender, e);
        }

        private void txt_EsSo_OtroMaterPiso_InfoVivien_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarNombres_SoloLetras(sender, e);
        }

        private void txt_EsSo_OtroServicio_InfoVivien_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarNombres_SoloLetras(sender, e);
        }

        private void txt_EsSo_Parques_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_Parques_SaludRecre);
        }

        private void txt_EsSo_CentrosCom_SaludRecre_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_EsSo_Museos_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_Museos_SaludRecre);
        }

        private void txt_EsSo_CentrosCom_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_CentrosCom_SaludRecre);
        }

        private void txt_EsSo_cine_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_cine_SaludRecre);
        }

        private void txt_EsSo_Balnearios_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_Balnearios_SaludRecre);
        }

        private void txt_EsSo_Playa_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_Playa_SaludRecre);
        }

        private void txt_EsSo_OtrosLugares_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_OtrosLugares_SaludRecre);
        }

        private void txt_EsSo_Aporbado_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_Aporbado_SaludRecre);
        }

        private void txt_EsSo_MasHijos_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Back) && !Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Enter)
            && e.KeyChar != Convert.ToChar(Keys.Space))
            {

                e.Handled = true;
            }
        }

        private void txt_EsSo_PersonaEntre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_PersonaEntre_DatosGe);
        }

        private void txt_EsSo_lugar_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_lugar_DatosGe);
        }

        private void txt_EsSo_IngreAbue_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_IngreAbue_InfoFami);
        }

        private void txt_EsSo_IngrePadre_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_IngrePadre_InfoFami);
        }

        private void txt_EsSo_IngreMadre_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_IngreMadre_InfoFami);
        }

        private void txt_EsSo_IngreHijo_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_IngreHijo_InfoFami);
        }

        private void txt_EsSo_IngrePencion_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_IngrePencion_InfoFami);
        }

        private void txt_EsSo_IngreOtros_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_IngrePadre_InfoFami);
        }

        private void txt_EsSo_IngreTotales_InfoFami_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_EsSo_HabitantesCasa_InfoFami_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_HabitantesCasa_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_HabitantesCasa_InfoFami);
        }

        private void txt_EsSo_CuantosHijos_InfoFami_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_CuantosHijos_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_CuantosFamil_InfoFami);
        }

        private void txt_EsSo_TotalTraba_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_TotalTraba_InfoFami);
        }

        private void txt_EsSo_GastoMedi_SaludRecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_GastoMedi_SaludRecre);
        }

        private void txt_EsSo_DomiciMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_DomiciMadre_DatosGe);
        }

        private void txt_EsSo_DomiciPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_DomiciPadre_DatosGe);
        }

        private void txt_EsSo_NomEncarg_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_NomEncarg_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_NomEncarg_DatosGe);
        }

        private void txt_EsSo_ParentescoEncar_DatosGe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EsSo_ParentescoEncar_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_ParentescoEncar_DatosGe);
        }

        private void txt_EsSo_OficioEncarg_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_OficioEncarg_DatosGe);
        }

        private void txt_EsSo_TelCasaMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '-') && (!txt_EsSo_CelMadre_DatosGe.Text.Contains("-")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void combox_EsSo_CuantosFami_InfoFami_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_EsSo_CuantosFami_InfoFami.SelectedIndex==1)
            {
                txt_EsSo_CuantosFamil_InfoFami.Enabled = false;
                txt_EsSo_CuantosFamil_InfoFami.Text = "0";
            }else
            {
                txt_EsSo_CuantosFamil_InfoFami.Enabled = true;
                txt_EsSo_CuantosFamil_InfoFami.Text = string.Empty;
            }
        }

        private void combox_EsSo_Parques_SaludRecre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_EsSo_Parques_SaludRecre.SelectedIndex == 1)
            {
                txt_EsSo_Parques_SaludRecre.Enabled = false;
            }
            else
            {
                txt_EsSo_Parques_SaludRecre.Enabled = true;
            }

        }

        private void combox_EsSo_CentrosCom_SaludRecre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_EsSo_CentrosCom_SaludRecre.SelectedIndex == 1)
            {
                txt_EsSo_CentrosCom_SaludRecre.Enabled = false;
            }else
            {
                txt_EsSo_CentrosCom_SaludRecre.Enabled = true;
            }

        }

        private void combox_EsSo_Museos_SaludRecre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_EsSo_Museos_SaludRecre.SelectedIndex == 1)
            {

                txt_EsSo_Museos_SaludRecre.Enabled = false;
            }else
            {
                txt_EsSo_Museos_SaludRecre.Enabled = true;
            }

        }

        private void combox_EsSo_Cine_SaludRecre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_EsSo_Cine_SaludRecre.SelectedIndex == 1)
            {
                txt_EsSo_cine_SaludRecre.Enabled = false;
            }else
            {
                txt_EsSo_cine_SaludRecre.Enabled = true;
            }

        }

        private void combox_EsSo_Balnearios_SaludRecre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_EsSo_Balnearios_SaludRecre.SelectedIndex == 1)
            {
                txt_EsSo_Balnearios_SaludRecre.Enabled = false;
            }else
            {
                txt_EsSo_Balnearios_SaludRecre.Enabled = true;
            }

        }

        private void combox_EsSo_Playa_SaludRecre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_EsSo_Playa_SaludRecre.SelectedIndex == 1)
            {
                txt_EsSo_Playa_SaludRecre.Enabled = false;
            }else
            {
                txt_EsSo_Playa_SaludRecre.Enabled = true;
            }

        }

        private void combox_EsSo_OtrosLugares_SaludRecre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_EsSo_OtrosLugares_SaludRecre.SelectedIndex == 1)
            {
                txt_EsSo_OtrosLugares_SaludRecre.Enabled = false;
            }else
            {
                txt_EsSo_OtrosLugares_SaludRecre.Enabled = true;
            }

        }

        private void txt_EsSo_EdadEncarg_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarID(sender, e);
        }

        private void txt_EsSo_TelEncarg_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarID(sender, e);

        }

        private void txt_EsSo_IdentPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarID(sender, e);
        }

        private void txt_EsSo_IdentMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarID(sender, e);
        }

        private void txt_EsSo_CelMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarID(sender, e);
        }

        private void txt_EsSo_TelTrabMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarID(sender, e);

        }

        private void txt_EsSo_TelCAsaPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarID(sender, e);

        }

        private void txt_EsSo_CelPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarID(sender, e);
        }

        private void txt_EsSo_TelTrabPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarID(sender, e);
        }

        private void txt_EsSo_CuantosFamil_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosReales_NegativosOPositivos(sender, e, txt_EsSo_CuantosFamil_InfoFami);
        }

        private void txt_EsSo_TotalMiemb_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosReales_NegativosOPositivos(sender, e, txt_EsSo_TotalMiemb_InfoFami);
        }

        private void txt_EsSo_Energia_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e , txt_EsSo_Energia_InfoFami);
        }

        private void txt_EsSo_IngreTotales_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_IngreTotales_InfoFami);

        }

        private void txt_EsSo_Agua_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_Agua_InfoFami);
        }

        private void txt_EsSo_Telefono_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_Telefono_InfoFami);

        }

        private void txt_EsSo_Alimentos_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_Alimentos_InfoFami);

        }

        private void txt_EsSo_Transp_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_Transp_InfoFami);
        }

        private void txt_EsSo_Salud_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_Salud_InfoFami);

        }

        private void txt_EsSo_Educa_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_Educa_InfoFami);
        }

        private void txt_EsSo_Combus_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_Combus_InfoFami);
        }

        private void txt_EsSo_Vestime_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_Vestime_InfoFami);
        }

        private void txt_EsSo_Alquiler_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_Alquiler_InfoFami);
        }

        private void txt_EsSo_Otros_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_Otros_InfoFami);
        }

        private void txt_EsSo_TotalGastos_InfoFami_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.NumerosDecimales(sender, e, txt_EsSo_TotalGastos_InfoFami);
        }

        private void FormaEstSocEco_Load(object sender, EventArgs e)
        {
            txt_EsSo_OtraTenencia_InfoVivien.Enabled = false;
txt_EsSo_OtroMaterial_InfoVivien.Enabled = false;
            txt_EsSo_OtroMaterPiso_InfoVivien.Enabled = false;
            txt_EsSo_OtroServicio_InfoVivien.Enabled = false;

            chekbox_EsSo_OtroSalud_SaludRecre.Checked = true;
            chekbox_EsSo_NingunaEnfer_SaludRecre.Checked = true;
            rbtm_EsSo_Propia_InfoVivien.Checked = true;
            rbtm_EsSo_Bloque_InfoVivien.Checked = true;
            rbtm_EsSo_Tierra_InfoVivien.Checked = true;
            chekbox_EsSo_Energia_InfoVivien.Checked = true;
            chekbox_EsSo_Tele_InfoVivien.Checked = true;


            combox_EsSo_Parques_SaludRecre.SelectedIndex = 1;
            combox_EsSo_CentrosCom_SaludRecre.SelectedIndex = 1;
            combox_EsSo_Museos_SaludRecre.SelectedIndex = 1;
            combox_EsSo_Cine_SaludRecre.SelectedIndex = 1;
            combox_EsSo_Balnearios_SaludRecre.SelectedIndex = 1;
            combox_EsSo_Playa_SaludRecre.SelectedIndex = 1;
            combox_EsSo_OtrosLugares_SaludRecre.SelectedIndex = 1;
            combox_EsSo_CuantosFami_InfoFami.SelectedIndex = 1;
            comboBox1.SelectedIndex = 1;
            ValidarClicDerecho();
        }

        public void Fun_Limpiar()
        {
            combox_EsSo_Parques_SaludRecre.SelectedIndex = 1;
            combox_EsSo_CentrosCom_SaludRecre.SelectedIndex = 1;
            combox_EsSo_Museos_SaludRecre.SelectedIndex = 1;
            combox_EsSo_Cine_SaludRecre.SelectedIndex = 1;
            combox_EsSo_Balnearios_SaludRecre.SelectedIndex = 1;
            combox_EsSo_Playa_SaludRecre.SelectedIndex = 1;
            combox_EsSo_OtrosLugares_SaludRecre.SelectedIndex = 1;
            combox_EsSo_CuantosFami_InfoFami.SelectedIndex = 1;
            comboBox1.SelectedIndex = 1;
            Combox_EsSo_TrabajaMadre_forma.SelectedIndex = -1;
            combox_EsSo_TrabajaPadre_forma.SelectedIndex = -1;
                checkBox1.Checked = false;
            txt_EsSo_TotalTraba_InfoFami.Text = string.Empty;
            txt_EsSo_CuantosFamil_InfoFami.Text = string.Empty;
            txt_EsSo_TotalMiemb_InfoFami.Text = string.Empty;
            txt_EsSo_HabitantesCasa_InfoFami.Text = string.Empty;
            txt_EsSo_CuantosHijos_InfoFami.Text = string.Empty;
            txt_EsSo_GastoMedi_SaludRecre.Text = string.Empty;
            txt_EsSo_Aporbado_SaludRecre.Text = string.Empty;
            txt_EsSo_OtraTenencia_InfoVivien.Text = string.Empty;
            txt_EsSo_OtroMaterial_InfoVivien.Text = string.Empty;
            txt_EsSo_OtroMaterPiso_InfoVivien.Text = string.Empty;
            txt_EsSo_OtroServicio_InfoVivien.Text = string.Empty;


            var boxes = groupBox13.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.Text = string.Empty;

            }

            var boxes1 = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                box.Text = string.Empty;

            }

            var boxes5 = groupBox2.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                box.Text = string.Empty;

            }

            var boxes6 = groupBox3.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                box.Text = string.Empty;

            }
            var boxes7 = groupBox6.Controls.OfType<TextBox>();
            foreach (var box in boxes7)
            {
                box.Text = string.Empty;

            }
            var boxes8 = groupBox5.Controls.OfType<TextBox>();
            foreach (var box in boxes8)
            {
                box.Text = string.Empty;

            }
            var boxes9 = groupBox9.Controls.OfType<TextBox>();
            foreach (var box in boxes9)
            {
                box.Text = string.Empty;

            }



            var boxa = groupBox7.Controls.OfType<CheckBox>();
            foreach (var box in boxa)
            {

                box.Checked = false;
            }


            var boxb = groupBox8.Controls.OfType<CheckBox>();
            foreach (var box in boxb)
            {
                box.Checked = false;

            }


            var box100 = groupBox11.Controls.OfType<CheckBox>();
            foreach (var box in box100)
            {
                box.Checked = false;

            }

            var box101 = groupBox10.Controls.OfType<CheckBox>();
            foreach (var box in box101)
            {
                box.Checked = false;

            }

                chekbox_EsSo_Tele_InfoVivien.Checked = true;
            chekbox_EsSo_Energia_InfoVivien.Checked = true;
            chekbox_EsSo_OtroSalud_SaludRecre.Checked = true;
            chekbox_EsSo_Diabetes_SaludRecre.Checked = true;

            rbtm_EsSo_Propia_InfoVivien.Checked = true;
            rbtm_EsSo_Ladrillo_InfoVivien.Checked = true;
            rbtm_EsSo_Tierra_InfoVivien.Checked = true;

        }
        public void ValidarClicDerecho()
        {
            var blankContextMenu = new ContextMenuStrip();

            txt_EsSo_TotalTraba_InfoFami.ContextMenuStrip = blankContextMenu;
            txt_EsSo_CuantosFamil_InfoFami.ContextMenuStrip = blankContextMenu;
            txt_EsSo_TotalMiemb_InfoFami.ContextMenuStrip = blankContextMenu;
            txt_EsSo_HabitantesCasa_InfoFami.ContextMenuStrip = blankContextMenu;
            txt_EsSo_CuantosHijos_InfoFami.ContextMenuStrip = blankContextMenu;
            txt_EsSo_GastoMedi_SaludRecre.ContextMenuStrip = blankContextMenu;
            txt_EsSo_Aporbado_SaludRecre.ContextMenuStrip = blankContextMenu;
            txt_EsSo_OtraTenencia_InfoVivien.ContextMenuStrip = blankContextMenu;
            txt_EsSo_OtroMaterial_InfoVivien.ContextMenuStrip = blankContextMenu;
            txt_EsSo_OtroMaterPiso_InfoVivien.ContextMenuStrip = blankContextMenu;
            txt_EsSo_OtroServicio_InfoVivien.ContextMenuStrip = blankContextMenu;


            var boxes = groupBox13.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes1 = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes5 = groupBox2.Controls.OfType<TextBox>();
            foreach (var box in boxes5)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes6 = groupBox3.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
            var boxes7 = groupBox6.Controls.OfType<TextBox>();
            foreach (var box in boxes7)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
            var boxes8 = groupBox5.Controls.OfType<TextBox>();
            foreach (var box in boxes8)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
            var boxes9 = groupBox9.Controls.OfType<TextBox>();
            foreach (var box in boxes9)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            
                  var boxes19 = groupBox4.Controls.OfType<TextBox>();
            foreach (var box in boxes19)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Fun_ValidarExistenciaMadre()
        {
            bool resp = false;

            if(string.IsNullOrEmpty(txt_EsSo_NomMadre_DatosGe.Text)==true 
                && string.IsNullOrEmpty(txt_EsSo_IdentMadre_DatosGe.Text) == true
                && string.IsNullOrEmpty(txt_EsSo_DomiciMadre_DatosGe.Text) == true
                && string.IsNullOrEmpty(txt_EsSo_OficioMadre_forma.Text) == true
                && string.IsNullOrEmpty(txt_EsSo_TelCasaMadre_DatosGe.Text) == true
                && string.IsNullOrEmpty(txt_EsSo_CelMadre_DatosGe.Text) == true
                && string.IsNullOrEmpty(txt_EsSo_TelTrabMadre_DatosGe.Text) == true)
            {
                resp= true;
            }


            if (string.IsNullOrEmpty(txt_EsSo_NomMadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_IdentMadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_DomiciMadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_OficioMadre_forma.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_TelCasaMadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_CelMadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_TelTrabMadre_DatosGe.Text) == false)
            {
                resp= true;
            }

            return resp;
        }

        public bool Fun_ValidarExistenciaPadre()
        {
            bool resp = false;

            if (string.IsNullOrEmpty(txt_EsSo_NomPadre_DatosGe.Text) == true
            && string.IsNullOrEmpty(txt_EsSo_IdentPadre_DatosGe.Text) == true
            && string.IsNullOrEmpty(txt_EsSo_DomiciPadre_DatosGe.Text) == true
            && string.IsNullOrEmpty(txt_EsSo_OficioPadre_forma.Text) == true
            && string.IsNullOrEmpty(txt_EsSo_TelCAsaPadre_DatosGe.Text) == true
            && string.IsNullOrEmpty(txt_EsSo_CelPadre_DatosGe.Text) == true
            && string.IsNullOrEmpty(txt_EsSo_TelTrabPadre_DatosGe.Text) == true)
            {
                resp = true;
            }


            if (string.IsNullOrEmpty(txt_EsSo_NomPadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_IdentPadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_DomiciPadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_OficioPadre_forma.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_TelCAsaPadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_CelPadre_DatosGe.Text) == false
              && string.IsNullOrEmpty(txt_EsSo_TelTrabPadre_DatosGe.Text) == false)
            {
                resp = true;
            }

          

            return resp;
        }

        public bool Fun_ValidarExistenciaOtros()
        {
            bool resp = false;

            if(string.IsNullOrEmpty(txt_EsSo_NomEncarg_DatosGe.Text)==true && 
                string.IsNullOrEmpty(txt_EsSo_ParentescoEncar_DatosGe.Text) == true && string.IsNullOrEmpty(txt_EsSo_EdadEncarg_DatosGe.Text) == true &&
                string.IsNullOrEmpty(txt_EsSo_TelEncarg_DatosGe.Text) == true && string.IsNullOrEmpty(txt_EsSo_OficioEncarg_DatosGe.Text) == true)
            {
                resp = true;
            }

            if (string.IsNullOrEmpty(txt_EsSo_NomEncarg_DatosGe.Text) == false 
                && string.IsNullOrEmpty(txt_EsSo_ParentescoEncar_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_EdadEncarg_DatosGe.Text) == false &&
                string.IsNullOrEmpty(txt_EsSo_TelEncarg_DatosGe.Text) == false && string.IsNullOrEmpty(txt_EsSo_OficioEncarg_DatosGe.Text) == false)
            {
                resp = true;
            }

           
            return resp;
        }

        public void ValidarIngresosVacios()
        {
            var boxes = groupBox5.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "0";
                }

            }

            var boxes1 = groupBox6.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    box.Text = "0";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex== 1)
            {
                txt_EsSo_CuantosHijos_InfoFami.Enabled = false;
                txt_EsSo_CuantosHijos_InfoFami.Text = "0";
            }else
            {
                txt_EsSo_CuantosHijos_InfoFami.Enabled = true;
                txt_EsSo_CuantosHijos_InfoFami.Text = string.Empty;
            }
        }

        public void Fun_VerificarLugaresVacios()
        {
            if (combox_EsSo_Parques_SaludRecre.SelectedItem.ToString() == "Si"  && string.IsNullOrEmpty( txt_EsSo_Parques_SaludRecre.Text))
            {
                txt_EsSo_Parques_SaludRecre.Text = "Desconocido";
            }


            if (combox_EsSo_CentrosCom_SaludRecre.SelectedItem.ToString() == "Si" && string.IsNullOrEmpty(txt_EsSo_CentrosCom_SaludRecre.Text))
            {
                txt_EsSo_CentrosCom_SaludRecre.Text = "Desconocido";
            }


            if (combox_EsSo_Museos_SaludRecre.SelectedItem.ToString() == "Si" && string.IsNullOrEmpty(txt_EsSo_Museos_SaludRecre.Text))
            {
                txt_EsSo_Museos_SaludRecre.Text = "Desconocido";
            }


            if (combox_EsSo_Cine_SaludRecre.SelectedItem.ToString() == "Si" && string.IsNullOrEmpty(txt_EsSo_cine_SaludRecre.Text))
            {
                txt_EsSo_cine_SaludRecre.Text = "Desconocido";
            }

            if (combox_EsSo_Balnearios_SaludRecre.SelectedItem.ToString() == "Si" && string.IsNullOrEmpty(txt_EsSo_Balnearios_SaludRecre.Text))
            {
                txt_EsSo_Balnearios_SaludRecre.Text = "Desconocido";
            }

            if (combox_EsSo_Playa_SaludRecre.SelectedItem.ToString() == "Si" && string.IsNullOrEmpty(txt_EsSo_Playa_SaludRecre.Text))
            {
                txt_EsSo_Playa_SaludRecre.Text = "Desconocido";
            }

            if (combox_EsSo_OtrosLugares_SaludRecre.SelectedItem.ToString() == "Si" && string.IsNullOrEmpty(txt_EsSo_OtrosLugares_SaludRecre.Text))
            {
                txt_EsSo_OtrosLugares_SaludRecre.Text = "Desconocido";
            }


        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void chekbox_EsSo_Ninguno_SaludRecre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void combox_EsSo_TrabajaPadre_forma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true) {
                combox_EsSo_Parques_SaludRecre.SelectedIndex = 1;
                combox_EsSo_CentrosCom_SaludRecre.SelectedIndex = 1;
                combox_EsSo_Museos_SaludRecre.SelectedIndex = 1;
                combox_EsSo_Cine_SaludRecre.SelectedIndex = 1;
                combox_EsSo_Balnearios_SaludRecre.SelectedIndex = 1;
                combox_EsSo_Playa_SaludRecre.SelectedIndex = 1;
                combox_EsSo_OtrosLugares_SaludRecre.SelectedIndex = 1;

                combox_EsSo_Parques_SaludRecre.Enabled = false;
                combox_EsSo_CentrosCom_SaludRecre.Enabled = false;
                combox_EsSo_Museos_SaludRecre.Enabled = false;
                combox_EsSo_Cine_SaludRecre.Enabled = false;
                combox_EsSo_Balnearios_SaludRecre.Enabled = false;
                combox_EsSo_Playa_SaludRecre.Enabled = false;
                combox_EsSo_OtrosLugares_SaludRecre.Enabled = false;

                txt_EsSo_Parques_SaludRecre.Text = string.Empty;
                txt_EsSo_CentrosCom_SaludRecre.Text = string.Empty;
                txt_EsSo_Museos_SaludRecre.Text = string.Empty;
                txt_EsSo_cine_SaludRecre.Text = string.Empty;
                txt_EsSo_Balnearios_SaludRecre.Text = string.Empty;
                txt_EsSo_Playa_SaludRecre.Text = string.Empty;
                txt_EsSo_OtrosLugares_SaludRecre.Text = string.Empty;
            }
            else
            {
                combox_EsSo_Parques_SaludRecre.Enabled = true;
                combox_EsSo_CentrosCom_SaludRecre.Enabled = true;
                combox_EsSo_Museos_SaludRecre.Enabled = true;
                combox_EsSo_Cine_SaludRecre.Enabled = true;
                combox_EsSo_Balnearios_SaludRecre.Enabled = true;
                combox_EsSo_Playa_SaludRecre.Enabled = true;
                combox_EsSo_OtrosLugares_SaludRecre.Enabled = true;
            }
        }

        private void txt_EsSo_Parques_SaludRecre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_EsSo_NomMadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_NomMadre_DatosGe);
        }

        private void txt_EsSo_OficioMadre_forma_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_OficioMadre_forma);
        }

        private void txt_EsSo_LugarTrabMadre_forma_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_LugarTrabMadre_forma);
        }

        private void txt_EsSo_TelCasaMadre_DatosGe_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_EsSo_OficioPadre_forma_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_OficioPadre_forma);
        }

        private void txt_EsSo_LugarTrabPadre_forma_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_LugarTrabPadre_forma);
        }

        private void txt_EsSo_NomPadre_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValirLetrasYEspaciosMayorEspacio(sender, e, txt_EsSo_NomPadre_DatosGe);
        }


        private void CalculoIngresos()
        {
            double Var_Abuela=0;
            double Var_Padre = 0;
            double Var_Madre = 0;
            double Var_Hijo = 0;
            double Var_Pension = 0;
            double Var_Otros = 0;
            double Var_Total = 0;

            if (string.IsNullOrEmpty(txt_EsSo_IngreAbue_InfoFami.Text))
            {
                Var_Abuela = 0;
            }
            else
            {
                Var_Abuela = Convert.ToDouble(txt_EsSo_IngreAbue_InfoFami.Text);
            }


            if (string.IsNullOrEmpty(txt_EsSo_IngrePadre_InfoFami.Text))
            {
                Var_Padre = 0;
            }
            else
            {
                Var_Padre = Convert.ToDouble(txt_EsSo_IngrePadre_InfoFami.Text);
            }

            if (string.IsNullOrEmpty(txt_EsSo_IngreMadre_InfoFami.Text))
            {
                Var_Madre = 0;
            }
            else
            {
                Var_Madre = Convert.ToDouble(txt_EsSo_IngreMadre_InfoFami.Text);
            }

            if (string.IsNullOrEmpty(txt_EsSo_IngreHijo_InfoFami.Text))
            {
                Var_Hijo = 0;
                
            }
            else
            {
                Var_Hijo = Convert.ToDouble(txt_EsSo_IngreHijo_InfoFami.Text);
            }

            if (string.IsNullOrEmpty(txt_EsSo_IngrePencion_InfoFami.Text))
            {
               Var_Pension = 0;
                
            }
            else
            {
                Var_Pension = Convert.ToDouble(txt_EsSo_IngrePencion_InfoFami.Text);
            }

            if (string.IsNullOrEmpty(txt_EsSo_IngreOtros_InfoFami.Text))
            {
                Var_Otros = 0;
                
            }
            else
            {
                Var_Otros = Convert.ToDouble(txt_EsSo_IngreOtros_InfoFami.Text);
            }

            Var_Total = Var_Otros + Var_Pension + Var_Hijo + Var_Madre + Var_Padre + Var_Abuela;
            txt_EsSo_IngreTotales_InfoFami.Text = Var_Total.ToString();
        }


        private void CalculoGastos()
        {
            double Var_EnergiaElec=0;
            double Var_Agua = 0;
            double Var_Telefono = 0;//--
            double Var_Alimentos = 0;//--
            double Var_Trans = 0;//--
            double Var_Salud = 0;//--
            double Var_Educacion = 0;//--
            double Var_Combustibles = 0;//--
            double Var_Vestimen = 0;//--
            double Var_Vivienda = 0;//--
            double Var_Otros = 0;//--
            double Var_Total = 0;//--

            if (string.IsNullOrEmpty(txt_EsSo_Agua_InfoFami.Text))
            {
                Var_Agua = 0;
            }
            else
            {
                Var_Agua = Convert.ToDouble(txt_EsSo_Agua_InfoFami.Text);
            }

            if (string.IsNullOrEmpty(txt_EsSo_Energia_InfoFami.Text))
            {
                Var_EnergiaElec = 0;
            }
            else
            {
                Var_EnergiaElec = Convert.ToDouble(txt_EsSo_Energia_InfoFami.Text);
            }


            if (string.IsNullOrEmpty(txt_EsSo_Alimentos_InfoFami.Text))
            {
                Var_Alimentos = 0;
            }
            else
            {
                Var_Alimentos = Convert.ToDouble(txt_EsSo_Alimentos_InfoFami.Text);
            }


            if (string.IsNullOrEmpty(txt_EsSo_Telefono_InfoFami.Text))
            {
                Var_Telefono = 0;
            }
            else
            {
                Var_Telefono = Convert.ToDouble(txt_EsSo_Telefono_InfoFami.Text);
            }




            if (string.IsNullOrEmpty(txt_EsSo_Transp_InfoFami.Text))
            {
                Var_Trans = 0;
            }
            else
            {
                Var_Trans = Convert.ToDouble(txt_EsSo_Transp_InfoFami.Text);
            }




            if (string.IsNullOrEmpty(txt_EsSo_Salud_InfoFami.Text))
            {
                Var_Salud = 0;
            }
            else
            {
                Var_Salud = Convert.ToDouble(txt_EsSo_Salud_InfoFami.Text);
            }




            if (string.IsNullOrEmpty(txt_EsSo_Educa_InfoFami.Text))
            {
                Var_Educacion = 0;
            }
            else
            {
                Var_Educacion = Convert.ToDouble(txt_EsSo_Educa_InfoFami.Text);
            }




            if (string.IsNullOrEmpty(txt_EsSo_Combus_InfoFami.Text))
            {
                Var_Combustibles = 0;
            }
            else
            {
                Var_Combustibles = Convert.ToDouble(txt_EsSo_Combus_InfoFami.Text);
            }



            if (string.IsNullOrEmpty(txt_EsSo_Vestime_InfoFami.Text))
            {
                Var_Vestimen = 0;
            }
            else
            {
                Var_Vestimen = Convert.ToDouble(txt_EsSo_Vestime_InfoFami.Text);
            }



            if (string.IsNullOrEmpty(txt_EsSo_Alquiler_InfoFami.Text))
            {
                Var_Vivienda = 0;
            }
            else
            {
                Var_Vivienda = Convert.ToDouble(txt_EsSo_Alquiler_InfoFami.Text);
            }
            //------
            if (string.IsNullOrEmpty(txt_EsSo_Otros_InfoFami.Text))
            {
                Var_Otros = 0;
            }
            else
            {
                Var_Otros = Convert.ToDouble(txt_EsSo_Otros_InfoFami.Text);
            }

            Var_Total = Var_Otros + Var_Vivienda + Var_Vestimen + Var_Combustibles + Var_Educacion +
                Var_Salud + Var_Trans + Var_Alimentos + Var_Telefono + Var_Agua + Var_EnergiaElec;
            txt_EsSo_TotalGastos_InfoFami.Text = Var_Total.ToString();
        }


        private void txt_EsSo_IngrePadre_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoIngresos();
        }

        private void txt_EsSo_IngreMadre_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoIngresos();
        }

        private void txt_EsSo_IngreHijo_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoIngresos();
        }

        private void txt_EsSo_IngrePencion_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoIngresos();
        }

        private void txt_EsSo_IngreOtros_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoIngresos();
        }

        private void txt_EsSo_Energia_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoGastos();
        }

        private void txt_EsSo_Agua_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoGastos();
        }

        private void txt_EsSo_Telefono_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoGastos();
        }

        private void txt_EsSo_Alimentos_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoGastos();
        }

        private void txt_EsSo_Transp_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoGastos();
        }

        private void txt_EsSo_Salud_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoGastos();
        }

        private void txt_EsSo_Educa_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoGastos();
        }

        private void txt_EsSo_Combus_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoGastos();
        }

        private void txt_EsSo_Vestime_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoGastos();
        }

        private void txt_EsSo_Alquiler_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoGastos();
        }

        private void txt_EsSo_Otros_InfoFami_TextChanged(object sender, EventArgs e)
        {
            CalculoGastos();
        }

        private void txt_EsSo_IdentiEst_DatosGe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarID(sender, e);
        }
    }

    }

