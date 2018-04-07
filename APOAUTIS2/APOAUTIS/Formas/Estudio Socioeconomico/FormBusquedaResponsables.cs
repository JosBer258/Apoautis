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
    public partial class FormBusquedaResponsables : Form
    {
        public FormBusquedaResponsables()
        {
            InitializeComponent();
        }

        private void Bttn_Cancelar_responsables_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btm_buscar_responsable_Click(object sender, EventArgs e)
        {
            DGV_responsables.DataSource = Clases.C_EstudioSocioMetodos.Buscar(Txt_FiltroResponsable.Text);

        }
    }
}
