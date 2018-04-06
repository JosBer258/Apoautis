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
            FromBusquedaAlumno frmBusqEstSoc = new FromBusquedaAlumno();
            frmBusqEstSoc.ShowDialog();
            
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
