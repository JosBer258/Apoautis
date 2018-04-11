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

            //Extaer ultimos codigos de responsables 
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
            { return false;
            }

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
            cAlum.ingresoAlumnos();
            int ultimo;
            ultimo = cMatri.obtenerUltimo();
            cMatri.Alumnos_CodAlumno1 = ultimo;
            cMatri.ingresoMatricula();
            this.Hide();
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

        private void Pest1_Txt_NomEducador_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pest1_Txt_NomEducador_KeyPress(object sender, KeyPressEventArgs e)
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

            Fun_VerificarVariables();
            if (Convert.ToInt32(comboBox1.SelectedValue)==1)
            {
                Fun_IngresarAlumno();
            }
            else if (Convert.ToInt32(comboBox1.SelectedValue) == 2)
            {
                


            }
            
           
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
            }


            //verificar si el codigo de la matricula ya existe

            //Ingresar la matricula
            try
            {
                if (cMatri.VerificarCod((int)Convert.ToDouble(Pest1_txtNumeroMatricula.Text)) == true)
                {
                    MessageBox.Show("Ya existe una matricula con ese numero, Ingrese un numero de matricula nuevamente", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Pest1_txtNumeroMatricula.Focus();
                    return;
                }

                Var_CodigoAlumno = cAlum.Fun_ExtraerCodigoAlumno();
                if (cAlum.Fun_Ingresar_Alumno() == false)
                {
                    return;
                }

                cTipoAtencion.Fun_IngresarTiposAtencion(Var_CodigoAlumno);
                cMatri.Fun_IngresarTiposAtencion(Var_CodigoAlumno);


                Var_Medicamentos = Pest4_Cmb_UsaMedicamentos.SelectedItem.ToString() + "," + Pest4_Txt_CualesMedic.Text;
                cAlum.Fun_Ingresar_Medicamentos(Var_CodigoAlumno, Var_Medicamentos);

                if (Fun_ValidarExistenciaMadre())
                {
                    cAlum.Var_NombreResp = Pest3_Txt_NombreMadre.Text;
                    cAlum.Var_LugarTrabajo = Pest3_Txt_LugarMadre.Text;
                    cAlum.Var_OficioProfesion = Pest3_Txt_ProfesionMadre.Text;
                    cAlum.Var_OficioProfesion = Pest3_Txt_ProfesionMadre.Text;
                    cAlum.Var_TelTrabajo = Pest3_Txt_TelefonoMadre.Text;

                    cAlum.Fun_IngresarResponsables();
                    cAlum.Var_CodResp = cAlum.Fun_ExtraerUltimoCodigo();
                    cAlum.Fun_Ingresar_Relacion_AlumnoRelac(Var_CodigoAlumno,2);

                }
                if (Fun_ValidarExistenciaPadre()) {
                    cAlum.Var_NombreResp = Pest3_Txt_NombrePadre.Text;
                    cAlum.Var_LugarTrabajo = Pest3_Txt_LugarPadre.Text;
                    cAlum.Var_OficioProfesion = Pest3_Txt_ProfesionPadre.Text;
                    cAlum.Var_OficioProfesion = Pest3_Txt_ProfesionPadre.Text;
                    cAlum.Var_TelTrabajo = Pest3_Txt_TelefonoPadre.Text;

                    cAlum.Fun_IngresarResponsables();
                    cAlum.Var_CodResp = cAlum.Fun_ExtraerUltimoCodigo();
                    cAlum.Fun_Ingresar_Relacion_AlumnoRelac(Var_CodigoAlumno,1);
                }

                Fun_Limpiar();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


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
            cAlum.GenerarTipoMatricula(comboBox1);
            Pest4_Cmb_UsaMedicamentos.SelectedIndex = 1;
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
    }
}
