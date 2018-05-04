using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using APOAUTIS.Clases;


namespace APOAUTIS.Formas
{
    public partial class seleccionNombreArchivo : Form
    {
        public seleccionNombreArchivo()
        {
            InitializeComponent();
        }

        C_EvalPsico cEval = new C_EvalPsico();
        FormaEvalPsic fEval = new FormaEvalPsic();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            string nombreArchivo = txtNombreArchivo.Text;
            string ruta = FormaEvalPsic.RutaArchivo;

            if(txtNombreArchivo.Text == "")
            {
                MessageBox.Show("Debe escribir un nombre para el archivo","ERROR");
            }
            else
            {
                txtNombreArchivo.Text = "";
                this.Hide();
                cEval.ExportDataTableToPdf(FormaEvalPsic.Dgv, ruta + @"\" + nombreArchivo + ".pdf", "Reporte de Evaluaciones");
                System.Diagnostics.Process.Start(ruta + @"\" + nombreArchivo + ".pdf");
            }
            
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreArchivo.Text = "";
            this.Close();
        }

        private void txtNombreArchivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            cEval.validarNumerosYLetras(sender, e);
        }

        private void seleccionNombreArchivo_Load(object sender, EventArgs e)
        {

        }
    }
}
