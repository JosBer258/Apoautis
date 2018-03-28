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

namespace APOAUTIS.Formas.Matricula
{
    public partial class FormRangoMensualidad : Form
    {
        C_SalarioMensaulidad Cl_Mensual = new C_SalarioMensaulidad();
        C_Validaciones Cl_Val = new C_Validaciones();

        public FormRangoMensualidad()
        {
            InitializeComponent();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Bttn_SalarioMin_Aceptar_Click(object sender, EventArgs e)
        {
            

            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea continuar con los cambios al sistema?", "pregunta de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                Cl_Mensual.Var_salario_minimo = (float)Convert.ToDouble(Txt_SalarioMinimoActual.Text);
                Cl_Mensual.Fun_Actualizar_SalarioLim();
            }
            else
            {
                Fun_MostrarSalrioMinimo();
            }


            Cl_Mensual.Fun_MostrarRangos(Data_Rangos);
        }

        private void FormRangoMensualidad_Load(object sender, EventArgs e)
        {
            var blankContextMenu = new ContextMenuStrip();
            Txt_SalarioMinimoActual.ContextMenuStrip = blankContextMenu;
            Text_Mensualidad.ContextMenuStrip = blankContextMenu;


            Cl_Mensual.Fun_MostrarRangos(Data_Rangos);
            Fun_MostrarSalrioMinimo();
            Fun_ExtraerCateg();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(Bttn_Aceptar, "debe selecionar una categoria");
                return;
            }else
            {
                errorProvider1.SetError(Bttn_Aceptar, "");
            }


            if (string.IsNullOrEmpty(Text_Mensualidad.Text))
            {
                errorProvider1.SetError(Text_Mensualidad, "debe ingresar este campo");
                return;
            }
            else
            {
                errorProvider1.SetError(Text_Mensualidad, "");
            }

            Cl_Mensual.Var_categ = (int)Convert.ToDouble(Txt_Codigo.Text);
            Cl_Mensual.Var_monto = (float)Convert.ToDouble(Text_Mensualidad.Text);
            Cl_Mensual.Fun_Actual_Monto_Ct();
            Cl_Mensual.Fun_MostrarRangos(Data_Rangos);
            Fun_LimpiarAct();

        }

        private void Fun_LimpiarAct()
        {
            comboBox1.SelectedIndex = -1;
            Txt_Codigo.Clear();
            Txt_RangoInicial.Clear();
            Text_Mensualidad.Clear();
        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fun_MostrarSalrioMinimo()
        {
            foreach (DataGridViewRow Row in Data_Rangos.Rows)
            {
                if ((float)Convert.ToDouble(Row.Cells["Cantidad de salarios minimos"].Value) == 1)
                {
                    Txt_SalarioMinimoActual.Text = Convert.ToString(Row.Cells["Rango inicial L."].Value);
                }

            }

        }



        private void Fun_ExtraerCateg()
        {
            foreach (DataGridViewRow Row in Data_Rangos.Rows)
            {

                comboBox1.Items.Add(Convert.ToString(Row.Cells["Cod de categoria"].Value));

            }

        }

        private void Fun_ExtraerDatos(int Var_Cod)
        {
            foreach(DataGridViewRow Row in Data_Rangos.Rows)
            {
                if ((float)Convert.ToDouble(Row.Cells["Cod de categoria"].Value) == Var_Cod)
                {
                    Txt_RangoInicial.Text= Convert.ToString(Row.Cells["Rango inicial L."].Value);
                    Text_Mensualidad.Text = Convert.ToString(Row.Cells["Total de mensualidad L."].Value);
                    Txt_Codigo.Text = Convert.ToString(Row.Cells["Codigo"].Value);

                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==-1)
            {
                return;
            }
            Fun_ExtraerDatos(Convert.ToInt32(comboBox1.Text));
        }

        private void Txt_SalarioMinimoActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.NumerosDecimales(sender, e, Txt_SalarioMinimoActual);
        }

        private void Text_Mensualidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Val.NumerosDecimales(sender, e, Text_Mensualidad);
        }

        private void Bttn_SalarioMin_Cancelar_Click(object sender, EventArgs e)
        {
            Fun_MostrarSalrioMinimo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
