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
            cResp.Fill_DGV_Resp(DGV_ShowResponsables);
            cmbTrabResp.SelectedIndex = 0;
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarTxtBox();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            validacionVacios();            
        }

        private void txtBusqResp_TextChanged(object sender, EventArgs e)
        {
           cResp.DGV_Busq(DGV_ShowResponsables, txtBusqResp.Text);
               
        }

        private void DGV_ShowResponsables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DGV_ShowResponsables.Rows[e.RowIndex];
            
            txtCodResp.Text = row.Cells["Codigo de Responsable"].Value.ToString();
            txtNomResp.Text = row.Cells["Nombre Completo"].Value.ToString();
            txtDomResp.Text = row.Cells["Domicilio"].Value.ToString();
            txtIdResp.Text = row.Cells["Numero de Identidad"].Value.ToString();
            txtTelCasResp.Text = row.Cells["Telefono de Casa"].Value.ToString();
            txtTelCelResp.Text = row.Cells["Telefono Celular"].Value.ToString();
            txtTelTrabResp.Text = row.Cells["Telefono de Trabajo"].Value.ToString();
            string tmp = row.Cells["Trabajo"].Value.ToString();
            txtCorrResp.Text = row.Cells["Correo"].Value.ToString();
            txtProfResp.Text = row.Cells["Profesion"].Value.ToString();
            cResp.Fill_DGV_Alum(DGV_ShowAlumnosResp, row.Cells["Codigo de Responsable"].Value.ToString());

            
            if (tmp.ToUpperInvariant().Contains("SI, ") == true) { cmbTrabResp.SelectedIndex = 0; } else { cmbTrabResp.SelectedIndex = 1; }
            string tmp2 = tmp.Replace("Si,", String.Empty);
            tmp2 = tmp.Replace("No,", String.Empty);
            txtLugResp.Text = tmp2.Trim();
            tmp2 = txtLugResp.Text.Replace("Si,", String.Empty);
            txtLugResp.Text = tmp2.Trim();
            MessageBox.Show("Datos Cargados","");
            
            

        }        

        private void txtBusqResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender,e);
        }

        private void txtNomResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCorrResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarCorreoIngreso(sender,e,txtCorrResp);
        }

        private void txtIdResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDomResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtDomResp);
        }

        private void txtProfResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void txtLugResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios_Direccion(sender, e, txtLugResp);
        }

        private void txtTelCasResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            cResp.validarSoloNumeros(sender,e);
        }
        
        private void txtTelCelResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            cResp.validarSoloNumeros(sender, e);
        }

        private void txtTelTrabResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            cResp.validarSoloNumeros(sender, e);
        }

        private void cmbTrabResp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrabResp.SelectedItem.ToString().Equals("No"))
            {
                txtLugResp.Text = string.Empty;
                txtLugResp.Enabled = false;
                txtTelTrabResp.Text = string.Empty;
                txtTelTrabResp.Enabled = false;
            }
            else
            {
                txtLugResp.Enabled = true;
                txtTelTrabResp.Enabled = true;
            }
        }




        /// <summary>
        /// ///////////////////
        /// </summary>
        /// 

        public void limpiarTxtBox()
        {
            txtCodResp.Text = string.Empty;
            txtNomResp.Text = string.Empty;
            txtDomResp.Text = string.Empty;
            //txtEdadResp.Text = string.Empty;
            txtIdResp.Text = string.Empty;
            txtTelCasResp.Text = string.Empty;
            txtTelCelResp.Text = string.Empty;
            txtTelTrabResp.Text = string.Empty;
            txtLugResp.Text = string.Empty;
            txtCorrResp.Text = string.Empty;
            txtProfResp.Text = string.Empty;
            txtBusqResp.Text = string.Empty;
            DGV_ShowAlumnosResp.DataSource = null;
            DGV_ShowAlumnosResp.Rows.Clear();
        }

        private void validacionVacios()
        {
            if (cmbTrabResp.SelectedItem.ToString().Equals("Si"))
            {
                if (txtCodResp.Text == string.Empty
                    || txtNomResp.Text == string.Empty
                    || txtDomResp.Text == string.Empty
                    || txtIdResp.Text == string.Empty
                    || txtProfResp.Text == string.Empty
                    || txtLugResp.Text == string.Empty
                    || txtTelCasResp.Text == string.Empty
                    || txtTelCelResp.Text == string.Empty
                    || txtTelTrabResp.Text == string.Empty
                    || txtCorrResp.Text == string.Empty)
                {
                    MessageBox.Show("Debe llenar todos los campos", "ERROR");
                }
                else
                {
                    if (txtTelCasResp.Text.Length < 8
                            || txtTelCelResp.Text.Length < 8
                            || txtTelTrabResp.Text.Length < 8)
                    {
                        MessageBox.Show("Los telefonos deben de tener un minimo de 8 digitos");
                    }
                    else
                    {
                        cResp.CodResp = Convert.ToInt32(txtCodResp.Text);
                        cResp.NomResp = txtNomResp.Text;
                        cResp.DomResp = txtDomResp.Text;
                        cResp.TelCasResp = txtTelCasResp.Text;
                        cResp.TelCelResp = txtTelCelResp.Text;
                        cResp.TelTrabResp = txtTelTrabResp.Text;
                        cResp.IdResp = txtIdResp.Text;
                        cResp.LugTrab = cmbTrabResp.SelectedItem.ToString() + ", " + txtLugResp.Text;
                        cResp.ProfResp = txtProfResp.Text;
                        //cResp.EdadResp = Convert.ToInt32(txtEdadResp.Text);
                        cResp.CorrResp = txtCorrResp.Text;

                        cResp.updateResp();
                        cResp.Fill_DGV_Resp(DGV_ShowResponsables);
                        cResp.msjUpdateCorrecto();
                        limpiarTxtBox();
                    }
                }
            }
            else
            {
                if (cmbTrabResp.SelectedItem.ToString().Equals("No"))
                {
                    if (txtCodResp.Text == string.Empty
                    || txtNomResp.Text == string.Empty
                    || txtDomResp.Text == string.Empty
                    || txtIdResp.Text == string.Empty
                    || txtProfResp.Text == string.Empty
                    || txtTelCasResp.Text == string.Empty
                    || txtTelCelResp.Text == string.Empty
                    || txtCorrResp.Text == string.Empty)
                    {
                        MessageBox.Show("Debe llenar todos los campos", "ERROR");
                    }
                    else
                    {
                        if (txtTelCasResp.Text.Length < 8 || txtTelCelResp.Text.Length < 8)
                        {
                            MessageBox.Show("Los telefonos deben de tener un minimo de 8 digitos");
                        }
                        else
                        {
                            cResp.CodResp = Convert.ToInt32(txtCodResp.Text);
                            cResp.NomResp = txtNomResp.Text;
                            cResp.DomResp = txtDomResp.Text;
                            cResp.TelCasResp = txtTelCasResp.Text;
                            cResp.TelCelResp = txtTelCelResp.Text;
                            cResp.TelTrabResp = txtTelTrabResp.Text;
                            cResp.IdResp = txtIdResp.Text;
                            cResp.LugTrab = cmbTrabResp.SelectedItem.ToString() + ", " + txtLugResp.Text;
                            cResp.ProfResp = txtProfResp.Text;
                            //cResp.EdadResp = Convert.ToInt32(txtEdadResp.Text);
                            cResp.CorrResp = txtCorrResp.Text;

                            cResp.updateResp();
                            cResp.Fill_DGV_Resp(DGV_ShowResponsables);
                            cResp.msjUpdateCorrecto();
                            limpiarTxtBox();
                        }
                    }
                }
            }
        }
    }
}
