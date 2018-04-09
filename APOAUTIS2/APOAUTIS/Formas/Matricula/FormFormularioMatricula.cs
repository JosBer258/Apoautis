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
                || Pest1_Txt_FechaNacimiento.Text == string.Empty
                || Pest1_Txt_DireccionCompleta.Text == string.Empty
                || Pest1_Txt_TelefonoFijo.Text == string.Empty
                || Pest1_Txt_Celular.Text == string.Empty
                || Pest1_Txt_InstProced.Text == string.Empty
                || Pest1_Txt_AnoIngreso.Text == string.Empty
                )
            { MessageBox.Show("Debe llenar todos los campos", "ERROR"); }
            else
            {
                if (Pest1_Txt_TelefonoFijo.TextLength < 8)
                {
                    MessageBox.Show("El telefono debe tener un minimo de digitos", "ERROR");
                }
                else
                if (Pest1_Txt_Celular.TextLength < 8)
                {
                } else
                {
                    cMatri.Tipo_Matricula1 = Convert.ToInt16(comboBox1.SelectedValue.ToString());
                    cMatri.CodMatricula1 = Convert.ToInt32(Pest1_txtNumeroMatricula.Text);
                    cAlum.NomAlumno11 = Pest1_Txt_NomEducador.Text;
                    cAlum.LugarNaciAlum11 = Pest1_Txt_LugarNacimiento.Text;

                   
                    cAlum.FechaNaciAlum11 = Pest1_Txt_FechaNacimiento.Text;

                    cAlum.DireccionAlum11 = Pest1_Txt_DireccionCompleta.Text;
                    cAlum.TelFijoAlum11 = Pest1_Txt_TelefonoFijo.Text;
                    cAlum.CelAlumno11 = Pest1_Txt_Celular.Text;
                    cMatri.Jornada1 = Convert.ToInt16(Pest1_Cmb_Jornada.SelectedValue.ToString());
                    cMatri.RecibioEvalu1 = Pest1_Cmb_Recibio.SelectedItem.ToString();
                    cAlum.InstProceAlumno11 = Pest1_Txt_InstProced.Text;

                  
                    cMatri.FechaIngreso1 = Pest1_Txt_AnoIngreso.Text; 

                    tabMatricula.SelectedTab = tabPage2;

                }
            }

            
        }

         

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            
            Pest1_txtNumeroMatricula.Text = Convert.ToString( cMatri.GenerarCod());
            Pest1_txtNumeroMatricula.Enabled = false;

            cAlum.GenerarJornada(Pest1_Cmb_Jornada);
            cAlum.GenerarTipoMatricula(comboBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabMatricula.SelectedTab = tabPage3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabMatricula.SelectedTab = tabPage4;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pest1_Txt_DireccionCompleta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
