using APOAUTIS.Clases;
using APOAUTIS.Formas.Alumnos;
using APOAUTIS.Formas.Manuales;
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
    public partial class FormMontoMatricula : Form
    {
        FormGlobalShowAlum F_ShowAlum = new FormGlobalShowAlum();
        C_MontoMens Cl_Mon = new C_MontoMens();
  

        public FormMontoMatricula()
        {
            InitializeComponent();
        }

        private void Bttn_BusquedaDeAlumno_Click(object sender, EventArgs e)
        {
          
            AddOwnedForm(F_ShowAlum);
            F_ShowAlum.Accion = "Monto";
            F_ShowAlum.ShowDialog();
        }

        private void FormMontoMatricula_Load(object sender, EventArgs e)
        {
            Radio_Agregar.Checked = true;
            Cl_Mon.Fun_MuestraDatosGen(DGV_Show);
            var blankContextMenu = new ContextMenuStrip();
            Txt_Filtro_Matricula.ContextMenuStrip = blankContextMenu;
        }

        public void Fun_CargarDatos(int Var_Codigo, string Var_Nombre)
        {
                Cl_Mon.Var_cod_nom = Var_Codigo;
                Cl_Mon.Var_nom_alumno = Var_Nombre;
                Cl_Mon.Fun_ExtraerResponsables();
                Cl_Mon.Fun_ExtraerTotalMen();
                Cl_Mon.Fun_CalcularMensualidad();
                Txt_Mensualidad.Text = Cl_Mon.Var_mensualidad.ToString();
                Txt_TotalIngreso.Text = Cl_Mon.Var_total_ingresos;
                Txt_NombreAlumno.Text = Cl_Mon.Var_nom_alumno;
                Txt_Responsable.Text = Cl_Mon.Var_resp_nombres;
                
   }

        private void Radio_Agregar_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Agregar.Checked == true)
            {
                Gruop_Busqueda.Enabled = false;
                Bttn_BusquedaDeAlumno.Enabled = true;
                Fun_Limpiar();
            }
            else
            {
                Gruop_Busqueda.Enabled = true;
                Bttn_BusquedaDeAlumno.Enabled = false;
            }
        }

        private void Radio_Actualizar_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Actualizar.Checked == true)
            {
                Gruop_Busqueda.Enabled = true;
                Bttn_BusquedaDeAlumno.Enabled = false;
                Fun_Limpiar();
            }
        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bttn_Calcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_TotalIngreso.Text)) {
                errorProvider1.SetError(Bttn_Calcular, "Debe ingresar un alumno");
                return;
            }
            else
            {
                errorProvider1.SetError(Bttn_Calcular, "");
            }


            Cl_Mon.Fun_CalcularMensualidad();
            Txt_Mensualidad.Text = Cl_Mon.Var_mensualidad.ToString();
        }

        private void Bttn_Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_NombreAlumno.Text))
            {
                errorProvider1.SetError(Txt_NombreAlumno, "Debe ingresar un alumno");
                return;
            }
            else
            {
                errorProvider1.SetError(Txt_NombreAlumno, "");
            }

            Cl_Mon.Fun_UpdateMensu();
            Fun_Limpiar();
            Cl_Mon.Fun_MuestraDatosGen(DGV_Show);
        }

        private void Bttn_Limpiar_Click(object sender, EventArgs e)
        {
            Fun_Limpiar();
        }

        private void Fun_Limpiar()
        {
            Txt_Mensualidad.Clear();
            Txt_NombreAlumno.Clear();
            Txt_Responsable.Clear();
            Txt_TotalIngreso.Clear();
        }

        private void Txt_Filtro_Matricula_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Filtro_Matricula.Text)) {
                Cl_Mon.Fun_MuestraDatosGen(DGV_Show);
            }
            else
            {
                Cl_Mon.Var_filtro_nom_cliente = Txt_Filtro_Matricula.Text;
                Cl_Mon.Fun_MuestraDatosPorAlum(DGV_Show);
            }
        }

        private void DGV_Show_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 

            DataGridViewRow row = DGV_Show.Rows[e.RowIndex];
            Fun_CargarDatos(
                (int)Convert.ToDouble(row.Cells["Codigo de Alumno"].Value.ToString()),
                row.Cells["Nombre de Alumno"].Value.ToString());
            }
            catch (Exception) { }
        }

        private void DGV_Show_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = DGV_Show.Rows[e.RowIndex];
                Fun_CargarDatos(
                    (int)Convert.ToDouble(row.Cells["Codigo de Alumno"].Value.ToString()),
                    row.Cells["Nombre de Alumno"].Value.ToString());
            }
            catch (Exception) { }
        }

        private void Txt_Filtro_Matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            C_Validaciones Cl_val = new C_Validaciones();
            Cl_val.ValidarNombres_SoloLetras(sender,e);
        }

        private void DGV_Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManual Manual = new FormManual();
            Manual.ShowDialog();
        }
    }
}
