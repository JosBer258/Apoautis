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
        Clases.C_Matricula cEval = new Clases.C_Matricula();
        Clases.C_Alumnos cAlum = new Clases.C_Alumnos();

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
            tabMatricula.SelectedTab = tabPage2;
        }

         

        private void FrmMatricula_Load(object sender, EventArgs e)
        {
            
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
    }
}
