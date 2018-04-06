using APOAUTIS.Clases;
using APOAUTIS.Formas.Entrevista_Padres;
using APOAUTIS.Formas.Matricula;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOAUTIS.Formas.Alumnos
{
    public partial class FormGlobalShowAlum : Form
    {
        C_ShowAlum Cl_Alumnos = new C_ShowAlum();
        C_Validaciones Cl_Valid = new C_Validaciones();
        public string Accion;

        public FormGlobalShowAlum()
        {
            InitializeComponent();
        }

        private void FormGlobalShowAlum_Load(object sender, EventArgs e)
        {
            Cl_Alumnos.Fun_MuestraDatosGen(DataGrid_Show);
            var blankContextMenu = new ContextMenuStrip();
            Txt_FiltroAlumno.ContextMenuStrip = blankContextMenu;

        }

        private void Txt_FiltroAlumno_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_FiltroAlumno.Text))
            {
                Cl_Alumnos.Fun_MuestraDatosGen(DataGrid_Show);
            }else
            {
                Cl_Alumnos.Var_nom_cliente = Txt_FiltroAlumno.Text;
                Cl_Alumnos.Fun_MuestraDatosPorAlum(DataGrid_Show);
            }
        }

        private void Bttn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGrid_Show_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            DataGridViewRow row = DataGrid_Show.Rows[e.RowIndex];

                if (Accion == "Gastos")
                {
                    FormIngresoGastos Form_Ingr = Owner as FormIngresoGastos;
                    Form_Ingr.Fun_CargarDatos((int)Convert.ToDouble(row.Cells["Codigo"].Value.ToString()),
                    row.Cells["Nombre del Alumno"].Value.ToString());
                }
                else if (Accion == "Vista_Entrevista")
                {
                    VistaEntrevistaPadres Form_Ent = new VistaEntrevistaPadres();
                    Form_Ent.Fun_ExtraerDatos((int)Convert.ToDouble(row.Cells["Codigo"].Value.ToString()),
                    row.Cells["Nombre del Alumno"].Value.ToString());
                    Form_Ent.Fun_MostrarDatosAnamnesis();
                }

                this.Close();

        }
            catch (Exception) { }
            
        }

        private void DataGrid_Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGrid_Show_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 

            DataGridViewRow row = DataGrid_Show.Rows[e.RowIndex];

          
                if(Accion == "Gastos")
                {
                    FormIngresoGastos Form_Ingr = Owner as FormIngresoGastos;
                    Form_Ingr.Fun_CargarDatos((int)Convert.ToDouble(row.Cells["Codigo"].Value.ToString()),
                    row.Cells["Nombre del Alumno"].Value.ToString());
                }
                else if (Accion == "Vista_Entrevista")
                {
                    VistaEntrevistaPadres Form_Ent = new VistaEntrevistaPadres();
                    Form_Ent.Fun_ExtraerDatos((int)Convert.ToDouble(row.Cells["Codigo"].Value.ToString()),
                    row.Cells["Nombre del Alumno"].Value.ToString());
                    Form_Ent.Fun_MostrarDatosAnamnesis();
                }



                this.Close();
            }
            catch (Exception) { }

        }

        private void Txt_FiltroAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cl_Valid.ValidarNombres_SoloLetras(sender, e);
        }
    }
}
