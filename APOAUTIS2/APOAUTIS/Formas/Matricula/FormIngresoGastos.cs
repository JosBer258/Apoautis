using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Matricula
{
    public partial class FormIngresoGastos : Form
    {
        public FormIngresoGastos()
        {
            InitializeComponent();
        }

        private void Pest1_Bttn_Siguiente_Click(object sender, EventArgs e)
        {
            TabGastos_Ingreso.SelectedTab = Pest_Gastos;
        }

        private void Pest2_Bttn_Anterior_Click(object sender, EventArgs e)
        {
            TabGastos_Ingreso.SelectedTab = Pest_Ingresos;
        }
    }
}
