using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Estudio_Socioeconomico
{
    public partial class FromBusquedaAlumno : Form
    {
        public FromBusquedaAlumno()
        {
            InitializeComponent();
        }

        private void Bttn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
