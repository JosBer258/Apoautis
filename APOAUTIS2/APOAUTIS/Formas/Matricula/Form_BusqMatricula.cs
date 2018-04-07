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
    public partial class Form_BusqMatricula : Form
    {
        C_BusqMatricula Cl_Busq = new C_BusqMatricula();

        public Form_BusqMatricula()
        {
            InitializeComponent();
        }

        private void Form_BusqMatricula_Load(object sender, EventArgs e)
        {
            Cl_Busq.Fun_MostrarTodos(DataGrid_Show);
            Cl_Busq.Fun_MostrarAños(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cl_Busq.Fun_MostrarTodos(DataGrid_Show);
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                Cl_Busq.Fun_MostrarTodos(DataGrid_Show);
            }
            else
            {
                Cl_Busq.Var_fecha_busq = (int)Convert.ToDouble(comboBox1.Text);
                Cl_Busq.Fun_MostrarPorFecha(DataGrid_Show);
            }
        }

      

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DataGrid_Show.Rows[e.RowIndex];

                VistaMatricula Form_Ingr = Owner as VistaMatricula;

                Form_Ingr.Fun_ExtraerEscencial(
                    (int)Convert.ToDouble(row.Cells["Codigo Matricula"].Value.ToString()),
                    (int)Convert.ToDouble(row.Cells["Codigo de Alumno"].Value.ToString()),
                row.Cells["Nombre de Alumno"].Value.ToString());

                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DataGrid_Show.Rows[e.RowIndex];

                VistaMatricula Form_Ingr = Owner as VistaMatricula;

                Form_Ingr.Fun_ExtraerEscencial(
                    (int)Convert.ToDouble(row.Cells["Codigo Matricula"].Value.ToString()),
                    (int)Convert.ToDouble(row.Cells["Codigo de Alumno"].Value.ToString()),
                row.Cells["Nombre de Alumno"].Value.ToString());

                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
