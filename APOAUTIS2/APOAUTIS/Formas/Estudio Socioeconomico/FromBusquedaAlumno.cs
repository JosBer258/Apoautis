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
using APOAUTIS.Formas.Estudio_Socioeconomico;
using MySql.Data.MySqlClient;

namespace APOAUTIS.Formas.Estudio_Socioeconomico
{
    public partial class FromBusquedaAlumno : Form
    {


        C_Validaciones Cl_Valid = new C_Validaciones();
        public string Accion;

        public FromBusquedaAlumno()
        {
            InitializeComponent();
        }



        private void Bttn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGV_Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormaEstSocEco estudio = new FormaEstSocEco();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FormaEstSocEco")
                    {
                        estudio = (FormaEstSocEco)frm;
                        estudio.txt_EsSo_IdentiEst_DatosGe.Text = DGV_Show.CurrentRow.Cells[0].Value.ToString();
                        estudio.txt_EsSo_NombreEst_DatosGe.Text = DGV_Show.CurrentRow.Cells[1].Value.ToString();
                        estudio.txt_EsSo_LugarNaci_DatosGe.Text = DGV_Show.CurrentRow.Cells[2].Value.ToString();
                        estudio.txt_EsSo_FechaNa_DatosGe.Text = DGV_Show.CurrentRow.Cells[3].Value.ToString();
                        estudio.txt_EsSo_EdadEst_DatosGe.Text = DGV_Show.CurrentRow.Cells[4].Value.ToString();



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
             

                 

        }

        private void Txt_FiltroAlumno_TextChanged(object sender, EventArgs e)
        {


        }

        

        private void btm_buscar_Click(object sender, EventArgs e)
        {
            DGV_Show.DataSource = Clases.C_EstudioSocioMetodos.BuscarS(Txt_FiltroAlumno.Text);

        }
        public static C_responsablesMadre madreSeleccionado { get; set; }
        public static C_DatosGenerales AlumnoSeleccionado { get;  set; }
        public static C_responsablePadre padreSeleccionado { get; set; }


        private void btm_Aceptar_Click(object sender, EventArgs e)
        {




            if (DGV_Show.SelectedRows.Count == 1)
            {
                double cod = Convert.ToDouble(DGV_Show.CurrentRow.Cells[0].Value);
                AlumnoSeleccionado = C_EstudioSocioMetodos.ObtenerDatosGenerales(cod);

                double cod2 = Convert.ToDouble(DGV_Show.CurrentRow.Cells[0].Value);
                madreSeleccionado = C_EstudioSocioMetodos.ObtenerMadre(cod2);

                double cod3 = Convert.ToDouble(DGV_Show.CurrentRow.Cells[0].Value);
                padreSeleccionado = C_EstudioSocioMetodos.ObtenerPadre(cod3);

                this.Close();
            }



        }

        private void FromBusquedaAlumno_Load(object sender, EventArgs e)
        {

        }
    }
}
