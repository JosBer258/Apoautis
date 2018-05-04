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
        public bool Var_Habilitar;
        C_Validaciones Cl_Val = new C_Validaciones();
        public int Cod_Madre=0, Cod_Pad=0, Cod_Alumno=0;
        Clases.C_Alumnos cAlum = new Clases.C_Alumnos();
        Clases.C_Matricula cMatri = new Clases.C_Matricula();

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

            Cod_Alumno = (int)Convert.ToDouble(FV_CodAlum);


            Pest1_Txt_LugarNacimiento.Text = Cl_Busq.Var_DG_TipoMatricula;
            textBox1.Text = Cl_Busq.Var_Alum_lugarnacimiento;
            Pest1_Txt_FechaNacimiento.Text = Cl_Busq.Var_Alum_fechanacimiento;
            Pest1_Txt_DireccionCompleta.Text = Cl_Busq.Var_Alum_direccioncompleta;
            Pest1_Txt_Celular.Text = Cl_Busq.Var_Alum_celular;
            Pest1_Txt_Instituto.Text = Cl_Busq.Var_Alum_instprocedencia;
            Pest1_Txt_AnoIngreso.Text = Cl_Busq.Var_DG_annioingreso;
            Pest1_Txt_RecibioEvaluacion.Text = Cl_Busq.Var_DG_recibioevaluacion;
            Pest1_Txt_TelefonoFijo.Text = Cl_Busq.Var_Alum_telefonofijo;
            
            Pest2_Pest_NombreInstituto.Text = Cl_Busq.Var_Alum_IntitutoIncl;
            Pest4_Txt_DireccionPorEmergencias.Text = Cl_Busq.Var_Alum_direcionemergencia;
            Pest4_Txt_TelefonoPorEmergencia.Text = Cl_Busq.Var_Alum_telefonoemergencia;
            Pest4_TxtBox_Observaciones.Text = Cl_Busq.Var_DG_Observaciones;
            Pest4_Txt_Fecha.Text = Cl_Busq.Var_DG_Fecha;
            Pest4_Txt_Entrevistador.Text = Cl_Busq.Var_DG_Entrevistador;

            comboBox1.SelectedValue = Cl_Busq.Var_DG_Jornada;
            //comboBox1.SelectedValue = Cl_Busq.Fun_Conseguir_jorm();


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
                Cod_Pad = (int)Convert.ToDouble(Cl_Busq.Var_cod);
                Pest3_Txt_NombrePadre.Text= Cl_Busq.Var_nombre;
                Pest3_Txt_ProfesionPadre.Text = Cl_Busq.Var_profesion;
                Pest3_Txt_LugarPadre.Text = Cl_Busq.Var_lugar;
                Pest3_Txt_TelefonoPadre.Text = Cl_Busq.Var_telefono;
            }

            if (Cl_Busq.Fun_ExtraerResponsables(Cl_Busq.Var_Alum_CodAlumno, 2))
            {
                Cod_Madre = (int) Convert.ToDouble(Cl_Busq.Var_cod);
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
            comboBox1.SelectedIndex = 0;
            Pest2_Pest_NombreInstituto.Text = string.Empty;
            Pest4_Txt_DireccionPorEmergencias.Text = string.Empty;
            Pest4_Txt_TelefonoPorEmergencia.Text = string.Empty;
            Pest4_TxtBox_Observaciones.Text = string.Empty;
            Pest4_Txt_Fecha.Text = string.Empty;
            Pest4_Txt_Entrevistador.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
            Pest1_Txt_LugarNacimiento.Text = string.Empty;
            Cod_Madre = 0;
            Cod_Pad = 0;
            Cod_Alumno = 0;
            Pest1_Txt_NombreEstudiante.Text = string.Empty;
            Pest4_Txt_UsaMedicamentos.Text = string.Empty;
            Pest_txtNumeroMatricula.Text = string.Empty;

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
        
        public void Habilitar()
        {
            
            Pest1_Txt_NombreEstudiante.ReadOnly = false;
            textBox1.ReadOnly = false;
            Pest1_Txt_Instituto.ReadOnly = false;
            Pest1_Txt_AnoIngreso.ReadOnly = false;



            Pest1_Txt_DireccionCompleta.ReadOnly = false;
            Pest1_Txt_Celular.ReadOnly = false;
            Pest1_Txt_TelefonoFijo.ReadOnly = false;
            comboBox_atencion_grupal.Enabled = true;
            comboBox_atencion_vocacional.Enabled = true;
            comboBox_atencion_prevocacional.Enabled = true;
            comboBox_atension_escolar.Enabled = true;
            comboBox_atension_individual.Enabled = true;
            comboBox_atension_distancia.Enabled = true;
            comboBox_atencion_terapia_domicilio.Enabled = true;
            comboBox_atencion_fisica.Enabled = true;
            Pest2_Pest_NombreInstituto.ReadOnly = false;
            Pest4_Txt_Entrevistador.ReadOnly = false;
            Pest4_TxtBox_Observaciones.ReadOnly = false;
            Pest4_Txt_UsaMedicamentos.ReadOnly = false;
            Pest4_Txt_TelefonoPorEmergencia.ReadOnly = false;
            Pest4_Txt_DireccionPorEmergencias.ReadOnly = false;

            Pest3_Txt_NombrePadre.ReadOnly = false;
            Pest3_Txt_ProfesionPadre.ReadOnly = false;
            Pest3_Txt_LugarPadre.ReadOnly = false;
            Pest3_Txt_TelefonoPadre.ReadOnly = false;

            Pest3_Txt_NombreMadre.ReadOnly = false;
            Pest3_Txt_ProfesionMadre.ReadOnly = false;
            Pest3_Txt_LugarMadre.ReadOnly = false;
            Pest3_Txt_TelefonoMadre.ReadOnly = false;
        }

      

        public void Clic_Derecho()
        {
            var blankContextMenu = new ContextMenuStrip();

            var boxes = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxes1 = groupBox2.Controls.OfType<TextBox>();
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
        private void VistaMatricula_Load(object sender, EventArgs e)
        {
            cAlum.GenerarJornada(comboBox1);
            Clic_Derecho();
            if (Var_Habilitar == true)
            {
                Habilitar();
            }
            else
            {
                button1.Visible = false;
                label39.Visible = false;
            }


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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //
            if (Fun_VerificarPadre() == true)
            {
                MessageBox.Show("Debe Llenar todos los campos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Fun_VerificarMadre() == true)
            {
                MessageBox.Show("Debe Llenar todos los campos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Fun_VerificaarVacios() == true)
            {
                MessageBox.Show("Debe Llenar todos los campos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Actualizar();
        }


        public void Actualizar()
        {

        

    
            cMatri.CodMatricula1 = Convert.ToInt32(Pest_txtNumeroMatricula.Text);
            cMatri.Alumnos_CodAlumno1 = Cod_Alumno;
            
            string Medicamentos =  Pest4_Txt_UsaMedicamentos.Text;
            cMatri.Fun_ActualiHistoria(Medicamentos, cMatri.Alumnos_CodAlumno1);

            if (Cod_Madre != 0)
            {
                cMatri.Fun_ActualiResp(Pest3_Txt_NombreMadre.Text,
                    Pest3_Txt_ProfesionMadre.Text,
                    Pest3_Txt_LugarMadre.Text,
                    Pest3_Txt_TelefonoMadre.Text,
                    Convert.ToInt32(Cod_Madre));
            }


            if (Cod_Pad !=0)
            {
                cMatri.Fun_ActualiResp(Pest3_Txt_NombrePadre.Text,
                    Pest3_Txt_ProfesionPadre.Text,
                    Pest3_Txt_LugarPadre.Text,
                    Pest3_Txt_TelefonoPadre.Text,
                    Convert.ToInt32(Cod_Pad));
            }


            cMatri.Fun_ActualizAtencion(comboBox_atencion_grupal.SelectedItem.ToString(),
                comboBox_atencion_prevocacional.SelectedItem.ToString(),
                comboBox_atencion_vocacional.SelectedItem.ToString(),
                comboBox_atension_escolar.SelectedItem.ToString(),
                comboBox_atension_individual.SelectedItem.ToString(),
                comboBox_atension_distancia.SelectedItem.ToString(),
                comboBox_atencion_terapia_domicilio.SelectedItem.ToString(),
                comboBox_atencion_fisica.SelectedItem.ToString(),
                Cod_Alumno);


            cMatri.Fun_ActualizarAlumno(
               Pest1_Txt_TelefonoFijo.Text,
                Pest1_Txt_Celular.Text,
                Pest1_Txt_DireccionCompleta.Text,
                Pest2_Pest_NombreInstituto.Text,
                Pest4_Txt_DireccionPorEmergencias.Text,
                Pest4_Txt_TelefonoPorEmergencia.Text,
                Cod_Alumno);

            cMatri.Fun_ActualizarMatricula(
                (int)Convert.ToDouble(comboBox1.SelectedValue),
                (int)Convert.ToDouble(Pest1_Txt_AnoIngreso.Text),
                Pest4_TxtBox_Observaciones.Text,
                Pest4_Txt_Entrevistador.Text,
                (int)Convert.ToDouble(Pest_txtNumeroMatricula.Text));
            //atri.Fun_ActualizarMatricula(int Cod_Jor, int Annio, string Observ, string Entre, int Cod_M)
            //nombre, lugar de nacimiento 
            //cMatri.Fun_ActualizarAl(string Name, string Direc, int Cod);
            cMatri.Fun_ActualizarAl(Pest1_Txt_NombreEstudiante.Text, textBox1.Text, Pest1_Txt_Instituto.Text, Cod_Alumno);

            MessageBox.Show("El procedimiento se ha ejecutado exitosamente", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Fun_Limpiar();

        }



        private bool Fun_VerificaarVacios()
        {
            bool resp = false;



            var boxes6 = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxes6)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    resp = true;
                }

            }


            var boxes = groupBox2.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    resp = true;
                }

            }


            var boxesx = groupBox3.Controls.OfType<TextBox>();
            foreach (var box in boxesx)
            {
                if (string.IsNullOrEmpty(box.Text))
                {
                    resp = true;
                }

            }



            return resp;
        }

        private bool Fun_VerificarPadre()
        {
            bool resp = false;

            
            if (Cod_Pad != 0)
            {

                if (string.IsNullOrEmpty(Pest3_Txt_NombrePadre.Text) || string.IsNullOrEmpty(Pest3_Txt_ProfesionPadre.Text) 
                    || string.IsNullOrEmpty(Pest3_Txt_LugarPadre.Text) || string.IsNullOrEmpty(Pest3_Txt_TelefonoPadre.Text))
                {
                    resp = true;
                }


            }
            else
                if (Cod_Pad == 0)
                 {
                      resp = false;
                 }


            return resp;
        }

        private bool Fun_VerificarMadre()
        {
            bool resp = false;

            if (Cod_Madre != 0)
            {

                if (string.IsNullOrEmpty(Pest3_Txt_NombreMadre.Text) || string.IsNullOrEmpty(Pest3_Txt_ProfesionMadre.Text) 
                    || string.IsNullOrEmpty(Pest3_Txt_LugarMadre.Text) || string.IsNullOrEmpty(Pest3_Txt_TelefonoMadre.Text))
                {
                    resp = true;
                }


            }else
                if (Cod_Madre == 0)
            {
                resp = false;
            }

            return resp;
        }

        private void Pest4_TxtBox_Observaciones_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Pest4_Txt_Entrevistador_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Pest4_Txt_UsaMedicamentos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Pest4_Txt_TelefonoPorEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Pest4_Txt_DireccionPorEmergencias_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            //******************************************************
        }

        private void Pest1_Txt_NombreEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //lugar nacimiento

        }

        private void Pest1_Txt_Instituto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValirLetrasYEspacios_Direccion(sender, e, Pest1_Txt_Instituto);
        }

        private void Pest1_Txt_AnoIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarID(sender, e);
        }

        private void Pest1_Txt_DireccionCompleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValirLetrasYEspacios_Direccion(sender, e, Pest1_Txt_DireccionCompleta);
        }

        private void Pest1_Txt_Celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarID(sender, e);
        }

        private void Pest1_Txt_TelefonoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarID(sender, e);
        }

        private void Pest2_Pest_NombreInstituto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValirLetrasYEspacios_Direccion(sender, e, Pest2_Pest_NombreInstituto);
        }

        private void Pest3_Txt_NombrePadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Pest3_Txt_ProfesionPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValirLetrasYEspacios_Direccion(sender, e, Pest3_Txt_ProfesionPadre);
        }

        private void Pest3_Txt_LugarPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValirLetrasYEspacios_Direccion(sender, e, Pest3_Txt_LugarPadre);
        }

        private void Pest3_Txt_TelefonoPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarID(sender,e);
        }

        private void Pest3_Txt_TelefonoMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarID(sender, e);
        }

        private void Pest3_Txt_LugarMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValirLetrasYEspacios_Direccion(sender, e, Pest3_Txt_LugarMadre);
        }

        private void Pest3_Txt_ProfesionMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValirLetrasYEspacios_Direccion(sender, e, Pest3_Txt_ProfesionMadre);
        }

        private void Pest3_Txt_NombreMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.ValidarNombres_SoloLetras(sender,e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //******************************************************
        }
    }
}
