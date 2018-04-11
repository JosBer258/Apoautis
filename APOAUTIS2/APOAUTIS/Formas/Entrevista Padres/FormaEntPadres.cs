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
    public partial class FormaEntPadres : Form
    {
        public FormaEntPadres()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void FormaEntPadres_Load(object sender, EventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_Amnesis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_Desarrollo_Motriz;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_DesarrolloSocial;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_AcontecimientoMedico;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_VidaDiaria;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_VidaDiaria2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_RelacionesConFamilia;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_RasgosIdentificables;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_RasgosIdentificables2;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_DatosGenerales;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tabEntPadres.SelectedTab = Pest_ComoReacciona;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FormaEstSocEco Est = new FormaEstSocEco();
            Est.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }
    }
}
