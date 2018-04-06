using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Manuales
{
    public partial class FormManual : Form
    {
        public FormManual()
        {
            InitializeComponent();
        }

        private void Bttn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormManual_Load(object sender, EventArgs e)
        {PDF_Local.src = (Application.StartupPath + @"\Manual\Manual_Usuario.pdf");

        }

        private void PDF_Local_OnError(object sender, EventArgs e)
        {

        }
    }
}
