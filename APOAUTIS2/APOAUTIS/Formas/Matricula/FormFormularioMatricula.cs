using APOAUTIS.Clases;
using APOAUTIS.Formas.Alumnos;
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


namespace APOAUTIS
{
    public partial class FrmMatricula : Form
    {
        Clases.C_Validaciones Val = new Clases.C_Validaciones();
        Clases.C_Alumnos cAlum = new Clases.C_Alumnos();
        Clases.C_Matricula cMatri = new Clases.C_Matricula();
        Clases.C_Tipos_Atencion cTipoAtencion = new Clases.C_Tipos_Atencion();
        Clases.C_EntrePadres cPadres = new C_EntrePadres();

        C_BusqMatricula Cl_Busq = new C_BusqMatricula();
        C_Tipos_Atencion Cl_Tipo = new C_Tipos_Atencion();

        public FrmMatricula()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (Pest1_txtNumeroMatricula.Text == string.Empty
                || Pest1_Txt_NomEducador.Text == string.Empty
                || Pest1_Txt_LugarNacimiento.Text == string.Empty
                || Pest1_Txt_DireccionCompleta.Text == string.Empty
                || Pest1_Txt_TelefonoFijo.Text == string.Empty
                || Pest1_Txt_Celular.Text == string.Empty
                || comboBox2.SelectedIndex==-1
                || textBox3.Text==string.Empty
                || Pest1_Txt_InstProced.Text == string.Empty
                || Pest1_Txt_AnoIngreso.Text == string.Empty
                || Pest2_Pest_NombreInstituto.Text == string.Empty
                )
            { MessageBox.Show("Debe llenar todos los campos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (Pest1_Txt_TelefonoFijo.TextLength < 8 || Pest1_Txt_Celular.TextLength < 8)
            {
                MessageBox.Show("El telefono debe tener un minimo de digitos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Fun_VerificarVariables();
        }

        private void Fun_EstablecerTiposAtencion()
        {

            cTipoAtencion.Var_Combo_AtencionGrupal = Fun_MandarVariableTipoAtencion(Combo_AtencionGrupal);
            cTipoAtencion.Var_Combo_AtencionPreVocacional = Fun_MandarVariableTipoAtencion(Combo_AtencionPreVocacional);
            cTipoAtencion.Var_Combo_AtencionVocacional = Fun_MandarVariableTipoAtencion(Combo_AtencionVocacional);
            cTipoAtencion.Var_Combo_AtensionFisica = Fun_MandarVariableTipoAtencion(Combo_AtensionFisica);
            cTipoAtencion.Var_Combo_Distancia = Fun_MandarVariableTipoAtencion(Combo_Distancia);
            cTipoAtencion.Var_Combo_Escolar = Fun_MandarVariableTipoAtencion(Combo_Escolar);
            cTipoAtencion.Var_Combo_Individual = Fun_MandarVariableTipoAtencion(Combo_Individual);
            cTipoAtencion.Var_Combo_TerapiaDomicilio = Fun_MandarVariableTipoAtencion(Combo_TerapiaDomicilio);
        }


        private string Fun_MandarVariableTipoAtencion(ComboBox FV_ComboBox)
        {
            string FV_VariableTipo = "No";
            if (FV_ComboBox.SelectedIndex == -1 || FV_ComboBox.SelectedItem.ToString() == "No")
            {
                FV_VariableTipo = "No";
            }
            else
            {
                FV_VariableTipo = "Si";
            }
            return FV_VariableTipo;
        }

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            Fun_Limpiar();
            Fun_DeshabilitarControles();
            cAlum.GenerarJornada(Pest1_Cmb_Jornada);
            cAlum.GenerarTipoMatricula(comboBox1);
            //Extaer ultimos codigos de responsables 
        }

        private void Fun_DeshabilitarControles()
        {
            var blankContextMenu = new ContextMenuStrip();

            var boxes = groupBox2.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes1 = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxes1)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes2 = Pest3_Grupo_DatosPadre.Controls.OfType<TextBox>();
            foreach (var box in boxes2)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes3 = Pest3_Grupo_DatosMadre.Controls.OfType<TextBox>();
            foreach (var box in boxes3)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxes4 = groupBox3.Controls.OfType<TextBox>();
            foreach (var box in boxes4)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

        }


        private bool Fun_ValidarPadre_Vacio()
        {
            if (string.IsNullOrEmpty(Pest3_Txt_NombrePadre.Text)
                && string.IsNullOrEmpty(Pest3_Txt_ProfesionPadre.Text)
                && string.IsNullOrEmpty(Pest3_Txt_LugarPadre.Text)
                && string.IsNullOrEmpty(Pest3_Txt_TelefonoPadre.Text)) {

                return true;
            }

            if (string.IsNullOrEmpty(Pest3_Txt_NombrePadre.Text) == false
                && string.IsNullOrEmpty(Pest3_Txt_ProfesionPadre.Text) == false
                && string.IsNullOrEmpty(Pest3_Txt_LugarPadre.Text) == false
                && string.IsNullOrEmpty(Pest3_Txt_TelefonoPadre.Text) == false)
            {

                return true;
            }

            return false;
        }


        private bool Fun_ValidarMadre_Vacio()
        {
            if (string.IsNullOrEmpty(Pest3_Txt_NombreMadre.Text)
                && string.IsNullOrEmpty(Pest3_Txt_ProfesionMadre.Text)
                && string.IsNullOrEmpty(Pest3_Txt_LugarMadre.Text)
                && string.IsNullOrEmpty(Pest3_Txt_TelefonoMadre.Text))
            {

                return true;
            }

            if (string.IsNullOrEmpty(Pest3_Txt_NombreMadre.Text) == false
                && string.IsNullOrEmpty(Pest3_Txt_ProfesionMadre.Text) == false
                && string.IsNullOrEmpty(Pest3_Txt_LugarMadre.Text) == false
                && string.IsNullOrEmpty(Pest3_Txt_TelefonoMadre.Text) == false)
            {

                return true;
            }

            return false;
        }

        private bool Fun_ValidarVaciosOtros()
        {
            bool Var_Comp = true;

            if (Pest4_Cmb_UsaMedicamentos.SelectedIndex == -1 ||
                (Pest4_Cmb_UsaMedicamentos.SelectedItem.ToString() == "Si" && string.IsNullOrEmpty(Pest4_Txt_CualesMedic.Text)))
            {
                Var_Comp = false;
            }

            if (string.IsNullOrEmpty(Pest4_TxtBox_Observaciones.Text)
                           || string.IsNullOrEmpty(Pest4_Txt_Entrevistador.Text)
                           || string.IsNullOrEmpty(Pest4_Txt_DireccionPorEmergencias.Text)
                           || string.IsNullOrEmpty(Pest4_Txt_TelefonoPorEmergencia.Text))
            {
                Var_Comp = false;
            }


            if (Pest1_txtNumeroMatricula.Text == string.Empty
               || Pest1_Txt_NomEducador.Text == string.Empty
               || Pest1_Txt_LugarNacimiento.Text == string.Empty
               || Pest1_Txt_DireccionCompleta.Text == string.Empty
               || Pest1_Txt_TelefonoFijo.Text == string.Empty
               || Pest1_Txt_Celular.Text == string.Empty
               || comboBox2.SelectedIndex == -1
               || textBox3.Text == string.Empty
               || Pest1_Txt_InstProced.Text == string.Empty
               || Pest1_Txt_AnoIngreso.Text == string.Empty
               || Pest2_Pest_NombreInstituto.Text == string.Empty
               )
            {
                MessageBox.Show("Debe llenar todos los campos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Var_Comp = false;
            }

/*
            if (Pest1_Txt_TelefonoFijo.TextLength < 8 || Pest1_Txt_Celular.TextLength < 8)
            {
                MessageBox.Show("El telefono debe tener un minimo de digitos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Var_Comp = false;
            }*/


            return Var_Comp;
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormaEntPadres Ent = new FormaEntPadres();
            Ent.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(comboBox1.SelectedValue) == 1)
            {
                Bttn_Buscar.Visible = false;
                label41.Visible = false;
                Pest1_Txt_LugarNacimiento.Enabled = true;
                Pest1_Txt_NomEducador.Enabled = true;
                dateTimePicker2.Enabled = true;
                Pest1_Txt_InstProced.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                Pest1_Txt_AnoIngreso.Enabled = true;
                textBox3.Enabled =  true;
                comboBox2.Enabled = true;
            }
            else
            {
                Bttn_Buscar.Visible = true;
                label41.Visible = true;
                Pest1_Txt_LugarNacimiento.Enabled = false;
                Pest1_Txt_NomEducador.Enabled = false;
                dateTimePicker2.Enabled = false;
                Pest1_Txt_InstProced.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                Pest1_Txt_AnoIngreso.Enabled = false;
                textBox3.Enabled = false;
                comboBox2.Enabled = false;
            }
        }

        private void Pest1_Txt_DireccionCompleta_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Pest4_Bttn_Finalizar_Click(object sender, EventArgs e)
        {
            if (Fun_ValidarPadre_Vacio() == false)
            {
                MessageBox.Show("Debe llenar todos los campos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Fun_ValidarMadre_Vacio() == false)
            {
                MessageBox.Show("Debe llenar todos los campos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Fun_ValidarVaciosOtros() == false)
            {
                MessageBox.Show("Debe llenar todos los campos", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(comboBox1.SelectedValue)==1)
            {
                Fun_VerificarVariables();
                Fun_IngresarAlumno();
            }
            else if (Convert.ToInt32(comboBox1.SelectedValue) == 2)
            {

                ReIngreso();

            }
            
           
        }
        public void ReIngreso()
        {
            if (cMatri.VerificarCod((int)Convert.ToDouble(Pest1_txtNumeroMatricula.Text)) == true)
            {
                MessageBox.Show("Ya existe una matricula con ese numero, Ingrese un numero de matricula nuevamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pest1_txtNumeroMatricula.Focus();
                return;
            }

            cMatri.Tipo_Matricula1 = Convert.ToInt16(comboBox1.SelectedValue.ToString());
            cMatri.CodMatricula1 = Convert.ToInt32(Pest1_txtNumeroMatricula.Text);
            cMatri.Jornada1 = Convert.ToInt16(Pest1_Cmb_Jornada.SelectedValue.ToString());
            if (Pest1_Cmb_Recibio.SelectedIndex == -1)
            {
                cMatri.RecibioEvalu1 = "No";
            }
            else
            {
                cMatri.RecibioEvalu1 = Pest1_Cmb_Recibio.SelectedItem.ToString();
            }

            cMatri.FechaIngreso1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            cMatri.AnioIngreso1 = Pest1_Txt_AnoIngreso.Text;
            cMatri.Entrevistador1 = Pest4_Txt_Entrevistador.Text;
            cMatri.Observaciones1 = Pest4_TxtBox_Observaciones.Text;
            cMatri.Alumnos_CodAlumno1 = Cl_Busq.Var_Alum_CodAlumno;

            //try
            //{
                cMatri.ingresoMatricula();
                   string Medicamentos = Pest4_Cmb_UsaMedicamentos.SelectedItem.ToString() + "  " + Pest4_Txt_CualesMedic.Text;
                cMatri.Fun_ActualiHistoria(Medicamentos, cMatri.Alumnos_CodAlumno1);

                if (Fun_ValidarExistenciaMadre())
                {
                    cMatri.Fun_ActualiResp(Pest3_Txt_NombreMadre.Text,
                        Pest3_Txt_ProfesionMadre.Text,
                        Pest3_Txt_LugarMadre.Text,
                        Pest3_Txt_TelefonoMadre.Text,
                        Convert.ToInt32(textBox2.Text));
                }
                if (Fun_ValidarExistenciaPadre())
                {
                    cMatri.Fun_ActualiResp(Pest3_Txt_NombrePadre.Text, 
                        Pest3_Txt_ProfesionPadre.Text,
                        Pest3_Txt_LugarPadre.Text,
                        Pest3_Txt_TelefonoPadre.Text,
                        Convert.ToInt32(textBox1.Text));
                }
            cMatri.Fun_ActualizAtencion(Combo_AtencionGrupal.SelectedItem.ToString(),
                Combo_AtencionPreVocacional.SelectedItem.ToString(),
                Combo_AtencionVocacional.SelectedItem.ToString(),
                Combo_Escolar.SelectedItem.ToString(),
                Combo_Individual.SelectedItem.ToString(),
                Combo_Distancia.SelectedItem.ToString(),
                Combo_TerapiaDomicilio.SelectedItem.ToString(),
                Combo_AtensionFisica.SelectedItem.ToString(),
                cMatri.Alumnos_CodAlumno1);


            cMatri.Fun_ActualizarAlumno(
               Pest1_Txt_TelefonoFijo.Text,
                Pest1_Txt_Celular.Text,
                Pest1_Txt_DireccionCompleta.Text,
                Pest2_Pest_NombreInstituto.Text,
                Pest4_Txt_DireccionPorEmergencias.Text,
                Pest4_Txt_TelefonoPorEmergencia.Text,
                cMatri.Alumnos_CodAlumno1);

           /* }
            catch (Exception)
            {

            }
            */
            Fun_Limpiar();

        }

        private void Fun_VerificarVariables()
        {
            cMatri.Tipo_Matricula1 = Convert.ToInt16(comboBox1.SelectedValue.ToString());
            cMatri.CodMatricula1 = Convert.ToInt32(Pest1_txtNumeroMatricula.Text);
            cMatri.Jornada1 = Convert.ToInt16(Pest1_Cmb_Jornada.SelectedValue.ToString());

            if (Pest1_Cmb_Recibio.SelectedIndex == -1)
            {
                cMatri.RecibioEvalu1 = "No";
            }
            else
            {
                cMatri.RecibioEvalu1 = Pest1_Cmb_Recibio.SelectedItem.ToString();
            }

            cMatri.FechaIngreso1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            cMatri.AnioIngreso1 = Pest1_Txt_AnoIngreso.Text;
            cMatri.Entrevistador1 = Pest4_Txt_Entrevistador.Text;
            cMatri.Observaciones1 = Pest4_TxtBox_Observaciones.Text;


            //*******************************Codigo del Alumno

            //Tabla de Alumnos
            DateTime DateFecha = Fecha_Actual.Value;
            DateTime DateFeNacimiento = dateTimePicker2.Value;

            cAlum.NomAlumno11 = Pest1_Txt_NomEducador.Text;
            cAlum.LugarNaciAlum11 = Pest1_Txt_LugarNacimiento.Text;
            cAlum.FechaNaciAlum11 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            cAlum.EdadAlum11 = DateFecha.Year - DateFeNacimiento.Year;
            cAlum.SexoAlum11 = comboBox2.SelectedItem.ToString();
             cAlum.IdAlum11 = textBox3.Text;
            cAlum.DireccionAlum11 = Pest1_Txt_DireccionCompleta.Text;
            cAlum.TelFijoAlum11 = Pest1_Txt_TelefonoFijo.Text;
            cAlum.CelAlumno11 = Pest1_Txt_Celular.Text;
            cAlum.InstProceAlumno11 = Pest1_Txt_InstProced.Text;
            cAlum.InstDondeEstaIncluido11 = Pest2_Pest_NombreInstituto.Text;
            cAlum.EmergLugar1 = Pest4_Txt_DireccionPorEmergencias.Text;
            cAlum.EmergTelefono1 = Pest4_Txt_TelefonoPorEmergencia.Text;
            tabMatricula.SelectedTab = tabPage2;

            //Tabla de Tipos de Atencion
            Fun_EstablecerTiposAtencion();
        }
        private void Fun_IngresarAlumno()
        {
            int Var_CodigoAlumno;
            int Var_CodMatricula;
            string Var_Medicamentos;


            if (cAlum.Fun_VeriicarNombreAlumno() == true && Convert.ToInt32(comboBox1.SelectedValue) == 1)
            {
                MessageBox.Show("El alumno ya esta matriculado, talvez dese un reingreso", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
                return;
            }


            //verificar si el codigo de la matricula ya existe

            //Ingresar la matricula
            //try
            //{
                if (cMatri.VerificarCod((int)Convert.ToDouble(Pest1_txtNumeroMatricula.Text)) == true)
                {
                    MessageBox.Show("Ya existe una matricula con ese numero, Ingrese un numero de matricula nuevamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Pest1_txtNumeroMatricula.Focus();
                    return;
                }

               
                if (cAlum.Fun_Ingresar_Alumno() == false)
                {
                    return;
                }

                int ultimo;
                ultimo = cMatri.obtenerUltimo();
                cMatri.Alumnos_CodAlumno1 = ultimo;
                cMatri.ingresoMatricula();



                Var_CodigoAlumno = cAlum.Fun_ExtraerCodigoAlumno();
                cTipoAtencion.Fun_IngresarTiposAtencion(ultimo);
               // cMatri.Fun_IngresarTiposAtencion(ultimo);


                Var_Medicamentos = Pest4_Cmb_UsaMedicamentos.SelectedItem.ToString() + "," + Pest4_Txt_CualesMedic.Text;
                cAlum.Fun_Ingresar_Medicamentos(ultimo, Var_Medicamentos);

                if (Fun_ValidarExistenciaMadre())
                {
                    cAlum.Var_NombreResp = Pest3_Txt_NombreMadre.Text;
                    cAlum.Var_LugarTrabajo = Pest3_Txt_LugarMadre.Text;
                    cAlum.Var_OficioProfesion = Pest3_Txt_ProfesionMadre.Text;
                    cAlum.Var_OficioProfesion = Pest3_Txt_ProfesionMadre.Text;
                    cAlum.Var_TelTrabajo = Pest3_Txt_TelefonoMadre.Text;

                    cAlum.Fun_IngresarResponsables();
                    cAlum.Var_CodResp = cAlum.Fun_ExtraerUltimoCodigo();
                    cAlum.Fun_Ingresar_Relacion_AlumnoRelac(ultimo, 2);

                }
                if (Fun_ValidarExistenciaPadre()) {
                    cAlum.Var_NombreResp = Pest3_Txt_NombrePadre.Text;
                    cAlum.Var_LugarTrabajo = Pest3_Txt_LugarPadre.Text;
                    cAlum.Var_OficioProfesion = Pest3_Txt_ProfesionPadre.Text;
                    cAlum.Var_OficioProfesion = Pest3_Txt_ProfesionPadre.Text;
                    cAlum.Var_TelTrabajo = Pest3_Txt_TelefonoPadre.Text;

                    cAlum.Fun_IngresarResponsables();
                    cAlum.Var_CodResp = cAlum.Fun_ExtraerUltimoCodigo();
                    cAlum.Fun_Ingresar_Relacion_AlumnoRelac(ultimo, 1);
                }
                cPadres.Fun_VerificarYear(ultimo);
                Fun_Limpiar();
            //}
            //catch (System.Exception ex)
            //{
               // MessageBox.Show(ex.ToString());
            //}


        }
        private void button1_Click_2(object sender, EventArgs e)
        {

        }
        
        private bool Fun_ValidarExistenciaPadre()
        {
            if (string.IsNullOrEmpty(Pest3_Txt_NombrePadre.Text) == false
               && string.IsNullOrEmpty(Pest3_Txt_ProfesionPadre.Text) == false
               && string.IsNullOrEmpty(Pest3_Txt_LugarPadre.Text) == false
               && string.IsNullOrEmpty(Pest3_Txt_TelefonoPadre.Text) == false)
            {

                return true;
            }


            return false;
        }

        private bool Fun_ValidarExistenciaMadre()
        {
            if (string.IsNullOrEmpty(Pest3_Txt_NombreMadre.Text) == false
                && string.IsNullOrEmpty(Pest3_Txt_ProfesionMadre.Text) == false
                && string.IsNullOrEmpty(Pest3_Txt_LugarMadre.Text) == false
                && string.IsNullOrEmpty(Pest3_Txt_TelefonoMadre.Text) == false)
            {

                return true;
            }

            return false;
        }


        private void Fun_Limpiar()
        {

            Pest3_Txt_NombrePadre.Clear();
            Pest3_Txt_LugarPadre.Clear();
            Pest3_Txt_ProfesionPadre.Clear();
            Pest3_Txt_ProfesionPadre.Clear();
            Pest3_Txt_TelefonoPadre.Clear();
            Pest3_Txt_NombreMadre.Clear();
            Pest3_Txt_LugarMadre.Clear();
            Pest3_Txt_ProfesionMadre.Clear();
            Pest3_Txt_ProfesionMadre.Clear();
            Pest3_Txt_TelefonoMadre.Clear();
            Pest4_Txt_DireccionPorEmergencias.Clear();
            Pest4_Txt_TelefonoPorEmergencia.Clear();
            Pest4_Txt_CualesMedic.Clear();
            Pest4_TxtBox_Observaciones.Clear();
            Pest4_Txt_Entrevistador.Clear();
            Pest2_Pest_NombreInstituto.Clear();
            Pest1_Txt_NomEducador.Clear();
            Pest1_Txt_LugarNacimiento.Clear();
            Pest1_Txt_InstProced.Clear();
            Pest1_Txt_AnoIngreso.Clear();
            Pest1_Txt_TelefonoFijo.Clear();
            Pest1_Txt_Celular.Clear();
            Pest1_Txt_DireccionCompleta.Clear();

            Pest1_Cmb_Recibio.SelectedIndex=-1;
            Combo_AtencionGrupal.SelectedIndex = -1;
            Combo_AtencionPreVocacional.SelectedIndex = -1;
            Combo_AtencionVocacional.SelectedIndex = -1;
            Combo_AtensionFisica.SelectedIndex = -1;
            Combo_Distancia.SelectedIndex = -1;
            Combo_Escolar.SelectedIndex = -1;
            Combo_Individual.SelectedIndex = -1;
            Combo_TerapiaDomicilio.SelectedIndex = -1;
            textBox1.Text=Convert.ToString( cAlum.Fun_ExtraerUltimoCodigo() +1);
            textBox2.Text = Convert.ToString(cAlum.Fun_ExtraerUltimoCodigo() + 2);
            Pest1_txtNumeroMatricula.Text = Convert.ToString(cMatri.GenerarCod());
            cAlum.GenerarJornada(Pest1_Cmb_Jornada);
          //  cAlum.GenerarTipoMatricula(comboBox1);
            Pest4_Cmb_UsaMedicamentos.SelectedIndex = 1;
            comboBox2.SelectedIndex = -1;
            textBox3.Clear();
        }

        private void Pest4_Cmb_UsaMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pest4_Cmb_UsaMedicamentos.SelectedItem.ToString() == "No")
            {
                Pest4_Txt_CualesMedic.Enabled = false;
            }else
            {
                Pest4_Txt_CualesMedic.Enabled = true;
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void Bttn_Buscar_Click(object sender, EventArgs e)
        {
            Form_BusqAlumMat Busq = new Form_BusqAlumMat();
            AddOwnedForm(Busq);
            Busq.ShowDialog();
            
        }

        public void Fun_ExtraerDatos(int cod, string name)
        {
            Fun_Limpiar();


            Cl_Busq.Var_Alum_CodAlumno = (int)Convert.ToDouble(cod);
            Pest1_Txt_NomEducador.Text = name;
            Cl_Busq.Fun_ExtraerDatos_Mat_Alumno();

            Cl_Busq.Fun_ExtraerDatos_Alum();
            Pest1_Txt_LugarNacimiento.Text = Cl_Busq.Var_DG_TipoMatricula;
            Pest1_Txt_LugarNacimiento.Text = Cl_Busq.Var_Alum_lugarnacimiento;
            dateTimePicker2.Value = Convert.ToDateTime(Cl_Busq.Var_Alum_fechanacimiento);
            Pest1_Txt_DireccionCompleta.Text = Cl_Busq.Var_Alum_direccioncompleta;
            Pest1_Txt_Celular.Text = Cl_Busq.Var_Alum_celular;
            Pest1_Txt_InstProced.Text = Cl_Busq.Var_Alum_instprocedencia;
            Pest1_Txt_AnoIngreso.Text = Cl_Busq.Var_DG_annioingreso;
   
            Pest1_Txt_TelefonoFijo.Text = Cl_Busq.Var_Alum_telefonofijo;
            
            Pest2_Pest_NombreInstituto.Text = Cl_Busq.Var_Alum_IntitutoIncl;
            Pest4_Txt_DireccionPorEmergencias.Text = Cl_Busq.Var_Alum_direcionemergencia;
            Pest4_Txt_TelefonoPorEmergencia.Text = Cl_Busq.Var_Alum_telefonoemergencia;

            textBox3.Text = Cl_Busq.Var_id;
            comboBox2.SelectedItem = Cl_Busq.Var_genero;

            Pest1_Txt_AnoIngreso.Text = Convert.ToString(Cl_Busq.Fun_MostrarAñoIngreso());

            Cl_Tipo.Fun_BuscarTipos(Cl_Busq.Var_Alum_CodAlumno);            
            Fun_Comb(Combo_AtensionFisica, Cl_Tipo.Var_Combo_AtensionFisica);
            Fun_Comb(Combo_AtencionGrupal, Cl_Tipo.Var_Combo_AtencionGrupal);
            Fun_Comb(Combo_AtencionPreVocacional, Cl_Tipo.Var_Combo_AtencionPreVocacional);
            Fun_Comb(Combo_TerapiaDomicilio, Cl_Tipo.Var_Combo_TerapiaDomicilio);
            Fun_Comb(Combo_AtencionVocacional, Cl_Tipo.Var_Combo_AtencionVocacional);
            Fun_Comb(Combo_Distancia, Cl_Tipo.Var_Combo_Distancia);
            Fun_Comb(Combo_Escolar, Cl_Tipo.Var_Combo_Escolar);
            Fun_Comb(Combo_Individual, Cl_Tipo.Var_Combo_Individual);

            if (Cl_Busq.Fun_ExtraerResponsables(Cl_Busq.Var_Alum_CodAlumno, 1))
            {
                textBox1.Text = Cl_Busq.Var_cod;
                Pest3_Txt_NombrePadre.Text = Cl_Busq.Var_nombre;
                Pest3_Txt_ProfesionPadre.Text = Cl_Busq.Var_profesion;
                Pest3_Txt_LugarPadre.Text = Cl_Busq.Var_lugar;
                Pest3_Txt_TelefonoPadre.Text = Cl_Busq.Var_telefono;
            }

            if (Cl_Busq.Fun_ExtraerResponsables(Cl_Busq.Var_Alum_CodAlumno, 2))
            {
                textBox2.Text = Cl_Busq.Var_cod;
                Pest3_Txt_NombreMadre.Text = Cl_Busq.Var_nombre;
                Pest3_Txt_ProfesionMadre.Text = Cl_Busq.Var_profesion;
                Pest3_Txt_LugarMadre.Text = Cl_Busq.Var_lugar;
                Pest3_Txt_TelefonoMadre.Text = Cl_Busq.Var_telefono;
            }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Fun_Limpiar();
        }

        private void Pest1_txtNumeroMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest1_Txt_NomEducador_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest1_Txt_LugarNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest1_Txt_AnoIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest1_Txt_InstProced_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender,e);
        }

        private void Pest1_Txt_TelefonoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest1_Txt_Celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest1_Txt_DireccionCompleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, Pest1_Txt_DireccionCompleta);
        }

        private void Pest2_Pest_NombreInstituto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Pest2_Pest_NombreInstituto);
        }

        private void Pest4_Txt_Entrevistador_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest4_TxtBox_Observaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspaciosMayorEspacio(sender, e, Pest4_TxtBox_Observaciones);
        }

        private void Pest4_Txt_CualesMedic_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspaciosMayorEspacio(sender, e, Pest4_Txt_CualesMedic);
        }

        private void Pest4_Txt_TelefonoPorEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest4_Txt_DireccionPorEmergencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, Pest4_Txt_DireccionPorEmergencias);
        }

        private void Pest3_Txt_LugarPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest3_Txt_TelefonoPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest3_Txt_LugarMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest3_Txt_TelefonoMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }

        private void Pest3_Txt_NombreMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest3_Txt_ProfesionMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest3_Txt_ProfesionPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest3_Txt_NombrePadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        public void Clean()
        {

        }
    }
}
