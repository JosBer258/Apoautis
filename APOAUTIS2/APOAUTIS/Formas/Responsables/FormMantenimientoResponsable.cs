using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Responsables
{
    public partial class FormMantenimientoResponsable : Form
    {
        Clases.C_Validaciones Val = new Clases.C_Validaciones();
        Clases.C_Responsables cResp = new Clases.C_Responsables();

        public FormMantenimientoResponsable()
        {
            InitializeComponent();
        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMantenimientoResponsable_Load(object sender, EventArgs e)
        {
            cResp.Fill_DGV(DGV_ShowResponsables);
            //Rad_Update.Checked = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cResp.limpiarTxtResp();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cResp.CodResp = Convert.ToInt32(txtCodResp.Text);
            cResp.NomResp = txtNomResp.Text;
            cResp.DomResp = txtDomResp.Text;
            cResp.TelCasResp = txtTelCasResp.Text;
            cResp.TelCelResp = txtTelCelResp.Text;
            cResp.TelTrabResp = txtTelTrabResp.Text;
            cResp.IdResp = Convert.ToInt32(txtIdResp.Text);
            cResp.LugTrab = txtLugResp.Text;
            cResp.ProfResp = txtProfResp.Text;
            cResp.EdadResp = Convert.ToInt32(txtEdadResp.Text);
            cResp.updateResp(); 
            cResp.Fill_DGV(DGV_ShowResponsables);
            cResp.msjUpdateCorrecto();
        }
    }
}
