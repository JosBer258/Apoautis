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
            tabMatricula.SelectedTab = Pest_DatosResponsable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabMatricula.SelectedTab = Pest_DatosAdicionales;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Forma Busqueda Matricula
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
