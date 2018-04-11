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
    public partial class FormaEvalPsic : Form
    {
        Clases.C_Validaciones Val = new Clases.C_Validaciones();
        Clases.C_EvalPsico cEval = new Clases.C_EvalPsico();

        public FormaEvalPsic()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bttn_Ok_Click(object sender, EventArgs e)
        {
            if (   txtCodEval.Text == string.Empty
                || txtNombre.Text == string.Empty
                || txtEdad.Text == string.Empty
                || txtResp.Text == string.Empty
                || txtTel.Text == string.Empty
                || txtImpDiag.Text == string.Empty
                || txtObs.Text == string.Empty
                ) { MessageBox.Show("Debe llenar todos los campos", "ERROR"); }
            else {
                if(txtTel.TextLength < 8)
                {
                    MessageBox.Show("El telefono debe tener un minimo de digitos","ERROR");
                }
                else
                {
                    cEval.CodEval = Convert.ToInt32(txtCodEval.Text);
                    cEval.NomEval = txtNombre.Text;
                    cEval.FechNac = DateTime.Parse(dateFechNac.Text).ToString("yyyy-MM-dd");
                    cEval.Edad = float.Parse(txtEdad.Text);
                    cEval.Sexo = cmbSexo.SelectedItem.ToString();
                    cEval.RespEval = txtResp.Text;
                    cEval.TelEval = txtTel.Text;
                    cEval.ImpDiag = txtImpDiag.Text;
                    cEval.ObsEval = txtObs.Text;
                    cEval.FechEval = DateTime.Parse(dateFechEval.Text).ToString("yyyy-MM-dd");

                    cEval.ingresoEval();
                    txtCodEval.Text = cEval.mostrarCodigo();
                    cEval.Fill_DGV_Eval(DGV_Evaluaciones);
                }
            }
        }

        private void FormaEvalPsic_Load(object sender, EventArgs e)
        {
            txtCodEval.Text = cEval.mostrarCodigo();
            cEval.Fill_DGV_Eval(DGV_Evaluaciones);
            cmbSexo.SelectedIndex = 0;
            ContextMenuStrip cm = new ContextMenuStrip();
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radTodas.Checked == true)
            {
                txtBusqNom.Enabled = false;
                txtBusqImpDiag.Enabled = false;
                txtBusqObs.Enabled = false;
                txtBusqID.Enabled = false;
                txtBusqOB.Enabled = false;
                dateBusqFech.Enabled = false;

                txtBusqNom.Text = string.Empty;
                txtBusqImpDiag.Text = string.Empty;
                txtBusqObs.Text = string.Empty;
                txtBusqID.Text = string.Empty;
                txtBusqOB.Text = string.Empty;
                dateBusqFech.Text = string.Empty;

                cEval.Fill_DGV_Eval(DGV_Evaluaciones);
            }
        }

        private void radBusqNom_CheckedChanged(object sender, EventArgs e)
        {
            if(radBusqNom.Checked == true)
            {
                txtBusqNom.Enabled = true;
                txtBusqImpDiag.Enabled = false;
                txtBusqObs.Enabled = false;
                txtBusqID.Enabled = false;
                txtBusqOB.Enabled = false;
                dateBusqFech.Enabled = false;

                txtBusqNom.Text = string.Empty;
                txtBusqImpDiag.Text = string.Empty;
                txtBusqObs.Text = string.Empty;
                txtBusqID.Text = string.Empty;
                txtBusqOB.Text = string.Empty;
                dateBusqFech.Text = string.Empty;
            }
            
        }

        private void radImpDiag_CheckedChanged(object sender, EventArgs e)
        {
            if (radImpDiag.Checked == true)
            {
                txtBusqNom.Enabled = false;
                txtBusqImpDiag.Enabled = true;
                txtBusqObs.Enabled = false;
                txtBusqID.Enabled = false;
                txtBusqOB.Enabled = false;
                dateBusqFech.Enabled = false;

                txtBusqNom.Text = string.Empty;
                txtBusqImpDiag.Text = string.Empty;
                txtBusqObs.Text = string.Empty;
                txtBusqID.Text = string.Empty;
                txtBusqOB.Text = string.Empty;
                dateBusqFech.Text = string.Empty;
            }
        }

        private void radObs_CheckedChanged(object sender, EventArgs e)
        {
            if (radObs.Checked == true)
            {
                txtBusqNom.Enabled = false;
                txtBusqImpDiag.Enabled = false;
                txtBusqObs.Enabled = true;
                txtBusqID.Enabled = false;
                txtBusqOB.Enabled = false;
                dateBusqFech.Enabled = false;

                txtBusqNom.Text = string.Empty;
                txtBusqImpDiag.Text = string.Empty;
                txtBusqObs.Text = string.Empty;
                txtBusqID.Text = string.Empty;
                txtBusqOB.Text = string.Empty;
                dateBusqFech.Text = string.Empty;
            }
        }

        private void radBusqFech_CheckedChanged(object sender, EventArgs e)
        {
            if (radBusqFech.Checked == true)
            {
                txtBusqNom.Enabled = false;
                txtBusqImpDiag.Enabled = false;
                txtBusqObs.Enabled = false;
                txtBusqID.Enabled = false;
                txtBusqOB.Enabled = false;
                dateBusqFech.Enabled = true;

                txtBusqNom.Text = string.Empty;
                txtBusqImpDiag.Text = string.Empty;
                txtBusqObs.Text = string.Empty;
                txtBusqID.Text = string.Empty;
                txtBusqOB.Text = string.Empty;
                dateBusqFech.Text = string.Empty;
            }
        }

        private void radBusqImpObs_CheckedChanged(object sender, EventArgs e)
        {
            if (radBusqImpObs.Checked == true)
            {
                txtBusqNom.Enabled = false;
                txtBusqImpDiag.Enabled = false;
                txtBusqObs.Enabled = false;
                txtBusqID.Enabled = true;
                txtBusqOB.Enabled = true;
                dateBusqFech.Enabled = false;

                txtBusqNom.Text = string.Empty;
                txtBusqImpDiag.Text = string.Empty;
                txtBusqObs.Text = string.Empty;
                txtBusqID.Text = string.Empty;
                txtBusqOB.Text = string.Empty;
                dateBusqFech.Text = string.Empty;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
            cmbSexo.SelectedItem = null;
            txtResp.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtImpDiag.Text = string.Empty;
            txtObs.Text = string.Empty;
            dateFechEval.Value = DateTime.Now;
        }
                
        private void txtBusqNom_TextChanged(object sender, EventArgs e)
        {
            cEval.busquedaNombre(DGV_Evaluaciones, txtBusqNom.Text);
        }

        private void txtBusqImpDiag_TextChanged(object sender, EventArgs e)
        {
            cEval.busquedaImpDiag(DGV_Evaluaciones, txtBusqImpDiag.Text);
        }

        private void txtBusqObs_TextChanged(object sender, EventArgs e)
        {
            cEval.busquedaObs(DGV_Evaluaciones, txtBusqObs.Text);
        }

        private void txtBusqID_TextChanged(object sender, EventArgs e)
        {
            cEval.busquedaIDOB(DGV_Evaluaciones, txtBusqID.Text, txtBusqOB.Text);
        }

        private void txtBusqOB_TextChanged(object sender, EventArgs e)
        {
            cEval.busquedaIDOB(DGV_Evaluaciones, txtBusqID.Text, txtBusqOB.Text);
        }
              
        
        private void txtBusqNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender,e);
        }

        private void txtBusqImpDiag_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void txtBusqObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void txtBusqID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void txtBusqOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void dateBusqFech_ValueChanged(object sender, EventArgs e)
        {
            cEval.busquedaFecha(DGV_Evaluaciones, DateTime.Parse(dateBusqFech.Text).ToString("yyyy-MM-dd"));
        }

        private void txtCodEval_KeyPress(object sender, KeyPressEventArgs e)
        {
            cEval.validarSoloNumeros(sender,e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void txtFechNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Val.NumerosReales_NegativosOPositivos(sender, e, txtFechNac);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cEval.validarSoloNumeros(sender, e);
            Val.NumerosDecimales(sender, e, txtEdad);
            //cEval.validarDecimal(sender, e);
        }

        private void txtResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            cEval.validarSoloNumeros(sender, e);
        }

        private void txtImpDiag_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void txtObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }
    }
}
