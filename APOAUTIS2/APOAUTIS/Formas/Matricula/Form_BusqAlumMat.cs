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

namespace APOAUTIS.Formas.Matricula
{
    public partial class Form_BusqAlumMat : Form
    {
        C_ShowAlum Show = new C_ShowAlum();
        C_Validaciones Val = new C_Validaciones();

        public Form_BusqAlumMat()
        {
            InitializeComponent();
        }

        private void Form_BusqAlumMat_Load(object sender, EventArgs e)
        {try
            {
                Show.Fun_MuestraDatosGen(dataGridView1);
                var blankContextMenu = new ContextMenuStrip();
                textBox1.ContextMenuStrip = blankContextMenu;
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    Show.Fun_MuestraDatosGen(dataGridView1);
                }
                else
                {
                    Show.Var_nom_cliente = textBox1.Text;
                    Show.Fun_MuestraDatosPorAlum(dataGridView1);
                }
            }
            catch (Exception)
            {

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            FrmMatricula Mt = Owner as FrmMatricula;
            Mt.Fun_ExtraerDatos((int)Convert.ToDouble(row.Cells["Codigo"].Value.ToString()),
            row.Cells["Nombre del Alumno"].Value.ToString());
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            FrmMatricula Mt = Owner as FrmMatricula;
            Mt.Fun_ExtraerDatos((int)Convert.ToDouble(row.Cells["Codigo"].Value.ToString()),
            row.Cells["Nombre del Alumno"].Value.ToString());
            this.Close();

        }
    }
}
