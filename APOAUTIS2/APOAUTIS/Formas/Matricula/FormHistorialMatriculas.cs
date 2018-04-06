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
    public partial class FormHistorialMatriculas : Form
    {
        C_MuestraHistorialMatricu Cl_Historial = new C_MuestraHistorialMatricu();

        public FormHistorialMatriculas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Radio_BusquedaEstudiante_CheckedChanged(object sender, EventArgs e)
        {
           if(Radio_BusquedaEstudiante.Checked == true)
            {
                Txt_NombreEstudiante.Enabled = true;
                Cmb_Anno.Enabled = false;
                Txt_NombreEstudiante.Clear();
                Cmb_Anno.SelectedIndex = -1;
                Cl_Historial.Fun_MostrarTodos(DGV_Show);
            }
            else
            {
                Txt_NombreEstudiante.Enabled = false;
                Cmb_Anno.Enabled = true;
            }
        }

        private void Radio_BusquedaAnno_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_BusquedaAnno.Checked == true)
            {
                Txt_NombreEstudiante.Enabled = false;
                Cmb_Anno.Enabled = true;
                Txt_NombreEstudiante.Clear();
                Cmb_Anno.SelectedIndex = -1;
                Cl_Historial.Fun_MostrarTodos(DGV_Show);
            }
            else
            {
                Txt_NombreEstudiante.Enabled = true;
                Cmb_Anno.Enabled = false;
            }
        }

        private void FormHistorialMatriculas_Load(object sender, EventArgs e)
        {
            var blankContextMenu = new ContextMenuStrip();
            Txt_NombreEstudiante.ContextMenuStrip = blankContextMenu;

            Cl_Historial.Fun_MostrarAños(Cmb_Anno);
            Radio_BusquedaEstudiante.Checked = true;

        }

        private void Txt_NombreEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Validaciones Cl_Val = new C_Validaciones();
            Cl_Val.ValidarNombres_SoloLetras(sender, e);
        }

        private void Bttn_Recargar_Click(object sender, EventArgs e)
        {
            Txt_NombreEstudiante.Clear();
            Cmb_Anno.SelectedIndex = -1;
            Cl_Historial.Fun_MostrarTodos(DGV_Show);
        }
    }
}
