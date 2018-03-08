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
    public partial class FormaEstSocEco : Form
    {
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabEstSocioEco.SelectedTab = SaludRecreacion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabEstSocioEco.SelectedTab = InformacionVivienda;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
