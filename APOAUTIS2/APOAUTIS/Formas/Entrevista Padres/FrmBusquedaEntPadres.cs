using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Entrevista_Padres
{
    public partial class FrmBusquedaEntPadres : Form
    {
        public FrmBusquedaEntPadres()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bttn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_FiltroAlumno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
