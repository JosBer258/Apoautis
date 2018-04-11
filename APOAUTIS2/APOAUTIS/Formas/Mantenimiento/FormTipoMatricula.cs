using APOAUTIS.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Mantenimiento
{
    public partial class FormTipoMatricula : Form
    {
        C_Mantenimiento Mant = new C_Mantenimiento();
        C_Validaciones Val = new C_Validaciones();
        public FormTipoMatricula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            textBox2.Text = string.Empty;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Text = Mant.Fun_ExtraerCodigoAlumno_TipoMat().ToString();
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == false)
            {
                textBox1.Text = Mant.Fun_ExtraerCodigoAlumno_TipoMat().ToString();
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void FormTipoMatricula_Load(object sender, EventArgs e)
        {
            Mant.Fun_ExtraerTiposMat(dataGridView1);
            radioButton1.Checked = true;
            var blankContextMenu = new ContextMenuStrip();
            textBox2.ContextMenuStrip = blankContextMenu;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (radioButton2.Checked == true)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells["Codigo de Tipo"].Value.ToString();
                    textBox2.Text = row.Cells["Descripcion"].Value.ToString();
                }
            }
            catch (Exception) { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (radioButton2.Checked == true)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells["Codigo de Tipo"].Value.ToString();
                    textBox2.Text = row.Cells["Descripcion"].Value.ToString();
                }
            }
            catch (Exception) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox1, "Debe llenar todos los campos");
                errorProvider1.SetError(textBox2, "Debe llenar todos los  campos");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                errorProvider1.SetError(textBox2, "");
            }

            if (radioButton1.Checked == true)
            {
                if (Mant.Fun_Validar_Tipo(textBox2.Text) == true)
                 {
                     errorProvider1.SetError(textBox2, "existe duplicacion de datos, ingrese otra descripcion");
                     return;
                 }
                 else
                 {
                     errorProvider1.SetError(textBox2, "");
                 }


                Mant.Fun_ingresarTipoM(textBox2.Text);
                Mant.Fun_ExtraerTiposMat(dataGridView1);
                textBox1.Text = Mant.Fun_ExtraerCodigoAlumno_TipoMat().ToString();
                textBox2.Text = "";
            }
            else
            {
                Mant.Fun_PdateTipo((int)Convert.ToDouble(textBox1.Text), textBox2.Text);
                Mant.Fun_ExtraerTiposMat(dataGridView1);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
